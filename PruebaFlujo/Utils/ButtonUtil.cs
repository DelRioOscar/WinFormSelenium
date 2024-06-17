using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace PruebaFlujo.Utils
{
    public static class ButtonUtil
    {
        public static void ClickContinuar(ChromeDriver driver)
        {
            var buttonContinuar = driver.FindElement(By.CssSelector("a.bs-btn.bs-btn-primary"));
            ScrollUtil.ScrollIntoView(driver, buttonContinuar);
            buttonContinuar.Click();
        }

        public static void ClickEnHipervinculo(ChromeDriver driver, string textoBoton)
        {
            var hipervinculo = driver.FindElement(By.XPath($"//a[text()='{textoBoton}']"));
            ScrollUtil.ScrollIntoView(driver, hipervinculo);
            Thread.Sleep(500);
            hipervinculo.Click();
        }

        public static void ClickInputBtnPorId(ChromeDriver driver, string id)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(id)));

            var button = driver.FindElement(By.Id(id));
            ScrollUtil.ScrollIntoView(driver, button);
            button.Click();
        }
    }
}
