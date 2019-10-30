using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Pages
{
    public class PatioVoucherPage
    {
        private readonly WiniumDriver _driver;
        Random rdn = new Random();

        public PatioVoucherPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarMenuPatio()
        {
            _driver.FindElementByName("PÁTIO").Click();
        }

        public void ClicarSubMenuVoucher()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElementByName("VOUCHER")).Click().Build().Perform();
        }

        public void ClicarBotaoNovoVoucher()
        {
            _driver.FindElementById("btnNovo").Click();
        }

        public void ClicarBotaoCriarNovoVoucher()
        {
            var novoVoucher = String.Format("Voucher -{0}", rdn.Next(1111, 9999));
            _driver.FindElementById("txtNomeEvento").SendKeys(novoVoucher);
            _driver.FindElementById("txtInicioVigencia").SendKeys("20/12/2018");
            _driver.FindElementById("txtTerminoVigencia").SendKeys("20/12/2040");
            _driver.FindElementById("txtQtdeVoucher").SendKeys("2");
        }

        public void ClicarBotaoSalvarVoucher()
        {
            _driver.FindElementById("btnSalvar").Click();
            _driver.FindElementById("radBtnOk").Click();
        }

        public void ClicarBotaoGerarVoucher()
        {
            _driver.FindElementById("btnGerar").Click();
        }

        public void InserirSequencialVoucher()
        {
            _driver.FindElementById("txtSequencialInicial").SendKeys("1");
            _driver.FindElementById("txtSequencialFinal").SendKeys("2");
        }

        public void ClicarBotaoImprimirVoucher()
        {
            _driver.FindElementById("btnImprimir").Click();
        }

        public void ClicarBotaoVoltar()
        {
            _driver.FindElementById("btnVoltar").Click();
        }

        public void CriarVoucher()
        {
            ClicarMenuPatio();
            ClicarSubMenuVoucher();
            ClicarBotaoNovoVoucher();
            ClicarBotaoCriarNovoVoucher();
            ClicarBotaoSalvarVoucher();
            ClicarBotaoGerarVoucher();
            InserirSequencialVoucher();
            ClicarBotaoImprimirVoucher();
            ClicarBotaoVoltar();
        }
    }
}
