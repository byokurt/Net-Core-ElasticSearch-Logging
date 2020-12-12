using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElasticSearchLogging.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Merhaba Dünya";
        }

        [HttpPost]
        [Route("customerror")]
        public bool CustomError(ExampleRequest request)
        {
            throw new Exception("Custom üretilen hata");
        }
    }
}