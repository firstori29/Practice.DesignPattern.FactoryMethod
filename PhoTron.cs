namespace PhoStoreProject
{
    internal class PhoTron : Pho
    {
        public PhoTron()
        {
            Name = "Pho Tron";
            Broth = Broth.Medium;
            IsDry = true;
            Meat = Meat.BoGa;
            Topping.AddRange(["Gia", "Quay"]);
        }

        public override int Payment()
        {
            return 55000;
        }
    }
}