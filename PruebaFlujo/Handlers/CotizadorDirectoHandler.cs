using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaFlujo.Models;
using PruebaFlujo.Utils;
using System.Diagnostics;

namespace PruebaFlujo.Handlers
{
    public class CotizadorDirectoHandler
    {
        private readonly bool _abrirNavegador;
        private readonly bool _sacarCaptura;
        private readonly bool _crearDocumentoWord;

        public CotizadorDirectoHandler(bool abrirNavegador, bool sacarCaptura)
        {
            _abrirNavegador = abrirNavegador;
            _sacarCaptura = sacarCaptura;
        }
        public void IniciarCuota(string url, string tipoCuota, bool esNuevo)
        {
            var parametroPrueba = new ParametroPrueba();
            var screenshotModel = new ScreenshotModel(parametroPrueba);

            screenshotModel.NombreCarpeta = "Cotizador Directo";
            screenshotModel.TipoCuota = tipoCuota;
            screenshotModel.EstadoAuto = esNuevo ? "Nuevo" : "Usado";

            Console.WriteLine("Iniciando Cuota Normal");
            var navegador = new NavegatorUtil(url, _abrirNavegador);
            var driver = navegador.IniciarNavegadorChrome();


            LoaderUtil.EsperarLoader(driver);

            if (esNuevo)
            {
                HyperlinkUtil.ClickEnHyperlink(driver, " Nuevo ");
            }

            if (!esNuevo)
            {
                InputUtil.IngresarTextoEnInput(driver, "patente", "xhbn22");
            }

            MultiSelectUtil.SeleccionarOpcionAlAzar(driver, "Selecciona Marca");
            MultiSelectUtil.SeleccionarOpcionAlAzar(driver, "Selecciona Modelo");
            SelectUtil.SeleccionarSelectAlAzar(driver, "Año");
            InputUtil.IngresarTextoEnInput(driver, "rut", "187334934");
            InputUtil.IngresarTextoEnInput(driver, "celular", "99999999");
            InputUtil.IngresarTextoEnInput(driver, "correo", "odelrio@acl.cl");

            SacarCapturaPantalla(driver, screenshotModel);

            ButtonUtil.ClickEnHipervinculo(driver, "Cotizar");
            LoaderUtil.EsperarLoader(driver);
            var salioModalError = ModalUtil.EsperarQueAparezcaModal(driver, sec: 1);
            if (salioModalError)
            {
                SacarCapturaPantalla(driver, screenshotModel);
                navegador.CerrarNavegador();
                IniciarCuota(url, tipoCuota, esNuevo);
            }

            SelectorUtil.SeleccionarDeducibleAlAzar(driver);
            CardUtil.SeleccionarPlan(driver);
            LoaderUtil.EsperarLoader(driver);

            MultiSelectUtil.SeleccionarOpcionAlAzar(driver, "Selecciona región");
            MultiSelectUtil.SeleccionarOpcionAlAzar(driver, "Selecciona comuna");
            InputUtil.IngresarTextoEnInput(driver, "calle", "Manuel Rodriguez 123");
            InputUtil.IngresarTextoEnInput(driver, "celular", "99999999");
            InputUtil.IngresarTextoEnInput(driver, "correo", "odelrio@acl.cl");


            if (esNuevo)
            {
                InputUtil.IngresarTextoEnInput(driver, "patente", "bxbx90");
                InputUtil.SeleccionarInputFile(driver, "factura", "test.pdf");
            }

            InputUtil.IngresarTextoEnInput(driver, "chasis", "395093NFMNFN09509");
            InputUtil.IngresarTextoEnInput(driver, "motor", "395093NFMNFN09509");
            SacarCapturaPantalla(driver, screenshotModel);

            ButtonUtil.ClickEnHipervinculo(driver, "Continuar");

            LoaderUtil.EsperarLoader(driver);
            SacarCapturaPantalla(driver, screenshotModel);

            // Acceder a la carpeta de descargas.
            string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            // obtener el ultimo archivo descargado por fecha reciente.
            var archivo = Directory.GetFiles(rutaDescargas).OrderByDescending(f => new FileInfo(f).LastWriteTime).First();

            // abrir el archivo descargado con un navegador de archivos.
            Process.Start("chrome.exe", archivo);


            ButtonUtil.ClickEnHipervinculo(driver, "Suscribir medio de pago");

            LoaderUtil.EsperarLoader(driver);


            PasarelaUtil.SeleccionarTipoPago(driver, parametroPrueba.TipoTarjeta);
            SacarCapturaPantalla(driver, screenshotModel);
            PasarelaUtil.SeleccionarPasarela(driver, parametroPrueba.Pasarela);
            SacarCapturaPantalla(driver, screenshotModel);

            PasarelaUtil.AceptarTerminos(driver);
            SacarCapturaPantalla(driver, screenshotModel);
            Thread.Sleep(1000);
            PasarelaUtil.ClickEnBotonContinuar(driver);
            SacarCapturaPantalla(driver, screenshotModel);
            Thread.Sleep(1000);
            PasarelaUtil.ClickEnBotonContinuarEnElModal(driver);

            if (parametroPrueba.Pasarela == "Klap Débito")
            {
                KlapDebito(driver, screenshotModel);
            }
            if (parametroPrueba.Pasarela == "Klap Crédito")
            {
                KlapCredito(driver, screenshotModel);
            }
            else if (parametroPrueba.Pasarela == "PatPass")
            {
                PatPass(driver, screenshotModel);
            }
            else if (parametroPrueba.Pasarela == "Mercado Pago Débito")
            {
                MercadoPagoDebito(driver);
            }
            else if (parametroPrueba.Pasarela == "Mercado Pago Crédito")
            {
                MercadoPagoCredito(driver);
            }
            else if (parametroPrueba.Pasarela == "Fintoc")
            {
                Fintoc(driver, screenshotModel);
            }

            SacarCapturaPantalla(driver, screenshotModel);
            ModalUtil.EsperarContenidoModalGps(driver);
            SacarCapturaPantalla(driver, screenshotModel);
            ModalUtil.CerrarModalGPS(driver);
            WaitUntil.EsperarHastaQueAparezcaH1ConTexto(driver, "¡Tu auto está asegurado!");
            SacarCapturaPantalla(driver, screenshotModel);
            navegador.CerrarNavegador();
        }

        private void Fintoc(ChromeDriver driver, ScreenshotModel screenshotModel)
        {
            FintocUtil.ClickEnBotonQueContengaTexto(driver, " Continuar ");
            SacarCapturaPantalla(driver, screenshotModel);
            FintocUtil.SeleccionarBanco(driver, "BCI");
            SacarCapturaPantalla(driver, screenshotModel);
            FintocUtil.IngresarTextoInput(driver, "username", "415792638");
            FintocUtil.IngresarTextoInput(driver, "password", "jonsnow");
            SacarCapturaPantalla(driver, screenshotModel);
            FintocUtil.ClickEnBotonQueContengaTexto(driver, " Continuar ");
            FintocUtil.ClickEnBotonQueContengaTexto(driver, " Suscribir ");
            FintocUtil.EvaluarProcesoPago(driver);

        }

        private void KlapDebito(ChromeDriver driver, ScreenshotModel screenshotModel)
        {
            KlapUtil.EsperarInput(driver, "numeroTarjeta");
            KlapUtil.SeleccionarTipoTarjeta(driver, "Débito");
            KlapUtil.IngresarTexto(driver, "numeroTarjetaDebito", "4900060083612025");
            KlapUtil.IngresarTexto(driver, "fechaExpiracionDebito", "1231");
            KlapUtil.IngresarTexto(driver, "cvvDebito", "123");
            SacarCapturaPantalla(driver, screenshotModel);
            KlapUtil.ClickEnBotonPagar(driver);
        }

        private void KlapCredito(ChromeDriver driver, ScreenshotModel screenshotModel)
        {
            KlapUtil.EsperarInput(driver, "numeroTarjeta");
            KlapUtil.SeleccionarTipoTarjeta(driver, "Crédito");
            KlapUtil.IngresarTexto(driver, "numeroTarjeta", "4900060083612025");
            KlapUtil.IngresarTexto(driver, "fechaExpiracion", "1231");
            KlapUtil.IngresarTexto(driver, "cvv", "123");
            SacarCapturaPantalla(driver, screenshotModel);
            KlapUtil.ClickEnBotonPagar(driver);
        }

        private void PatPass(ChromeDriver driver, ScreenshotModel screenshotModel)
        {
            WaitUntil.EsperarHastaElementoVisible(driver, "formulario:tarjeta_th");

            InputUtil.LimpiarInput(driver, "formulario:nombre_th");
            InputUtil.IngresarTextoEnInput(driver, "formulario:nombre_th", "Oscar Ignacio");

            InputUtil.LimpiarInput(driver, "formulario:paterno_th");
            InputUtil.IngresarTextoEnInput(driver, "formulario:paterno_th", "Del Rio");

            InputUtil.LimpiarInput(driver, "formulario:materno_th");
            InputUtil.IngresarTextoEnInput(driver, "formulario:materno_th", "Pindal");

            PatPassUtil.EscribirTarjeta(driver, "formulario:tarjeta_th", "4051885600446623");
            SelectUtil.SeleccionarSelectNativo(driver, "formulario:ciudadesCombo", "OSORNO");
            SacarCapturaPantalla(driver, screenshotModel);

            ButtonUtil.ClickInputBtnPorId(driver, "formulario:gotoWebPay");

            var form = TransbankUtil.EncontrarFormulario(driver);
            TransbankUtil.IngresarTexto(form, "rutClient", "111111111");
            TransbankUtil.IngresarTexto(form, "passwordClient", "123");
            SacarCapturaPantalla(driver, screenshotModel);
            SendKeys.SendWait("{Enter}");

            TransbankUtil.ClickEnBotonContinuar(driver);
            SacarCapturaPantalla(driver, screenshotModel);

            PatPassUtil.CheckCheckboxPorName(driver, "formulario:j_id128");
            SacarCapturaPantalla(driver, screenshotModel);
            ButtonUtil.ClickInputBtnPorId(driver, "formulario:suscribirStep3");
            SacarCapturaPantalla(driver, screenshotModel);
            ButtonUtil.ClickInputBtnPorId(driver, "formulario:continuarStep3");
        }

        private void MercadoPagoDebito(ChromeDriver driver)
        {
            DivUtil.SeleccionarElementoConTexto(driver, "Tarjeta de débito");
            MercadoPagoUtil.EscribirTextoDentroIFrame(driver, "cardNumber", "5241019826646950");
            MercadoPagoUtil.EscribirTextoDentroIFrame(driver, "expirationDate", "1125");
            MercadoPagoUtil.EscribirTextoDentroIFrame(driver, "securityCode", "123");
            MercadoPagoUtil.EscribirTexto(driver, "HOLDER_NAME", "OSCAR IGNACIO DEL RIO PINDAL");
            MercadoPagoUtil.EscribirTexto(driver, "DOCUMENT", "187334934");
            MercadoPagoUtil.ClickEnPagar(driver);
        }

        private void MercadoPagoCredito(ChromeDriver driver)
        {
            DivUtil.SeleccionarElementoConTexto(driver, "Tarjeta de crédito");
            MercadoPagoUtil.EscribirTextoDentroIFrame(driver, "cardNumber", "5416752602582580");
            MercadoPagoUtil.EscribirTextoDentroIFrame(driver, "expirationDate", "1125");
            MercadoPagoUtil.EscribirTextoDentroIFrame(driver, "securityCode", "123");
            MercadoPagoUtil.EscribirTexto(driver, "HOLDER_NAME", "OSCAR IGNACIO DEL RIO PINDAL");
            MercadoPagoUtil.EscribirTexto(driver, "DOCUMENT", "187334934");
            MercadoPagoUtil.ClickEnPagar(driver);
        }

        private string SacarCapturaPantalla(ChromeDriver driver, ScreenshotModel screenshotModel)
        {
            if (_sacarCaptura)
            {
                return ScreenshotUtil.SacarCapturaPantalla(driver, screenshotModel, _abrirNavegador);
            }
            return null;
        }
    }
}
