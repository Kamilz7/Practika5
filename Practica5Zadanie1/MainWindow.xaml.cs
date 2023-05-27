using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica5Zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private int count;
        private int sum;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TbNumber.Text, out int number))
            {
                ListBoxData.Items.Add(number);
                if (number >= 10 && number < 100)
                {
                    count++;
                    sum += number;
                }
                TbNumber.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректное число!");
            }
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            if (count > 0)
            {
                double average = (double)sum / count;
                TextBlockAnswer.Text = $"Ответ:\n{average}";
            }
            else
            {
                TextBlockAnswer.Text = "NO";
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}