using System.Text.Json.Serialization;

namespace KL.CatAPI
{
    public class CatPicture
    {
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
