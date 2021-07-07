﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {

        ProductsDb prds;

        public ProductApiController()
        {
            prds = new ProductsDb();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(prds);
        }
    }
}
