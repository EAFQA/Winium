using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using PDV_Tests.Pages;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Utils
{
    public class Email
    {
        public static string EnderecoEmail(int numberOfCharacters)
        {
            var characters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            var random = new Random();
            var EnderecoEmail = new string(Enumerable.Repeat(characters, numberOfCharacters).Select(s => s[random.Next(s.Length)]).ToArray());
            EnderecoEmail = EnderecoEmail + "@testautopdv.com";

            return EnderecoEmail;
        }

        public string NumeroCartaoCredito(int numbers)
        {
            string CreditCardNumber = null;
            int nums = numbers;
            Random num = new Random();
            for (int i = 0; i < nums; i++)
            {
                CreditCardNumber = num.Next(9) + CreditCardNumber;
            }
            return CreditCardNumber;
        }

        public string NomeTeste(int numberOfCharacters)
        {
            string TestNames = null;
            var characters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz_0123456789";
            var random = new Random();
            TestNames = new string(Enumerable.Repeat(characters, numberOfCharacters).Select(s => s[random.Next(s.Length)]).ToArray());
            return TestNames;
        }

        public static void EnviarEmail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
            mail.Subject = "Pequena validação com Email";
            mail.From = new MailAddress(""); //Inserir o Email
            mail.To.Add(""); //Inserir o Email
            mail.Body = "Ops! Favor verificar o momento em que o caso de teste falhou, na data e hora: " + DateTime.Now;
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("C:\\PDV_Tests\\PDV_Tests\\Test_Screen\\FailedPage.Jpeg");
            mail.Attachments.Add(attachment);

            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new NetworkCredential("", ""); ////Inserir o Email e Senha da conta "Pai", pode ser a mesma inserida acima
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}
