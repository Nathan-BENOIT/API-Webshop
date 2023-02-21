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
            var json = await client.GetStringAsync("https://615f5fb4f7254d0017068109.mockapi.io/api/v1/customers");
            var data = JsonConvert.DeserializeObject<List<Clients>>(json);
            return data;
        }

        // GET clients/id
        [HttpGet("{id}")]
        public async Task<Clients> Get(int id)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://615f5fb4f7254d0017068109.mockapi.io/api/v1/customers/" + id);
            var data = JsonConvert.DeserializeObject<Clients>(json);
            return data;
        }

        // GET clients/id/orders
        [HttpGet("{id}")]
        public async Task<Orders> GetOrders(int id)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://615f5fb4f7254d0017068109.mockapi.io/api/v1/customers/" + id + "orders");
            var data = JsonConvert.DeserializeObject<Orders>(json);
            return data;
        }
    }
}
