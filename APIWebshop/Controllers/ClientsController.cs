using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIWebshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        // GET: client
        [HttpGet]
        public async Task<List<Clients>> GetAsync()
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://63f39eecde3a0b242b461bef.mockapi.io/api/v1/customers");
            var data = JsonConvert.DeserializeObject<List<Clients>>(json);
            return data;
        }

        // GET clients/id
        [HttpGet("{id}")]
        public async Task<Clients> Get(int id)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://63f39eecde3a0b242b461bef.mockapi.io/api/v1/customers/" + id);
            var data = JsonConvert.DeserializeObject<Clients>(json);
            return data;
        }

        // GET clients/id/orders
        [HttpGet("{id}/commandes")]
        public async Task<List<Order>> GetOrders(int id)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://63f39eecde3a0b242b461bef.mockapi.io/api/v1/customers/" + id + "/orders");
            var data = JsonConvert.DeserializeObject<List<Order>>(json);
            return data;
        }

        // GET clients/id/orders/orderId/produits
        [HttpGet("{id}/commandes/{orderId}/produits")]
        public async Task<List<Products>> GetProductsOrder(int id, int orderId)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://63f39eecde3a0b242b461bef.mockapi.io/api/v1/customers/" + id + "/orders/" + orderId + "/products");
            var data = JsonConvert.DeserializeObject<List<Products>>(json);
            return data;
        }
    }
}
