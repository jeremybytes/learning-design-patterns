using System.Windows;

namespace ChainOfResponsibility;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        Application.Current.DispatcherUnhandledException += 
            (_, _) => MessageBox.Show("UNHANDLED EXCEPTION\n\nApplication Exiting");
    }
}
