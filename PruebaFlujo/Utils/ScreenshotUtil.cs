using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Text.RegularExpressions;
using PruebaFlujo.Models;
using System.Drawing.Imaging;

namespace PruebaFlujo.Utils
{
    public static class ScreenshotUtil
    {
        public static string SacarCapturaPantalla(ChromeDriver driver, ScreenshotModel model, bool navegadorAbierto)
        {
            return SacarCapturaPantallaNativo(model);
            //if (navegadorAbierto)
            //{
            //    return SacarCapturaConNavegadorAbierto(driver, model);
            //}
            //else
            //{
            //    return SacarCapturaConNavegadorCerrado(driver, model);
            //}

        }
        private static string SacarCapturaConNavegadorCerrado(ChromeDriver driver, ScreenshotModel model)
        {
            //long scrollHeight = Convert.ToInt64(((IJavaScriptExecutor)driver).ExecuteScript("return document.body.scrollHeight"));
            //long totalHeight = scrollHeight;

            //if(totalHeight < 1080)
            //{
            //    totalHeight = 1080;
            //}

            //driver.Manage().Window.Size = new Size(1920, (int)totalHeight + 50);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            var subFolder = ObtenerNombreCarpeta(model);
            var folderPath = CrearDirectorio(model.NombreCarpeta, subFolder);
            var screenshotPath = Path.Combine(folderPath, $"{model.NombreCarpeta}_{model.TipoCuota}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            screenshot.SaveAsFile(screenshotPath);
            return screenshotPath;
        }

        private static string SacarCapturaPantallaNativo(ScreenshotModel model)
        {
            var pantalla = Screen.PrimaryScreen.Bounds;
            var bmp = new Bitmap(pantalla.Width, pantalla.Height);
            var g = Graphics.FromImage(bmp);
            g.CopyFromScreen(pantalla.X, pantalla.Y, 0, 0, pantalla.Size);
            var subFolder = ObtenerNombreCarpeta(model);
            var folderPath = CrearDirectorio(model.NombreCarpeta, subFolder);
            var screenshotPath = Path.Combine(folderPath, $"{model.NombreCarpeta}_{model.TipoCuota}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            bmp.Save(screenshotPath, ImageFormat.Png);
            return screenshotPath;
        }

        private static string SacarCapturaConNavegadorAbierto(ChromeDriver driver, ScreenshotModel model)
        {
            // Obtener el tamaño de la página
            int totalWidth = (int)(long)((IJavaScriptExecutor)driver).ExecuteScript("return document.body.scrollWidth");
            int totalHeight = (int)(long)((IJavaScriptExecutor)driver).ExecuteScript("return document.body.scrollHeight");

            // Obtener el tamaño de la ventana
            int viewportWidth = driver.Manage().Window.Size.Width;
            int viewportHeight = driver.Manage().Window.Size.Height;

            // Inicializar una lista para almacenar las capturas de pantalla
            List<Image> images = new List<Image>();

            for (int y = 0; y < totalHeight; y += viewportHeight)
            {
                for (int x = 0; x < totalWidth; x += viewportWidth)
                {
                    // Desplazarse a la posición (x, y)
                    ((IJavaScriptExecutor)driver).ExecuteScript($"window.scrollTo({x}, {y});");
                    Thread.Sleep(500); // Esperar a que el desplazamiento termine

                    // Tomar la captura de pantalla
                    Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                    using (MemoryStream memStream = new MemoryStream(screenshot.AsByteArray))
                    {
                        images.Add(Image.FromStream(memStream));
                    }
                }
            }

            // Crear una imagen grande para la captura de pantalla completa
            Bitmap finalImage = new Bitmap(totalWidth, totalHeight);
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                int offsetX = 0;
                int offsetY = 0;
                foreach (Image img in images)
                {
                    g.DrawImage(img, offsetX, offsetY);
                    offsetX += img.Width;
                    if (offsetX >= totalWidth)
                    {
                        offsetX = 0;
                        offsetY += img.Height;
                    }
                }
            }

            var subFolder = ObtenerNombreCarpeta(model);
            var folderPath = CrearDirectorio(model.NombreCarpeta, subFolder);
            var screenshotPath = Path.Combine(folderPath, $"{model.NombreCarpeta}_{model.TipoCuota}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            finalImage.Save(screenshotPath, ImageFormat.Png);
            return subFolder;
        }

        private static string ObtenerNombreCarpeta(ScreenshotModel model)
        {
            var subFolder = $"{model.EstadoAuto}_{model.TipoCuota}_{model.TipoTarjeta}_{model.Pasarela}_{model.Plan}_{model.FechaCaptura}";
            subFolder = Regex.Replace(subFolder, @"[<>:""/\\|?*]", "");
            subFolder = subFolder.Replace(" ", "_");
            subFolder = subFolder.Replace(",", "");
            subFolder = subFolder.Replace("(", "");
            subFolder = subFolder.Replace(")", "");
            return subFolder;
        }

        private static string CrearDirectorio(string folderName, string subfolderName)
        {
            var mainFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), folderName);
            

            if (!Directory.Exists(mainFolderPath))
            {
                Directory.CreateDirectory(mainFolderPath);
            }

            var subFolderPath = Path.Combine(mainFolderPath, subfolderName);
            if (!Directory.Exists(subFolderPath))
            {
                Directory.CreateDirectory(subFolderPath);
            }

            return subFolderPath;
        }
    }
}
