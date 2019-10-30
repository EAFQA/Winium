using NUnit.Framework;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class ConfiguracaoTerminalTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");

        }
        //[Test]
        public void DeveClicarSubMenuTerminais()
        {
            try
            {
                configuracaoTerminalPage.ClicarMenuConfiguracao();
                configuracaoTerminalPage.ClicarSubMenuTerminal();
                configuracaoTerminalPage.ClicarBotaoNovoTerminal();
                configuracaoTerminalPage.InserirNovoTerminal();
                configuracaoTerminalPage.ClicarBotaoSalvarTerminal();
                configuracaoTerminalPage.ClicarModalBotaoOkTerminal();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }

        ////[Test]
        //public void DevoClicarBotaoNovoTerminal()
        //{
        //    configuracaoTerminalPage.ClicarBotaoNovoTerminal();
        //}

        ////[Test]
        //public void DevoCriarNovoTerminal()
        //{
        //    configuracaoTerminalPage.InserirNovoTerminal();
        //}

        ////[Test]
        //public void DevoSalvarNovoTerminal()
        //{
        //    configuracaoTerminalPage.ClicarBotaoSalvarTerminal();
        //    configuracaoTerminalPage.ClicarModalBotaoOkTerminal();
        //}
    }
}
