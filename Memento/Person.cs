namespace Memento
{
    class Person
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public MementoPerson MementoPerson { get; set; }

        public Person()
        {
            /*It creates an instance of the person in the MementoPerson class*/
            Name = "Edgardo";
            Surname = "Maulen";
            MementoPerson = new MementoPerson(Name, Surname);
        }

        public void Update(string name, string surname)
        {
            /*We update the person but the MementoPerson we created before remains intact*/
            this.Name = name;
            this.Surname = surname;
        }

        public void Revert()
        {
            /*We reinstantiate the person using the information from the MementoPerson */
            Name = MementoPerson.Name;
            Surname = MementoPerson.Surname;
        }
    }
}
