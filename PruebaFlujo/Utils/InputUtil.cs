using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PruebaFlujo.Utils
{
    public static class InputUtil
    {
        public static void IngresarTextoEnInput(ChromeDriver driver, string id, string textoAIngresar)
        {
            Thread.Sleep(500);
            var input = driver.FindElement(By.Id(id));
            input.SendKeys(textoAIngresar);
            ScrollUtil.ScrollIntoView(driver, input);
            Thread.Sleep(100);
        }

        public static void LimpiarInput(ChromeDriver driver, string id)
        {
            Thread.Sleep(200);
            var input = driver.FindElement(By.Id(id));
            input.Clear();
            Thread.Sleep(100);
        }

        public static void SeleccionarInputFile(ChromeDriver driver, string id, string path)
        {
            Thread.Sleep(200);
            var input = driver.FindElement(By.Id(id));

            // ver el padre del input
            var parent = input.FindElement(By.XPath(".."));

            // hermano del parent
            var sibling = parent.FindElement(By.XPath("following-sibling::input"));
            ScrollUtil.ScrollIntoView(driver, input);

            // verificar si existe el archivo test.pdf en la carpeta de descargas.
            string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string nombreArchivo = "test.pdf";

            if (!File.Exists(Path.Combine(rutaDescargas, nombreArchivo)))
            {
                // si no existe, copiar el archivo test.pdf a la carpeta de descargas que se encuentra en el proyecto.
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", nombreArchivo);
                File.Copy(rutaArchivo, Path.Combine(rutaDescargas, nombreArchivo));
            }

            // obtener test.pdf desde la carpeta de descargas.
            var pathDisk = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", path);
            sibling.SendKeys(pathDisk);
                
        }
    }
}
