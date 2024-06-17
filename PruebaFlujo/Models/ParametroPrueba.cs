using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Models
{
    public class ParametroPrueba
    {
        public string TipoTarjeta { get; }
        public string Pasarela { get; }
        public string Plan { get; }

        public ParametroPrueba()
        {
            var configManager = ConfigManager.LoadSettings();

            var tipoSeleccionado = configManager.MedioPago == "Fintoc" ?
                " Pagar con cuenta (corriente) " :
                " Pagar con tarjeta (crédito, débito) ";

            var pasarelaSeleccionada = configManager.MedioPago;

            var planes = new List<string>
            {
                "SEGURO DE AUTO PLAN PRO",
                "SEGURO DE AUTO PLAN ESTÁNDAR",
                "SEGURO DE AUTO PLAN FULL",
                "SEGURO DE AUTO PLAN ESTÁNDAR +"
            };
            var planSeleccionado = planes[new Random().Next(0, planes.Count)];

            TipoTarjeta = tipoSeleccionado;
            Pasarela = pasarelaSeleccionada;
            Plan = planSeleccionado;
        }
    }
}
