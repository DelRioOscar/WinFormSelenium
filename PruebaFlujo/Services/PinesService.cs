using Newtonsoft.Json;
using PruebaFlujo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFlujo.Services
{
    public static class PinesService
    {
        private static string _url = "https://apidescuentosespeciales.qa.bciseguros.cl";
        public static string CrearPin(PinRequest pinRequest)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(pinRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync($"{_url}/api/v1/Pines/CrearPin", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var pinResponse = JsonConvert.DeserializeObject<PinResponse>(responseContent);
                return pinResponse.Pin.FirstOrDefault().Nropin;
            }
            else
            {
                return string.Empty;
            }

        }
    }
}
