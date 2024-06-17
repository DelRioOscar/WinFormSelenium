
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace PruebaFlujo.Utils
{
    public class NavegatorUtil
    {
        private ChromeDriver _driver;

        private readonly string _url;
        private readonly bool _abrirNavegador;

        public NavegatorUtil(string url, bool abrirNavegador)
        {
            _url = url;
            _abrirNavegador = abrirNavegador;
        }
        public ChromeDriver IniciarNavegadorChrome()
        {
            var options = new ChromeOptions();
            if (!_abrirNavegador)
            {
                MessageBox.Show("Se abrirá el navegador en modo headless");
                options.AddArgument("--headless");
            }

            var driver = new ChromeDriver(options);
            //var networkInterceptor = new NetworkInterceptor();
            //_ = networkInterceptor.LogNetworkRequests(driver, _url);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(_url);
            _driver = driver;
            return driver;
        }

        public void CloseChromeDriverProcess()
        {
            // Buscar todos los procesos con el nombre "chromedriver"
            var chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            // Cerrar cada proceso encontrado
            foreach (var process in chromeDriverProcesses)
            {
                process.Kill();
                process.WaitForExit();
            }
        }

        public void CerrarNavegador()
        {
            try
            {
                _driver.Close();
                CloseChromeDriverProcess();
            }
            catch
            {

            }
            
        }
    }
}
