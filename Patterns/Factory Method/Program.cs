using System;

namespace Patterns_FactoryMethod
{
    //  Factory Method

        // The Factory Method design pattern is a Creational design pattern which defines an interface for creating an object,
        // but doesn't specify what objects the individual implementations of that interface will instantiate.

        // When using this pattern, you can define certain methods and properties of object that will be common to all objects
        // created using the Factory Method, but let the individual Factory Methods define what specific objects they will instantiate.

        // Terminology
            
            // - The Product defines the interfaces of objects that the factory method will create.
            // - The ConcreteProduct objects implement the Product interface.
            // - The Creator declares the factory method, which returns an object of type Product. The Creator can also define a default implementation
            //   of the factory method, though you will not see that in the below example.
            // - The ConcreteCreator objects overrides the factory method to return an instance of a Concrete Product.

    // Product
    abstract class Ingredient { }

    // Concrete Products
    class Bread : Ingredient { }
    class Turkey : Ingredient { }
    class Lettuce : Ingredient { }
    class Mayonnaise : Ingredient { }

    // Creator
    abstract class Sandwich
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();
        
        public Sandwich()
        {
            CreateIngredients();
        }
 
        //Factory method
        public abstract void CreateIngredients();
 
        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
        }

        public void DisplayIngredients()
        {
            if (_ingredients.Count > 0)
            {
                _ingredients.ForEach(i => Console.WriteLine(i));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(this.GetType().Name + " has no ingredients.");
                Console.WriteLine();
            }
        }
    }       

    // Concrete Creator
    class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Bread());
        }
    }

    // Concrete Creator
    class Dagwood : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
        }      
    }

    // Concrete Creator
    class EmptySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            // Empty Sandwich
        }
    }
 
    class Program
    {   
        static void Main(string[] args)
        {
            var turkeySandwich = new TurkeySandwich();
            turkeySandwich.DisplayIngredients();

            var dagwood = new Dagwood();
            dagwood.DisplayIngredients();

            var emptySandwich = new EmptySandwich();
            emptySandwich.DisplayIngredients();
        }
    }
}