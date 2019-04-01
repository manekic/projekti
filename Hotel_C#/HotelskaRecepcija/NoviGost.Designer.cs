namespace HotelskaRecepcija
{
    partial class NoviGost
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
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.noviGostIme = new System.Windows.Forms.TextBox();
            this.noviGostPrezime = new System.Windows.Forms.TextBox();
            this.btnDodajGosta = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelBrojNocenja = new System.Windows.Forms.Label();
            this.labelDatumDolaska = new System.Windows.Forms.Label();
            this.noviGostId = new System.Windows.Forms.TextBox();
            this.noviGostBrojNocenja = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodavanje novog gosta";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.ForeColor = System.Drawing.Color.DarkRed;
            this.labelIme.Location = new System.Drawing.Point(25, 59);
            this.labelIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(24, 13);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPrezime.Location = new System.Drawing.Point(25, 98);
            this.labelPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(44, 13);
            this.labelPrezime.TabIndex = 2;
            this.labelPrezime.Text = "Prezime";
            // 
            // noviGostIme
            // 
            this.noviGostIme.Location = new System.Drawing.Point(148, 56);
            this.noviGostIme.Margin = new System.Windows.Forms.Padding(2);
            this.noviGostIme.Name = "noviGostIme";
            this.noviGostIme.Size = new System.Drawing.Size(131, 20);
            this.noviGostIme.TabIndex = 3;
            // 
            // noviGostPrezime
            // 
            this.noviGostPrezime.Location = new System.Drawing.Point(148, 95);
            this.noviGostPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.noviGostPrezime.Name = "noviGostPrezime";
            this.noviGostPrezime.Size = new System.Drawing.Size(131, 20);
            this.noviGostPrezime.TabIndex = 4;
            // 
            // btnDodajGosta
            // 
            this.btnDodajGosta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDodajGosta.Location = new System.Drawing.Point(38, 273);
            this.btnDodajGosta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajGosta.Name = "btnDodajGosta";
            this.btnDodajGosta.Size = new System.Drawing.Size(84, 30);
            this.btnDodajGosta.TabIndex = 5;
            this.btnDodajGosta.Text = "DODAJ";
            this.btnDodajGosta.UseVisualStyleBackColor = true;
            this.btnDodajGosta.Click += new System.EventHandler(this.btnDodajGosta_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnZatvori.Location = new System.Drawing.Point(176, 273);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(76, 30);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.Color.DarkRed;
            this.labelId.Location = new System.Drawing.Point(25, 139);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(97, 13);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id sobe/apartmana";
            // 
            // labelBrojNocenja
            // 
            this.labelBrojNocenja.AutoSize = true;
            this.labelBrojNocenja.ForeColor = System.Drawing.Color.DarkRed;
            this.labelBrojNocenja.Location = new System.Drawing.Point(25, 178);
            this.labelBrojNocenja.Name = "labelBrojNocenja";
            this.labelBrojNocenja.Size = new System.Drawing.Size(66, 13);
            this.labelBrojNocenja.TabIndex = 8;
            this.labelBrojNocenja.Text = "Broj noćenja";
            // 
            // labelDatumDolaska
            // 
            this.labelDatumDolaska.AutoSize = true;
            this.labelDatumDolaska.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDatumDolaska.Location = new System.Drawing.Point(25, 218);
            this.labelDatumDolaska.Name = "labelDatumDolaska";
            this.labelDatumDolaska.Size = new System.Drawing.Size(78, 13);
            this.labelDatumDolaska.TabIndex = 9;
            this.labelDatumDolaska.Text = "Datum dolaska";
            // 
            // noviGostId
            // 
            this.noviGostId.Location = new System.Drawing.Point(148, 136);
            this.noviGostId.Name = "noviGostId";
            this.noviGostId.Size = new System.Drawing.Size(131, 20);
            this.noviGostId.TabIndex = 10;
            // 
            // noviGostBrojNocenja
            // 
            this.noviGostBrojNocenja.Location = new System.Drawing.Point(148, 175);
            this.noviGostBrojNocenja.Name = "noviGostBrojNocenja";
            this.noviGostBrojNocenja.Size = new System.Drawing.Size(131, 20);
            this.noviGostBrojNocenja.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 212);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // NoviGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 329);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.noviGostBrojNocenja);
            this.Controls.Add(this.noviGostId);
            this.Controls.Add(this.labelDatumDolaska);
            this.Controls.Add(this.labelBrojNocenja);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnDodajGosta);
            this.Controls.Add(this.noviGostPrezime);
            this.Controls.Add(this.noviGostIme);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NoviGost";
            this.Text = "Novi gost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox noviGostIme;
        private System.Windows.Forms.TextBox noviGostPrezime;
        private System.Windows.Forms.Button btnDodajGosta;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelBrojNocenja;
        private System.Windows.Forms.Label labelDatumDolaska;
        private System.Windows.Forms.TextBox noviGostId;
        private System.Windows.Forms.TextBox noviGostBrojNocenja;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}