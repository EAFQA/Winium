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
    public class ConfiguracaoParametroTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuParametros()
        {
            try
            {
                configuracaoParametroPage.ClicarMenuConfiguracao();
                configuracaoParametroPage.ClicarSubMenuParametros();
                configuracaoParametroPage.ClicarBotaoSalvarParametros();
                configuracaoParametroPage.ClicarModalBotaoOkParametros();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }

        ////[Test]
        //public void DeveSalvarParametros()
        //{
        //    configuracaoParametroPage.ClicarBotaoSalvarParametros();
        //    configuracaoParametroPage.ClicarModalBotaoOkParametros();
        //}
    }
}
