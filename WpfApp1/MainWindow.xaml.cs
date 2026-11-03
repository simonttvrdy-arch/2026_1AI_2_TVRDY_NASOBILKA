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

namespace WpfApp1
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
            txtBlockVypis.Text = "";

            if (String.IsNullOrEmpty(txtBoxCislo.Text))
            {
                MessageBox.Show("Zadaj číslo!");
            }
            else
            {
                // dam si long aj na ozaj veľké čísla
                long cislo = 0;
                // pozriem či mám číslo alebo nie -> validácia
                if(long.TryParse(txtBoxCislo.Text, out cislo))
                {
                    // ak mam číslo tak rátam
                    for (int i = 1; i <= 10; i++)
                    {
                        long sucin = cislo * i;
                        txtBlockVypis.Text += cislo + " x " + i + " = " + sucin + "\n";
                        //Console.WriteLine(i);
                    }
                } else
                {
                    //nebolo zadané číslo v stringu
                    MessageBox.Show("NEZADAL SI ČÍSLO!");
                }

            }
            
        }
    }
}