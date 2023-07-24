using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KL.CatAPI
{
    public class CatPicture
    {
        //string id { get; set; }
        //string url { get; set; }
        //int width { get; set; }
        //int height { get; set; }
        //bool breeds { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName ("url")]
        public string? Url { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; } 

    }
}
