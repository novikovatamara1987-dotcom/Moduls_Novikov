using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Novikov_PR2.Pages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtRowsN.Text);
                int m = Convert.ToInt32(txtColsM.Text);

                int[,] matrix = new int[n, m];
                int[] flatArray = new int[n * m];
                Random rnd = new Random();

                int min = 100;
                int max = -100;
                int k = 0;

              
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = rnd.Next(-10, 11);
                        flatArray[k] = matrix[i, j];
                        k++;

                        if (matrix[i, j] < min) min = matrix[i, j];
                        if (matrix[i, j] > max) max = matrix[i, j];
                    }
                }

                txtMinMax.Text = "Мин: " + min + " Макс: " + max;

         
                int[] ascArray = (int[])flatArray.Clone();
                for (int i = 0; i < ascArray.Length - 1; i++)
                {
                    for (int j = 0; j < ascArray.Length - 1 - i; j++)
                    {
                        if (ascArray[j] > ascArray[j + 1])
                        {
                            int temp = ascArray[j];
                            ascArray[j] = ascArray[j + 1];
                            ascArray[j + 1] = temp;
                        }
                    }
                }

 
                gridOriginal.ItemsSource = MakeTable(flatArray, n, m).DefaultView;
                gridAscending.ItemsSource = MakeTable(ascArray, n, m).DefaultView;


                int[] descArray = new int[n * m];
                int index = 0;
                for (int i = ascArray.Length - 1; i >= 0; i--)
                {
                    descArray[index] = ascArray[i];
                    index++;
                }
                gridDescending.ItemsSource = MakeTable(descArray, n, m).DefaultView;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода размера массива");
            }
        }


        private DataTable MakeTable(int[] arr, int rows, int cols)
        {
            DataTable dt = new DataTable();
            for (int j = 0; j < cols; j++)
            {
                dt.Columns.Add("Ст " + (j + 1));
            }

            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < cols; j++)
                {
                    row[j] = arr[k];
                    k++;
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}