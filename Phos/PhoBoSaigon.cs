using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoBoSaigon : Pho
    {
        public PhoBoSaigon()
        {
            Name = "Pho Bo Saigon";
            Broth = Broth.Thick;
            RiceNoodle = "Nuoc Ham Xuong Bo Saigon";
            Meat = Meat.Bo;
            Topping.AddRange(["Gia Saigon", "Trung tran Saigon", "Quay Saigon", "Rau song"]);
        }

        public override void Carry()
        {
            Console.WriteLine($"Shipping Pho {Name} to customer home");
        }

        public override int Payment()
        {
            return 60000;
        }
    }
}