using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication5.Modelos;

namespace WebApplication5.Repositorios
{
    public class RPSituacion
    {
        public static List<Situacion> _listaSituacion = new List<Situacion>()
        {
            new Situacion() { Id = -9999, Nombre = "No disponible" },
            new Situacion() { Id = 101, Nombre = "Despejado" },
            new Situacion() { Id = 102, Nombre = "Nubes altas" },
            new Situacion() { Id = 103, Nombre = "Nubes y claros" },
            new Situacion() { Id = 104, Nombre = "Nublado 75%" },
            new Situacion() { Id = 105, Nombre = "Cubierto" },
            new Situacion() { Id = 106, Nombre = "Nieblas" },
            new Situacion() { Id = 107, Nombre = "Chubasco" },
            new Situacion() { Id = 108, Nombre = "Chubasco (75%)" },
            new Situacion() { Id = 109, Nombre = "Chuvasco nieve" },
            new Situacion() { Id = 110, Nombre = "LLovizna" },
            new Situacion() { Id = 111, Nombre = "LLuvia" },
            new Situacion() { Id = 112, Nombre = "Nieve" },
            new Situacion() { Id = 113, Nombre = "Tormenta" },
            new Situacion() { Id = 114, Nombre = "Bruma" },
            new Situacion() { Id = 115, Nombre = "Bancos de niebla" },
            new Situacion() { Id = 116, Nombre = "Nuves medias" },
            new Situacion() { Id = 117, Nombre = "Lluvia débil" },
            new Situacion() { Id = 118, Nombre = "Chubascos débiles" },
            new Situacion() { Id = 119, Nombre = "Tormenta con pocas nubes" },
            new Situacion() { Id = 120, Nombre = "Agua nieve" },
            new Situacion() { Id = 121, Nombre = "Granizo" },

            new Situacion() { Id = 201, Nombre = "Despejado" },
            new Situacion() { Id = 202, Nombre = "Nubes altas" },
            new Situacion() { Id = 203, Nombre = "Nubes y claros" },
            new Situacion() { Id = 204, Nombre = "Nublado 75%" },
            new Situacion() { Id = 205, Nombre = "Cubierto" },
            new Situacion() { Id = 206, Nombre = "Nieblas" },
            new Situacion() { Id = 207, Nombre = "Chubasco" },
            new Situacion() { Id = 208, Nombre = "Chubasco (75%)" },
            new Situacion() { Id = 209, Nombre = "Chuvasco nieve" },
            new Situacion() { Id = 210, Nombre = "LLovizna" },
            new Situacion() { Id = 211, Nombre = "LLuvia" },
            new Situacion() { Id = 212, Nombre = "Nieve" },
            new Situacion() { Id = 213, Nombre = "Tormenta" },
            new Situacion() { Id = 214, Nombre = "Bruma" },
            new Situacion() { Id = 215, Nombre = "Bancos de niebla" },
            new Situacion() { Id = 216, Nombre = "Nuves medias" },
            new Situacion() { Id = 217, Nombre = "Lluvia débil" },
            new Situacion() { Id = 218, Nombre = "Chubascos débiles" },
            new Situacion() { Id = 219, Nombre = "Tormenta con pocas nubes" },
            new Situacion() { Id = 220, Nombre = "Agua nieve" },
            new Situacion() { Id = 221, Nombre = "Granizo" },

            
        };

        public IEnumerable<Situacion> ObtenerSituacion()
        {
            return _listaSituacion;
        }

        public Situacion ObtenerSituacion(int id)
        {
            var Situacion = _listaSituacion.Where(cli => cli.Id == id);

            return Situacion.FirstOrDefault();
        }

    }
}
