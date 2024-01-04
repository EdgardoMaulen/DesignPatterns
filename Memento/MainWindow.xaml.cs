using System.Windows;

namespace Memento
{
    /* This patterns allows for the recording of infomation that we can recover later. The basics is that we create two classes of the same type (Person, mementoPerson)
     * but in the class we want to save we create a copy of it in the other class (Person to MementoPerson) everytime we create an instance of said class. That way we can
     * recover the information in case the user wants to revert changes.
     * Check the "person" class for more info
     */

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DisplayPerson();
        }

        Person person = new Person();

        public void DisplayPerson()
        {
            NameBox.Text = person.Name;
            SurnameBox.Text = person.Surname; 
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            person.Update(NameBox.Text, SurnameBox.Text);
        }


        private void Revert_Click(object sender, RoutedEventArgs e)
        {
            person.Revert();
            DisplayPerson();
        }
    }
}