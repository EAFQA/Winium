using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using PDV_Tests.Utils;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class AdministracaoUsuariosPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public AdministracaoUsuariosPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuAdministracao()
        {
            _driver.FindElementByName("ADMINISTRAÇÃO").Click();
        }

        public void ClicarSubMenuUsuarios()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("USUÁRIOS")).Click().Build().Perform();
        }

        public void ClicarBotaoNovoUsuario()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void CriarUsuario()
        {
            var novoUsuario = String.Format("Usuario-{0}", rdn.Next(1111, 9999));
            var novaSenha = String.Format("Senha-{0}", rdn.Next(1111, 9999));

            _driver.FindElementById("txtNome").SendKeys(novoUsuario);
            Assert.AreEqual(novoUsuario, novoUsuario);
            _driver.FindElementById("cmbPerfilAcesso").Clear();
            //_driver.FindElementById("cmbPerfilAcesso").SendKeys("ADMINISTRADOR");
            // _driver.Keyboard.SendKeys("ADMINISTRADOR");
            _driver.FindElementById("txtUsuario").SendKeys(novoUsuario);
            Assert.AreEqual(novoUsuario, novoUsuario);
            _driver.FindElementById("txtSenha").SendKeys(novaSenha);
            Assert.AreEqual(novaSenha, novaSenha);
            _driver.FindElementById("txtConfirmacaoSenha").SendKeys(novaSenha);
            Assert.AreEqual(novaSenha, novaSenha);
            _driver.FindElementById("chkAtivo").Click();
            _driver.FindElementById("chkAlterarSenha").Click();
        }

        public void ClicarBotaoSalvarUsuario()
        {
            _driver.FindElementById("btnSalvar").Click();
            Assert.AreEqual("Dados gravados com sucesso.", "Dados gravados com sucesso.");
            _driver.FindElementById("radBtnOk").Click();
        }

        public void ClicarConsultarUsuario()
        {
            ConnectDB con = new ConnectDB();
            con.query_string = "select top 1 * from Usuario(Nolock) order by 1 desc";
            var dataTable = new DataTable();

            dataTable = con.sql_data_adapter();
            String consultaUsuario = dataTable.Rows[0]["Nome"].ToString();

            _driver.FindElementById("txtPesquisa").SendKeys(consultaUsuario);
            Assert.AreEqual(consultaUsuario, consultaUsuario);
            _driver.FindElementById("btnPesquisar").Click();
            Assert.AreEqual(consultaUsuario, consultaUsuario);
        }

        public void ClicarBotaoCancelarCadastroUsuario()
        {
            _driver.FindElementByName("btnCancelar").Click();
        }

        public void CriaUsuario()
        {
            ClicarMenuAdministracao();
            ClicarSubMenuUsuarios();
            ClicarBotaoNovoUsuario();
            CriarUsuario();
            ClicarBotaoSalvarUsuario();
            ClicarConsultarUsuario();
        }
    }
}
