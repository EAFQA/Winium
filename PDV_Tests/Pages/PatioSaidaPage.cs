using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDV_Tests.Pages;
using PDV_Tests.Utils;
using System.Data;
using NUnit.Framework;

namespace PDV_Tests.Pages
{
    public class PatioSaidaPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public PatioSaidaPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuPatio()
        {
            _driver.FindElementByName("PÁTIO").Click();
        }

        public void ClicarSubMenuSaida()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("SAÍDA")).Click().Build().Perform();
        }

        public void ModalAbrirCaixa()
        {
            _driver.FindElementById("btnOK").Click();
        }

        public void InserirPlacaUtilizadaEntrada()
        {
            ConnectDB con = new ConnectDB();
            con.query_string = "select top 1 * from GuardaVeiculo(Nolock) where DataSaida is null and DataLiberacaoSaida is null order by 1 desc";
            var dataTable = new DataTable();

            dataTable = con.sql_data_adapter();
            String placa = dataTable.Rows[0]["Placa"].ToString();

            _driver.FindElementById("txtPlaca").SendKeys(placa);
            _driver.FindElementById("txtPlaca").Submit();
        }

        public void InserirPlacaUtilizadaEntrada2()
        {
            ConnectDB con = new ConnectDB();
            con.query_string = "select top 1 * from GuardaVeiculo(Nolock) where DataSaida is null and DataLiberacaoSaida is null order by 1 desc";
            var dataTable = new DataTable();

            dataTable = con.sql_data_adapter();
            String placa = dataTable.Rows[0]["Placa"].ToString();

            _driver.FindElementById("txtPlaca").SendKeys(placa);
            _driver.FindElementById("txtPlaca").Submit();
        }

        public void InserirFormaPagamentoDinheiro()
        {
            _driver.FindElementById("btnCancelar").Click();
            Assert.AreEqual("CLIENTE POSSUI CARTÃO DE CRÉDITO PORTO SEGURO?", "CLIENTE POSSUI CARTÃO DE CRÉDITO PORTO SEGURO?");
            _driver.FindElementById("radBtnNo").Click();
            _driver.FindElementById("txtPlaca").Submit();
            _driver.FindElementById("rbFormaPagamentoDINHEIRO").Click();
            Assert.AreEqual("DINHEIRO", "DINHEIRO");
            _driver.FindElementById("rbFormaPagamentoDINHEIRO").Submit();
            _driver.FindElementById("txtValorPago").Submit();
            _driver.FindElementById("txtTroco").Submit();
        }

        public void NaoInserirCpfNaNota()
        {
            _driver.FindElementById("txtPlaca").Submit();
            Assert.AreEqual("CPF/CNPJ na RPS?", "CPF/CNPJ na RPS?");
            _driver.FindElementById("radBtnNo").Click();
            Assert.AreEqual("Saída Liberada", "Saída Liberada");
            _driver.FindElementById("radBtnOk").Click();
        }

        public void InserirCpfNaNota()
        {
            _driver.FindElementById("txtPlaca").Submit();
            Assert.AreEqual("CPF/CNPJ na RPS?", "CPF/CNPJ na RPS?");
            _driver.FindElementById("radBtnYes").Click();
            Assert.AreEqual("Pessoa Física?", "Pessoa Física?");
            _driver.FindElementById("radBtnYes").Click();
            _driver.FindElementById("txtCPF").SendKeys(CPF.GerarCPF());
            _driver.FindElementById("txtCPF").Submit();
            _driver.FindElementById("txtNome").SendKeys(Faker.Name.FullName());
            _driver.FindElementById("txtNome").Submit();
            Assert.AreEqual("Saída Liberada", "Saída Liberada");
            _driver.FindElementById("radBtnOk").Click();
        }

        public void FluxoSaida2()
        {
            ClicarMenuPatio();
            ClicarSubMenuSaida();
            ModalAbrirCaixa();
            InserirPlacaUtilizadaEntrada2();
            InserirFormaPagamentoDinheiro();
            NaoInserirCpfNaNota();
        }

        public void RealizarSaidaSemCPF()
        {
            ClicarMenuPatio();
            ClicarSubMenuSaida();
            InserirPlacaUtilizadaEntrada();
            InserirFormaPagamentoDinheiro();
            NaoInserirCpfNaNota();
        }

        public void RealizarSaidaComCPF()
        {
            InserirPlacaUtilizadaEntrada2();
            InserirFormaPagamentoDinheiro();
            InserirCpfNaNota();
        }
    }
}
