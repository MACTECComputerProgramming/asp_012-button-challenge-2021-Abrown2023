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

namespace csasp12
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
            double pencilbutton = 0;

            pencilbutton = Convert.ToDouble(textbox1);

        }

        private void Pen_Button_Click(object sender, RoutedEventArgs e)
        {
            double penbutton = 0;

            penbutton = Convert.ToDouble(textbox1);

        }

        private void Phone_button_Click(object sender, RoutedEventArgs e)
        {
            double phonebutton = 0;

            phonebutton = Convert.ToDouble(textbox1);
        }

        private void padbutton_Click(object sender, RoutedEventArgs e)
        {
            double padbutton = 0;

            padbutton = Convert.ToDouble(textbox1);

        }

        private void push_me_button_Click(object sender, RoutedEventArgs e)
        {
            double pushmebutton = 0;

            pushmebutton = Convert.ToDouble(textbox1);
        }
    }
}
