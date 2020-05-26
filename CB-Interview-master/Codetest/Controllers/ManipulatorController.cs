using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Codetest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManipulatorController : ControllerBase
    {
       

        private readonly ILogger<ManipulatorController> _logger;

        public ManipulatorController(ILogger<ManipulatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ManipulatorModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ManipulatorModel()
            {
                Message = $"Test Message {index}"              
            })
            .ToArray();
        }
    }
}
