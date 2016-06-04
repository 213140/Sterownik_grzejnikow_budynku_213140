using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Pilot : Form
    {
        Systemik systemik = new Systemik();
        int id;

        public Pilot()
        {
            Swiat_zew.init();
            InitializeComponent();
            lokalizacja.Items.AddRange(systemik.dod_pokoje());
            dostepne_do_uzycia_lokal.Items.AddRange(systemik.dod_pokoje());
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (Pilot_sterownik.Checked == true)
            {
                id = 1;
            }
            else if (Grzejnik.Checked == true)
            {
                id = 2;
            }
            else if (Czujnik.Checked == true)
            {
                id = 3;
            }
            else if (Wiatrakk.Checked == true)
            {
                id = 4;
            }
            if (systemik.dodaj(systemik, nazwa.Text, lokalizacja.Text, id) != null)
            {
                nazwa.Text = null;
                if (id == 1)
                {
                    Controler_pilot Controler_pilot = new Controler_pilot(systemik, lokalizacja.Text);
                    Controler_pilot.Show();
                }
                    aktualizuj_liste();
            }
            else
            {
                MessageBox.Show("Urządzenie o takiej nazwie już istnieje!! \nWybierz inną nazwę :) ");
            }
        }

        void aktualizuj_liste()
        {
            urzadzenia.Items.Clear();  
            foreach (string s in systemik.lista_urzadzen())
            {             
                urzadzenia.Items.Add(systemik.aktualizuj_baze_danych(s));
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            dostepne_do_usuwania.Items.Clear();
            foreach (string s in systemik.lista_urzadzen())
            {
                dostepne_do_usuwania.Items.Add(s);
            }
            Kuchnia.Text = Swiat_zew.Get_temp("Kuchnia").ToString();
            Sypialnia.Text = Swiat_zew.Get_temp("Sypialnia").ToString();
            Łazienka.Text = Swiat_zew.Get_temp("Łazienka").ToString();
            Toaleta.Text = Swiat_zew.Get_temp("Toaleta").ToString();
            Przedpokoj.Text = Swiat_zew.Get_temp("Przedpokój").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            systemik.usun(dostepne_do_usuwania.Text);
            aktualizuj_liste();
            dostepne_do_usuwania.Text = null;
        }

        private void Ustaw_Click(object sender, EventArgs e)
        {
            systemik.ustaw_temp_ktos(dostepne_do_uzycia_lokal.Text, Int32.Parse(textBox1.Text));
        }

    }

}
