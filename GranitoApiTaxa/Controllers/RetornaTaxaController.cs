using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GranitoApiTaxa.Controllers
{
    [Route("granito/[controller]")]
    [ApiController]
    public class RetornaTaxaController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return 1;
        }
    }
}
