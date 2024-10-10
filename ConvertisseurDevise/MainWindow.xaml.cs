using Microsoft.Xaml.Behaviors.Core;
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

        /// <summary>
        /// Fonction Achat, peremetant de convertir la valeur si l'utilisateur choisi d'acheter
        /// </summary>
        /// <param name="valeurSaisie"> Valeur de montant a convertir</param>

        private void Achat(int valeurSaisie)
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
            double valeurConvertie =0;
            //Declaration des variables pour recuperer les valeurs saisie
            string DeviseAConvertir=ComboBox_DeviseAConvertir.Text;
            string DeviseDeDestination=ComboBox_DeviseConverti.Text;

            if (DeviseAConvertir.Equals("CAD") && DeviseDeDestination.Equals("CAD"))
            {
                valeurConvertie = valeurSaisie * cadToCad;
                textBox_TauxDeChange.Text = cadToCad.ToString();
            }
            else if (DeviseAConvertir.Equals("CAD") && DeviseDeDestination.Equals("USD"))
            {
                valeurConvertie = valeurSaisie * cadToUsd;
                textBox_TauxDeChange.Text = cadToUsd.ToString();
            }
            else if (DeviseAConvertir.Equals("CAD") && DeviseDeDestination.Equals("EUR"))
            {
                valeurConvertie = valeurSaisie * cadToEur;
                textBox_TauxDeChange.Text = cadToEur.ToString();

            }
            else if (DeviseAConvertir.Equals("USD") && DeviseDeDestination.Equals("CAD"))
            {
                valeurConvertie = valeurSaisie * usdToCad;
                textBox_TauxDeChange.Text = usdToCad.ToString();

            }
            else if (DeviseAConvertir.Equals("USD") && DeviseDeDestination.Equals("USD"))
            {
                valeurConvertie = valeurSaisie * usdToUsd;
                textBox_TauxDeChange.Text = usdToUsd.ToString();

            }
            else if (DeviseAConvertir.Equals("USD") && DeviseDeDestination.Equals("EUR"))
            {
                valeurConvertie = valeurSaisie * usdToEur;
                textBox_TauxDeChange.Text = usdToEur.ToString();

            }
            else if (DeviseAConvertir.Equals("EUR") && DeviseDeDestination.Equals("CAD"))
            {
                valeurConvertie = valeurSaisie * eurToCad;
                textBox_TauxDeChange.Text = eurToCad.ToString();

            }
            else if (DeviseAConvertir.Equals("EUR") && DeviseDeDestination.Equals("USD"))
            {
                valeurConvertie = valeurSaisie * eurToUsd;
                textBox_TauxDeChange.Text = eurToUsd.ToString();

            }
            else if (DeviseAConvertir.Equals("EUR") && DeviseDeDestination.Equals("EUR"))
            {
                valeurConvertie = valeurSaisie * eurToEur;
                textBox_TauxDeChange.Text = eurToEur.ToString();

            }
            textBox_ValeurConvertie.Text = valeurConvertie.ToString();
        }

        /// <summary>
        /// Fonction prenant en compte le traitement de la vente
        /// </summary>
        /// <param name="valeurSaisie">Valeur a convertir passer en paramettre de la fonction</param>
        private void Vente(int valeurSaisie)
        {
            //Declaration des taux de change en constante
            const double cadToCad = 1;
            const double cadToUsd = 0.78;
            const double cadToEur = 0.70;

            const double usdToCad = 1.27;
            const double usdToUsd = 1;
            const double usdToEur = 0.95;

            const double eurToCad = 1.35;
            const double eurToUsd = 1.08;
            const double eurToEur = 1;

            double valeurConvertie = 0;
            //Declaration des variables pour recuperer les valeurs saisie

            string DeviseAConvertir = ComboBox_DeviseAConvertir.Text;
            string DeviseDeDestination = ComboBox_DeviseConverti.Text;

            if (DeviseAConvertir.Equals("CAD") && DeviseDeDestination.Equals("CAD"))
            {
                valeurConvertie = valeurSaisie * cadToCad;
                textBox_TauxDeChange.Text=cadToCad.ToString();
            }
            else if (DeviseAConvertir.Equals("CAD") && DeviseDeDestination.Equals("USD"))
            {
                valeurConvertie = valeurSaisie * cadToUsd;
                textBox_TauxDeChange.Text = cadToUsd.ToString();
            }
            else if (DeviseAConvertir.Equals("CAD") && DeviseDeDestination.Equals("EUR"))
            {
                valeurConvertie = valeurSaisie * cadToEur;
                textBox_TauxDeChange.Text = cadToEur.ToString();

            }
            else if (DeviseAConvertir.Equals("USD") && DeviseDeDestination.Equals("CAD"))
            {
                valeurConvertie = valeurSaisie * usdToCad;
                textBox_TauxDeChange.Text = usdToCad.ToString();

            }
            else if (DeviseAConvertir.Equals("USD") && DeviseDeDestination.Equals("USD"))
            {
                valeurConvertie = valeurSaisie * usdToUsd;
                textBox_TauxDeChange.Text = usdToUsd.ToString();

            }
            else if (DeviseAConvertir.Equals("USD") && DeviseDeDestination.Equals("EUR"))
            {
                valeurConvertie = valeurSaisie * usdToEur;
                textBox_TauxDeChange.Text = usdToEur.ToString();

            }
            else if (DeviseAConvertir.Equals("EUR") && DeviseDeDestination.Equals("CAD"))
            {
                valeurConvertie = valeurSaisie * eurToCad;
                textBox_TauxDeChange.Text = eurToCad.ToString();

            }
            else if (DeviseAConvertir.Equals("EUR") && DeviseDeDestination.Equals("USD"))
            {
                valeurConvertie = valeurSaisie * eurToUsd;
                textBox_TauxDeChange.Text = eurToUsd.ToString();

            }
            else if (DeviseAConvertir.Equals("EUR") && DeviseDeDestination.Equals("EUR"))
            {
                valeurConvertie = valeurSaisie * eurToEur;
                textBox_TauxDeChange.Text = eurToEur.ToString();

            }
            textBox_ValeurConvertie.Text = valeurConvertie.ToString();
        }

        /// <summary>
        /// Au click du bouton les verifications sont faites et les calculs sont fait.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Conversion_Click(object sender, RoutedEventArgs e)
        {
            string valeur=textBox_ValeurAConvertir.Text;
            int valSaisie=0;

            string? deviseAConvertir = null;
            string? deviseConverti = null;

            deviseAConvertir = ComboBox_DeviseAConvertir.Text.Trim();
            deviseConverti = ComboBox_DeviseConverti.Text.Trim();
            bool isTrue=int.TryParse(valeur, out valSaisie);
            if (btnRadio_Achat.IsChecked == true)
            {
                if (isTrue && deviseAConvertir is not null && deviseConverti is not null)
                {
                    Achat(valSaisie);
                }
                else
                {
                    MessageBox.Show("Erreur les valeurs de saisie et des devises ne peuvent pas etre nulle et la valeur a convertit doit etre numerique","Erreur de saisie",MessageBoxButton.OK);
                }
            }
            else if(btnRadio_Vente.IsChecked == true)
            {
                if (isTrue && deviseAConvertir is not null && deviseConverti is not null)
                {
                    Vente(valSaisie);
                }
                else
                {
                    MessageBox.Show("Erreur les valeurs de saisie et des devises ne peuvent pas etre nulle et la valeur a convertit doit etre numerique", "Erreur de saisie", MessageBoxButton.OK);
                }
            }
        }

        //Boutn reinitialisé
        private void btn_Reinitialiser_Click(object sender, RoutedEventArgs e)
        {
            textBox_ValeurAConvertir.Text = "";
            textBox_ValeurConvertie.Text = "";
            textBox_TauxDeChange.Text = "";
        }
        //Boutn Fermer

        private void btn_Fermer_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}