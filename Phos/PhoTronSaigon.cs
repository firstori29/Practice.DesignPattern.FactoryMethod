using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoTronSaigon : Pho
    {
        public PhoTronSaigon()
        {
            Name = "Pho Tron Saigon";
            Broth = Broth.Medium;
            IsDry = true;
            Meat = Meat.BoGa;
            Topping.AddRange(["Gia Saigon", "Quay Saigon"]);
        }

        public override int Payment()
        {
            return 49000;
        }
    }
}