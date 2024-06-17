using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using PruebaFlujo.Models;
using PruebaFlujo.Utils;

namespace PruebaFlujo.Handlers
{
    public class VentaAsistidaHandler
    {
        private readonly bool _abrirNavegador;
        private readonly bool _sacarCapturaPantalla;
        public VentaAsistidaHandler(bool abrirNavegador, bool sacarCapturaPantalla)
        {
            _abrirNavegador = abrirNavegador;
            _sacarCapturaPantalla = sacarCapturaPantalla;

        }

        public void IniciarCuotaNormal(string url, string tipoCuota, bool esNuevo)
        {
            try
            {
                var screenshotModel = new ScreenshotModel();
                screenshotModel.NombreCarpeta = "Venta Asistida";
                screenshotModel.TipoCuota = tipoCuota;
                screenshotModel.EstadoAuto = esNuevo ? "Nuevo" : "Usado";

                var navegador = new NavegatorUtil(url, _abrirNavegador);
                var driver = navegador.IniciarNavegadorChrome();

                #region primera_pantalla
                //ModalUtil.EsperarQueAparezcaModal(driver);
                WaitUntil.EsperarHastaElementoVisible(driver, "celular");
                InputUtil.IngresarTextoEnInput(driver, "celular", "99999999");
                InputUtil.IngresarTextoEnInput(driver, "email", "odelrio@acl.cl");
                SacarCapturaPantalla(driver, screenshotModel);
                ButtonUtil.ClickContinuar(driver);
                #endregion

                #region segunda_pantalla
                ModalUtil.EsperarQueAparezcaModal(driver);
                ModalUtil.HastaQueDesaparezcaModal(driver);
                MultiSelectUtil.SeleccionarOpcionConLabel(driver, "Marca", "Chevrolet");
                MultiSelectUtil.SeleccionarOpcionConLabel(driver, "Modelo", "Corsa");
                MultiSelectUtil.SeleccionarOpcionConLabel(driver, "Año", "2023");
                SacarCapturaPantalla(driver, screenshotModel);
                ButtonUtil.ClickContinuar(driver);
                #endregion

                #region tercera_pantalla
                WaitUntil.EsperarHastaQueAparezcaDeducible(driver, "5");
                SelectorUtil.SeleccionarDeducible(driver, "5");
                SacarCapturaPantalla(driver, screenshotModel);
                SelectorUtil.SeleccionarPrecio(driver);
                #endregion

                #region cuarta_pantalla
                WaitUntil.EsperarHastaElementoVisible(driver, "rut");
                CheckboxUtil.ClickEnCheckbox(driver, "Usar los datos del asegurado");
                InputUtil.IngresarTextoEnInput(driver, "direccion", "Manuel Rodriguez");
                InputUtil.IngresarTextoEnInput(driver, "numeroCasa", "123");
                MultiSelectUtil.SeleccionarOpcionConLabel(driver, "Región", "Metropolitana");
                MultiSelectUtil.SeleccionarOpcionConLabel(driver, "Comuna", "Macul");
                InputUtil.IngresarTextoEnInput(driver, "motor", "395093NFMNFN09509");
                InputUtil.IngresarTextoEnInput(driver, "chasis", "395093NFMNFN09509");
                InputUtil.IngresarTextoEnInput(driver, "kilometraje", "100");
                SelectUtil.SeleccionarSelect(driver, "Forma de pago", "Suscripción");
                SacarCapturaPantalla(driver, screenshotModel);
                ButtonUtil.ClickEnHipervinculo(driver, "Emitir propuesta");
                #endregion

                #region quinta_pantalla
                //ModalUtil.EsperarQueAparezcaModal(driver);
                ModalUtil.HastaQueDesaparezcaModal(driver);
                CheckboxUtil.ClickEnCheckbox(driver, "Robo contenido vehículo");
                SacarCapturaPantalla(driver, screenshotModel);
                ButtonUtil.ClickEnHipervinculo(driver, "Enviar link de pago");
                #endregion

                #region sexta_pantalla
                //ModalUtil.EsperarQueAparezcaModal(driver);
                ModalUtil.HastaQueDesaparezcaModal(driver);
                SacarCapturaPantalla(driver, screenshotModel);
                #endregion
            }
            catch
            {
                MessageBox.Show("Error en la ejecución de la prueba");
            }
        }

        private void SacarCapturaPantalla(ChromeDriver driver, ScreenshotModel screenshotModel)
        {
            if(_sacarCapturaPantalla)
            {
                ScreenshotUtil.SacarCapturaPantalla(driver, screenshotModel, _abrirNavegador);
            }
        }
    }
}
