using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Arv
{
    public class Chihuahua : Dog
    {
        // Fields
        public bool IsCute;
        
        // Constructor
        public Chihuahua(string name = "Puppy", string sneaky = "No", string type = "Mammal", double weight = 8, string size = "Small", bool moody = false, bool iscute = true) : base(name, sneaky, type, weight, size, moody)
        {
            this.Name = name;
            this.Sneaky = sneaky;
            this.Type = type;
            this.Weight = weight;
            this.Size = size;
            this.IsAGoodBoy = moody;
            this.IsCute = iscute;
            this.Sound = "pip";
        }

        // Methods
        public override void makeSound()
        {
            Console.WriteLine("Chihuahuas låter: " + Sound);
        }
        public override void sleep()
        {
            Console.WriteLine("Chihuahuas sover mycket.");
        }
        public override void eats()
        {
            Console.WriteLine("Chihuahuas äter lite.");
        }
        public override void drinks()
        {
            Console.WriteLine("Chihuahuas dricker vatten.");
        }
        public override void Drewls()
        {
            Console.WriteLine("Chihuahuas drägglar lite.");
        }
    }
}
