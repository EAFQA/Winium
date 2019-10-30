using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using PDV_Tests.Utils;
using System;


namespace PDV_Tests.Pages
{
    public class ConfiguracaoTerminalPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public ConfiguracaoTerminalPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuConfiguracao()
        {
            _driver.FindElementByName("CONFIGURAÇÕES").Click();
        }

        public void ClicarSubMenuTerminal()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("TERMINAIS")).Click().Build().Perform();
        }

        public void ClicarBotaoNovoTerminal()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void InserirNovoTerminal()
        {
            var nomeTerminal = String.Format("terminal-{0}", rdn.Next(11111, 99999));
            _driver.FindElementById("txtDescricao").SendKeys(nomeTerminal);
            _driver.FindElementById("txtNomeImpressora").SendKeys(nomeTerminal);
            _driver.FindElementById("ddlTipoImpressora").Click();
            _driver.Keyboard.PressKey("DIEBOLD");
            _driver.FindElementById("txtIP").SendKeys(CPF.GerarCPF());
        }

        public void ClicarModalBotaoOkTerminal()
        {
            _driver.FindElementById("radBtnOk").Click();
        }

        public void ClicarBotaoSalvarTerminal()
        {
            _driver.FindElementById("btnSalvar").Click();
        }

        public void SalvarConfiguracaoTerminal()
        {
            ClicarMenuConfiguracao();
            ClicarSubMenuTerminal();
            ClicarBotaoNovoTerminal();
            InserirNovoTerminal();
            ClicarBotaoSalvarTerminal();
            ClicarModalBotaoOkTerminal();
        }
    }
}
