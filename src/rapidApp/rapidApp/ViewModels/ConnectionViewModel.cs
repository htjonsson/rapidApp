using System;

namespace rapidApp.ViewModels
{
    public class ConnectionViewModel
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
    
        public static ConnectionViewModel Map(Domains.Connection connection)
        {
            var o = new ConnectionViewModel();

            o.Id = connection.Id;
            o.Type = connection.Type.GetName();
            o.Name = connection.Name;
            o.Description = connection.Description;
            o.ModifiedDate = connection.ModifiedDate;

            return o;
        }
    } 
}