using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoGaNamDinh : Pho
    {
        public PhoGaNamDinh()
        {
            Name = "Pho Ga Nam Dinh";
            Broth = Broth.Thin;
            RiceNoodle = "Nuoc Luoc Ga Nam Dinh";
            Meat = Meat.Ga;
            Topping.AddRange(["Gia Nam Dinh", "Trung tran Nam Dinh", "Quay Nam Dinh"]);
        }

        public override int Payment()
        {
            return 40000;
        }
    }
}