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
    public static class DivUtil
    {
        public static void SeleccionarElementoConTexto(ChromeDriver driver, string texto)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//div[text()='{texto}']")));
            
            var div = driver.FindElement(By.XPath($"//div[text()='{texto}']"));
            div.Click();
        }
    }
}
