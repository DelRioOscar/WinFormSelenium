using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Models
{
    public class Pin
    {
        public int IdPin { get; set; }
        public DateTime Fechacreacion { get; set; }
        public object Fechautilizacion { get; set; }
        public object Nropoliza { get; set; }
        public object Nrocotizacion { get; set; }
        public int Descuento { get; set; }
        public int IdUsuarioCotizador { get; set; }
        public int Estado { get; set; }
        public int IdBolsaDistribucionPines { get; set; }
        public string Nropin { get; set; }
        public object Descuentoutilizado { get; set; }
        public object Email { get; set; }
        public double Rut { get; set; }
        public string DvRut { get; set; }
        public double IdTipoPin { get; set; }
    }

    public class PinResponse
    {
        public List<Pin> Pin { get; set; }
        public bool Estado { get; set; }
        public string Mensaje { get; set; }
    }

}
