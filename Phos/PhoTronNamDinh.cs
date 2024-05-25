using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoTronNamDinh : Pho
    {
        public PhoTronNamDinh()
        {
            Name = "Pho Tron Nam Dinh";
            Broth = Broth.Medium;
            IsDry = true;
            Meat = Meat.BoGa;
            Topping.AddRange(["Gia Nam Dinh", "Quay Nam Dinh"]);
        }

        public override int Payment()
        {
            return 56000;
        }
    }
}