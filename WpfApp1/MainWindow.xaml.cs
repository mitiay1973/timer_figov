using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer _timer;

        public static readonly DependencyProperty TickCounterProperty = DependencyProperty.Register(
            "TickCounter", typeof(int), typeof(MainWindow), new PropertyMetadata(default(int)));

        public MainWindow()
        {
            InitializeComponent();
           
        }

        public int TickCounter
        {
            get { return (int)GetValue(TickCounterProperty); }
            set { SetValue(TickCounterProperty, value); }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (--TickCounter <= 0)
            {
                var timer = (DispatcherTimer)sender;
                timer.Stop();
                MessageBox.Show($"Время вышло");
            }
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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Random random = new Random();
            plusLeftLabel.Text = random.Next(0, 20).ToString();
            plusRightLabel.Text = random.Next(0, 20).ToString();
            minusLeftLabel.Text = random.Next(0, 20).ToString();
            minusRightLabel.Text = random.Next(0, 20).ToString();
            ymnLeftLabel.Text = random.Next(0, 20).ToString();
            ymnRightLabel.Text = random.Next(0, 20).ToString();
            delLeftLabel.Text = random.Next(1, 20).ToString();
            delRightLabel.Text = random.Next(1, 20).ToString();
            stopwatch.Stop();
            TickCounter = 60;
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1d);
            _timer.Tick += new EventHandler(Timer_Tick);
            _timer.Start();
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

        private void proverka_Click(object sender, RoutedEventArgs e)
        {
            int symma = Convert.ToInt32(plusLeftLabel.Text) + Convert.ToInt32(plusRightLabel.Text);
            int razn = Convert.ToInt32(minusLeftLabel.Text) - Convert.ToInt32(minusRightLabel.Text);
            int ymn = Convert.ToInt32(ymnLeftLabel.Text) * Convert.ToInt32(ymnRightLabel.Text);
            double del = Convert.ToDouble(delLeftLabel.Text) / Convert.ToDouble(delRightLabel.Text);
            if (symma == Convert.ToInt32(plusOtvLabel.Text))
            {
                if (razn == Convert.ToInt32(minusOtvLabel.Text))
                {
                    if (ymn == Convert.ToInt32(ymnOtvLabel.Text))
                    {
                        if (del == Convert.ToDouble(delOtvLabel.Text))
                        {
                            _timer.Stop();
                            int tim = 60 - Convert.ToInt32(Time.Text);
                            MessageBox.Show($"Вы успешно завершили тест за {tim} сек");
                        }
                    }
                }
            }
    }
    }
}
