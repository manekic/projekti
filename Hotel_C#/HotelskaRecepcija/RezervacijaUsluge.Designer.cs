namespace HotelskaRecepcija
{
    partial class RezervacijaUsluge
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRezUslugu = new System.Windows.Forms.Button();
            this.rezUslugaIme = new System.Windows.Forms.TextBox();
            this.rezUslugaPrezime = new System.Windows.Forms.TextBox();
            this.datumrezUsluge = new System.Windows.Forms.DateTimePicker();
            this.rezUsluga = new System.Windows.Forms.DomainUpDown();
            this.terminRezUsluge = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(32, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usluga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(32, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(32, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Termin";
            // 
            // btnRezUslugu
            // 
            this.btnRezUslugu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRezUslugu.Location = new System.Drawing.Point(314, 367);
            this.btnRezUslugu.Name = "btnRezUslugu";
            this.btnRezUslugu.Size = new System.Drawing.Size(135, 48);
            this.btnRezUslugu.TabIndex = 5;
            this.btnRezUslugu.Text = "REZERVIRAJ";
            this.btnRezUslugu.UseVisualStyleBackColor = true;
            this.btnRezUslugu.Click += new System.EventHandler(this.btnRezUslugu_Click);
            // 
            // rezUslugaIme
            // 
            this.rezUslugaIme.Location = new System.Drawing.Point(240, 45);
            this.rezUslugaIme.Name = "rezUslugaIme";
            this.rezUslugaIme.Size = new System.Drawing.Size(215, 22);
            this.rezUslugaIme.TabIndex = 6;
            // 
            // rezUslugaPrezime
            // 
            this.rezUslugaPrezime.Location = new System.Drawing.Point(240, 103);
            this.rezUslugaPrezime.Name = "rezUslugaPrezime";
            this.rezUslugaPrezime.Size = new System.Drawing.Size(215, 22);
            this.rezUslugaPrezime.TabIndex = 7;
            // 
            // datumrezUsluge
            // 
            this.datumrezUsluge.Location = new System.Drawing.Point(240, 212);
            this.datumrezUsluge.Name = "datumrezUsluge";
            this.datumrezUsluge.Size = new System.Drawing.Size(215, 22);
            this.datumrezUsluge.TabIndex = 8;
            // 
            // rezUsluga
            // 
            this.rezUsluga.ForeColor = System.Drawing.Color.OrangeRed;
            this.rezUsluga.Location = new System.Drawing.Point(240, 156);
            this.rezUsluga.Name = "rezUsluga";
            this.rezUsluga.Size = new System.Drawing.Size(215, 22);
            this.rezUsluga.TabIndex = 10;
            this.rezUsluga.Text = "Usluga";
            // 
            // terminRezUsluge
            // 
            this.terminRezUsluge.ForeColor = System.Drawing.Color.OrangeRed;
            this.terminRezUsluge.Location = new System.Drawing.Point(240, 281);
            this.terminRezUsluge.Name = "terminRezUsluge";
            this.terminRezUsluge.Size = new System.Drawing.Size(215, 22);
            this.terminRezUsluge.TabIndex = 11;
            this.terminRezUsluge.Text = "Termin";
            // 
            // RezervacijaUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.terminRezUsluge);
            this.Controls.Add(this.rezUsluga);
            this.Controls.Add(this.datumrezUsluge);
            this.Controls.Add(this.rezUslugaPrezime);
            this.Controls.Add(this.rezUslugaIme);
            this.Controls.Add(this.btnRezUslugu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RezervacijaUsluge";
            this.Text = "Rezervacija Usluge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRezUslugu;
        private System.Windows.Forms.TextBox rezUslugaIme;
        private System.Windows.Forms.TextBox rezUslugaPrezime;
        private System.Windows.Forms.DateTimePicker datumrezUsluge;
        private System.Windows.Forms.DomainUpDown rezUsluga;
        private System.Windows.Forms.DomainUpDown terminRezUsluge;
    }
}