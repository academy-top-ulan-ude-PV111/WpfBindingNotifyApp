using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;

namespace WpfBindingNotifyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new DataSource();

            timer = new() { Interval = TimeSpan.FromMilliseconds(500) };
            timer.Tick += Timer_Tick;

            timerValue.Text = (DataContext as DataSource).Value.ToString();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            (DataContext as DataSource).Value++;
            timerValue.Text = (DataContext as DataSource).Value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!timer.IsEnabled)
                timer.Start();
        }
    }
}
