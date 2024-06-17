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
    public static class KlapUtil
    {
        public static void SeleccionarTipoTarjeta(ChromeDriver driver, string tipo)
        {
            var tipoTarjeta = driver.FindElement(By.XPath($"//label[contains(text(),'{tipo}')]"));
            tipoTarjeta.Click();
        }
        public static void EsperarInput(ChromeDriver driver, string texto)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//input[@formcontrolname='{texto}']")));
        }
        public static void IngresarTexto(ChromeDriver driver, string control, string texto)
        {
            Thread.Sleep(1000);
            var input = driver.FindElement(By.XPath($"//input[@formcontrolname='{control}']"));
            input.SendKeys(texto);
        }

        public static void ClickEnBotonPagar(ChromeDriver driver)
        {
            var botonPagar = driver.FindElement(By.Id("payBtn"));
            botonPagar.Click();
        }
    }
}
