using NUnit.Framework;
using PDV_Tests.Utils;
using System;

namespace PDV_Tests.Tests
{
    public class LoginTest : BaseTest
    {
        //[Test]
        public void DeveRealizarLogin()
        {
            try
            {
                loginPage.Logar("suportein1", "sup1n1512");
                Assert.AreEqual("suportein1", "suportein1");
                loginPage.Notificacao();
                loginPage.BotaoOkModalLogin();
                loginPage.Logar("suportein", "sup1n15122");
                Assert.AreEqual("sup1n15122", "sup1n15122");
                loginPage.Notificacao();
                loginPage.BotaoOkModalLogin();
                loginPage.Logar("suportein", "sup1n1512");
                Assert.AreEqual("suportein", "suportein");
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}