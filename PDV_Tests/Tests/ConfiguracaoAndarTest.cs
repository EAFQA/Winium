using NUnit.Framework;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class ConfiguracaoAndarTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuAndar()
        {
            try
            {
                configuracaoAndarPage.ClicarMenuConfiguracao();
                configuracaoAndarPage.ClicarSubMenuAndar();
                configuracaoAndarPage.ClicarBotaoNovoAndar();
                configuracaoAndarPage.CriarNovoAndar();
                configuracaoAndarPage.SalvarNovoAndar();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
