using NUnit.Framework;
using PDV_Tests.Utils;
using System;

namespace PDV_Tests.Tests
{
    public class AdministracaoCadastroDiariaTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        [Test]
        public void DeveClicarSubMenuCadastroDiaria()
        {
            try
            {
                administracaoCadastroDiariaPage.ClicarMenuAdministracao();
                administracaoCadastroDiariaPage.ClicarSubMenuACadastroDiaria();
                administracaoCadastroDiariaPage.ClicarBotaoNovaDiaria();
                administracaoCadastroDiariaPage.CriarNovaDiaria();
                administracaoCadastroDiariaPage.ClicarBotaoSalvarNovaDiaria();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
