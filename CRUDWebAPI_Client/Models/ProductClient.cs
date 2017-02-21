using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CRUDWebAPI_Client.Models
{
    public class ProductClient
    {
        private string BASE_URL = "http://localhost:63027/api/";

        public IEnumerable<Product> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("product").Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                }
                return null;

            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}