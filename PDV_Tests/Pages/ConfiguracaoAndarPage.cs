using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class ConfiguracaoAndarPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public ConfiguracaoAndarPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuConfiguracao()
        {
            _driver.FindElementByName("CONFIGURAÇÕES").Click();
        }

        public void ClicarSubMenuAndar()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("ANDAR")).Click().Build().Perform();
        }

        public void ClicarBotaoNovoAndar()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void CriarNovoAndar()
        {
            var novoAndar = String.Format("Andar - {0}", rdn.Next(1111, 9999));
            string portaEntrada = rdn.Next(11).ToString();
            string portaSaida = rdn.Next(11).ToString();
            string quantidadeVaga = rdn.Next(1111).ToString();
            string vagaOcupada = rdn.Next(11).ToString();

            _driver.FindElementById("txtDescricao").SendKeys(novoAndar);
            Assert.AreEqual(novoAndar, novoAndar);
            _driver.FindElementById("txtPortaEntrada").SendKeys(portaEntrada); ;
            Assert.AreEqual(portaEntrada, portaEntrada);
            _driver.FindElementById("txtPortaSaida").SendKeys(portaSaida);
            Assert.AreEqual(portaSaida, portaSaida);
            _driver.FindElementById("cmbAndarAnterior").Click();
            _driver.Keyboard.PressKey("COBERTURA");
            _driver.FindElementById("panel1").Click();
            _driver.FindElementById("txtQtdeVagasTotal").SendKeys(quantidadeVaga);
            Assert.AreEqual(quantidadeVaga, quantidadeVaga);
            _driver.FindElementById("txtQtdeVagasOcupadas").SendKeys(vagaOcupada);
            Assert.AreEqual(vagaOcupada, vagaOcupada);
        }

        public void SalvarNovoAndar()
        {
            _driver.FindElementById("btnSalvar").Click();
            Assert.AreEqual("Salvo com sucesso", "Salvo com sucesso");
            _driver.FindElementById("radBtnOk").Click();
        }

        public void CriarAndar()
        {
            ClicarMenuConfiguracao();
            ClicarSubMenuAndar();
            ClicarBotaoNovoAndar();
            CriarNovoAndar();
            SalvarNovoAndar();
        }
    }
}
