using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;

namespace PDV_Tests.Pages
{
    public class AdministracaoCadastroDiariaPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public AdministracaoCadastroDiariaPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuACadastroDiaria()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("CADASTRO DE DIÁRIAS")).Click().Build().Perform();
        }

        public void ClicarBotaoNovaDiaria()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void CriarNovaDiaria()
        {
            var diaria = String.Format("Nome-{0}", rdn.Next(99999));

            _driver.FindElementById("txtTitulo").Click();
            _driver.FindElementById("txtTitulo").SendKeys(diaria);
            Assert.AreEqual(diaria, diaria);
            _driver.FindElementById("txtValor").SendKeys(Faker.RandomNumber.Next(1, 111).ToString());
            _driver.FindElementById("SpinElement.ButtonUp").Click();
            _driver.FindElementById("dtInicioVigencia").SendKeys("01/01/2001");
            Assert.AreEqual("01/01/2001", "01/01/2001");
            _driver.FindElementById("dtTerminoVigencia").SendKeys("30/12/2040");
            Assert.AreEqual("30/12/2040", "30/12/2040");
        }

        public void ClicarBotaoSalvarNovaDiaria()
        {
            _driver.FindElementById("btnSalvar").Click();
        }

        public void CriarDiaria()
        {
            ClicarMenuAdministracao();
            ClicarSubMenuACadastroDiaria();
            ClicarBotaoNovaDiaria();
            CriarNovaDiaria();
            ClicarBotaoSalvarNovaDiaria();
        }
    }
}
