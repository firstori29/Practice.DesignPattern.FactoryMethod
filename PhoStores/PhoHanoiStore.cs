using PhoStoreProject.Phos;
using PhoStoreProject.Phos.Base;
using PhoStoreProject.PhoStores.Base;

namespace PhoStoreProject.PhoStores
{
    internal class PhoHanoiStore : PhoStoreFactory
    {
        public override Pho CreatePho(string type)
        {
            switch (type)
            {
                case nameof(PhoBoHanoi):
                    return new PhoBoHanoi();

                case nameof(PhoGaHanoi):
                    return new PhoGaHanoi();

                case nameof(PhoTronHanoi):
                    return new PhoTronHanoi();

                default:
                    Console.WriteLine($"We are not selling {type} at {nameof(PhoHanoiStore)}");
                    return null;
            }
        }
    }
}