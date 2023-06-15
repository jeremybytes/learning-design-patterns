using System.Windows;

namespace Proxy;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void ClickMeButton_Click(object sender, RoutedEventArgs e)
    {
        var proxy = new PeopleServiceProxy();
        var people = await proxy.GetPeople();
        foreach (var person in people)
        {
            PersonListBox.Items.Add(person);
        }
    }
}
