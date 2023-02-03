﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIWebshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProduitsController : ControllerBase
    {
        // GET: client
        [HttpGet]
        public async Task<List<Produits>> GetAsync()
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://615f5fb4f7254d0017068109.mockapi.io/api/v1/products");
            var data = JsonConvert.DeserializeObject<List<Produits>>(json);
            return data;
        }

        // GET produits/id
        [HttpGet("{id}")]
        public async Task<Produits> Get(int id)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://615f5fb4f7254d0017068109.mockapi.io/api/v1/products/" + id);
            var data = JsonConvert.DeserializeObject<Produits>(json);
            return data;
        }
    }
}
