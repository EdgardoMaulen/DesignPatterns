namespace Adaptor
{
    internal class LaptopAdapter : ILaptop
    {
        public void ShowModel(){}
        public static void ShowModel(ILaptop laptop)
        {
            laptop.ShowModel();
        }
    }
}
