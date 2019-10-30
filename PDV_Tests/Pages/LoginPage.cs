using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System.Drawing.Imaging;
using System.IO;

namespace PDV_Tests.Pages
{
    public class LoginPage
    {
        private readonly WiniumDriver _driver;
        public LoginPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void Logar(string usuario, string senha)
        {
            _driver.FindElement(By.Id("txtUsuario")).SendKeys(usuario);
            _driver.FindElement(By.Id("txtSenha")).SendKeys(senha);
            _driver.FindElement(By.Id("pcbBtnEntrar")).Click();
        }

        public void Notificacao()
        {
            _driver.FindElement(By.Id("radLblText"));
            Assert.AreEqual("Usuário não encontrado", "Usuário não encontrado");
        }

        public void BotaoOkModalLogin()
        {
            _driver.FindElement(By.Id("radBtnOk")).Click();
        }

        public void Screen()
        {
            ITakesScreenshot screen = _driver as ITakesScreenshot;
            Screenshot scrnst = screen.GetScreenshot();
            string screenshot = "C:\\PDV_Tests\\PDV_Tests\\Test_Screen\\FailedPage.Jpeg";
            scrnst.SaveAsFile(screenshot, ImageFormat.Jpeg);
        }

        public void LogarPDV()
        {
            Logar("suportein","sup1n1512");
        }
    }
}
