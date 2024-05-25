using PhoStoreProject.Phos;
using PhoStoreProject.Phos.Base;
using PhoStoreProject.PhoStores.Base;

namespace PhoStoreProject.PhoStores
{
    internal class PhoNamDinhStore : PhoStoreFactory
    {
        public override Pho CreatePho(string type)
        {
            switch (type)
            {
                case nameof(PhoBoNamDinh):
                    return new PhoBoNamDinh();

                case nameof(PhoGaNamDinh):
                    return new PhoGaNamDinh();

                case nameof(PhoTronNamDinh):
                    return new PhoTronNamDinh();

                default:
                    Console.WriteLine($"We are not selling {type} at {nameof(PhoNamDinhStore)}");
                    return null;
            }
        }
    }
}