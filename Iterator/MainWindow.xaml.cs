using System.Collections.Generic;
using System.Windows;

namespace Iterator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Person> people = People.GetPeople();

            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }
    }
}
