using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    public class Swiat_zew
    {
        private static Dictionary<string, int> T = new Dictionary<string, int>();
        public static void init()
        {
            T["Kuchnia"] = 15;
            T.Add("Sypialnia", 15);
            T.Add("Łazienka", 15);
            T.Add("Toaleta", 15);
            T.Add("Przedpokój", 15);
        }
        public static void Set_temp(string lokalizacja, int temp)
        {
            T[lokalizacja] = temp;
        }
        public static int Get_temp(string lokalizacja)
        {
            return T[lokalizacja]; 
        }
    }
}
