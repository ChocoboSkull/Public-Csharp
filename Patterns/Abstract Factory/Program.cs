using System;

namespace Patterns_AbsractFactory
{
    //  Abstract Factory

        // The Abstract Factory Pattern (AKA Factory of Factories) is a Creational pattern in which interfaces are defined for creating families of related objects
        // without specifying their actual implementations.

        // When using this pattern, you create factories which return many kinds of related objects. This pattern enables larger architectures such as
        // Dependency Injection.

    // Terminology
            
        // - An AbstractProduct declares an interface for a type of product.
        // - An AbstractFactory declares an interface for operations which will create AbstractProduct objects.
        // - A ConcreteProduct defines a product object that will be created by the corresponding ConcreteFactory.
        // - ConcreteFactory objects implement the operations defined by the AbstractFactory.
        // - The Client uses the AbstractFactory and AbstractProduct interfaces.

    // AbstractProduct
    abstract class Sandwich { }
    abstract class Dessert { }

    // AbstractFactory
    abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Dessert CreateDessert();
    }

    // ConcreteProduct
    class Bacon : Sandwich { }
    class Cake : Dessert { }

    // ConcreteFactory
    class AdultMenuFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new Bacon();
        }
 
        public override Dessert CreateDessert()
        {
            return new Cake();
        }        
    }

    // ConcreteProduct
    class Ham : Sandwich { }
    class IceCream : Dessert { }

    // ConcreteFactory
    class KidMenuFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new Ham();
        }
 
        public override Dessert CreateDessert()
        {
            return new IceCream();            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;

            // The Client
            RecipeFactory factory;
 
            switch(input)
            {
                case 'A' : case 'a':
                    factory = new AdultMenuFactory();
                break;
 
                case 'C': case 'c':
                    factory = new KidMenuFactory();
                break;
                
                default:
                    throw new NotImplementedException();
            }
 
            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);
            Console.ReadKey();
        } 
    } 
}