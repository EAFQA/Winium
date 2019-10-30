using NUnit.Framework;
using PDV_Tests.Utils;
using System;

namespace PDV_Tests.Tests
{
    public class AdministracaoTabelaDePrecoTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        ////[Test]
        //public void DeveClicarSubMenuTabelaDePreco()
        //{
        //    try
        //    {
        //        administracaoTabelaDePrecoPage.ClicarMenuAdministracao();
        //        administracaoTabelaDePrecoPage.ClicarSubMenuTabelaDePreco();
        //        administracaoTabelaDePrecoPage.ClicarBotaoNovaTabelaDePreco();
        //        administracaoTabelaDePrecoPage.CriarNovaTabelaDePreco();
        //        administracaoTabelaDePrecoPage.ClicarBotaoSalvarNovaTabelaDePreco();
        //    }
        //    catch (Exception)
        //    {
        //        loginPage.Screen();
        //        Email.EnviarEmail();
        //    }
        //}
    }
}