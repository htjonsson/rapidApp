using System;
using rapidApp.Context;
using rapidApp.Repositories;
using rapidApp.Domains;

namespace rapidApp.Bootstraps {

    public class Loader {

        public static void Connections()
        {
            var connectionRepository = new ConnectionRepository();

            var domain = new Domains.Connection()
            {
                Id = "cognos_ten_samples",
                Type = ConnectionType.Template,
                Name = "Cognos 10 Samples",
                Description = string.Empty,
                ModifiedDate = new DateTime(2018, 12, 10, 13, 49, 51)  
            };
            connectionRepository.Save(domain);      
        }

    }

}