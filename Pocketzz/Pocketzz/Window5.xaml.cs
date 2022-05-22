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
using System.Windows.Shapes;

namespace Pocketzz
{
    /// <summary>
    /// Interaktionslogik für Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ddos_attack_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"IP: {ddos_ip.Text}\nPort: {ddos_port.Text}\nMethod: {ddos_method.Text}\nTime: {ddos_time.Text}", "attacking....");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
