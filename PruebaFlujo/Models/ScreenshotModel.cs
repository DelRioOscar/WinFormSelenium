using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Models
{
    public class ScreenshotModel
    {
        public string NombreCarpeta { get; set; }
        public string TipoCuota { get; set; }
        public string EstadoAuto { get; set; }
        public string TipoTarjeta { get; }
        public string Pasarela { get; }
        public string Plan { get; }
        public DateTime FechaCaptura { get; set; }

        public ScreenshotModel()
        {
            
        }
        public ScreenshotModel(ParametroPrueba parametroPrueba)
        {
            FechaCaptura = DateTime.Now;
            TipoTarjeta = parametroPrueba.TipoTarjeta;
            Pasarela = parametroPrueba.Pasarela;
            Plan = parametroPrueba.Plan;
        }
    }
}
