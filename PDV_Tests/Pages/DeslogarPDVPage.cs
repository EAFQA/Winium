using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class DeslogarPDVPage
    {
        private readonly WiniumDriver _driver;

        public DeslogarPDVPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarBotaoDeslogar()
        {
            _driver.FindElementById("btnDeslogar").Click();
        }

        public void ClicarBotaoModalSim()
        {
            _driver.FindElementById("radBtnYes").Click();
        }

        public void ClicarBotaoCancelar()
        {
            _driver.FindElementById("btnCancelar").Click();
        }

        public void SairPDV()
        {
            ClicarBotaoDeslogar();
            ClicarBotaoModalSim();
            ClicarBotaoCancelar();
        }
    }
}
