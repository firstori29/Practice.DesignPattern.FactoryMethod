using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoTronHanoi : Pho
    {
        public PhoTronHanoi()
        {
            Name = "Pho Tron Hanoi";
            Broth = Broth.Medium;
            IsDry = true;
            Meat = Meat.BoGa;
            Topping.AddRange(["Gia Hanoi", "Quay Hanoi"]);
        }

        public override void Carry()
        {
            Console.WriteLine($"Shipping Pho {Name} to customer home address");
        }

        public override int Payment()
        {
            return 35000;
        }
    }
}