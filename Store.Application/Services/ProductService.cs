using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Store.Application.Models;

namespace Store.Application.Services
{
    public class ProductService : IProductService
    {
        public async Task<ICollection<Product>> GetAllAsync()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:10479/api/v1/products");
            var product = await response.Content.ReadAsAsync<ICollection<Product>>();
            return product;
        }

       
      
    }
}
