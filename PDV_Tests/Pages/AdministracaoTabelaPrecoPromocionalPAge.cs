using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class AdministracaoTabelaPrecoPromocionalPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public AdministracaoTabelaPrecoPromocionalPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuTabelaDePrecoPromocional()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("TABELA DE PREÇOS PROMOCIONAL")).Click().Build().Perform();
        }

        //public void ClicarBotaoNovaTabelaDePreco()
        //{

        //}

        //public void CriarNovaTabelaDePreco()
        //{

        //}

        //public void ClicarBotaoSalvarNovaTabelaDePreco()
        //{

        //}
    }
}
