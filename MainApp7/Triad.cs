using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MainApp7
{
    class Triad
    {
       public int first;  //первый элемент
       public int second;  //второй элемент
       public int third;  //третий элемент

        public int First //свойства для полей с проверкой на четность
        {
            get
            {
                return first;
            }

            set
            {
                if (value % 2 == 1)
                {
                    first = value;
                }
                else
                {
                    Triad.Nechet();
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                if (value % 2 == 1)
                {
                    second = value;
                }
                else
                {
                    Triad.Nechet();
                }
            }
        }

        public int Third
        {
            get
            {
                return third;
            }

            set
            {
                if (value % 2 == 1)
                {
                    third = value;
                }
                else
                {
                    Triad.Nechet();
                }
            }
        }

        public static void Nechet() //предупреждение что число нечетное
        {
            MessageBox.Show("Число четное, введите нечетное");
        }

    }
}    