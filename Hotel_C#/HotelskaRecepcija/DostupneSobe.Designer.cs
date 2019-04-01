namespace HotelskaRecepcija
{
    partial class DostupneSobe
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
            System.Windows.Forms.Label idLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.prikaziKarakteristikeButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelKat = new System.Windows.Forms.Label();
            this.labelKarakteristike = new System.Windows.Forms.Label();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxKat = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxDostupnost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDostupnost = new System.Windows.Forms.Label();
            this.labelDostupnostOdgovor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(24, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(54, 13);
            idLabel.TabIndex = 18;
            idLabel.Text = "Broj sobe:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(84, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 21;
            // 
            // prikaziKarakteristikeButton
            // 
            this.prikaziKarakteristikeButton.Location = new System.Drawing.Point(27, 56);
            this.prikaziKarakteristikeButton.Name = "prikaziKarakteristikeButton";
            this.prikaziKarakteristikeButton.Size = new System.Drawing.Size(158, 39);
            this.prikaziKarakteristikeButton.TabIndex = 22;
            this.prikaziKarakteristikeButton.Text = "Prikaži karakteristike i dostupnost";
            this.prikaziKarakteristikeButton.UseVisualStyleBackColor = true;
            this.prikaziKarakteristikeButton.Click += new System.EventHandler(this.prikaziKarakteristikeButton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(113, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(72, 145);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonZatvori.Location = new System.Drawing.Point(293, 270);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(132, 25);
            this.buttonZatvori.TabIndex = 24;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(24, 111);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(80, 13);
            this.labelCijena.TabIndex = 25;
            this.labelCijena.Text = "Cijena noćenja:";
            // 
            // labelKat
            // 
            this.labelKat.AutoSize = true;
            this.labelKat.Location = new System.Drawing.Point(24, 135);
            this.labelKat.Name = "labelKat";
            this.labelKat.Size = new System.Drawing.Size(26, 13);
            this.labelKat.TabIndex = 26;
            this.labelKat.Text = "Kat:";
            // 
            // labelKarakteristike
            // 
            this.labelKarakteristike.AutoSize = true;
            this.labelKarakteristike.Location = new System.Drawing.Point(24, 159);
            this.labelKarakteristike.Name = "labelKarakteristike";
            this.labelKarakteristike.Size = new System.Drawing.Size(74, 13);
            this.labelKarakteristike.TabIndex = 27;
            this.labelKarakteristike.Text = "Karakteristike:";
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCijena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCijena.Enabled = false;
            this.textBoxCijena.Location = new System.Drawing.Point(114, 111);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(71, 13);
            this.textBoxCijena.TabIndex = 28;
            // 
            // textBoxKat
            // 
            this.textBoxKat.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxKat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKat.Enabled = false;
            this.textBoxKat.Location = new System.Drawing.Point(113, 135);
            this.textBoxKat.Name = "textBoxKat";
            this.textBoxKat.Size = new System.Drawing.Size(72, 13);
            this.textBoxKat.TabIndex = 29;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(226, 45);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 30;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBoxDostupnost
            // 
            this.textBoxDostupnost.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDostupnost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDostupnost.Enabled = false;
            this.textBoxDostupnost.Location = new System.Drawing.Point(349, 301);
            this.textBoxDostupnost.Name = "textBoxDostupnost";
            this.textBoxDostupnost.Size = new System.Drawing.Size(138, 13);
            this.textBoxDostupnost.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Odaberite datum:";
            // 
            // labelDostupnost
            // 
            this.labelDostupnost.AutoSize = true;
            this.labelDostupnost.Location = new System.Drawing.Point(223, 231);
            this.labelDostupnost.Name = "labelDostupnost";
            this.labelDostupnost.Size = new System.Drawing.Size(64, 13);
            this.labelDostupnost.TabIndex = 37;
            this.labelDostupnost.Text = "Dostupnost:";
            // 
            // labelDostupnostOdgovor
            // 
            this.labelDostupnostOdgovor.AutoSize = true;
            this.labelDostupnostOdgovor.Location = new System.Drawing.Point(337, 238);
            this.labelDostupnostOdgovor.Name = "labelDostupnostOdgovor";
            this.labelDostupnostOdgovor.Size = new System.Drawing.Size(0, 13);
            this.labelDostupnostOdgovor.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(293, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 40;
            // 
            // DostupneSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(456, 316);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDostupnostOdgovor);
            this.Controls.Add(this.labelDostupnost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDostupnost);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxKat);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.labelKarakteristike);
            this.Controls.Add(this.labelKat);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.prikaziKarakteristikeButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DostupneSobe";
            this.Text = "Dostupne sobe";
            this.Load += new System.EventHandler(this.DostupneSobe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button prikaziKarakteristikeButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelKat;
        private System.Windows.Forms.Label labelKarakteristike;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxKat;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxDostupnost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDostupnost;
        private System.Windows.Forms.Label labelDostupnostOdgovor;
        private System.Windows.Forms.TextBox textBox1;
    }
}