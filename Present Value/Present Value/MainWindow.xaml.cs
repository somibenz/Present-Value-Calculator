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

namespace Present_Value
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        double FutureValue;
        double annualRate;
        double numofYears;
        double ratepercent;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
             FutureValue = double.Parse(textBox1.Text);
            annualRate = double.Parse(textBox2.Text);
            ratepercent = annualRate / 100;
             numofYears = double.Parse(textBox3.Text);
            double sum = CalcPresentValue(FutureValue,ratepercent, numofYears);
            label.Content = sum;
        }
        private double CalcPresentValue(double FutureValue,double ratepercent, double numofYears)
        {
            return FutureValue / Math.Pow(1 + ratepercent, numofYears);
        }
    }
}
