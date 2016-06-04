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
    public partial class Controler_pilot : Form
    {
        Systemik s;
        string lokalizacja;
        public Controler_pilot(Systemik systemik, string lokal)
        {
            s = systemik;
            InitializeComponent();
            label1.Text = lokal;
            lokalizacja = lokal;
        }

        private void Ustaw_Click(object sender, EventArgs e)
        {
            s.ustaw_temp_z_pilota(lokalizacja, Int32.Parse(textBox1.Text));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = Swiat_zew.Get_temp(lokalizacja).ToString();
        }

    }
}
