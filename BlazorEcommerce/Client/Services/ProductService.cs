﻿namespace BlazorEcommerce.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } =  new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId) 
        { 
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            //pq essa tem return e a de baixo nao tem ???
            return result;
        }  
        public async Task GetProducts() 
        { 
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");

            Products = result.Data;
        }
    }
}
