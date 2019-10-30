using NUnit.Framework;
using OpenQA.Selenium.Winium;
using PDV_Tests.Tests;
using PDV_Tests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PDV_Tests.Utils;

namespace PDV_Tests.Tests
{
    public class PatioEntradaTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuEntrada()
        {
            try
            {
                patioentradaPage.ClicarMenuPatio();
                patioentradaPage.ClicarSubMenuEntrada();
                patioentradaPage.ModalAbrirCaixa();
                patioentradaPage.EntradaComPlaca();
                patioentradaPage.ModalConfirmarEntrada();

                patioentradaPage.EntradaComPlaca2();
                patioentradaPage.ModalConfirmarEntrada();

                patioentradaPage.EntradaComPlaca3();
                patioentradaPage.ModalConfirmarEntrada();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }

        ////[Test]
        //public void EntradaComPlaca()
        //{
        //    patioentradaPage.EntradaComPlaca();
        //    patioentradaPage.ModalConfirmarEntrada();
        //}
    }
}
