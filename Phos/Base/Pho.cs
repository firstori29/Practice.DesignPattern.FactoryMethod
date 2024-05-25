using PhoStoreProject.Enum;

namespace PhoStoreProject.Phos.Base
{
    internal abstract class Pho
    {
        protected string Name;
        protected Broth Broth;
        protected string RiceNoodle;
        protected Meat Meat;
        protected List<string> Topping = [];
        protected bool IsDry = false;

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}...");
            Console.WriteLine(IsDry ? $"Insert Pho {Name} to disk" : $"Pouring {RiceNoodle}");
            Console.WriteLine($"Adding {Broth} broth");
            Console.WriteLine($"Adding meat {Meat}");
            Console.WriteLine("Adding toppings:");
            Topping.ForEach(x => Console.WriteLine($"\t{x}"));
        }

        public virtual void Carry() // polymorphism
        {
            Console.WriteLine($"Carrying Pho {Name} to customer on table");
        }

        public abstract int Payment(); // abstraction
    }
}