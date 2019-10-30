using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PDV_Tests.Pages
{
    public class ConfiguracaoAreaPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public ConfiguracaoAreaPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuConfiguracao()
        {
            _driver.FindElementByName("CONFIGURAÇÕES").Click();
        }

        public void ClicarSubMenuArea()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("AREA")).Click().Build().Perform();
        }

        public void ClicarBotaoNovaArea()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void CriarNovaArea()
        {
            var novaArea = String.Format("Area-{0}", rdn.Next(1111, 9999));
            string quantidadeVaga = rdn.Next(111).ToString();

            _driver.FindElementById("txtArea").SendKeys(novaArea);
            Assert.AreEqual(novaArea, novaArea);
            _driver.FindElementById("txtQtdeVaga").SendKeys(quantidadeVaga);
            Assert.AreEqual(quantidadeVaga, quantidadeVaga);
        }

        public void SalvarNovaArea()
        {
            _driver.FindElementById("btnSalvar").Click();
            _driver.FindElementById("radBtnOk").Click();
        }

        public void CriarArea()
        {
            ClicarMenuConfiguracao();
            ClicarSubMenuArea();
            ClicarBotaoNovaArea();
            CriarNovaArea();
            SalvarNovaArea();
        }

        public void DeveFecharInstancia()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
