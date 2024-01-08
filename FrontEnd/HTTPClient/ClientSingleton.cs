using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.HTTPClient
{
    public class ClientSingleton
    {
        private static ClientSingleton instance;
        private HttpClient client;

        private ClientSingleton()
        {
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instance == null)
            {

                instance = new ClientSingleton();

            }
            return instance;
        }
        public async Task<HttpResponse> GetAsync(string url)
        {
            try
            {
                var result = await client.GetAsync(url);
                var content = "";


                if (result.IsSuccessStatusCode)
                {

                    content = await result.Content.ReadAsStringAsync();
                }
                return new HttpResponse(result.StatusCode, content, result.IsSuccessStatusCode);
            }
            catch (Exception ex)
            {

                return new HttpResponse(System.Net.HttpStatusCode.BadRequest, ex.Message, false);
            }
           
            
        }

        public async Task<HttpResponse> PostAsync(string url, string data)
        {


            try
            {
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                var reply = "A server error occurred";

                if (result.IsSuccessStatusCode)
                {

                    reply = await result.Content.ReadAsStringAsync();
                }
                return new HttpResponse(result.StatusCode, reply, result.IsSuccessStatusCode);
            }
            catch (Exception ex)
            {

                return new HttpResponse(System.Net.HttpStatusCode.BadRequest, ex.Message, false);
            }


            //
        }
        public async Task<HttpResponse> PutAsync(string url, string data)
        {
            try
            {
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PutAsync(url, content);
                var reply = "An error occurred on the server";

                if (result.IsSuccessStatusCode)
                {
                    reply = await result.Content.ReadAsStringAsync();
                }
                return new HttpResponse(result.StatusCode, reply, result.IsSuccessStatusCode);
            }
            catch (Exception ex)
            {
                return new HttpResponse(System.Net.HttpStatusCode.BadRequest, ex.Message, false);
            }
        }

        public async Task<HttpResponse> DeleteAsync(string url)
        {
            try
            {
                var result = await client.DeleteAsync(url);

                if (result.IsSuccessStatusCode)
                {
                    var reply = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"Operation successful: {reply}");
                    return new HttpResponse(result.StatusCode, reply, true);
                }
                else
                {
                    var errorResponse = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"Server error: {result.StatusCode}\n{errorResponse}");
                    return new HttpResponse(result.StatusCode, errorResponse, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
                return new HttpResponse(System.Net.HttpStatusCode.BadRequest, ex.Message, false);
            }
        }
    }
}
