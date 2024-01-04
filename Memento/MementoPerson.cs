namespace Memento
{
    class MementoPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public MementoPerson(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
