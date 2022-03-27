using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace rapidApp.Controllers
{
    [ApiController]
    [Route("[/api/v1/connections]")]
    public class ConnectionsController
    {
        private readonly ILogger<ConnectionsController> _logger;

        public ConnectionsController(ILogger<ConnectionsController> logger)
        {
            _logger = logger;
        }
        
    }
}