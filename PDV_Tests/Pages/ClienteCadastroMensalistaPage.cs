using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using PDV_Tests.Utils;

using System;

namespace PDV_Tests.Pages
{
    public class ClienteCadastroMensalistaPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public ClienteCadastroMensalistaPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuClientes()
        {
            _driver.FindElementByName("CLIENTES").Click();
        }

        public void ClicarSubMenuCadastroMensalista()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("CADASTRO DE MENSALISTA")).Click().Build().Perform();
        }

        public void ClicarBotaoOkModalCaixa()
        {
            _driver.FindElementById("btnOK").Click();
        }

        public void SelecionarTabelaPreco()
        {

                _driver.FindElementById("ddlTabelaPreco").Click();
                _driver.Keyboard.PressKey("MOTO - S1");
                _driver.FindElementById("btnOk").Click();
        }

        public void InserirCPF()
        {
            _driver.FindElementById("txtCpf").SendKeys(CPF.GerarCPF());
            _driver.FindElementById("btnConsultarCPFCNPJ").Click();
        }

        public void PreencherFormulario()
        {
            var placa = String.Format("tst-{0}", rdn.Next(99999));
            var nome = String.Format("Nome - {0}", rdn.Next(99999));
            string numeroEndereco = rdn.Next(1111).ToString();
            var numeroCredencial = Convert.ToString(rdn.Next(1111111111));
            var numeroTelefone = Convert.ToString(rdn.Next(1111111111));

            _driver.FindElementById("txtPlacaVeiculo").SendKeys(placa);
            Assert.AreEqual(placa, placa);
            _driver.FindElementById("txtCep").SendKeys("05338001");
            Assert.AreEqual("05338001", "05338001");
            _driver.FindElementById("btnConsultar").Click();
            _driver.FindElementById("txtNumero").Click();
            _driver.FindElementById("txtNumero").SendKeys(numeroEndereco);
            _driver.FindElementById("txtNome").SendKeys(nome);
            Assert.AreEqual(nome, nome);
            _driver.FindElementById("txtEmail").SendKeys(Email.EnderecoEmail(5));
            _driver.FindElementById("CelularTXT").SendKeys(numeroTelefone);
            Assert.AreEqual(numeroTelefone, numeroTelefone);
            _driver.FindElementById("txtNumeroCredencial").SendKeys(numeroCredencial);
            Assert.AreEqual(numeroCredencial, numeroCredencial);
        }

        public void ClicarBotaoProsseguir()
        {
            _driver.FindElementById("btnEnviar").Click();
            Assert.AreEqual("NÃO É SEGURADO PORTO-SEGURO", "NÃO É SEGURADO PORTO-SEGURO");
            _driver.FindElementById("radBtnOk").Click();
        }

        public void SelecionarFormaPagamento()
        {
            _driver.FindElementById("rbFormaPagamentoDINHEIRO").Click();
            Assert.AreEqual("DINHEIRO", "DINHEIRO");
            _driver.FindElementById("rbFormaPagamentoDINHEIRO").Submit();
            _driver.FindElementById("txtValorPago").Submit();
            _driver.FindElementById("txtTroco").Submit();
        }

        public void ClicarBotaoConfirmarPagamento()
        {
            _driver.FindElementById("btnEnviar").Click();
        }

        public void NaoInserirTicketRotativo()
        {
            Assert.AreEqual("ASSOCIAR TICKET ROTATIVO?", "ASSOCIAR TICKET ROTATIVO?");
            _driver.FindElementById("radBtnNo").Click();
        }

        public void ClicarBotaoConcluirCadastro()
        {
            _driver.FindElementById("btnEnviar").Click();
            Assert.AreEqual("CADASTRO REALIZADO COM SUCESSO!", "CADASTRO REALIZADO COM SUCESSO!");
            _driver.FindElementById("radBtnOk").Click();
        }

        public void CadastrarMensalista()
        {
            ClicarMenuClientes();
            ClicarSubMenuCadastroMensalista();
            SelecionarTabelaPreco();
            InserirCPF();
            PreencherFormulario();
            ClicarBotaoProsseguir();
            SelecionarFormaPagamento();
            ClicarBotaoConfirmarPagamento();
            NaoInserirTicketRotativo();
            ClicarBotaoConcluirCadastro();
        }
    }
}
