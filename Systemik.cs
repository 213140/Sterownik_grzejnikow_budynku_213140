using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    public class Systemik
    {
        private List<Urzadzenie> maszyny = new List<Urzadzenie>();
        private object[] pokoje = new object[5];

        public List<string> lista_urzadzen()
        {
            List<string> l = new List<string>();
            foreach (Urzadzenie cz in maszyny)
                l.Add(cz.ToString());
            return l;
        }

        public object[] dod_pokoje()
        {
            pokoje[0] = "Kuchnia";
            pokoje[1] = "Sypialnia";
            pokoje[2] = "Łazienka";
            pokoje[3] = "Toaleta";
            pokoje[4] = "Przedpokój";
            return pokoje;
        }

        public ListViewItem aktualizuj_baze_danych(string s)
        {
            ListViewItem lvs = new ListViewItem(s);
            lvs.SubItems.Add(maszyny.ElementAt((lista_urzadzen().IndexOf(s))).lokalizacja);
            lvs.SubItems.Add(maszyny.ElementAt((lista_urzadzen().IndexOf(s))).typ);
            return lvs;
        }
        public string dodaj(Systemik systemik, string nazwa, string lokalizacja, int id)
        {
            foreach (Urzadzenie cz in maszyny)
                if (cz.nazwa == nazwa)
                    return null;
            if (id == 1)
            {
                Urzadzenie nowy = new Controler(systemik, nazwa, lokalizacja);
                maszyny.Add(nowy);
                //tablica a = new tablica(nowy, nowy.nazwa, nowy.typ, nowy.lokalizacja);
               // tablica_wszystkich.Add(a);
                return nowy.ToString();
            }
            else if (id == 2)
            {
                Urzadzenie nowy = new Heater(systemik, nazwa, lokalizacja);
                maszyny.Add(nowy);
                //tablica a = new tablica(nowy, nowy.nazwa, nowy.typ, nowy.lokalizacja);
                //tablica_wszystkich.Add(a);
                return nowy.ToString();
            }
            else if (id == 3)
            {
                Urzadzenie nowy = new Sensor(systemik, nazwa, lokalizacja);
                maszyny.Add(nowy);
               // tablica a = new tablica(nowy, nowy.nazwa, nowy.typ, nowy.lokalizacja);
                //tablica_wszystkich.Add(a);
                return nowy.ToString();
            }
            else if (id == 4)
            {
                Urzadzenie nowy = new Wiatrak(systemik, nazwa, lokalizacja);
                maszyny.Add(nowy);
                //tablica a = new tablica(nowy, nowy.nazwa, nowy.typ, nowy.lokalizacja);
               // tablica_wszystkich.Add(a);
                return nowy.ToString();
            }
            else
            {
                return null;
            }
          
        }

        public bool usun(string nazwa)
        {
            foreach (Urzadzenie cz in maszyny)
                if (cz.nazwa == nazwa)
                {
                    maszyny.RemoveAt(lista_urzadzen().IndexOf(nazwa));
                    return true;
                }
            return false;
        }

        public void ustaw_temp_z_pilota(string lokalizacja, int temperatura)
        {
            foreach (Urzadzenie cz in maszyny)
            {
                if (cz.typ == "Pilot" && cz.lokalizacja == lokalizacja)
                {
                    cz.wyslij(temperatura);
                }
            }           
        } //ustaw_temp_z_pilota tak na prawdę ta metoda nie ma sensu w danej aplikacji, wykonuje to samo co metoda ustaw_temp_ktos ale robi to przez urządzenie Controler. Służy aby zaprezentować, że klasa Controler ma sens być w rzeczywistości. 
        // Klasa pilot to taki jeden duży pilot z systemikiem w środku, co steruje wszystkim. A objekty klasy Controler to pojedyncze piloty przenośne do każdego pokoju osobno, albo do kilku pokoi, obiektem tej klasy może też być telefon użytownika z aplikacją do powiązania się z tym systemikiem i ustawienia lub odczytania temperatury o określonej lokalizacji :) 
        public void ustaw_temp_ktos(string lokalizacja, int temperatura)
        {
            foreach (Urzadzenie cz in maszyny)
            {
                if (cz.lokalizacja == lokalizacja)
                {
                    cz.ustaw(temperatura);
                }
            }
        }

        public int? odczytaj_temp(string lokalizacja)
        {
            foreach (Urzadzenie cz in maszyny)
            {
                if(cz.lokalizacja == lokalizacja)
                {
                    return cz.get_temp();
                }
            }
            return null;
        }

    }
}
