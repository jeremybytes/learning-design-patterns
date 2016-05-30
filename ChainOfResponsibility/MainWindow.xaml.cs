using System;
using System.Windows;

namespace ChainOfResponsibility
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            Method1();
        }

        private void Method1()
        {
            Method2();
        }

        private void Method2()
        {
            switch (ExceptionBox.Text)
            {
                case "AccessViolationException":
                    throw new AccessViolationException();
                case "NullReferenceException":
                    throw new NullReferenceException();
                case "ArgumentException":
                    throw new ArgumentException();
                case "Exception":
                    throw new Exception();
            }
        }
    }
}
