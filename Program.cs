namespace PhoStoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoStore store = new PhoStore();
            store.OrderPho(nameof(PhoBo));
            store.OrderPho(nameof(PhoGa));
            store.OrderPho(nameof(PhoTron));
            store.OrderPho("Pho Vit");
        }
    }
}