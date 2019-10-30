using NUnit.Framework;
using PDV_Tests.Pages;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class TCaixaSangriaTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuSangria()
        {
            try
            {
                patiosaidaPage.FluxoSaida2();
                caixaSangriaPage.ClicarMenuCaixa();
                caixaSangriaPage.ClicarSubMenuSangria();
                caixaSangriaPage.InserirValorSangria();
                caixaSangriaPage.ClicarBotaoConfirmarSangria();
                caixaSangriaPage.ConfirmarModalUsuarioSenhaSangria();
                caixaSangriaPage.ConfirmarModalSangria();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
