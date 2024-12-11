using System;
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
        int[] input = new int[6];

        Random random = new Random();

        int buttonCounter = 0;
        int numberOfTries = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            int buttonValue = -1;

            if (buttonCounter < 6)
            {
                if (button == _0Button)
                    buttonValue = 0;
                else if (button == _1Button)
                    buttonValue = 1;
                else if (button == _2Button)
                    buttonValue = 2;
                else if (button == _3Button)
                    buttonValue = 3;
                else if (button == _4Button)
                    buttonValue = 4;
                else if (button == _5Button)
                    buttonValue = 5;
                else if (button == _6Button)
                    buttonValue = 6;
                else if (button == _7Button)
                    buttonValue = 7;
                else if (button == _8Button)
                    buttonValue = 8;
                else if (button == _9Button)
                    buttonValue = 9;

                if (buttonValue != -1)
                {
                    int asteriskIndex = resultTextBox.Text.IndexOf('*');
                    if (asteriskIndex != -1)
                    {
                        resultTextBox.Text = resultTextBox.Text.Remove(asteriskIndex, 1).Insert(asteriskIndex, buttonValue.ToString());
                        input[buttonCounter] = buttonValue;
                        buttonCounter++;

                        ValidateEachNumber();
                    }
                }
            }

            if (buttonCounter == 6)
            {
                ValidateTotalWord();
            }
        }

        private void ValidateEachNumber()
        {
            if (input[buttonCounter - 1] == code[buttonCounter - 1])
            {
                MessageBox.Show($"{input[buttonCounter - 1]} staat op de juiste plaats", "Correct cijfer op juiste plaats!", MessageBoxButton.OK);
            }
            else if (code.Contains(input[buttonCounter - 1]))
            {
                MessageBox.Show($"{input[buttonCounter - 1]} staat op de foute plaats", "Correct cijfer op foute plaats!", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show($"{input[buttonCounter - 1]} komt niet voor in de code", "Fout cijfer", MessageBoxButton.OK);
            }
        }

        private void ValidateTotalWord()
        {
            bool isCorrect = true;
            string feedback = "";

            for (int i = 0; i < 6; i++)
            {
                if (input[i] == code[i])
                {
                    feedback += $"Number {input[i]}: Correct position\n";
                }
                else if (code.Contains(input[i]))
                {
                    feedback += $"Number {input[i]}: Wrong position (Yellow)\n";
                    isCorrect = false;
                }
                else
                {
                    feedback += $"Number {input[i]}: Not in code (Red)\n";
                    isCorrect = false;
                }
            }

            MessageBox.Show(feedback, "Validation Feedback", MessageBoxButton.OK, MessageBoxImage.Information);

            if (isCorrect)
            {
                MessageBox.Show("Code correct!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                resultTextBox.Text = "******";
                buttonCounter = 0;
            }

            numberOfTries++;

            if (numberOfTries == 3)
            {
                MessageBox.Show("U heeft geen pogingen meer!", "Geen pogingen meer", MessageBoxButton.OK, MessageBoxImage.Stop);
                Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 6; i++) 
            {
                int randomNumber = random.Next(0, 10);

                code[i] = randomNumber;
            }

            resultTextBox.Text = "******";
        }
    }
}