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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Wtf_Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Brush randomColor;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button bt)
            {
                this.Background = bt.Background;

                Random r = new Random();
                randomColor = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));

                MessageBox.Show($"I am button {bt.Content}");
            }
        }

        private void Button_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button bt)
            {
                this.Title = $"{bt.Content} button delete";
                MyStackPanel.Children.Remove(bt);
            }
        }
    }
}
