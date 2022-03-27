using rapidApp.Context;

namespace rapidApp.Repositories
{
    public class ConnectionRepository
    {
        private readonly LiteDbContext _liteDbContext;

        public ConnectionRepository() 
        {
            this._liteDbContext = new LiteDbContext();
        }
    }
}