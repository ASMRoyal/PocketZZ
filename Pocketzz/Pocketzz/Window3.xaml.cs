using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    /// Interaktionslogik für Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {

        public Window3()
        {
            InitializeComponent();
        }

        private void lookup_button_Click(object sender, RoutedEventArgs e)
        {
            var url = "http://ip-api.com/json/" + lookup_textbox.Text;

            var request = WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            MessageBox.Show(data, "Result");

        }
    }
}
