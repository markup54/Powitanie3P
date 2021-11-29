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

namespace Powitanie3P
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("witaj");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            czas_button.Content = data.ToString("T");
        }

        private void czas_button_MouseLeave(object sender, MouseEventArgs e)
        {
            czas_button.Content = "Czas";
        }
    }
}
