using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace PruebaFlujo.Utils
{
    public static class ModalUtil
    {
        public static bool EsperarQueAparezcaModal(ChromeDriver driver, int sec = 30)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p-dialog")));
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        public static void HastaQueDesaparezcaModal(ChromeDriver driver)
        {
            try
            {
                var pdialog = driver.FindElement(By.XPath("//p-dialog"));
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//p-dialog")));
            }
            catch
            {

            }
        }

        public static void EsperarContenidoModalGps(ChromeDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//app-modal-gps")));
            var modal = driver.FindElement(By.XPath("//app-modal-gps"));
            // encontrar etiqueta iframe esperar que su contenido cargue dentro del modal.

            var iframe = modal.FindElement(By.TagName("iframe"));
            driver.SwitchTo().Frame(iframe);


            // esperar hasta que salga el h3 con la palabra Formulario dentro del iframe.
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h3[text()='Formulario']")));
            driver.SwitchTo().DefaultContent();

        }

        public static void CerrarModalGPS(ChromeDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//app-modal-gps")));

            var modal = driver.FindElement(By.XPath("//app-modal-gps"));
            var button = modal.FindElement(By.Id("bs-btn-contactenos-header"));
            button.Click();
        }
    }
}
