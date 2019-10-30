using NUnit.Framework;
using OpenQA.Selenium.Winium;
using PDV_Tests.Tests;
using PDV_Tests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PDV_Tests.Utils;

namespace PDV_Tests.Tests
{
    public class PatioSaidaTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuSaida()
        {
            try
            {
                patiosaidaPage.ClicarMenuPatio();
                patiosaidaPage.ClicarSubMenuSaida();
                patiosaidaPage.ModalAbrirCaixa();
                patiosaidaPage.InserirPlacaUtilizadaEntrada();
                patiosaidaPage.InserirFormaPagamentoDinheiro();
                patiosaidaPage.NaoInserirCpfNaNota();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
        ////[Test]
        //public void DeveInformarPlacaUtilizadaEntrada()
        //{
        //    patiosaidaPage.InserirPlacaUtilizadaEntrada();
        //}
        ////[Test]
        //public void DeveInserirFormaPagamentoDinheiro()
        //{
        //    patiosaidaPage.InserirFormaPagamentoDinheiro();
        //}

        ////[Test]
        //public void NaoDeveInserirCpfNaNota()
        //{
        //    patiosaidaPage.NaoInserirCpfNaNota();
        //}
    }
}
