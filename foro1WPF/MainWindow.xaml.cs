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

namespace foro1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Num1Txt.Text = "";
            Num2Txt.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(OpcionesCB.SelectedIndex == 0) { 
               
                MessageBox.Show("La suma es: " + (int.Parse(Num1Txt.Text) + int.Parse(Num2Txt.Text))); 
            }
            else if (OpcionesCB.SelectedIndex == 1) { 
                MessageBox.Show("La resta es: " + (int.Parse(Num1Txt.Text) - int.Parse(Num2Txt.Text))); }
            else if (OpcionesCB.SelectedIndex == 2) { 
                MessageBox.Show("La multiplicacion es: " + (int.Parse(Num1Txt.Text) * int.Parse(Num2Txt.Text))); 
            }
            else if (OpcionesCB.SelectedIndex == 3) { 
                MessageBox.Show("La division es: " + (int.Parse(Num1Txt.Text) / int.Parse(Num2Txt.Text))); 
            }
            else { MessageBox.Show("Selecciona una opcion por favor"); }
        }
    }
}
