using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Arv
{
    public class Djur
    {
        // Fields
        public string Name;
        public string Sneaky;
        public string Type;
        public double Weight;
        public string Size;
        public string Sound;
        
        // Methods
        public virtual void makeSound()
        {
            Console.WriteLine("Vi vet inte vilket djur."+ Sound);
        }

        public virtual void sleep()
        {
            Console.WriteLine("Alla djur sover ibland.");
        }

        public virtual void eats()
        {
            Console.WriteLine("Alla djur måste äta.");
        }

        public virtual void drinks()
        {
            Console.WriteLine("Alla djur måste dricka.");
        }
    }
}
