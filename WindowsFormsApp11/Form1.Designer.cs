﻿
namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produkty = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dodaj_produkt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sprzedaj_produkt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dodaj_produkt = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.opis_produktu = new System.Windows.Forms.TextBox();
            this.nazwa_produktu = new System.Windows.Forms.TextBox();
            this.cena_produktu = new System.Windows.Forms.TextBox();
            this.cena_promocyjna_produktu = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_sprzedaj_produkt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Produkty.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Produkty
            // 
            this.Produkty.Controls.Add(this.tabPage1);
            this.Produkty.Controls.Add(this.tabPage2);
            this.Produkty.Controls.Add(this.tabPage3);
            this.Produkty.Controls.Add(this.tabPage4);
            this.Produkty.Location = new System.Drawing.Point(173, 93);
            this.Produkty.Name = "Produkty";
            this.Produkty.SelectedIndex = 0;
            this.Produkty.Size = new System.Drawing.Size(615, 345);
            this.Produkty.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dodaj_produkt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produkty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dodaj_produkt
            // 
            this.dodaj_produkt.BackColor = System.Drawing.Color.Green;
            this.dodaj_produkt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dodaj_produkt.Location = new System.Drawing.Point(429, 19);
            this.dodaj_produkt.Name = "dodaj_produkt";
            this.dodaj_produkt.Size = new System.Drawing.Size(162, 42);
            this.dodaj_produkt.TabIndex = 1;
            this.dodaj_produkt.Text = "Dodaj nowy produkt";
            this.dodaj_produkt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produkty";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sprzedaj_produkt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(607, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sprzedaż";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sprzedaj_produkt
            // 
            this.sprzedaj_produkt.BackColor = System.Drawing.Color.Green;
            this.sprzedaj_produkt.ForeColor = System.Drawing.SystemColors.Control;
            this.sprzedaj_produkt.Location = new System.Drawing.Point(437, 17);
            this.sprzedaj_produkt.Name = "sprzedaj_produkt";
            this.sprzedaj_produkt.Size = new System.Drawing.Size(155, 44);
            this.sprzedaj_produkt.TabIndex = 1;
            this.sprzedaj_produkt.Text = "Dodaj sprzedaż";
            this.sprzedaj_produkt.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sprzedaż";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_dodaj_produkt);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.opis_produktu);
            this.tabPage3.Controls.Add(this.nazwa_produktu);
            this.tabPage3.Controls.Add(this.cena_produktu);
            this.tabPage3.Controls.Add(this.cena_promocyjna_produktu);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(607, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dodaj";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "opis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ilość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cena promocyjna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodaj nowy produkt";
            // 
            // btn_dodaj_produkt
            // 
            this.btn_dodaj_produkt.BackColor = System.Drawing.Color.Green;
            this.btn_dodaj_produkt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dodaj_produkt.Location = new System.Drawing.Point(331, 231);
            this.btn_dodaj_produkt.Name = "btn_dodaj_produkt";
            this.btn_dodaj_produkt.Size = new System.Drawing.Size(154, 66);
            this.btn_dodaj_produkt.TabIndex = 5;
            this.btn_dodaj_produkt.Text = "Dodaj";
            this.btn_dodaj_produkt.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(230, 133);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 27);
            this.numericUpDown1.TabIndex = 4;
            // 
            // opis_produktu
            // 
            this.opis_produktu.Location = new System.Drawing.Point(33, 188);
            this.opis_produktu.Name = "opis_produktu";
            this.opis_produktu.Size = new System.Drawing.Size(273, 27);
            this.opis_produktu.TabIndex = 3;
            // 
            // nazwa_produktu
            // 
            this.nazwa_produktu.Location = new System.Drawing.Point(33, 82);
            this.nazwa_produktu.Name = "nazwa_produktu";
            this.nazwa_produktu.Size = new System.Drawing.Size(273, 27);
            this.nazwa_produktu.TabIndex = 2;
            // 
            // cena_produktu
            // 
            this.cena_produktu.Location = new System.Drawing.Point(33, 133);
            this.cena_produktu.Name = "cena_produktu";
            this.cena_produktu.Size = new System.Drawing.Size(64, 27);
            this.cena_produktu.TabIndex = 1;
            // 
            // cena_promocyjna_produktu
            // 
            this.cena_promocyjna_produktu.Location = new System.Drawing.Point(127, 133);
            this.cena_promocyjna_produktu.Name = "cena_promocyjna_produktu";
            this.cena_promocyjna_produktu.Size = new System.Drawing.Size(72, 27);
            this.cena_promocyjna_produktu.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_sprzedaj_produkt);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.numericUpDown2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(607, 312);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sprzedaj";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_sprzedaj_produkt
            // 
            this.btn_sprzedaj_produkt.BackColor = System.Drawing.Color.Green;
            this.btn_sprzedaj_produkt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sprzedaj_produkt.Location = new System.Drawing.Point(304, 185);
            this.btn_sprzedaj_produkt.Name = "btn_sprzedaj_produkt";
            this.btn_sprzedaj_produkt.Size = new System.Drawing.Size(144, 77);
            this.btn_sprzedaj_produkt.TabIndex = 2;
            this.btn_sprzedaj_produkt.Text = "Sprzedaj";
            this.btn_sprzedaj_produkt.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(50, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 204);
            this.listBox1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(304, 73);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 27);
            this.numericUpDown2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Produkty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sprzedaż";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kajetan Trebnio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(614, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "System komunikacji pomiędzy aplikacją destopową a bazą danych na zewnętrzym serwe" +
    "rze";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(648, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Licencja aktywna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Produkty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Produkty.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Produkty;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button dodaj_produkt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button sprzedaj_produkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opis_produktu;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox cena_promocyjna;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.TextBox cena_produktu;
        private System.Windows.Forms.TextBox cena_promocyjna_produktu;
        private System.Windows.Forms.TextBox nazwa_produktu;
        private System.Windows.Forms.Button btn_dodaj_produkt;
        private System.Windows.Forms.Button btn_dodaj;
        
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btn_sprzedaj_produkt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Produkty_zak;
        private System.Windows.Forms.Button produkty_zak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

