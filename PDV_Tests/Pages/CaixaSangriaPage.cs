using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class CaixaSangriaPage
    {
        private readonly WiniumDriver _driver;

        public CaixaSangriaPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuCaixa()
        {
            _driver.FindElementByName("CAIXA").Click();
        }

        public void ClicarSubMenuSangria()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("SANGRIA")).Click().Build().Perform();
        }

        public void ClicarBotaoOkModalAberturaCaixa()
        {
            _driver.FindElementByName("btnOK").Click();
        }

        public void InserirValorSangria()
        {
            _driver.FindElementById("txtValorSangria").SendKeys("0,50");
        }

        public void ClicarBotaoConfirmarSangria()
        {
            _driver.FindElementById("btnConfirma").Click();
        }

        public void ConfirmarModalUsuarioSenhaSangria()
        {
            _driver.FindElementById("txtUsuario").SendKeys("Sangria");
            _driver.FindElementById("txtSenha").SendKeys("Sangria");
        }

        public void ConfirmarModalSangria()
        {
            _driver.FindElementById("btnConfirma").Click();
            _driver.FindElementById("radBtnOk").Click();
        }

        public void RealizarSangria()
        {
            ClicarMenuCaixa();
            ClicarSubMenuSangria();
            InserirValorSangria();
            ClicarBotaoConfirmarSangria();
            ConfirmarModalUsuarioSenhaSangria();
            ConfirmarModalSangria();
        }
    }
}