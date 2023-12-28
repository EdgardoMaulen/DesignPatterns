namespace Adaptor
{
    class Person
    {
        public void SwitchOn(ILaptop laptop)
        {
            LaptopAdapter.ShowModel(laptop);
        }
    }
}
