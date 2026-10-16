using System;
using System.Windows;
using System.Windows.Controls;

namespace Novikov_PR2.Pages
{
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void btnRearrange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int b = Convert.ToInt32(txtInputB.Text);
                string[] strNumbers = txtInputArray.Text.Split(' ');

                string leftSide = "";
                string rightSide = "";

                for (int i = 0; i < strNumbers.Length; i++)
                {
                    if (strNumbers[i] != "")
                    {
                        int number = Convert.ToInt32(strNumbers[i]);
                        if (number <= b)
                        {
                            leftSide += number.ToString() + " ";
                        }
                        else
                        {
                            rightSide += number.ToString() + " ";
                        }
                    }
                }

                txtResult.Text = leftSide + rightSide;
            }
            catch
            {
                MessageBox.Show("Проверьте ввод массива и числа b!");
            }
        }
    }
}