using System;
using System.Windows;
using System.Windows.Controls;

namespace Novikov_PR2.Pages
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] strNumbers = txtInputArray.Text.Split(' ');
                int[] arr = new int[strNumbers.Length];

                for (int i = 0; i < strNumbers.Length; i++)
                {
                    arr[i] = Convert.ToInt32(strNumbers[i]);
                }

                int maxLen = 1;
                int currentLen = 1;
                int maxEndIndex = 0;

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] != 0 && arr[i] % arr[i - 1] == 0)
                    {
                        currentLen++;
                    }
                    else
                    {
                        currentLen = 1; 
                    }

                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxEndIndex = i;
                    }
                }

                string res = "";
                int startIndex = maxEndIndex - maxLen + 1;
                for (int i = startIndex; i <= maxEndIndex; i++)
                {
                    res += arr[i] + " ";
                }

                txtResult.Text = "Длина: " + maxLen + "\nЧисла: " + res;
            }
            catch
            {
                MessageBox.Show("Ошибка! Вводите числа через один пробел.");
            }
        }
    }
}