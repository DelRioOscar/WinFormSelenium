using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PruebaFlujo.Utils
{
    public static class WaitUntil
    {
        public static void EsperarHastaElementoVisible(ChromeDriver driver, string id)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(id)));
        }


        public static void EsperarHastaQueAparezcaDeducible(ChromeDriver driver, string deducible)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//span[@class='label' and text()='{deducible}']/parent::a")));
        }

        public static void EsperarHastaQueAparezcaH1ConTexto(ChromeDriver driver, string texto)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//h1[text()='{texto}']")));
            Thread.Sleep(1000);
        }
    }
}
