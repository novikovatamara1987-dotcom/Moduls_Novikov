using System.Windows;
using System.Windows.Controls;

namespace Novikov_AutoServicesRul.Pages
{
    public partial class Autho : Page
    {
        private const string MessageTitle = "Авторизация";

        public Autho()
        {
            InitializeComponent();
        }

        private void buttonGuestLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Client());
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            bool isLoginEmpty = string.IsNullOrWhiteSpace(textBoxLogin.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordBoxPassword.Password);

            if (isLoginEmpty || isPasswordEmpty)
            {
                ShowMessage("Введите логин и пароль.", MessageBoxImage.Warning);
                return;
            }

            ShowMessage("Проверка учётных данных будет добавлена в следующих работах.", MessageBoxImage.Information);
        }

        private static void ShowMessage(string text, MessageBoxImage icon)
        {
            MessageBox.Show(text, MessageTitle, MessageBoxButton.OK, icon);
        }
    }
}
