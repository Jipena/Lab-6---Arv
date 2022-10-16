using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Arv
{
    public class Horse : Djur
    {
        // Fields
        public bool LikesApples;
        
        // Constructor
        public Horse(string name = "Polle", string sneaky = "No", string type = "Mammal", double weight = 300, string size = "Huge", bool likesapples = true)
        {
            this.Name = name;
            this.Sneaky = sneaky;
            this.Type = type;
            this.Weight = weight;
            this.Size = size;
            this.LikesApples = likesapples;
            this.Sound = "Gnägg";
        }

        // Methods
        public override void makeSound()
        {
            Console.WriteLine("Hästen låter: " + Sound);
        }
        public override void sleep()
        {
            Console.WriteLine("Hästar sover på natten.");
        }
        public override void eats()
        {
            Console.WriteLine("Hästar äter gräs.");
        }
        public override void drinks()
        {
            Console.WriteLine("Hästar dricker regnvatten.");
        }
        public void JumpsHigh()
        {
            Console.WriteLine("Hästar hoppas högt!");
        }
    }
}
