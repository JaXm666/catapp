using System.Diagnostics;
using System.Text.Json;

namespace KL.CatAPI
{
    public class CatAPI
    {
        public static string GetSomeString()
        {
            return "Some other string instead";
        }

        public static async Task<CatPicture?> GetRandomCatPicture()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", "live_3HOkiXvCClmFdXLdYonURTrPldXXYBoucwp9YkuaboILKA47KRwUO7aH9dtssnfo");

            var response = await client.GetAsync("https://api.thecatapi.com/v1/images/search");
            var s = await response.Content.ReadAsStringAsync();
            try
            {          
                var kittyPics = JsonSerializer.Deserialize<CatPicture[]>(s);
                if (kittyPics != null && kittyPics.Length > 0)
                {
                    return kittyPics[0];
                }

                return null; 
            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }

        }
    }
}