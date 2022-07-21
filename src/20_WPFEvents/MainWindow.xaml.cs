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

namespace _20_WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ORA_Button.Click += Ora_Click;
            
        }

        private void Ora_Click(object sender, RoutedEventArgs e)
        {
            MyOtherLabel.Content = "ORAAA! ORA! ORA! ORA! ORAAA!";
        }

        private void ORA_Button_Click(object sender, RoutedEventArgs e)
        {
            MyLabel.Content = "ORA! ORA! ORA! ORA! ORA!";
        }
    }
}
