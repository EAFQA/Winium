using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class AdministracaoTabelaDePrecoPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public AdministracaoTabelaDePrecoPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuTabelaDePreco()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("TABELA DE PREÇOS")).Click().Build().Perform();
        }

        public void ClicarBotaoNovaTabelaDePreco()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void CriarNovaTabelaDePreco()
        {
            var nomeTabelaPreco = String.Format("Feriado-{0}", rdn.Next(11111, 99999));
            _driver.FindElementById("txtNomeTabela").SendKeys(nomeTabelaPreco);
            _driver.FindElementById("dtInicioVigencia").SendKeys("01/01/2000");
            _driver.FindElementById("dtTerminoVigencia").SendKeys("20/12/2040");
        }

        public void ClicarBotaoSalvarNovaTabelaDePreco()
        {
            _driver.FindElementById("btnSalvar").Click();
        }
    }
}
