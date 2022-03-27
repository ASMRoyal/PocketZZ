using System.Windows;
using System.Windows.Controls;

namespace Pocketzz
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text + password.Text == "")
            {
                MessageBox.Show("Please Enter an Username Or password");
            }
            else if (username.Text == "ASM_Royal")
            {
                if (password.Text == "Falcons")
                {
                    Window1 window1 = new Window1();
                    window1.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
