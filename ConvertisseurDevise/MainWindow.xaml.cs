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

namespace ConvertisseurDevise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //**************************//
            // Abotsidia, Yao Josue, 2719507 // 
            //*************************//

            InitializeComponent();
            //btnRadio_Achat.IsChecked = false;
            //btnRadio_Vente.IsChecked = false;
           sous_grid.IsEnabled = false;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (btnRadio_Achat.IsChecked == true || btnRadio_Vente.IsChecked == true)
            {
                sous_grid.IsEnabled = true;
            }
            else if (btnRadio_Achat.IsChecked == false || btnRadio_Vente.IsChecked == false)
            {
                sous_grid.IsEnabled = false;
            }
        }

        private void Achat()
        {
            //Declaration des taux de change en constante
            const double cadToCad= 1;
            const double cadToUsd = 0.8;
            const double cadToEur = 0.72;

            const double usdToCad = 1.25;
            const double usdToUsd = 1;
            const double usdToEur = 0.9;

            const double eurToCad = 1.39;
            const double eurToUsd = 1.11;
            const double eurToEur = 1;

            //Declaration des variables pour recuperer les valeurs saisie
            string DeviseAConvertir=ComboBox_DeviseAConvertir.Text;
            string DeviseDeDestination=ComboBox_DeviseConverti.Text;

            if (DeviseAConvertir.Equals("CAD") && DeviseDeDestination.Equals("CAD"))
            {
                
            }
        }

        private void btn_Conversion_Click(object sender, RoutedEventArgs e)
        {
            Achat();
        }
    }
}