using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Arv
{
    public class Dog : Djur
    {   
        // Fields
        public bool IsAGoodBoy;
        
        // Constructor
        public Dog(string name = "Dogge", string sneaky = "No", string type = "Mammal", double weight = 30, string size = "Medium", bool moody = true)
        {
            this.Name = name;
            this.Sneaky = sneaky;
            this.Type = type;
            this.Weight = weight;
            this.Size = size;
            this.IsAGoodBoy = moody;
            this.Sound = "Woof";
        }

        // Methods
        public override void makeSound()
        {
            Console.WriteLine("Hunden låter: "+ Sound);
        }
        public override void sleep()
        {
            Console.WriteLine("Hundar sover mycket.");
        }
        public override void eats()
        {
            Console.WriteLine("Hundar äter pinnar.");
        }
        public override void drinks()
        {
            Console.WriteLine("Hundar dricker vatten.");
        }
        public virtual void Drewls()
        {
            Console.WriteLine("Vissa hundar drägglar.");
        }
    }
}
