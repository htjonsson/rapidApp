using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rapidApp.Services;
using rapidApp.Context;
using rapidApp.Repositories;
namespace rapidApp.Controllers
{
    [ApiController]
    [Route("/api/v1/card")]
    public class CardController : ControllerBase
    {
        private readonly ILogger<CardController> _logger;
        private readonly CardService _cardService;
        private readonly CardDataService _cardDataService;

        public CardController(ILogger<CardController> logger)
        {
            _logger = logger;
            _cardService = new CardService();
            _cardDataService = new CardDataService();
        }

        [HttpGet]
        [Route("/api/v1/card/{id}")]
        public JsonResult GetCard(string id)
        {
            return new JsonResult(string.Empty);
        }

        [HttpPost]
        [Route("/api/v1/card/save")]     
        public JsonResult Save(string json) 
        {
            var rawMessage = (new StreamReader(Request.Body)).ReadToEndAsync().GetAwaiter().GetResult();

            _cardDataService.SaveJson(rawMessage);

            return new JsonResult(string.Empty);
        }
    }
}