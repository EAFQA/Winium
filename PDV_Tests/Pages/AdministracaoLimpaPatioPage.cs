using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class AdministracaoLimpaPatioPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public AdministracaoLimpaPatioPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuLimpaPatio()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("LIMPAR PÁTIO")).Click().Build().Perform();
        }

        public void ClicarBotaoOkModal()
        {
            _driver.FindElementById("btnOK").Click();
        }

        public void InserirPeriodo()
        {
            _driver.FindElementById("txtPeriodoInicial").SendKeys("20/12/2030");
        }

        public void ClicarBotaoConfirmar()
        {
            _driver.FindElementById("btnConfirmar").Click();
        }

        public void ClicarModalBotaoNao()
        {
            _driver.FindElementById("radBtnNo").Click();
        }

        public void ClicarModalBotaoSim()
        {
            _driver.FindElementById("btnConfirmar").Click();
            _driver.FindElementById("radBtnYes").Click();
            _driver.FindElementById("radBtnOk").Click();
        }

        public void LimparPatio()
        {
            ClicarMenuAdministracao();
            ClicarSubMenuLimpaPatio();
            InserirPeriodo();
            ClicarBotaoConfirmar();
            ClicarModalBotaoNao();
            ClicarModalBotaoSim();
        }
    }
}
