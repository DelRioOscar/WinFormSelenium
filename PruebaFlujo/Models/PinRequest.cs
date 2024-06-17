using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Models
{
    public class PinRequest
    {
        public int Descuento { get; set; }
        public int IdUsuarioCotizador { get; set; }
        public int IdBolsaDistribucionPines { get; set; }
        public int Rut { get; set; }
        public string DvRut { get; set; }
        public int IdTipoPin { get; set; }
        public int IdConvenio { get; set; }

        public PinRequest(int idConvenio)
        {
            Descuento = 25;
            IdUsuarioCotizador = 1;
            IdBolsaDistribucionPines = 20;
            Rut = 17552386;
            DvRut = "3";
            IdTipoPin = 1;
            IdConvenio = idConvenio;
        }
    }
}
