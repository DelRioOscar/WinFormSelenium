using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Keys = OpenQA.Selenium.Keys;

namespace PruebaFlujo.Utils
{
    public static class PatPassUtil
    {
        public static void EscribirTarjeta(ChromeDriver driver, string id, string numero)
        {
            var element = driver.FindElement(By.Id(id));
            element.SendKeys(Keys.Home + numero);
        }

        public static void CheckCheckboxPorName(ChromeDriver driver, string name)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(name)));

            var element = driver.FindElement(By.Name(name));
            element.Click();
        }
    }
}
