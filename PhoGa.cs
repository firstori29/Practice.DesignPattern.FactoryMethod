namespace PhoStoreProject
{
    internal class PhoGa : Pho
    {
        public PhoGa()
        {
            Name = "Pho Ga";
            Broth = Broth.Thin;
            RiceNoodle = "Nuoc Luoc Ga";
            Meat = Meat.Ga;
            Topping.AddRange(["Gia", "Trung tran", "Quay"]);
        }

        public override void Carry()
        {
            Console.WriteLine($"Carrying Pho {Name} ship to customer home");
        }

        public override int Payment()
        {
            return 45000;
        }
    }
}