using System.Collections.Generic;
using rapidApp.Context;
using rapidApp.Domains;

namespace rapidApp.Repositories
{
    public class CardDataRepository
    {
        private readonly LiteDbContext _liteDbContext;

        public CardDataRepository() 
        {
            this._liteDbContext = new LiteDbContext();
        }

        public List<CardData> GetAll()
        {
            return this._liteDbContext.GetAll<CardData>(typeof(CardData).Name);
        }

        public bool Save(CardData cardData) 
        {
            return this._liteDbContext.Save<CardData>(typeof(CardData).Name, cardData);
        }

        public bool Delete(CardData cardData) 
        {
            return this._liteDbContext.Delete(typeof(CardData).Name, cardData.Id);
        }        
    }
}