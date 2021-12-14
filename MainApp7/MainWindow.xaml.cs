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

namespace MainApp7
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

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пичугин Дмитрий ИСП-31 Использовать класс Triad (тройка нечетных чисел). Определить производный класс Time с полями: час, минута и секунда.Определить полный набор методов сравнения моментов времени.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Time FirstDate = new Time(); //инициализация первой даты

            FirstDate.Day = Convert.ToInt32(OneOne.Text);       //заполнение полей
            FirstDate.Month = Convert.ToInt32(OneTwo.Text);
            FirstDate.Year = Convert.ToInt32(OneThree.Text);

            Time SecondDate = new Time(); //инициализация второй даты

            SecondDate.Day = Convert.ToInt32(TwoOne.Text);         //заполнение полей
            SecondDate.Month = Convert.ToInt32(TwoTwo.Text);
            SecondDate.Year = Convert.ToInt32(TwoThree.Text);

            int DR, MR, YR;   //пременные разницы

            Time.Compare(FirstDate, SecondDate, out DR, out MR, out YR);    //использование функции сравнения
            
            MessageBox.Show("Между датами прошло: " + Convert.ToString(DR) + " дней, " + Convert.ToString(MR) + " месяцев, " + Convert.ToString(YR) + " лет ");   //вывод результата
            
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
