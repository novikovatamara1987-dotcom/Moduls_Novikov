using System;
using System.Windows;
using System.Windows.Controls;

namespace Novikov_PR2.Pages
{
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtInputN.Text);
                if (n <= 0 || n > 100)
                {
                    MessageBox.Show("Введите натуральное число до 100");
                    return;
                }

                double factorial = 1; 
                for (int i = 1; i <= n; i++)
                {
                    factorial = factorial * i;
                }

                double result = 2 * factorial;
                txtResult.Text = "Результат: " + result.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода! Введите число.");
            }
        }
    }
}