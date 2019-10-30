using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class AdministracaoPrismaPage
    {
        private readonly WiniumDriver _driver;

        public AdministracaoPrismaPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuPrisma()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("PRISMAS")).Click().Build().Perform();
        }
    }
}
