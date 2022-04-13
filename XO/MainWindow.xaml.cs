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

namespace XO
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool X;
        Gracz g1;
        Gracz g2;
        int tura = 1;
        public MainWindow()
        {
            InitializeComponent();
            Random rand = new Random();
            X = rand.Next(2) == 1;
            g1 = new Gracz("PlayerOne", X);
            g2 = new Gracz("PlayerTwo", !X);
            btn00.Content = null; btn01.Content = null; btn02.Content = null;
            btn10.Content = null; btn11.Content = null; btn12.Content = null;
            btn20.Content = null; btn21.Content = null; btn22.Content = null;
            Refresh();
        }
        string WykonajTure()
        {   
            if (!CzyZajete())
            {
                tura++;
                if (tura % 2 != 0) return g1.WstawXO();
                else return g2.WstawXO();
            }
            else return "lol";

        }
        void Refresh()
        {
            if (tura % 2 != 0) lblGracz.Content = $"Tura gracza: {g2.nick},({g2.WstawXO()})";
            else lblGracz.Content = $"Tura gracza: {g1.nick},({g1.WstawXO()})";
            Wygrana();
        }
        bool CzyZajete()
        {
            Button btn=new Button();
            if (btn.Content != null) return true;
            else return false;
        }
        void Wygrana()
        {
                //poziome
                if (btn00.Content == btn01.Content && btn01.Content == btn02.Content)
                {
                    if (btn00.Content != null && btn01.Content != null && btn02.Content != null)
                    { _ = MessageBox.Show("1Wygrywa: " + btn00.Content); Clear(); this.Close(); }
                }
                else if (btn10.Content == btn11.Content && btn11.Content == btn12.Content)
                {
                    if (btn10.Content != null && btn11.Content != null && btn12.Content != null)
                    { _ = MessageBox.Show("2Wygrywa: " + btn10.Content); Clear(); this.Close(); }
                }
                else if (btn20.Content == btn21.Content && btn21.Content == btn22.Content)
                {
                    if (btn20.Content != null && btn21.Content != null && btn22.Content != null)
                    { _ = MessageBox.Show("3Wygrywa: " + btn20.Content); Clear(); this.Close(); }
                }
                //pionowe
                else if (btn00.Content == btn10.Content && btn10.Content == btn20.Content)
                {
                    if (btn00.Content != null && btn10.Content != null && btn20.Content != null)
                    { _ = MessageBox.Show("4Wygrywa: " + btn00.Content); Clear(); this.Close(); }
                }
                else if (btn01.Content == btn11.Content && btn11.Content == btn21.Content)
                {
                    if (btn01.Content != null && btn11.Content != null && btn21.Content != null)
                    { _ = MessageBox.Show("5Wygrywa: " + btn01.Content); Clear(); this.Close(); }
                }
                else if (btn02.Content == btn12.Content && btn12.Content == btn22.Content)
                {
                    if (btn02.Content != null && btn12.Content != null && btn22.Content != null)
                    { _ = MessageBox.Show("6Wygrywa: " + btn02.Content); Clear(); this.Close(); }
                }
            //skośne
                else if (btn00.Content == btn11.Content && btn11.Content == btn22.Content)
                {
                    if (btn00.Content != null && btn11.Content != null && btn22.Content != null)
                    { _ = MessageBox.Show("7Wygrywa: " + btn00.Content); Clear(); this.Close(); }
                }
                else if (btn20.Content == btn11.Content && btn11.Content == btn02.Content)
                {
                    if (btn20.Content != null && btn11.Content != null && btn02.Content != null)
                    { _ = MessageBox.Show("8Wygrywa: " + btn20.Content); Clear(); this.Close(); }
                }
                 else if (tura > 9) { _ = MessageBox.Show("Remis: "); Clear(); this.Close(); }
        }
        void Clear()
        {
            btn00.Content = null; btn01.Content = null; btn02.Content = null;
            btn10.Content = null; btn11.Content = null; btn12.Content = null;
            btn20.Content = null; btn21.Content = null; btn22.Content = null;
        }
        private void btn00_Click(object sender, RoutedEventArgs e)
        {
            btn00.Content = WykonajTure(); Refresh();
        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            btn01.Content = WykonajTure(); Refresh();
        }

        private void btn02_Click(object sender, RoutedEventArgs e)
        {
            btn02.Content = WykonajTure(); Refresh();
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            btn10.Content = WykonajTure(); Refresh();
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            btn11.Content = WykonajTure(); Refresh();
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            btn12.Content = WykonajTure(); Refresh();
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
            btn20.Content = WykonajTure(); Refresh();
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            btn21.Content = WykonajTure(); Refresh();
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            btn22.Content = WykonajTure(); Refresh();
        }
    } 
}
