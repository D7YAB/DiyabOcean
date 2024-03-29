﻿using DiyabOcean.Shared;

namespace DiyabOcean.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public event Action? ProductsChanged;
        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; } = "Loading products...";

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null
                ? await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product")
                : await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/Product/category/{categoryUrl}");
            if (result is { Data: not null })
            {
                Products = result.Data;
            }
            ProductsChanged?.Invoke();
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task SearchProducts(string searchText)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/Product/search/{searchText}");
            if (result is { Data: not null })
            {
                Products = result.Data;
                if (Products.Count == 0) Message = "No products found.";
                ProductsChanged?.Invoke();
            }
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
            var result =
                await _http.GetFromJsonAsync<ServiceResponse<List<string>>>(
                    $"api/Product/searchSuggestions/{searchText}");
            return result.Data;
            throw new NotImplementedException();
        }
    }
}
