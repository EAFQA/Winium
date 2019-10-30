using NUnit.Framework;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class ClienteCadastroMensalistaTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuCadastroDeMensalista()
        {
            try
            {
                clienteCadastroMensalistaPage.ClicarMenuClientes();
                clienteCadastroMensalistaPage.ClicarSubMenuCadastroMensalista();
                clienteCadastroMensalistaPage.ClicarBotaoOkModalCaixa();
                clienteCadastroMensalistaPage.SelecionarTabelaPreco();
                clienteCadastroMensalistaPage.InserirCPF();
                clienteCadastroMensalistaPage.PreencherFormulario();
                clienteCadastroMensalistaPage.ClicarBotaoProsseguir();
                clienteCadastroMensalistaPage.SelecionarFormaPagamento();
                clienteCadastroMensalistaPage.ClicarBotaoConfirmarPagamento();
                clienteCadastroMensalistaPage.NaoInserirTicketRotativo();
                clienteCadastroMensalistaPage.ClicarBotaoConcluirCadastro();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
