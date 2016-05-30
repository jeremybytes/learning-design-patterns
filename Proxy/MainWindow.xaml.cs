using System.Windows;
using Proxy.PersonService;

namespace Proxy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            var proxy = new PersonServiceClient();
            var people = proxy.GetPeople();

            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }
    }
}
