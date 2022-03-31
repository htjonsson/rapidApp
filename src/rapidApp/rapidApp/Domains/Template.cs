using System;
using System.Collections.Generic;

namespace rapidApp.Domains
{
    public class Template
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string SourceTable { get; set; }
        public List<String> Elements { get; set; }
        public string Code { get; set; }
        public DateTime ValidatedDate { get; set; }
    } 
}