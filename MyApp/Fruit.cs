using System.Security.Cryptography;

namespace MyApp
{
    public class Fruit
    {
        public string? Name { get; set; }
        public string? Colour { get; set; }
        public bool IsRipe { get; set; }


        
        public Fruit(string name, string colour, bool isRipe)
        {
            Name = name;
            Colour = colour;
            IsRipe = isRipe;
        }
         
    }
}