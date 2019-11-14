using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return new List<string>
            {
                "Débito",
                "Crédito",
                "Carne do Bau"
            };
        }
    }
}