using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H11Oef12Kluis
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

        int[] code = new int[6];

        Random random = new Random();

        int buttonCounter = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button == _0Button)
            {

                buttonCounter++;
            }
            else if (button == _1Button)
            {

                buttonCounter++;
            }
            else if (button == _2Button)
            {

                buttonCounter++;
            }
            else if (button == _3Button)
            {

                buttonCounter++;
            }
            else if (button == _4Button)
            {

                buttonCounter++;
            }
            else if (button == _5Button)
            {

                buttonCounter++;
            }
            else if (button == _6Button)
            {

                buttonCounter++;
            }
            else if (button == _7Button)
            {

                buttonCounter++;
            }
            else if (button == _8Button)
            {

                buttonCounter++;
            }
            else if (button == _9Button)
            {

                buttonCounter++;
            }
        }
    }
}