using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return new List<string>
            {
                "Produto 1",
                "Produto 2",
                "Produto 2"
            };
        }
    }
}