using CrossCutting.Exceptions;
using System.Net.Http.Json;

namespace CrossCutting.ExternalServices
{
    public class CallApi
    {
        public async Task PostApiAsync<T>(T obj,string endpoint) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
               var response =  await client.PostAsJsonAsync(endpoint,obj);
                if(response.IsSuccessStatusCode)
                {
                    await response.Content.ReadAsStringAsync();
                }
                ExceptionHandler.NotFoundException(await response.Content.ReadAsStringAsync());
                await Task.CompletedTask;
            }
        }
    }
}
