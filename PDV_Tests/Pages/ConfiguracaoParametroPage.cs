using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;

namespace PDV_Tests.Pages
{
    public class ConfiguracaoParametroPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public ConfiguracaoParametroPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuConfiguracao()
        {
            _driver.FindElementByName("CONFIGURAÇÕES").Click();
        }

        public void ClicarSubMenuParametros()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("PARÂMETROS")).Click().Build().Perform();
        }

        public void ClicarBotaoSalvarParametros()
        {
            _driver.FindElementById("btnSalvar").Click();
        }

        public void ClicarModalBotaoOkParametros()
        {
            _driver.FindElementById("radBtnOk").Click();
        }

        public void SalvarConfiguracaoParametro()
        {
            ClicarMenuConfiguracao();
            ClicarSubMenuParametros();
            ClicarBotaoSalvarParametros();
            ClicarModalBotaoOkParametros();
        }
    }
}
