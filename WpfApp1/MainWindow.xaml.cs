using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void plusLeftLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void plusRightLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void plusOtvLabel_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random(); 
            plusLeftLabel.Text=random.Next(0,20).ToString();
            plusRightLabel.Text=random.Next(0,20).ToString();
            minusLeftLabel.Text=random.Next(0,20).ToString();
            minusRightLabel.Text=random.Next(0,20).ToString();
            ymnLeftLabel.Text=random.Next(0,20).ToString();
            ymnRightLabel.Text=random.Next(0,20).ToString();
            ymnRightLabel.Text=random.Next(0,20).ToString();
            delLeftLabel.Text=random.Next(0,20).ToString();
            delRightLabel.Text=random.Next(0,20).ToString();
            Timer timer= new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.
            timer.Stop();

        }

        private void minusLeftLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void minusRightLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void minusOtvLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ymnLeftLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ymnRightLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ymnOtvLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void delLeftLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void delRightLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void delOtvLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
