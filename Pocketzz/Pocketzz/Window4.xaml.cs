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
    /// Interaktionslogik für Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("This user will be banned(" + username_ban_textbox.Text + "). You want to Continue?", "Warning", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                MessageBox.Show("Ban Report successfully sent !");
            }
            else
            {
                MessageBox.Show("Event Successfully stopped !");
            }
        }
    }
}
