using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication5.Modelos;

namespace WebApplication5.Repositorios
{
    public class RPMunicipio
    {
        public static List<Municipio> _listaMunicipios = new List<Municipio>()
        {
            new Municipio() { Id = 15001, Nombre = "Abegondo" },
            new Municipio() { Id = 15002, Nombre = "Ames" },
            new Municipio() { Id = 15003, Nombre = "Aranga" },
            new Municipio() { Id = 15004, Nombre = "Ares" },
            new Municipio() { Id = 15005, Nombre = "Arteixo" },
            new Municipio() { Id = 15006, Nombre = "Arzúa" },
            new Municipio() { Id = 15007, Nombre = "A Baña" },
            new Municipio() { Id = 15008, Nombre = "Bergondo" },
            new Municipio() { Id = 15009, Nombre = "Betanzos" },
            new Municipio() { Id = 15010, Nombre = "Boimorto" },
            new Municipio() { Id = 15011, Nombre = "Boiro" },
            new Municipio() { Id = 15012, Nombre = "Boqueixón" },
            new Municipio() { Id = 15013, Nombre = "Brión" },
            new Municipio() { Id = 15014, Nombre = "Cabana de Bergantiños" },
            new Municipio() { Id = 15015, Nombre = "Cabanas" },
            new Municipio() { Id = 15016, Nombre = "Camariñas" },
            new Municipio() { Id = 15017, Nombre = "Cambre" },
            new Municipio() { Id = 15018, Nombre = "A Capela" },
            new Municipio() { Id = 15019, Nombre = "Carballo" },
            new Municipio() { Id = 15901, Nombre = "Cariño" },
            new Municipio() { Id = 15020, Nombre = "Carnota" },
            new Municipio() { Id = 15021, Nombre = "Carral" },
            new Municipio() { Id = 15022, Nombre = "Cedeira" },
            new Municipio() { Id = 15023, Nombre = "Cee" },
            new Municipio() { Id = 15024, Nombre = "Cerceda" },
            new Municipio() { Id = 15025, Nombre = "Cerdido" },
            new Municipio() { Id = 15027, Nombre = "Coirós" },
            new Municipio() { Id = 15028, Nombre = "Corcubión" },
            new Municipio() { Id = 15029, Nombre = "Coristanco" },
            new Municipio() { Id = 15030, Nombre = "A Coruña" },
            new Municipio() { Id = 15031, Nombre = "Culleredo" },
            new Municipio() { Id = 15032, Nombre = "Curtis" },
            new Municipio() { Id = 15033, Nombre = "Dodro" },
            new Municipio() { Id = 15034, Nombre = "Dumbría" },
            new Municipio() { Id = 15035, Nombre = "Fene" },
            new Municipio() { Id = 15036, Nombre = "Ferrol" },
            new Municipio() { Id = 15037, Nombre = "Fisterra" },
            new Municipio() { Id = 15038, Nombre = "Frades" },
            new Municipio() { Id = 15039, Nombre = "Irixoa" },
            new Municipio() { Id = 15041, Nombre = "A Laracha" },
            new Municipio() { Id = 15040, Nombre = "Laxe" },
            new Municipio() { Id = 15042, Nombre = "Lousame" },
            new Municipio() { Id = 15043, Nombre = "Malpica de Bergantiños" },
            new Municipio() { Id = 15044, Nombre = "Mañón" },
            new Municipio() { Id = 15045, Nombre = "Mazaricos" },
            new Municipio() { Id = 15046, Nombre = "Melide" },
            new Municipio() { Id = 15047, Nombre = "Mesía" },
            new Municipio() { Id = 15048, Nombre = "Miño" },
            new Municipio() { Id = 15049, Nombre = "Moeche" },
            new Municipio() { Id = 15050, Nombre = "Monfero" },
            new Municipio() { Id = 15051, Nombre = "Mugardos" },
            new Municipio() { Id = 15053, Nombre = "Muros" },
            new Municipio() { Id = 15052, Nombre = "Muxía" },
            new Municipio() { Id = 15054, Nombre = "Narón" },
            new Municipio() { Id = 15055, Nombre = "Neda" },
            new Municipio() { Id = 15056, Nombre = "Negreira" },
            new Municipio() { Id = 15057, Nombre = "Noia" },
            new Municipio() { Id = 15058, Nombre = "Oleiros" },
            new Municipio() { Id = 15059, Nombre = "Ordes" },
            new Municipio() { Id = 15060, Nombre = "Oroso" },
            new Municipio() { Id = 15061, Nombre = "Ortigueira" },
            new Municipio() { Id = 15062, Nombre = "Outes" },
            new Municipio() { Id = 15902, Nombre = "Oza-Cesuras" },
            new Municipio() { Id = 15064, Nombre = "Paderne" },
            new Municipio() { Id = 15065, Nombre = "Padrón" },
            new Municipio() { Id = 15066, Nombre = "O Pino" },
            new Municipio() { Id = 15067, Nombre = "Pobra do Caramiñal" },
            new Municipio() { Id = 15068, Nombre = "Ponteceso" },
            new Municipio() { Id = 15069, Nombre = "Pontedeume" },
            new Municipio() { Id = 15070, Nombre = "As Pontes de García Rodríguez" },
            new Municipio() { Id = 15071, Nombre = "Porto do Son" },
            new Municipio() { Id = 15072, Nombre = "Rianxo" },
            new Municipio() { Id = 15073, Nombre = "Ribeira" },
            new Municipio() { Id = 15074, Nombre = "Rois" },
            new Municipio() { Id = 15075, Nombre = "Sada" },
            new Municipio() { Id = 15076, Nombre = "San Sadurniño" },
            new Municipio() { Id = 15077, Nombre = "Santa Comba" },
            new Municipio() { Id = 15079, Nombre = "Santiso" },
            new Municipio() { Id = 15080, Nombre = "Sobrado" },
            new Municipio() { Id = 15081, Nombre = "As Somozas" },
            new Municipio() { Id = 15082, Nombre = "Teo" },
            new Municipio() { Id = 15083, Nombre = "Toques" },
            new Municipio() { Id = 15084, Nombre = "Tordoia" },
            new Municipio() { Id = 15085, Nombre = "Touro" },
            new Municipio() { Id = 15086, Nombre = "Trazo" },
            new Municipio() { Id = 15087, Nombre = "Val do Dubra" },
            new Municipio() { Id = 15088, Nombre = "Valdoviño" },
            new Municipio() { Id = 15089, Nombre = "Vedra" },
            new Municipio() { Id = 15090, Nombre = "Vilamaior" },
            new Municipio() { Id = 15091, Nombre = "Vilasantar" },
            new Municipio() { Id = 15092, Nombre = "Vimianzo" },
            new Municipio() { Id = 15093, Nombre = "Zas" },
            

            
        };

        public IEnumerable<Municipio> ObtenerMunicipios()
        {
            return _listaMunicipios;
        }

        public Municipio ObtenerMunicipio(string nombre)
        {
            var Municipio = _listaMunicipios.Where(cli => cli.Nombre == nombre);

            return Municipio.FirstOrDefault();
        }

    }
}
