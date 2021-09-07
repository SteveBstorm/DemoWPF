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

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Personne> personnes { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            personnes = new List<Personne>();
            personnes.Add(new Personne { Nom = "Le Gaulois", Prenom = "Provencal" , Email = "perceval@galles.com" });
            personnes.Add(new Personne { Nom = "Lorent", Prenom = "Steve" , Email = "steve.lorent@bstorm.be" });
            personnes.Add(new Personne { Nom = "Morre", Prenom = "Thierry" , Email = "thierry.morre@cognitic.be" });

            this.DataContext = personnes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Arthour !!! Couiillllleeeerree";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Window1 newWin = new Window1();
            newWin.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            personnes.Add((Personne)datagrid.Items.CurrentItem);
        }
    }
}
