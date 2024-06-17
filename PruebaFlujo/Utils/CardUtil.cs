using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaFlujo.Models;

namespace PruebaFlujo.Utils
{
    public static class CardUtil
    {
        public static void SeleccionarPlan(ChromeDriver driver)
        {
            // acceder al padre de la etiqueta div con clase 'bloque-planes'.
            var div = driver.FindElement(By.XPath("//div[@class='bloque-planes pb-4']/parent::div/parent::div"));

            // contar cuantos hijos tiene el div.
            var hijos = div.FindElements(By.XPath("./*"));

            // seleccionar un hijo al azar.
            var random = new Random();
            var hijo = hijos[random.Next(hijos.Count)];

            // acceder al hijo seleccionado y encontrar la etiqueta a con el texto 'Quiero Contratar'.
            var card = hijo.FindElement(By.XPath(".//a[text()='Quiero Contratar']"));

            // hacer scroll hasta la tarjeta.
            ScrollUtil.ScrollIntoView(driver, card);
            Thread.Sleep(1000);

            // hacer click en la tarjeta.
            card.Click();
        }
    }
}
