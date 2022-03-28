using System.Collections.Generic;
using rapidApp.Repositories;
using rapidApp.Domains;

namespace rapidApp.Services
{
    public class CardService
    {
        private readonly CardRepository _cardRepository;

        public CardService()
        {
            this._cardRepository = new CardRepository();
        }

        public List<Card> GetAll() 
        {
            return _cardRepository.GetAll();
        }
    }
}