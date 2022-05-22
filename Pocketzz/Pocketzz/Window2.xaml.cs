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
using System.Net.NetworkInformation;

namespace Pocketzz
{
    /// <summary>
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Ping()
        {
            string fortnite = ping_ip.Text;
            Ping p1 = new Ping();
            PingReply PR = p1.Send(fortnite);
            MessageBox.Show(PR.Status.ToString());
            _ = p1.Send(fortnite);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ping();
        }
    }
}
