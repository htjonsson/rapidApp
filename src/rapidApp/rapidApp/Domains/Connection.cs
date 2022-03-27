using System;

namespace rapidApp.Domains
{
    public enum ConnectionType {
        Folder
    }

    public class Connection
    {
        public string Id { get; set; }
        public ConnectionType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
    
        public void Init()
        {
            Type = ConnectionType.Folder;
            Name = "Cognos 10 Samples";
            Description = string.Empty;
            ModifiedDate = new DateTime(2018, 12, 10, 13, 49, 51);
        }
    } 
}