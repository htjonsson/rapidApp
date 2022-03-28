using System.Collections.Generic;
using rapidApp.Context;
using rapidApp.Domains;

namespace rapidApp.Repositories
{
    public class ConnectionRepository
    {
        private readonly LiteDbContext _liteDbContext;

        public ConnectionRepository() 
        {
            this._liteDbContext = new LiteDbContext();
        }

        public List<Connection> GetAll()
        {
            return this._liteDbContext.GetAll<Connection>(typeof(Connection).Name);
        }

        public bool Save(Connection connection) 
        {
            return this._liteDbContext.Save<Connection>(typeof(Connection).Name, connection);
        }

        public bool Delete(Connection connection) 
        {
            return this._liteDbContext.Delete(typeof(Connection).Name, connection.Id);
        }        
    }
}