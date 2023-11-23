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

namespace Zadanie_1
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
            if (!Double.TryParse(Texta.Text, out double a))
            { MessageBox.Show("Поле только для чисел"); }
            double b;
            b = Math.Floor(a / 10);
            double c;
            c = a % 10;
            Textc.Text += ("единицы:" + c);
            Textb.Text += ("десятки:" + b);
        }
    }
}
