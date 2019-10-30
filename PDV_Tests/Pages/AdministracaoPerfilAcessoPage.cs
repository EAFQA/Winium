using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
   public class AdministracaoPerfilAcessoPage
    {
        private readonly WiniumDriver _driver;
        public AdministracaoPerfilAcessoPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuPerfilAcesso()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("PERFIS DE ACESSO")).Click().Build().Perform();
        }

        public void ClicarBotaoNovoPerfilAcesso()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void CriarPerfilAcesso()
        {
            _driver.FindElementById("txtDescricao").SendKeys(Faker.Name.FullName());
            _driver.FindElementById("chkAdministrador").Click();
        }

        public void ClicarBotaoSalvarPerfilAcesso()
        {
            _driver.FindElementById("btnSalvar").Click();
            _driver.FindElementById("radBtnOk").Click();
        }

        public void CriaPerfilAcesso()
        {
            ClicarMenuAdministracao();
            ClicarSubMenuPerfilAcesso();
            ClicarBotaoNovoPerfilAcesso();
            CriarPerfilAcesso();
            ClicarBotaoSalvarPerfilAcesso();
        }
    }
}
