using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApplication5.Modelos;
using WebApplication5.Repositorios;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ValuesController()
        {
            _httpClient = new System.Net.Http.HttpClient();
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetAsync(String municipio)
        
        {
            RPMunicipio rpMuni = new RPMunicipio();
            var idConcello = rpMuni.ObtenerMunicipio(municipio).Id;
            
            RPSituacion rpSitu = new RPSituacion();

            var response = await _httpClient.GetAsync($"https://servizos.meteogalicia.gal/rss/predicion/jsonPredConcellos.action?idConc=" + idConcello);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();

            // Convertir la respuesta JSON en un objeto de JObject
            var prediccion = Newtonsoft.Json.Linq.JObject.Parse(responseContent);

            // Obtener los datos necesarios de la predicción para el día actual y los dos siguientes
            var datos = new List<object>();
            for (var i = 0; i < 3; i++)
            {
                var fechaStringMal = prediccion["predConcello"]["listaPredDiaConcello"][i]["dataPredicion"].Value<String>();

                DateTime fecha = DateTime.ParseExact(fechaStringMal, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                string fechaString = fecha.ToString("dd/MM/yyyy");

                var ceo_manha = prediccion["predConcello"]["listaPredDiaConcello"][i]["ceo"]["manha"].Value<int>();
                var ceo_tarde = prediccion["predConcello"]["listaPredDiaConcello"][i]["ceo"]["tarde"].Value<int>();
                var ceo_noite = prediccion["predConcello"]["listaPredDiaConcello"][i]["ceo"]["noite"].Value<int>();

                var lluvia_manha = prediccion["predConcello"]["listaPredDiaConcello"][i]["ceo"]["manha"];
                var lluvia_tarde = prediccion["predConcello"]["listaPredDiaConcello"][i]["ceo"]["tarde"];
                var lluvia_noite = prediccion["predConcello"]["listaPredDiaConcello"][i]["ceo"]["noite"];

                var situacion_manha = rpSitu.ObtenerSituacion(ceo_manha).Nombre;
                var situacion_tarde = rpSitu.ObtenerSituacion(ceo_tarde).Nombre;
                var situacion_noite = rpSitu.ObtenerSituacion(ceo_noite).Nombre;

                var tMax = prediccion["predConcello"]["listaPredDiaConcello"][i]["tMax"].Value<int>();
                var tMin = prediccion["predConcello"]["listaPredDiaConcello"][i]["tMin"].Value<int>();

                // Añadir los datos a la lista
                datos.Add(new
                {
                    fechaString,
                    ceo_manha,
                    ceo_tarde,
                    ceo_noite,
                    situacion_manha,
                    situacion_tarde,
                    situacion_noite,
                    lluvia_manha,
                    lluvia_tarde,
                    lluvia_noite,
                    tMax,
                    tMin
                });
            }

            // Devolver los datos como JSON
            return Ok(datos);
        }
    }


}
