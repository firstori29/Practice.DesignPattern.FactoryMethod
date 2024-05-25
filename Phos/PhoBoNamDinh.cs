using PhoStoreProject.Enum;
using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.Phos
{
    internal class PhoBoNamDinh : Pho
    {
        public PhoBoNamDinh()
        {
            Name = "Pho Bo Nam Dinh";
            Broth = Broth.Thick;
            RiceNoodle = "Nuoc Ham Xuong Bo Nam Dinh";
            Meat = Meat.Bo;
            Topping.AddRange(["Gia Nam Dinh", "Trung tran Nam Dinh", "Quay", "Rau song"]);
        }

        public override int Payment()
        {
            return 55000;
        }
    }
}