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
    public static class HyperlinkUtil
    {
        public static void ClickEnHyperlink(ChromeDriver driver, string texto)
        {
            var hyperlink = driver.FindElement(By.XPath($"//a[@class='bs-selector w-100p']//span[@class='label' and text()='{texto}']"));
            ScrollUtil.ScrollIntoView(driver, hyperlink);
            hyperlink.Click();
        }
    }
}
