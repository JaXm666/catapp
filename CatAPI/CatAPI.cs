namespace KL.CatAPI
{
    public class CatAPI
    {
        public static string GetSomeString()
        {
            return "Some other string instead";
        }

        public static async Task<HttpResponseMessage> GetRandomCatPicture()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", "live_3HOkiXvCClmFdXLdYonURTrPldXXYBoucwp9YkuaboILKA47KRwUO7aH9dtssnfo");
            return await client.GetAsync("https://api.thecatapi.com/v1/images/search");
        }
    }
}