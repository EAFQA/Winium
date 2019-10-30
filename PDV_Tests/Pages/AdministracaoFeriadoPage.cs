using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using PDV_Tests.Pages;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class AdministracaoFeriadoPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public AdministracaoFeriadoPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuFeriados()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("FERIADOS")).Click().Build().Perform();
        }

        public void ClicarBotaoNovoFeriado()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void InserirNovoFeriado()
        {
            DateTime GerarData()
            {
                Random rdn = new Random();

                int ano = rdn.Next(1990, 2050);
                int mes = rdn.Next(01, 12);
                int dia = DateTime.DaysInMonth(ano, mes);
                int Dia = rdn.Next(1, dia);
                DateTime data = new DateTime(Dia, mes, ano);

                return data;
            }

            var nomeFeriado = String.Format("Feriado-{0}", rdn.Next(11111, 99999));
            _driver.FindElementById("txtTitulo").SendKeys(nomeFeriado);
            Assert.AreEqual(nomeFeriado, nomeFeriado);
            _driver.FindElementById("dtFeriado").SendKeys(GerarData().ToString());
        }

        public void ClicarBotaoSalvarFeriado()
        {
            _driver.FindElementById("btnSalvar").Click();
            Assert.AreEqual("Dados gravados com sucesso.", "Dados gravados com sucesso.");
            _driver.FindElementById("radBtnOk").Click();
        }

        public void CadastrarFeriado()
        {
            ClicarMenuAdministracao();
            ClicarSubMenuFeriados();
            ClicarBotaoNovoFeriado();
            InserirNovoFeriado();
            ClicarBotaoSalvarFeriado();
        }
    }
}
