using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Utils
{
    public static class TransbankUtil
    {
        public static IWebElement EncontrarFormulario(ChromeDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("iframeId")));

            var iframe = driver.FindElement(By.Name("iframeId"));
            driver.SwitchTo().Frame(iframe);
            var form = driver.FindElement(By.Name("frm"));
            return form;
        }

        public static void IngresarTexto(IWebElement form, string id, string texto)
        {
            Thread.Sleep(500);
            var rutInput = form.FindElement(By.Id(id));
            rutInput.SendKeys(texto);
            Thread.Sleep(500);
        }

        public static void ClickEnBotonContinuar(ChromeDriver driver)
        {
            driver.SwitchTo().DefaultContent();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("iframeId")));

            var iframe = driver.FindElement(By.Name("iframeId"));

            driver.SwitchTo().Frame(iframe);
            IWebElement continuarButton = driver.FindElement(By.CssSelector("input[value='Continuar']"));
            continuarButton.Click();
            driver.SwitchTo().DefaultContent();

        }
    }
}
