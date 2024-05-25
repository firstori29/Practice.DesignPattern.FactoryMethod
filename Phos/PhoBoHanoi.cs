using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoBoHanoi : Pho
    {
        public PhoBoHanoi()
        {
            Name = "Pho Bo Hanoi";
            Broth = Broth.Thick;
            RiceNoodle = "Nuoc Ham Xuong Bo Hanoi";
            Meat = Meat.Bo;
            Topping.AddRange(["Gia", "Trung tran Hanoi", "Quay Hanoi", "Rau song"]);
        }

        public override void Carry()
        {
            Console.WriteLine($"Carrying Pho {Name} to customer take away");
        }

        public override int Payment()
        {
            return 50000;
        }
    }
}