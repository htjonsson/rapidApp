using System.Collections.Generic;
using rapidApp.Context;
using rapidApp.Domains;

namespace rapidApp.Repositories
{
    public class CardRepository
    {
        private readonly LiteDbContext _liteDbContext;

        public CardRepository() 
        {
            this._liteDbContext = new LiteDbContext();
        }

        public List<Card> GetAll()
        {
            return this._liteDbContext.GetAll<Card>(typeof(Card).Name);
        }

        public bool Save(Card card) 
        {
            return this._liteDbContext.Save<Card>(typeof(Card).Name, card);
        }

        public bool Delete(Card card) 
        {
            return this._liteDbContext.Delete(typeof(Card).Name, card.Id);
        }        
    }
}