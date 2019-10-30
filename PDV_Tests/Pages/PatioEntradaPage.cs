using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class PatioEntradaPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();
        public PatioEntradaPage(WiniumDriver driver)
        {
            _driver = driver;
        }
        public void UsuarioLogado()
        {
            _driver.FindElement(By.Id("lblUsuario"));
        }

        public void ClicarMenuPatio()
        {
            _driver.FindElementByName("PÁTIO").Click();
        }

        public void ClicarSubMenuEntrada()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("ENTRADA")).Click().Build().Perform();
        }

        public void ModalAbrirCaixa()
        {
            _driver.FindElementById("btnOK").Click();
        }

        public void EntradaComPlaca()
        {
            var placa = String.Format("tst-{0}", rdn.Next(1111, 9999));
            _driver.FindElementById("radMskPlaca").SendKeys(placa);
            Assert.AreEqual(placa, placa);
            _driver.FindElementById("radMskPlaca").Submit();
        }

        public void EntradaComPlaca2()
        {
            var placa2 = String.Format("tst-{0}", rdn.Next(1111, 9999));
            _driver.FindElementById("radMskPlaca").SendKeys(placa2);
            Assert.AreEqual(placa2, placa2);
            _driver.FindElementById("radMskPlaca").Submit();
        }

        public void EntradaComPlaca3()
        {
            var placa3 = String.Format("tst-{0}", rdn.Next(1111, 9999));
            _driver.FindElementById("radMskPlaca").SendKeys(placa3);
            Assert.AreEqual(placa3, placa3);
            _driver.FindElementById("radMskPlaca").Submit();
        }

        public void EntradaComPlaca4()
        {
            var placa4 = String.Format("tst-{0}", rdn.Next(1111, 9999));
            _driver.FindElementById("radMskPlaca").SendKeys(placa4);
            Assert.AreEqual(placa4, placa4);
            _driver.FindElementById("radMskPlaca").Submit();
        }

        public void ModalConfirmarEntrada()
        {
            Assert.AreEqual("Cliente Rotativo?", "Cliente Rotativo?");
            _driver.FindElementById("radBtnYes").Click();
        }

        public void RealizarEntradaComPlaca()
        {
            ClicarMenuPatio();
            ClicarSubMenuEntrada();
            ModalAbrirCaixa();
            EntradaComPlaca();
            ModalConfirmarEntrada();
            EntradaComPlaca2();
            ModalConfirmarEntrada();
            EntradaComPlaca3();
            ModalConfirmarEntrada();
            EntradaComPlaca4();
            ModalConfirmarEntrada();
        }
    }
}

