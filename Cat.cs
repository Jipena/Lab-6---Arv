using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Arv
{
    public class Cat : Djur
    {
        // Fields
        public int Lives;
        
        // Constructor
        public Cat(string name = "Walle", string sneaky = "Yes", string type = "Mammal", double weight = 5, string size = "Small", int lives = 9)
        {
            this.Name = name;
            this.Sneaky = sneaky;
            this.Type = type;
            this.Weight = weight;
            this.Size = size;
            this.Lives = lives;
            this.Sound = "Meow";
        }

        // Methods
        public override void makeSound()
        {
            Console.WriteLine("Katten låter: " + Sound);
        }
        public override void sleep()
        {
            Console.WriteLine("Katter sover alltid.");
        }
        public override void eats()
        {
            Console.WriteLine("Katter äter råttor.");
        }
        public override void drinks()
        {
            Console.WriteLine("Katter dricker mjölk.");
        }
        public void ClimbTrees()
        {
            Console.WriteLine("Katter klättrar i träd.");
        }
    }
}
