using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
   public  class AdministracaoSelosPage
    {
        private readonly WiniumDriver _driver;
        public AdministracaoSelosPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuSelos()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("SELOS")).Click().Build().Perform();
        }
    }
}
