using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    abstract class Urzadzenie 
    {
        protected Systemik s; 
        public string nazwa, lokalizacja, typ;
        public int temperatura = 0;

        public Urzadzenie()
        {
        }

        public virtual int get_temp() { return 1000; }
        public virtual void ustaw(int temp) { }
        public virtual void wyslij(int temp) { }
    }
    class Controler : Urzadzenie
    {
        public override string ToString()
        {
            return base.nazwa ;
        }
        public Controler(Systemik systemik, string nazwa, string lokalizacja)
        {
            base.lokalizacja = lokalizacja;
            base.nazwa = nazwa;
            base.typ = "Pilot";
            base.s = systemik;
        }
        public override void wyslij(int temp)
        {
            base.s.ustaw_temp_ktos(this.lokalizacja, temp); 
            // Controler nie jest używany, ponieważ steruje tym jeden duży systemik (systemików może być więcej)
        }
    }
    class Heater : Urzadzenie
    {
        public override string ToString()
        {
            return base.nazwa;
        }
        public Heater(Systemik systemik, string nazwa, string lokalizacja)
        {
            base.lokalizacja = lokalizacja;
            base.nazwa = nazwa;
            base.typ = "Grzejnik";
            base.s = systemik;
        }
        public override void ustaw(int temp)
        {
            if (base.s.odczytaj_temp(this.lokalizacja) < temp) // musi istnieć czujnik danej lokalizacji aby móc odczytać wartosć temperatury inaczej odzytamy błędną temperaturę 
            {
                Swiat_zew.Set_temp(this.lokalizacja, temp);
            }
        }

    }
    class Sensor : Urzadzenie
    {
        public override string ToString()
        {
            return base.nazwa;
        }
        public Sensor(Systemik systemik, string nazwa, string lokalizacja) 
        {
            base.nazwa = nazwa; 
            base.lokalizacja = lokalizacja;
            base.typ = "Czujnik";
            base.s = systemik;
        }


        public override int get_temp()
        {
            return Swiat_zew.Get_temp(this.lokalizacja);
        }


    }
    class Wiatrak : Urzadzenie
    {
        public override string ToString()
        {
            return base.nazwa;
        }
        public Wiatrak(Systemik systemik, string nazwa, string lokalizacja)
        {
            base.lokalizacja = lokalizacja;
            base.nazwa = nazwa;
            base.typ = "Wiatrak";
            base.s = systemik;
        }
        public override void ustaw(int temp)
        {
            if (base.s.odczytaj_temp(this.lokalizacja) > temp) // musi istnieć czujnik danej lokalizacji aby móc odczytać wartosć temperatury inaczej odzytamy błędną temperaturę
            {
                Swiat_zew.Set_temp(this.lokalizacja, temp);
            }
        }

    }
    class Nawilzacz : Urzadzenie
    {
    }
    class Osuszacz : Urzadzenie
    {
    }
}
