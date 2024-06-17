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
    public static class SelectUtil
    {
        public static void SeleccionarSelect(ChromeDriver driver, string labelTitle, string elementoTexto)
        {
            try
            {
                var select = driver.FindElement(By.XPath($"//p[@class='bs-label' and text()='{labelTitle}']/following-sibling::p-dropdown"));
                ScrollUtil.ScrollIntoView(driver, select);
                select.Click();
                var dropdownItems = select.FindElement(By.XPath($"//p-dropdownitem//li//span[text()='{elementoTexto}']"));
                dropdownItems.Click();
            }
            catch
            {
                var select = driver.FindElement(By.XPath($"//p[text()='{labelTitle}']/following-sibling::p-dropdown"));
                ScrollUtil.ScrollIntoView(driver, select);
                select.Click();
                var dropdownItems = select.FindElement(By.XPath($"//p-dropdownitem//li//span[text()='{elementoTexto}']"));
                dropdownItems.Click();

            }
        }

        public static void SeleccionarSelectAlAzar(ChromeDriver driver, string labelTitle)
        {
            var select = driver.FindElement(By.XPath($"//p[text()='{labelTitle}']/following-sibling::p-dropdown"));
            select.Click();

            ScrollUtil.ScrollIntoView(driver, select);

            // obtener todos los li con la clase 'p-dropdown-item p-ripple'
            var lis = driver.FindElements(By.CssSelector("li.p-dropdown-item.p-ripple"));

            // seleccionar un li al azar.
            var random = new Random();
            var li = lis[random.Next(lis.Count)];
            li.Click();
        }

        public static void SeleccionarSelectNativo(ChromeDriver driver, string id, string elementoTexto)
        {
            var select = driver.FindElement(By.Id(id));
            var selectElement = new SelectElement(select);
            selectElement.SelectByText(elementoTexto);
        }
    }
}
