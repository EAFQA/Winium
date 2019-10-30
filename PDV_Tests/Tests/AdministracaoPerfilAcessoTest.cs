using NUnit.Framework;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class AdministracaoPerfilAcessoTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuPerfilAcesso()
        {
            try
            {
                administracaoPerfilAcessoPage.ClicarMenuAdministracao();
                administracaoPerfilAcessoPage.ClicarSubMenuPerfilAcesso();
                administracaoPerfilAcessoPage.ClicarBotaoNovoPerfilAcesso();
                administracaoPerfilAcessoPage.CriarPerfilAcesso();
                administracaoPerfilAcessoPage.ClicarBotaoSalvarPerfilAcesso();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}