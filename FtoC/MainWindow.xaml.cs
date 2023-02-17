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

namespace FtoC
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

        private void input_Click(object sender, RoutedEventArgs e)
        {
            double value = 0;
            // read value from input text box, convert to a double and store in value
            value = Convert.ToDouble(input.Text);
            // multiply value by 10
            value = value * 10;
            // Outputs the value to the output text box
            output.Text = Convert.ToString(value);
           
            // changing the background colour of the multiply button
            // any property can be changed
            mul.Background = Brushes.Blue;

    
        }
    }
}
