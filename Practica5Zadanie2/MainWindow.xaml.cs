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

namespace Practica5Zadanie2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(TbNumber.Text); // ввод количества учеников
            int unsatisfactoryCount = 0; // количество неудовлетворительных оценок
            bool allSolved = false; // все ли ученики решили все задачи
            for (int i = 0; i < n; i++)
            {
                int solved = int.Parse(TbNumber.Text); // ввод количества правильно решенных примеров
                if (solved < 5) // если решено менее 5 задач
                {
                    unsatisfactoryCount++; // увеличиваем счетчик неудовлетворительных оценок
                }
                if (solved == 10) // если решены все задачи
                {
                    allSolved = true; // выставляем флаг
                }
            }
            if (allSolved) // если хотя бы один ученик решил все задачи
            {
                MessageBox.Show("YES");
            }
            else // если ни один ученик не решил все задачи
            {
                MessageBox.Show("NO");
            }
            MessageBox.Show($"Количество неудовлетворительных оценок: {unsatisfactoryCount}");
        }
    }
}