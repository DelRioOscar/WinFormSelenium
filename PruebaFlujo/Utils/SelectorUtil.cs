using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Utils
{
    public static class SelectorUtil
    {
        public static void SeleccionarDeducible(ChromeDriver driver, string deducible)
        {
            var label = driver.FindElement(By.XPath($"//span[@class='label' and text()='{deducible}']/parent::a"));
            ScrollUtil.ScrollIntoView(driver, label);
            label.Click();
        }

        public static void SeleccionarDeducibleAlAzar(ChromeDriver driver)
        {
            // esperar hasta que salga el parrafo con el texto "Seleccione deducible".
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[text()='Seleccione deducible']")));

            // encontrar el p con el texto "Seleccione deducible" y acceder al hermano.
            var div = driver.FindElement(By.XPath("//p[text()='Seleccione deducible']/following-sibling::div"));

            // del div obtener todos los span.
            var spans = div.FindElements(By.TagName("span"));

            // almacenar en un arreglo de entero todos el texto de los span.
            var deducibles = spans.Select(s => int.Parse(s.Text)).ToArray();

            // seleccionar un deducible al azar.
            var random = new Random();
            var deducible = deducibles[random.Next(deducibles.Length)];

            // seleccionar el deducible.
            SeleccionarDeducible(driver, deducible.ToString());


        }

        public static void SeleccionarPrecio(ChromeDriver driver)
        {
            var div = driver.FindElement(By.CssSelector("div.bs-tabla-comparativa section div:nth-child(3) div:nth-child(3)"));
            ScrollUtil.ScrollIntoView(driver, div);
            div.Click();
        }
    }
}
