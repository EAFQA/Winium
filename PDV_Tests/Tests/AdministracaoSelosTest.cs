using NUnit.Framework;
using OpenQA.Selenium;
using PDV_Tests.Utils;
using System;

namespace PDV_Tests.Tests
{
    public class AdministracaoSelosTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuSelos()
        {
            try
            {
                administracaoSelosPage.ClicarMenuAdministracao();
                administracaoSelosPage.ClicarSubMenuSelos();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
