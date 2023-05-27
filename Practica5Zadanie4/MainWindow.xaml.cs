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

namespace Practica5Zadanie4
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

        static double Cos(double x, int n)
        {
            if (n == 0) // базовый случай, когда не осталось слагаемых
            {
                return 1; // первое слагаемое в ряде Тейлора для cos(X) равно 1
            }
            double prev = Cos(x, n - 1); // вычисляем предыдущее слагаемое
            double factorial = 1; // факториал текущего числа
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial *= i; // вычисляем факториал текущего числа
            }
            double power = Math.Pow(x, 2 * n); // вычисляем текущую степень X
            int sign = (n % 2 == 0) ? 1 : -1; // знак следующего слагаемого
            return prev + sign * power / factorial; // 
        }
    }
}
