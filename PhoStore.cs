namespace PhoStoreProject
{
    internal class PhoStore
    {
        public void OrderPho(string type)
        {
            Pho pho;
            switch (type)
            {
                case nameof(PhoBo):
                    pho = new PhoBo();
                    break;

                case nameof(PhoGa):
                    pho = new PhoGa();
                    break;

                case nameof(PhoTron):
                    pho = new PhoTron();
                    break;

                default:
                    Console.WriteLine($"We are not selling {type}");
                    return;
            }

            pho.Prepare();
            pho.Carry();
            pho.Payment();
            Console.WriteLine();

            //Console.WriteLine(TestArgument(pho));
        }

        private int TestArgument(Pho pho)
        {
            return pho.Payment();
        }
    }
}