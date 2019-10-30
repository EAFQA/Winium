using NUnit.Framework;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class AdministracaoFeriadoTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuFeriado()
        {
            try
            {
                administracaoFeriadoPage.ClicarMenuAdministracao();
                administracaoFeriadoPage.ClicarSubMenuFeriados();
                administracaoFeriadoPage.ClicarBotaoNovoFeriado();
                administracaoFeriadoPage.InserirNovoFeriado();
                administracaoFeriadoPage.ClicarBotaoSalvarFeriado();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
