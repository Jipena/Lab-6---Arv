using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Arv
{
    public class Bulldog : Dog
    {
        // Fields
        public bool LooksAngry;
        
        // Constructor
        public Bulldog(string name = "Puggy", string sneaky = "No", string type = "Mammal", double weight = 15, string size = "Small", bool moody = true, bool looksangry = true) : base(name, sneaky, type, weight, size, moody)   // Constructor
        {
            this.Name = name;
            this.Sneaky = sneaky;
            this.Type = type;
            this.Weight = weight;
            this.Size = size;
            this.IsAGoodBoy = moody;
            this.LooksAngry = looksangry;
            this.Sound = "Grrr";
        }

        // Methods
        public override void makeSound()   
        {
            Console.WriteLine("Bulldogs låter: " + Sound);
        }
        public override void sleep()
        {
            Console.WriteLine("Bulldogs sover mycket.");
        }
        public override void eats()
        {
            Console.WriteLine("Bulldogs äter ben.");
        }
        public override void drinks()
        {
            Console.WriteLine("Bulldogs dricker vatten.");
        }
        public override void Drewls()  
        {
            Console.WriteLine("Bulldogs drägglar mycket!");
        }

    }

        
    
}
