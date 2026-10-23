using System;
using System.Windows;
using Novikov_AutoServicesRul.Pages;

namespace Novikov_AutoServicesRul
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frameContent.Navigate(new Autho());
        }

        private void buttonGoBack_Click(object sender, RoutedEventArgs e)
        {
            if (frameContent.CanGoBack)
            {
                frameContent.GoBack();
            }
        }

        /// <summary>
        /// Показывает кнопку «Назад» только если в журнале навигации есть предыдущая страница.
        /// </summary>
        private void frameContent_ContentRendered(object sender, EventArgs e)
        {
            buttonGoBack.Visibility = frameContent.CanGoBack ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
