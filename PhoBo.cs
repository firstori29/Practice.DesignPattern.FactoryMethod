namespace PhoStoreProject
{
    internal class PhoBo : Pho
    {
        public PhoBo()
        {
            Name = "Pho Bo";
            Broth = Broth.Thick;
            RiceNoodle = "Nuoc Ham Xuong Bo";
            Meat = Meat.Bo;
            Topping.AddRange(["Gia", "Trung tran", "Quay", "Rau song"]);
        }

        public override void Carry()
        {
            Console.WriteLine($"Carrying Pho {Name} to customer take away");
        }

        public override int Payment()
        {
            return 50000;
        }
    }
}