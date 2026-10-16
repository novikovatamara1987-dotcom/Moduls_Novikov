using System.Windows;

namespace Novikov_PR2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Pages.Task1Page());
        }

        private void btnTask2_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Pages.Task2Page());
        }

        private void btnTask3_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Pages.Task3Page());
        }

        private void btnTask4_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Pages.Task4Page());
        }

        private void btnTask5_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Pages.Task5Page());
        }

        private void FrmMain_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}