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
    
        public void Init(Domains.Connection connection)
        {
            this.Id = connection.Id;
            if (connection.Type == Domains.ConnectionType.Folder) 
            {
                this.Type = "folder";
            }
            this.Name = connection.Name;
            this.Description = connection.Description;
            this.ModifiedDate = connection.ModifiedDate;
        }
    } 
}