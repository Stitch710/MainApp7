using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;

namespace MainApp7
{
    class Time : Triad
    {

        public static void Error() //предупреждение что число выходит за рамки
        {
            MessageBox.Show("Дата выходит за рамки или введена неверно, ввердите корректные числа");          
        }

        public int Year   //свойство для поля год
        {
            get
            {
                return third;
            }

            set
            {
                third = value;
            }
        }

        public int Day //свойства для полей с проверкой
        {
            get
            {
                return first;
            }

            set
            {
                if (second == 3 || second == 5 || second == 7 || second == 8 || second == 10 || second == 12 || second == 1)  //проверка на месяцы в которых 31 день
                {
                    if (value > 31 || value == 0)
                    {
                        Time.Error();

                    }
                    else
                    {
                        first = value;
                    }
                }
                else
                {
                    if (value > 30 || value == 0)
                    {
                        Time.Error();
                    }
                    else
                    {
                        first = value;
                    }
                }
            }
        }

        public int Month //свойства для полей с проверкой
        {
            get
            {
                return second;
            }

            set
            {
                if (value > 12 || value == 0)
                {
                    Time.Error();
                    
                }
                else
                {
                    second = value;
 
                }
            }
        }

        public static void Compare (Time FirstDate, Time SecondDate, out int dr, out int mr, out int yr)
        {            

            if (SecondDate.Year == FirstDate.Year && SecondDate.Month < FirstDate.Month)
            {
                yr = 0;
                Time.Error();
            }
            else
            {
                yr = SecondDate.Year - FirstDate.Year;
            }

            if (SecondDate.Month < FirstDate.Month)
            {
                if (SecondDate.Year > FirstDate.Year)
                {
                    mr = (SecondDate.Month - FirstDate.Month) + 12;
                }
                else
                {
                    mr = 0;
                    Time.Error();
                }

            }
            else
            {
                mr = SecondDate.Month - FirstDate.Month;
            }

            if (SecondDate.Day < FirstDate.Day)
            {
                if (SecondDate.Month < FirstDate.Month && SecondDate.Year > FirstDate.Year)
                {
                    dr = (SecondDate.Day - FirstDate.Day) + 31;
                }
                else
                {
                    dr = 0;
                    Time.Error();
                }

            }
            else
            {
                dr = SecondDate.Day - FirstDate.Day;
            }

        }
    }
}
