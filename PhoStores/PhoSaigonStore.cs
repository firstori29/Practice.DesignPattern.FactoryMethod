using PhoStoreProject.Phos;
using PhoStoreProject.Phos.Base;
using PhoStoreProject.PhoStores.Base;

namespace PhoStoreProject.PhoStores
{
    internal class PhoSaigonStore : PhoStoreFactory
    {
        public override Pho CreatePho(string type)
        {
            switch (type)
            {
                case nameof(PhoBoSaigon):
                    return new PhoBoSaigon();

                case nameof(PhoGaSaigon):
                    return new PhoGaSaigon();

                case nameof(PhoTronSaigon):
                    return new PhoTronSaigon();

                default:
                    Console.WriteLine($"We are not selling {type} at {nameof(PhoSaigonStore)}");
                    return null;
            }
        }
    }
}