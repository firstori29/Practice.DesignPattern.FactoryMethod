using PhoStoreProject.Phos.Base;

namespace PhoStoreProject.PhoStores.Base
{
    internal abstract class PhoStoreFactory
    {
        public void OrderPho(string type)
        {
            Pho pho = CreatePho(type);

            if (pho == null) return;

            pho.Prepare();
            pho.Carry();
            pho.Payment();
            Console.WriteLine();

            //Console.WriteLine(TestArgument(pho));
        }

        public abstract Pho CreatePho(string type);

        private int TestArgument(Pho pho)
        {
            return pho.Payment();
        }
    }
}