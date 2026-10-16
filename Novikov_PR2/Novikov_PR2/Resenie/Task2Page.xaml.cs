using System;
using System.Windows;
using System.Windows.Controls;

namespace Novikov_PR2.Pages
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            string text = txtInputString.Text;
            if (text == "")
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            string[] words = text.Split(' ');
            string result = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] != "")
                {
                    result = result + words[i] + " ";
                }
            }

            txtResult.Text = result;
        }

        private void txtInputString_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}