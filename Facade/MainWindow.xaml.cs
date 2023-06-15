using Shared;
using System.Windows;

namespace Facade;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void ClickMeButton_Click(object sender, RoutedEventArgs e)
    {
        IEnumerable<Person> people = People.GetPeople();

        using IEnumerator<Person> enumerator = people.GetEnumerator();
        while(enumerator.MoveNext())
        {
            await Task.Delay(500);
            PersonListBox.Items.Add(enumerator.Current);
        }

        //foreach (var person in people)
        //{
        //    await Task.Delay(500);
        //    PersonListBox.Items.Add(person);
        //}
    }
}
