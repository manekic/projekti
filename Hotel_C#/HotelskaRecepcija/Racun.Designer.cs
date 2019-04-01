namespace HotelskaRecepcija
{
    partial class Racun
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.racunIme = new System.Windows.Forms.TextBox();
            this.racunPrezime = new System.Windows.Forms.TextBox();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BrojNocenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Datum,
            this.Soba,
            this.BrojNocenja,
            this.Cijena});
            this.listView1.Location = new System.Drawing.Point(40, 151);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 156);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum dolaska";
            this.Datum.Width = 105;
            // 
            // Soba
            // 
            this.Soba.Text = "Soba";
            this.Soba.Width = 81;
            // 
            // Cijena
            // 
            this.Cijena.Text = "Cijena";
            this.Cijena.Width = 96;
            // 
            // racunIme
            // 
            this.racunIme.Location = new System.Drawing.Point(136, 43);
            this.racunIme.Margin = new System.Windows.Forms.Padding(2);
            this.racunIme.Name = "racunIme";
            this.racunIme.Size = new System.Drawing.Size(109, 20);
            this.racunIme.TabIndex = 3;
            // 
            // racunPrezime
            // 
            this.racunPrezime.Location = new System.Drawing.Point(136, 98);
            this.racunPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.racunPrezime.Name = "racunPrezime";
            this.racunPrezime.Size = new System.Drawing.Size(109, 20);
            this.racunPrezime.TabIndex = 4;
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnIzdajRacun.Location = new System.Drawing.Point(350, 57);
            this.btnIzdajRacun.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(93, 43);
            this.btnIzdajRacun.TabIndex = 5;
            this.btnIzdajRacun.Text = "IZDAJ RAČUN";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(280, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ukupno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(430, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "€";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // BrojNocenja
            // 
            this.BrojNocenja.Text = "Broj noćenja";
            this.BrojNocenja.Width = 96;
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.racunPrezime);
            this.Controls.Add(this.racunIme);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Racun";
            this.Text = "Racun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox racunIme;
        private System.Windows.Forms.TextBox racunPrezime;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Soba;
        private System.Windows.Forms.ColumnHeader Cijena;
        private System.Windows.Forms.ColumnHeader BrojNocenja;
    }
}