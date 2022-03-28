using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rapidApp.Services;
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
            var domain = new Domains.Connection();
            domain.Init();

            var viewModel = new rapidApp.ViewModels.ConnectionViewModel();
            viewModel.Init(domain);

            var array = new List<ViewModels.ConnectionViewModel>(1);
            array.Add(viewModel);

            return new JsonResult(array.ToArray());
        }
        
    }
}