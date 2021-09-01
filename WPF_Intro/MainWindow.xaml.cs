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

namespace WPF_Intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //lblOutput.Visibility = Visibility.Hidden;
            lblOutput.Content = "";

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text); //hehe

            DateTime today = DateTime.Now;
            int birthyear = today.Year - age;

            lblOutput.Content = $"You were born in {birthyear.ToString("G0")}";
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
