using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResenaApp.ModelsUpdate
{
    public class Juego
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty ("nombre")]
        public string nombre { get; set; }

        [JsonProperty ("descripcion")]
        public string descripcion { get; set; }

        [JsonProperty ("fechaCreacion")]
        public string fechaCreacion { get; set; }

        [JsonProperty("urlImagen")]
        public string urlImagen { get; set; }

        [JsonProperty("categoriaId")]
        public int categoriaId { get; set; }

        [JsonProperty("categoria")]
        public object categoria { get; set; }


        public List<object> resenas { get; set; }
    }
}
