namespace P05AplikacjaZawodnicy
{
    partial class FrmZawodnicy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLicznaZaimportowanychDanych = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.rbImie = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNazwisko = new System.Windows.Forms.RadioButton();
            this.rbWzrost = new System.Windows.Forms.RadioButton();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 81);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(279, 303);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 13);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaimportowano rekordów:";
            // 
            // lblLicznaZaimportowanychDanych
            // 
            this.lblLicznaZaimportowanychDanych.AutoSize = true;
            this.lblLicznaZaimportowanychDanych.Location = new System.Drawing.Point(227, 19);
            this.lblLicznaZaimportowanychDanych.Name = "lblLicznaZaimportowanychDanych";
            this.lblLicznaZaimportowanychDanych.Size = new System.Drawing.Size(13, 13);
            this.lblLicznaZaimportowanychDanych.TabIndex = 3;
            this.lblLicznaZaimportowanychDanych.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtr";
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(41, 50);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(250, 20);
            this.txtFiltr.TabIndex = 5;
            this.txtFiltr.Text = "pol";
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(297, 81);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 6;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(298, 111);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 7;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // rbImie
            // 
            this.rbImie.AutoSize = true;
            this.rbImie.Location = new System.Drawing.Point(297, 222);
            this.rbImie.Name = "rbImie";
            this.rbImie.Size = new System.Drawing.Size(44, 17);
            this.rbImie.TabIndex = 8;
            this.rbImie.TabStop = true;
            this.rbImie.Text = "Imie";
            this.rbImie.UseVisualStyleBackColor = true;
            this.rbImie.Click += new System.EventHandler(this.rbKolumna_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sortuj";
            // 
            // rbNazwisko
            // 
            this.rbNazwisko.AutoSize = true;
            this.rbNazwisko.Location = new System.Drawing.Point(297, 245);
            this.rbNazwisko.Name = "rbNazwisko";
            this.rbNazwisko.Size = new System.Drawing.Size(71, 17);
            this.rbNazwisko.TabIndex = 10;
            this.rbNazwisko.TabStop = true;
            this.rbNazwisko.Text = "Nazwisko";
            this.rbNazwisko.UseVisualStyleBackColor = true;
            this.rbNazwisko.Click += new System.EventHandler(this.rbKolumna_Click);
            // 
            // rbWzrost
            // 
            this.rbWzrost.AutoSize = true;
            this.rbWzrost.Location = new System.Drawing.Point(297, 268);
            this.rbWzrost.Name = "rbWzrost";
            this.rbWzrost.Size = new System.Drawing.Size(58, 17);
            this.rbWzrost.TabIndex = 11;
            this.rbWzrost.TabStop = true;
            this.rbWzrost.Text = "Wzrost";
            this.rbWzrost.UseVisualStyleBackColor = true;
            this.rbWzrost.Click += new System.EventHandler(this.rbKolumna_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(297, 300);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 397);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.rbWzrost);
            this.Controls.Add(this.rbNazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbImie);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.txtFiltr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLicznaZaimportowanychDanych);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLicznaZaimportowanychDanych;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.RadioButton rbImie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNazwisko;
        private System.Windows.Forms.RadioButton rbWzrost;
        private System.Windows.Forms.Button btnZapisz;
    }
}

