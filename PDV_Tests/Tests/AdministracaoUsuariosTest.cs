using NUnit.Framework;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class AdministracaoUsuariosTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuUsuarios()
        {
            try
            {
                administracaoUsuariosPage.ClicarMenuAdministracao();
                administracaoUsuariosPage.ClicarSubMenuUsuarios();
                administracaoUsuariosPage.ClicarBotaoNovoUsuario();
                administracaoUsuariosPage.CriarUsuario();
                administracaoUsuariosPage.ClicarBotaoSalvarUsuario();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
