using System.Collections.Generic;
using rapidApp.Repositories;
using rapidApp.Domains;

namespace rapidApp.Services
{
    public class ConnectionService
    {
        private readonly ConnectionRepository _connectionRepository;

        public ConnectionService()
        {
            this._connectionRepository = new ConnectionRepository();
        }

        public List<Connection> GetAll() 
        {
            return _connectionRepository.GetAll();
        }
    }
}