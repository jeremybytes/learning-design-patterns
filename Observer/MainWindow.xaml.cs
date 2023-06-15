using System.Windows;

namespace Observer;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ClickMeButton.Click += Observer1;
        ClickMeButton.Click += Observer2;
        ClickMeButton.Click += Observer3;
    }

    private void Observer1(object sender, RoutedEventArgs e)
    {
        TextBlock1.Text = "Hello from Observer 1";
    }

    private void Observer2(object sender, RoutedEventArgs e)
    {
        TextBlock2.Text = "Hello from Observer 2";
    }

    private void Observer3(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello from Observer 3");
    }
}
