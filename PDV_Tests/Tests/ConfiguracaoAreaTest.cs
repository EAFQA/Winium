using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class ConfiguracaoAreaTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }
       
        //[Test]
        public void DeveClicarSubMenuArea()
        {
            try
            {
                configuracaoAreaPage.ClicarMenuConfiguracao();
                configuracaoAreaPage.ClicarSubMenuArea();
                configuracaoAreaPage.ClicarBotaoNovaArea();
                configuracaoAreaPage.CriarNovaArea();
                configuracaoAreaPage.SalvarNovaArea();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
        ////[Test]
        //public void DeveClicarBotaoNovaArea()
        //{
        //    configuracaoAreaPage.ClicarBotaoNovaArea();
        //}

        ////[Test]
        //public void DeveCriarNovaArea()
        //{
        //    configuracaoAreaPage.CriarNovaArea();
        //}

        ////[Test]
        //public void DeveSalvarNovaArea()
        //{
        //    configuracaoAreaPage.SalvarNovaArea();
        //}

       
    }
}
