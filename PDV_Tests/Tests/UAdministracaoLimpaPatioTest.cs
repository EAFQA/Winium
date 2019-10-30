using NUnit.Framework;
using PDV_Tests.Utils;
using System;

namespace PDV_Tests.Tests
{
    public class UAdministracaoLimpaPatioTest : BaseTest
    {

        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuLimpaPatio()
        {
            try
            {
                administracaoLimpaPatioPage.ClicarMenuAdministracao();
                administracaoLimpaPatioPage.ClicarSubMenuLimpaPatio();
                administracaoLimpaPatioPage.ClicarBotaoOkModal();
                administracaoLimpaPatioPage.InserirPeriodo();
                administracaoLimpaPatioPage.ClicarBotaoConfirmar();
                administracaoLimpaPatioPage.ClicarModalBotaoNao();
                administracaoLimpaPatioPage.ClicarModalBotaoSim();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }

        }
    }
}
