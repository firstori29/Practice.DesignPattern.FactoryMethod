using PhoStoreProject.Phos;
using PhoStoreProject.PhoStores;
using PhoStoreProject.PhoStores.Base;

namespace PhoStoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoStoreFactory phoHanoi = new PhoHanoiStore();
            PhoStoreFactory phoNamDinh = new PhoNamDinhStore();
            PhoStoreFactory phoSaigon = new PhoSaigonStore();
            phoHanoi.OrderPho(nameof(PhoBoHanoi));
            phoNamDinh.OrderPho(nameof(PhoBoNamDinh));
            phoSaigon.OrderPho(nameof(PhoBoSaigon));
            phoHanoi.OrderPho("Pho Vit");
            phoNamDinh.OrderPho("Pho Cho");
            phoSaigon.OrderPho("Pho Chim");
        }
    }
}