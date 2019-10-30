using NUnit.Framework;
using OpenQA.Selenium.Winium;
using PDV_Tests.Pages;
using System;

namespace PDV_Tests.Tests
{
    public class BaseTest
    {
        public WiniumDriver driver;
        public LoginPage loginPage;
        public PatioEntradaPage patioentradaPage;
        public ConfiguracaoParametroPage configuracaoParametroPage;
        public ConfiguracaoTerminalPage configuracaoTerminalPage;
        public PatioSaidaPage patiosaidaPage;
        public ConfiguracaoAreaPage configuracaoAreaPage;
        public ConfiguracaoAndarPage configuracaoAndarPage;
        public PatioVoucherPage patioVoucherPage;
        public AdministracaoCadastroDiariaPage administracaoCadastroDiariaPage;
        public AdministracaoTabelaDePrecoPage administracaoTabelaDePrecoPage;
        public AdministracaoFeriadoPage administracaoFeriadoPage;
        public AdministracaoLimpaPatioPage administracaoLimpaPatioPage;
        public AdministracaoSelosPage administracaoSelosPage;
        public AdministracaoTabelaPrecoPromocionalPage administracaoTabelaPrecoPromocionalPage;
        public AdministracaoUsuariosPage administracaoUsuariosPage;
        public AdministracaoPerfilAcessoPage administracaoPerfilAcessoPage;
        public AdministracaoPrismaPage administracaoPrismaPage;
        public CaixaSangriaPage caixaSangriaPage;
        public ClienteCadastroMensalistaPage clienteCadastroMensalistaPage;
        public DeslogarPDVPage deslogarPDVPage;

        [SetUp]
        public void SetUp()
        {
            DesktopOptions options = new DesktopOptions();

            //Toda vez que obter uma nova versão do PDV, talvez seja necessário alterar o caminho da pasta ou implementar uma forma que ele capture esse cara dinâmico.
            options.ApplicationPath = @"C:\Users\admin\AppData\Local\Apps\2.0\XV4WTXYP.4JT\8XTDVXDC.PMB\esta..tion_0000000000000000_0001.0000_16bdff4dcd836b87\Estapar.PDV.UI.exe";
            var driver = new WiniumDriver(@"C:\PDV_Tests\Winium.Desktop.Driver", options);
            //Tempo máximo de espera até que o elemento esteja visível, se demoprar mais que 20 segundos o teste falha.
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));

            loginPage = new LoginPage(driver);
            patioentradaPage = new PatioEntradaPage(driver);
            patiosaidaPage = new PatioSaidaPage(driver);
            configuracaoParametroPage = new ConfiguracaoParametroPage(driver);
            configuracaoTerminalPage = new ConfiguracaoTerminalPage(driver);
            configuracaoAreaPage = new ConfiguracaoAreaPage(driver);
            configuracaoAndarPage = new ConfiguracaoAndarPage(driver);
            patioVoucherPage = new PatioVoucherPage(driver);
            administracaoCadastroDiariaPage = new AdministracaoCadastroDiariaPage(driver);
            administracaoTabelaDePrecoPage = new AdministracaoTabelaDePrecoPage(driver);
            administracaoFeriadoPage = new AdministracaoFeriadoPage(driver);
            administracaoLimpaPatioPage = new AdministracaoLimpaPatioPage(driver);
            administracaoSelosPage = new AdministracaoSelosPage(driver);
            administracaoTabelaPrecoPromocionalPage = new AdministracaoTabelaPrecoPromocionalPage(driver);
            administracaoUsuariosPage = new AdministracaoUsuariosPage(driver);
            administracaoPerfilAcessoPage = new AdministracaoPerfilAcessoPage(driver);
            administracaoPrismaPage = new AdministracaoPrismaPage(driver);
            caixaSangriaPage = new CaixaSangriaPage(driver);
            clienteCadastroMensalistaPage = new ClienteCadastroMensalistaPage(driver);
            deslogarPDVPage = new DeslogarPDVPage(driver);
        }

        [TearDown]
        public void Close()
        {
            configuracaoAreaPage.DeveFecharInstancia(); //Foi realizado esse tratamento, por ser Desktop, ele cria uma dependência de um método fora da própria classe.
        }
    }
}
