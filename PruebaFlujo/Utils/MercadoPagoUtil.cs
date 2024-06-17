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
    public static class MercadoPagoUtil
    {
        public static void EscribirTextoDentroIFrame(ChromeDriver driver, string id, string texto)
        {
            driver.SwitchTo().DefaultContent();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//iframe[@name='{id}']")));

            driver.SwitchTo().Frame(driver.FindElement(By.XPath($"//iframe[@name='{id}']")));
            var input = driver.FindElement(By.Id(id));
            Thread.Sleep(1000);
            input.SendKeys(texto);
        }

        public static void EscribirTexto(ChromeDriver driver, string name, string texto)
        {
            driver.SwitchTo().DefaultContent();
            var element = driver.FindElement(By.Name(name));
            element.SendKeys(texto);
        }

        public static void ClickEnPagar(ChromeDriver driver)
        {
            driver.SwitchTo().DefaultContent();
            var pagarButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            pagarButton.Click();

        }
    }
}
