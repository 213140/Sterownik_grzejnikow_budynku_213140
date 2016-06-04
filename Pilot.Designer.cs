namespace WindowsFormsApplication2
{
    partial class Pilot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pilot));
            this.lokalizacja = new System.Windows.Forms.ComboBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.urzadzenia = new System.Windows.Forms.ListView();
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kambarys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dostepne_do_uzycia_lokal = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ustaw = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Pilot_sterownik = new System.Windows.Forms.RadioButton();
            this.Grzejnik = new System.Windows.Forms.RadioButton();
            this.Czujnik = new System.Windows.Forms.RadioButton();
            this.Wiatrakk = new System.Windows.Forms.RadioButton();
            this.dostepne_do_usuwania = new System.Windows.Forms.ComboBox();
            this.usun = new System.Windows.Forms.Button();
            this.Kuchnia = new System.Windows.Forms.TextBox();
            this.Sypialnia = new System.Windows.Forms.TextBox();
            this.Łazienka = new System.Windows.Forms.TextBox();
            this.Toaleta = new System.Windows.Forms.TextBox();
            this.Przedpokoj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lokalizacja
            // 
            this.lokalizacja.FormattingEnabled = true;
            this.lokalizacja.Location = new System.Drawing.Point(118, 10);
            this.lokalizacja.Name = "lokalizacja";
            this.lokalizacja.Size = new System.Drawing.Size(121, 21);
            this.lokalizacja.TabIndex = 0;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(118, 37);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(121, 89);
            this.Dodaj.TabIndex = 1;
            this.Dodaj.Text = "Dodaj Urządzenie";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // nazwa
            // 
            this.nazwa.Location = new System.Drawing.Point(12, 10);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(100, 20);
            this.nazwa.TabIndex = 2;
            // 
            // urzadzenia
            // 
            this.urzadzenia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Model,
            this.Kambarys,
            this.Typ});
            this.urzadzenia.FullRowSelect = true;
            this.urzadzenia.GridLines = true;
            this.urzadzenia.Location = new System.Drawing.Point(274, 140);
            this.urzadzenia.Name = "urzadzenia";
            this.urzadzenia.Size = new System.Drawing.Size(382, 159);
            this.urzadzenia.TabIndex = 3;
            this.urzadzenia.UseCompatibleStateImageBehavior = false;
            this.urzadzenia.View = System.Windows.Forms.View.Details;
            // 
            // Model
            // 
            this.Model.Text = "Model/Nazwa";
            this.Model.Width = 135;
            // 
            // Kambarys
            // 
            this.Kambarys.Text = "Pokój";
            this.Kambarys.Width = 138;
            // 
            // Typ
            // 
            this.Typ.Text = "Typ";
            this.Typ.Width = 106;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // dostepne_do_uzycia_lokal
            // 
            this.dostepne_do_uzycia_lokal.FormattingEnabled = true;
            this.dostepne_do_uzycia_lokal.Location = new System.Drawing.Point(5, 9);
            this.dostepne_do_uzycia_lokal.Name = "dostepne_do_uzycia_lokal";
            this.dostepne_do_uzycia_lokal.Size = new System.Drawing.Size(121, 21);
            this.dostepne_do_uzycia_lokal.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Ustaw
            // 
            this.Ustaw.Location = new System.Drawing.Point(132, 9);
            this.Ustaw.Name = "Ustaw";
            this.Ustaw.Size = new System.Drawing.Size(73, 47);
            this.Ustaw.TabIndex = 5;
            this.Ustaw.Text = "Ustaw";
            this.Ustaw.UseVisualStyleBackColor = true;
            this.Ustaw.Click += new System.EventHandler(this.Ustaw_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Pilot_sterownik
            // 
            this.Pilot_sterownik.AutoSize = true;
            this.Pilot_sterownik.Location = new System.Drawing.Point(19, 35);
            this.Pilot_sterownik.Name = "Pilot_sterownik";
            this.Pilot_sterownik.Size = new System.Drawing.Size(45, 17);
            this.Pilot_sterownik.TabIndex = 9;
            this.Pilot_sterownik.TabStop = true;
            this.Pilot_sterownik.Text = "Pilot";
            this.Pilot_sterownik.UseVisualStyleBackColor = true;
            // 
            // Grzejnik
            // 
            this.Grzejnik.AutoSize = true;
            this.Grzejnik.Location = new System.Drawing.Point(19, 58);
            this.Grzejnik.Name = "Grzejnik";
            this.Grzejnik.Size = new System.Drawing.Size(63, 17);
            this.Grzejnik.TabIndex = 10;
            this.Grzejnik.TabStop = true;
            this.Grzejnik.Text = "Grzejnik";
            this.Grzejnik.UseVisualStyleBackColor = true;
            // 
            // Czujnik
            // 
            this.Czujnik.AutoSize = true;
            this.Czujnik.Location = new System.Drawing.Point(19, 81);
            this.Czujnik.Name = "Czujnik";
            this.Czujnik.Size = new System.Drawing.Size(59, 17);
            this.Czujnik.TabIndex = 11;
            this.Czujnik.TabStop = true;
            this.Czujnik.Text = "Czujnik";
            this.Czujnik.UseVisualStyleBackColor = true;
            // 
            // Wiatrakk
            // 
            this.Wiatrakk.AutoSize = true;
            this.Wiatrakk.Location = new System.Drawing.Point(19, 104);
            this.Wiatrakk.Name = "Wiatrakk";
            this.Wiatrakk.Size = new System.Drawing.Size(62, 17);
            this.Wiatrakk.TabIndex = 12;
            this.Wiatrakk.TabStop = true;
            this.Wiatrakk.Text = "Wiatrak";
            this.Wiatrakk.UseVisualStyleBackColor = true;
            // 
            // dostepne_do_usuwania
            // 
            this.dostepne_do_usuwania.FormattingEnabled = true;
            this.dostepne_do_usuwania.Location = new System.Drawing.Point(13, 9);
            this.dostepne_do_usuwania.Name = "dostepne_do_usuwania";
            this.dostepne_do_usuwania.Size = new System.Drawing.Size(121, 21);
            this.dostepne_do_usuwania.TabIndex = 13;
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(149, 10);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(126, 20);
            this.usun.TabIndex = 14;
            this.usun.Text = "usun";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kuchnia
            // 
            this.Kuchnia.Location = new System.Drawing.Point(79, 31);
            this.Kuchnia.Name = "Kuchnia";
            this.Kuchnia.Size = new System.Drawing.Size(44, 20);
            this.Kuchnia.TabIndex = 16;
            // 
            // Sypialnia
            // 
            this.Sypialnia.Location = new System.Drawing.Point(79, 57);
            this.Sypialnia.Name = "Sypialnia";
            this.Sypialnia.Size = new System.Drawing.Size(44, 20);
            this.Sypialnia.TabIndex = 17;
            // 
            // Łazienka
            // 
            this.Łazienka.Location = new System.Drawing.Point(79, 82);
            this.Łazienka.Name = "Łazienka";
            this.Łazienka.Size = new System.Drawing.Size(44, 20);
            this.Łazienka.TabIndex = 18;
            // 
            // Toaleta
            // 
            this.Toaleta.Location = new System.Drawing.Point(79, 108);
            this.Toaleta.Name = "Toaleta";
            this.Toaleta.Size = new System.Drawing.Size(44, 20);
            this.Toaleta.TabIndex = 19;
            // 
            // Przedpokoj
            // 
            this.Przedpokoj.Location = new System.Drawing.Point(79, 134);
            this.Przedpokoj.Name = "Przedpokoj";
            this.Przedpokoj.Size = new System.Drawing.Size(44, 20);
            this.Przedpokoj.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kuchnia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sypialnia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Łazienka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Toaleta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Przedpokoj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Aktualne temperatury";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Przedpokoj);
            this.panel1.Controls.Add(this.Toaleta);
            this.panel1.Controls.Add(this.Łazienka);
            this.panel1.Controls.Add(this.Sypialnia);
            this.panel1.Controls.Add(this.Kuchnia);
            this.panel1.Location = new System.Drawing.Point(7, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 167);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.dostepne_do_uzycia_lokal);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Ustaw);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 68);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.Wiatrakk);
            this.panel3.Controls.Add(this.Czujnik);
            this.panel3.Controls.Add(this.Grzejnik);
            this.panel3.Controls.Add(this.Pilot_sterownik);
            this.panel3.Controls.Add(this.nazwa);
            this.panel3.Controls.Add(this.Dodaj);
            this.panel3.Controls.Add(this.lokalizacja);
            this.panel3.Location = new System.Drawing.Point(274, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 131);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.Controls.Add(this.usun);
            this.panel4.Controls.Add(this.dostepne_do_usuwania);
            this.panel4.Location = new System.Drawing.Point(274, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 35);
            this.panel4.TabIndex = 30;
            // 
            // Pilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 350);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.urzadzenia);
            this.Name = "Pilot";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox lokalizacja;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.ListView urzadzenia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox dostepne_do_uzycia_lokal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Ustaw;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RadioButton Pilot_sterownik;
        private System.Windows.Forms.RadioButton Grzejnik;
        private System.Windows.Forms.RadioButton Czujnik;
        private System.Windows.Forms.RadioButton Wiatrakk;
        public System.Windows.Forms.ColumnHeader Kambarys;
        public System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ComboBox dostepne_do_usuwania;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.ColumnHeader Typ;
        private System.Windows.Forms.TextBox Kuchnia;
        private System.Windows.Forms.TextBox Sypialnia;
        private System.Windows.Forms.TextBox Łazienka;
        private System.Windows.Forms.TextBox Toaleta;
        private System.Windows.Forms.TextBox Przedpokoj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

