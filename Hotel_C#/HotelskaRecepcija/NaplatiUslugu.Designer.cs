namespace HotelskaRecepcija
{
    partial class NaplatiUslugu
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
            this.uslugaNaplati = new System.Windows.Forms.Label();
            this.uslugaNaplatiOdabir = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIspisiRacunZaUslugu = new System.Windows.Forms.Button();
            this.ukupnoKn = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Usluga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kuna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uslugaNaplati
            // 
            this.uslugaNaplati.AutoSize = true;
            this.uslugaNaplati.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.uslugaNaplati.ForeColor = System.Drawing.Color.OrangeRed;
            this.uslugaNaplati.Location = new System.Drawing.Point(21, 22);
            this.uslugaNaplati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uslugaNaplati.Name = "uslugaNaplati";
            this.uslugaNaplati.Size = new System.Drawing.Size(49, 15);
            this.uslugaNaplati.TabIndex = 2;
            this.uslugaNaplati.Text = "Usluga";
            // 
            // uslugaNaplatiOdabir
            // 
            this.uslugaNaplatiOdabir.ForeColor = System.Drawing.Color.OrangeRed;
            this.uslugaNaplatiOdabir.Location = new System.Drawing.Point(78, 21);
            this.uslugaNaplatiOdabir.Margin = new System.Windows.Forms.Padding(2);
            this.uslugaNaplatiOdabir.Name = "uslugaNaplatiOdabir";
            this.uslugaNaplatiOdabir.Size = new System.Drawing.Size(168, 20);
            this.uslugaNaplatiOdabir.TabIndex = 8;
            this.uslugaNaplatiOdabir.Text = "Usluga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(18, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ukupno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(148, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "kn";
            // 
            // btnIspisiRacunZaUslugu
            // 
            this.btnIspisiRacunZaUslugu.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIspisiRacunZaUslugu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnIspisiRacunZaUslugu.Location = new System.Drawing.Point(194, 203);
            this.btnIspisiRacunZaUslugu.Margin = new System.Windows.Forms.Padding(2);
            this.btnIspisiRacunZaUslugu.Name = "btnIspisiRacunZaUslugu";
            this.btnIspisiRacunZaUslugu.Size = new System.Drawing.Size(82, 34);
            this.btnIspisiRacunZaUslugu.TabIndex = 15;
            this.btnIspisiRacunZaUslugu.Text = "ISPIŠI";
            this.btnIspisiRacunZaUslugu.UseVisualStyleBackColor = true;
            this.btnIspisiRacunZaUslugu.Click += new System.EventHandler(this.btnIspisiRacunZaUslugu_Click);
            // 
            // ukupnoKn
            // 
            this.ukupnoKn.AutoSize = true;
            this.ukupnoKn.Location = new System.Drawing.Point(75, 126);
            this.ukupnoKn.Name = "ukupnoKn";
            this.ukupnoKn.Size = new System.Drawing.Size(0, 13);
            this.ukupnoKn.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Usluga,
            this.Cijena});
            this.listView1.Location = new System.Drawing.Point(24, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(222, 117);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Usluga
            // 
            this.Usluga.Text = "Usluga";
            this.Usluga.Width = 119;
            // 
            // Cijena
            // 
            this.Cijena.Text = "Cijena";
            this.Cijena.Width = 95;
            // 
            // kuna
            // 
            this.kuna.AutoSize = true;
            this.kuna.Location = new System.Drawing.Point(93, 214);
            this.kuna.Name = "kuna";
            this.kuna.Size = new System.Drawing.Size(0, 13);
            this.kuna.TabIndex = 18;
            // 
            // NaplatiUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 259);
            this.Controls.Add(this.kuna);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ukupnoKn);
            this.Controls.Add(this.btnIspisiRacunZaUslugu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uslugaNaplatiOdabir);
            this.Controls.Add(this.uslugaNaplati);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NaplatiUslugu";
            this.Text = "Naplati Uslugu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uslugaNaplati;
        private System.Windows.Forms.DomainUpDown uslugaNaplatiOdabir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIspisiRacunZaUslugu;
        private System.Windows.Forms.Label ukupnoKn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Usluga;
        private System.Windows.Forms.ColumnHeader Cijena;
        private System.Windows.Forms.Label kuna;
    }
}