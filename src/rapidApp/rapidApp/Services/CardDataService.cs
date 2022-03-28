using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using rapidApp.Repositories;
using rapidApp.Domains;

namespace rapidApp.Services
{
    public class CardDataService
    {
        private readonly CardDataRepository _cardDataRepository;

        public CardDataService()
        {
            this._cardDataRepository = new CardDataRepository();
        }

        public bool SaveJson(string jsonString) 
        {
            JObject o = JObject.Parse(jsonString);
            
            if(!o.ContainsKey("id")) 
            {
                return false;
            }
            var id  = o["id"].ToString();

            var cardData = new CardData()
            {
                Id = id,
                JsonString = jsonString,
                ModifiedDate = System.DateTime.UtcNow
            };

            return _cardDataRepository.Save(cardData);
        }

        public List<CardData> GetAll() 
        {
            return _cardDataRepository.GetAll();
        }
    }
}