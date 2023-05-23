using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonConvert2Core.Contracts.Services;
using JsonConvert2Core.Entities;

namespace JsonConvert2Infrastructure.Services
{
    public class ProductService : IProductService
    {

        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<Root> GetProducts()
        {
            using (var client = _httpClient)
            {
                client.BaseAddress = new Uri("https://dummyjson.com/");
                var responseTask = await client.GetAsync("products");
                Root myDeserializedClass = JsonSerializer.Deserialize<Root>(await responseTask.Content.ReadAsStringAsync());
           
                return myDeserializedClass;

            }
        }
    }
}
