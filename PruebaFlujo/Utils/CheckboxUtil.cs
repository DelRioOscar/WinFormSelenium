using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Utils
{
    public static class CheckboxUtil
    {
        public static void ClickEnCheckbox(ChromeDriver driver, string texto)
        {
            IWebElement checkbox = null;
            checkbox = driver.FindElement(By.XPath($"//p-checkbox//label[text()='{texto}']"));

            if (checkbox == null)
                checkbox = driver.FindElement(By.XPath($"//p-checkbox[@ng-reflect-label='{texto}']"));


            ScrollUtil.ScrollIntoView(driver, checkbox);
            checkbox.Click();

            Thread.Sleep(500);
        }

    }
}
