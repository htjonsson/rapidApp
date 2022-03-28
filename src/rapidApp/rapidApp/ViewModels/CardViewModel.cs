using System;

namespace rapidApp.ViewModels
{
    public class CardViewModel
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
    } 
}