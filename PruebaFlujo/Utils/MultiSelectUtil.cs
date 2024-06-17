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
    public static class MultiSelectUtil
    {
        public static  void SeleccionarOpcionConLabel(ChromeDriver driver, string labelTitle, string textoAIngresar)
        {
            Thread.Sleep(500);
            var select = driver.FindElement(By.XPath($"//p[@class='bs-label' and text()='{labelTitle}']/following-sibling::p-dropdown"));
            select.Click();

            ScrollUtil.ScrollIntoView(driver, select);

            Thread.Sleep(100);
            var input = driver.FindElement(By.CssSelector("input.p-dropdown-filter.p-inputtext"));
            input.SendKeys(textoAIngresar);

            Thread.Sleep(100);
            var dropdownItems = driver.FindElement(By.CssSelector("div.p-dropdown-items-wrapper ul li"));
            dropdownItems.Click();
            Thread.Sleep(200);
        }

        public static void SeleccionarOpcion(ChromeDriver driver, string texto, string textoAIngresar)
        {
            Thread.Sleep(500);
            var select = driver.FindElement(By.XPath($"//span[text()='{texto}']/following-sibling::div"));
            select.Click();

            ScrollUtil.ScrollIntoView(driver, select);


            Thread.Sleep(500);
            var input = driver.FindElement(By.CssSelector("input.p-dropdown-filter.p-inputtext"));
            input.SendKeys(textoAIngresar);

            Thread.Sleep(500);
            var dropdownItems = driver.FindElement(By.CssSelector("div.p-dropdown-items-wrapper ul li"));
            dropdownItems.Click();
        }

        public static void SeleccionarOpcionAlAzar(ChromeDriver driver, string label)
        {
            var select = driver.FindElement(By.XPath($"//span[text()='{label}']/following-sibling::div"));
            select.Click();

            ScrollUtil.ScrollIntoView(driver, select);

            // acceder a la etiqueta ul con la clase 'p-dropdown-items'.
            var ul = driver.FindElement(By.CssSelector("ul.p-dropdown-items"));

            // desde el ul, obtener todos los li.
            var lis = ul.FindElements(By.TagName("li"));

            // desde los lis, obtener un li al azar.
            var random = new Random();
            var li = lis[random.Next(lis.Count)];

            // hacer click en el li.
            li.Click();


        }
    }
}
