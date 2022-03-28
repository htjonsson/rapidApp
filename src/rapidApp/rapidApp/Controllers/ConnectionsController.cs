using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rapidApp.Services;
using rapidApp.Context;
using rapidApp.Repositories;
namespace rapidApp.Controllers
{
    [ApiController]
    [Route("/api/v1/connections")]
    public class ConnectionsController
    {
        private readonly ILogger<ConnectionsController> _logger;
        private readonly ConnectionService _connectionService;

        public ConnectionsController(ILogger<ConnectionsController> logger)
        {
            _logger = logger;
            _connectionService = new ConnectionService();
        }

        [HttpGet]
        public JsonResult GetConnections()
        {
            var list = _connectionService.GetAll();

            return new JsonResult(list.ToArray());
        }
        
    }
}