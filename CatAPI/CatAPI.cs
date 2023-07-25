using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace KL.CatAPI
{
    public class CatAPIService
    {
        private readonly HttpClient client;

        public CatAPIService(string apiKey)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);
        }

        public async Task<CatPicture?> GetRandomCatPicture()
        {
            var response = await client.GetAsync("https://api.thecatapi.com/v1/images/search");
            var responseString = await response.Content.ReadAsStringAsync();

            try
            {          
                var kittyPics = JsonSerializer.Deserialize<CatPicture[]>(responseString);
                if (kittyPics == null || kittyPics.Length == 0)
                {
                    return null; 
                }

                return kittyPics[0];
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }

        }
    }
}