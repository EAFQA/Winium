using NUnit.Framework;
using PDV_Tests.Utils;
using System;

namespace PDV_Tests.Tests
{
    public class ZExecutaTodosTestes : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }
        [Test]
        public void DeveExecutarTodosTestes()
        {
            try
            {
                //administracaoCadastroDiariaPage.CriarDiaria();
                patioentradaPage.RealizarEntradaComPlaca();
                administracaoFeriadoPage.CadastrarFeriado();
                administracaoPerfilAcessoPage.CriaPerfilAcesso();
                administracaoUsuariosPage.CriaUsuario();
                clienteCadastroMensalistaPage.CadastrarMensalista();
                configuracaoAndarPage.CriarAndar();
                configuracaoAreaPage.CriarArea();
                configuracaoParametroPage.SalvarConfiguracaoParametro();
                configuracaoTerminalPage.SalvarConfiguracaoTerminal();
                patiosaidaPage.RealizarSaidaSemCPF();
                patiosaidaPage.RealizarSaidaComCPF();
                patioVoucherPage.CriarVoucher();
                caixaSangriaPage.RealizarSangria();
                administracaoLimpaPatioPage.LimparPatio();
                deslogarPDVPage.SairPDV();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
