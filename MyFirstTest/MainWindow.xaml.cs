using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Globalization;
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

namespace MyFirstTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
            MessageBox.Show(WeekOfMonth( new DateTime (100000, 5, 11), 200).ToString());
        }

            public static double WeekOfMonth(DateTime date, double a)
        {
            try
            {
                DateTime start = new DateTime(date.Year, date.Month, 1);
                while (date.Date.AddDays(1).DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                    date = date.AddDays(1);
                int weekinmouth = (int)Math.Truncate((double)date.Subtract(start).TotalDays / 7f) + 1;
                if (weekinmouth == 4 &&a>0)
                {
                    return a - (a / 100 * 4);
                }
                if (a <= 0)
                {
                    return 0;
                }
                return a;
                
                
                            }
            catch 
            {

                MessageBox.Show("Неккоректные данные") ;
                return 0;
            }
              
            }
        }
    }

