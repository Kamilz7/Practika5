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

namespace Practica5Zadanie3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            ListBoxResults.Items.Clear();

            if (double.TryParse(TbPricePerKg.Text, out double pricePerKg))
            {
                for (double weight = 0.1; weight <= 1.0; weight += 0.1)
                {
                    double totalPrice = pricePerKg * weight;
                    ListBoxResults.Items.Add($"Вес: {weight:F1} кг, Стоимость: {totalPrice:F2}");
                }
            }
            else
            {
                MessageBox.Show("Введите корректную цену за 1 кг конфет.");
            }
        }
    }
}