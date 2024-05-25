using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoGaSaigon : Pho
    {
        public PhoGaSaigon()
        {
            Name = "Pho Ga Saigon";
            Broth = Broth.Thin;
            RiceNoodle = "Nuoc Luoc Ga Saigon";
            Meat = Meat.Ga;
            Topping.AddRange(["Gia Saigon", "Trung tran Saigon", "Quay"]);
        }

        public override void Carry()
        {
            Console.WriteLine($"Carrying Pho {Name} ship to customer home");
        }

        public override int Payment()
        {
            return 45000;
        }
    }
}