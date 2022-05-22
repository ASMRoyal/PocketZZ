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
using System.Diagnostics;

namespace Pocketzz
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public static void sendWebHook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    Username
                },
                {
                    "content",
                    msg
                }
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is the Multi-Tool of ASM_Royal#9532 and departuree#0001. This is just a Beta Version. Thank you for using :)");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            sendWebHook(webhook_url.Text, webhook_msg.Text, webhook_username.Text);
        }

        private void webhook_msg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }
    }
}
