using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace PruebaFlujo.Utils
{
    public static class FintocUtil
    {
        public static void SeleccionarBanco(ChromeDriver driver, string bancoTexto)
        {
            var waitIframe = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            waitIframe.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("fintoc-legacy-iframe-id")));

            // cambiar a iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("fintoc-legacy-iframe-id")));


            // obtener el primer hijo del div con la clase 'bank-grid'
            var waitBank = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            waitBank.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='bank-grid']")));
            var banco = driver.FindElement(By.XPath("//div[@class='bank-grid']/div[1]"));
            banco.Click();

            driver.SwitchTo().DefaultContent();
        }

        public static void IngresarTextoInput(ChromeDriver driver, string atributo, string texto)
        {
            // esperar que aparezca el iframe con id 'fintoc-legacy-iframe-id'
            var waitIframe = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            waitIframe.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("fintoc-legacy-iframe-id")));

            // cambiar a iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("fintoc-legacy-iframe-id")));

            var input = driver.FindElement(By.XPath($"//input[@name='{atributo}']"));
            ScrollUtil.ScrollIntoView(driver, input);
            input.SendKeys(texto);

            driver.SwitchTo().DefaultContent();
        }

        public static void ClickEnBotonQueContengaTexto(ChromeDriver driver, string texto)
        {
            // esperar que aparezca el iframe con id 'fintoc-legacy-iframe-id'
            var waitIframe = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            waitIframe.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("fintoc-legacy-iframe-id")));

            // cambiar a iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("fintoc-legacy-iframe-id")));

            // encontrar div con la clase font-medium y que contenga el texto.
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='font-medium' and contains(text(),'{texto}')]")));
            var boton = driver.FindElement(By.XPath($"//div[@class='font-medium' and contains(text(),'{texto}')]"));
            
            ScrollUtil.ScrollIntoView(driver, boton);
            boton.Click();

            // cambiar driver al default
            driver.SwitchTo().DefaultContent();
        }

        public static void EvaluarProcesoPago(ChromeDriver driver)
        {
            // esperar que aparezca el iframe con id 'fintoc-legacy-iframe-id'
            var waitIframe = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            waitIframe.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("fintoc-legacy-iframe-id")));

            // cambiar a iframe
            driver.SwitchTo().Frame(driver.FindElement(By.Id("fintoc-legacy-iframe-id")));

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-test='auth-action-text']")));

                var div = driver.FindElement(By.XPath("//div[@data-test='auth-action-text']"));
                var texto = div.Text;

                if (texto.Contains("Ingresa las coordenadas de tu Tarjeta de Coordenadas"))
                {
                    var inputA = driver.FindElement(By.XPath("//input[@type='tel' and @data-index='0']"));
                    inputA.SendKeys("00");

                    var inputB = driver.FindElement(By.XPath("//input[@type='tel' and @data-index='1']"));
                    inputB.SendKeys("00");

                    var inputC = driver.FindElement(By.XPath("//input[@type='tel' and @data-index='2']"));
                    inputC.SendKeys("00");

                    driver.SwitchTo().DefaultContent();
                    ClickEnBotonQueContengaTexto(driver, " Suscribir ");
                }

                if(texto.Contains("Ingresa el código que genera tu"))
                {
                    var inputFk1 = driver.FindElement(By.Id("fk_1"));
                    inputFk1.SendKeys("0");
                    Thread.Sleep(500);

                    var inputFk2 = driver.FindElement(By.Id("fk_2"));
                    inputFk1.SendKeys("0");
                    Thread.Sleep(500);

                    var inputFk3 = driver.FindElement(By.Id("fk_3"));
                    inputFk3.SendKeys("0");
                    Thread.Sleep(500);

                    var inputFk4 = driver.FindElement(By.Id("fk_4"));
                    inputFk4.SendKeys("0");
                    Thread.Sleep(500);

                    var inputFk5 = driver.FindElement(By.Id("fk_5"));
                    inputFk5.SendKeys("0");
                    Thread.Sleep(500);

                    var inputFk6 = driver.FindElement(By.Id("fk_6"));
                    inputFk6.SendKeys("0");

                    driver.SwitchTo().DefaultContent();
                    ClickEnBotonQueContengaTexto(driver, " Suscribir ");
                }
            }
            catch
            {
                driver.SwitchTo().DefaultContent();
            }
            

            
           
        }
    }
}
