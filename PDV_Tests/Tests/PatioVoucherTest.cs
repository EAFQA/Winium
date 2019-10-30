using NUnit.Framework;
using PDV_Tests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Tests
{
    public class PatioVoucherTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            loginPage.Logar("suportein", "sup1n1512");
        }

        //[Test]
        public void DeveClicarSubMenuVoucher()
        {
            try
            {
                patioVoucherPage.ClicarMenuPatio();
                patioVoucherPage.ClicarSubMenuVoucher();
                patioVoucherPage.ClicarBotaoNovoVoucher();
                patioVoucherPage.ClicarBotaoCriarNovoVoucher();
                patioVoucherPage.ClicarBotaoSalvarVoucher();
                patioVoucherPage.ClicarBotaoGerarVoucher();
                patioVoucherPage.InserirSequencialVoucher();
                patioVoucherPage.ClicarBotaoImprimirVoucher();
                patioVoucherPage.ClicarBotaoVoltar();
            }
            catch (Exception)
            {
                loginPage.Screen();
                Email.EnviarEmail();
            }
        }
    }
}
