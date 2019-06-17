/* Cameron Heinz
 * Project Euler Problem # 3
 * largest Prime Factor
 * June 17,2019*/
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

namespace _312639LargestPrimeFactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            const long numm = 600851475143;
            long largestFact = 0;

            for (long i = 2; i < numm; i++)
            {
                if (numm % i == 0)
                { // It is a divisor
                    bool isPrime = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        largestFact = i;
                    }
                    lblOutput.Content = largestFact;
                }
            }
        }
    }
}
