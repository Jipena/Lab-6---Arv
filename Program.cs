using System;

namespace Lab_6___Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Djur();
            animals.makeSound();
            animals.sleep();
            animals.eats();
            animals.drinks();
            Console.ReadLine();
            
            var dog = new Dog();
            dog.makeSound();
            dog.sleep();
            dog.eats();
            dog.drinks();
            dog.Drewls();
            Console.ReadLine();

            var bulldog = new Bulldog();
            bulldog.makeSound();
            bulldog.sleep();
            bulldog.eats();
            bulldog.drinks();
            bulldog.Drewls();
            Console.ReadLine();

            var chihuahua = new Chihuahua();
            chihuahua.makeSound();
            chihuahua.sleep();
            chihuahua.eats();
            chihuahua.drinks();
            chihuahua.Drewls();
            Console.ReadLine();

            var cat = new Cat();
            cat.makeSound();
            cat.sleep();
            cat.eats();
            cat.drinks();
            cat.ClimbTrees();
            Console.ReadLine();

            var horse = new Horse();
            horse.makeSound();
            horse.sleep();
            horse.eats();
            horse.drinks();
            horse.JumpsHigh();
            Console.ReadLine();
        }
    }
}
