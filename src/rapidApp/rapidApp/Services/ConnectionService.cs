using System.Collections.Generic;
using rapidApp.Repositories;

namespace rapidApp.Services
{
    public class ConnectionService
    {
        private readonly ConnectionRepository _connectionRepository;

        public ConnectionService()
        {
            this._connectionRepository = new ConnectionRepository();
        }
    }
}