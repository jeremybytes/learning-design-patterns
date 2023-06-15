using Shared;
using System.Windows;

namespace Iterator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void ClickMeButton_Click(object sender, RoutedEventArgs e)
    {
        IEnumerable<Person> people = People.GetPeople();
        foreach (var person in people)
        {
            await Task.Delay(500);
            PersonListBox.Items.Add(person);
        }
    }
}
