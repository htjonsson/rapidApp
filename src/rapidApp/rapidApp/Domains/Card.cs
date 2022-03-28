using System;

namespace rapidApp.Domains
{
    public enum CardType {
        Simple
    }

    public class Card
    {
        public string Id { get; set; }
        public CardType Type { get; set; } = CardType.Simple;
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
    } 
}