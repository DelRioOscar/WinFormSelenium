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
    public static class PasarelaUtil
    {
        public static void SeleccionarTipoPago(ChromeDriver driver, string texto)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='bs-selector w-100p grande']//span[text()='{texto}']")));
            var tipoPago = driver.FindElement(By.XPath($"//div[@class='bs-selector w-100p grande']//span[text()='{texto}']"));
            ScrollUtil.ScrollIntoView(driver, tipoPago);
            tipoPago.Click();
        }

        public static void SeleccionarPasarela(ChromeDriver driver, string texto)
        {
            // Encontrar etiqueta img con el attributo alt igual a texto.
            string pasarelaText = string.Empty;
            if (texto.Contains("Mercado"))
            {
                pasarelaText = "Mercado Pago";
            }
            else if (texto.Contains("Klap"))
            {
                pasarelaText = "Klap";
            }
            else if(texto.Contains("Fintoc"))
            {
                pasarelaText = "Fintoc";
            }
            else
            {
                throw new Exception("Pasarela no encontrada.");
            }

            var pasarela = driver.FindElement(By.XPath($"//img[@alt='{pasarelaText}']"));
            ScrollUtil.ScrollIntoView(driver, pasarela);
            pasarela.Click();
        }

        public static void AceptarTerminos(ChromeDriver driver)
        {
            string texto = "Acepto términos y condiciones";
            // encontrar label que contenga el texto.
            var terminos = driver.FindElement(By.XPath($"//label[contains(text(),'{texto}')]"));
            ScrollUtil.ScrollIntoView(driver, terminos);
            terminos.Click();
        }

        public static void ClickEnBotonContinuar(ChromeDriver driver)
        {
            var botonContinuar = driver.FindElement(By.Id("BtnContinuar"));
            ScrollUtil.ScrollIntoView(driver, botonContinuar);
            botonContinuar.Click();
        }

        public static void ClickEnBotonContinuarEnElModal(ChromeDriver driver)
        {
            var botonContinuar = driver.FindElement(By.XPath("//div[@class='derecha boton-der']"));
            ScrollUtil.ScrollIntoView(driver, botonContinuar);
            botonContinuar.Click();
        }
    }
}
