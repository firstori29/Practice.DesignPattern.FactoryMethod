using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoGaHanoi : Pho
    {
        public PhoGaHanoi()
        {
            Name = "Pho Ga Hanoi";
            Broth = Broth.Thin;
            RiceNoodle = "Nuoc Luoc Ga Hanoi";
            Meat = Meat.Ga;
            Topping.AddRange(["Gia Hanoi", "Trung tran Hanoi", "Quay"]);
        }

        public override void Carry()
        {
            Console.WriteLine($"Carrying Pho {Name} ship to customer home");
        }

        public override int Payment()
        {
            return 35000;
        }
    }
}