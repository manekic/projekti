namespace HotelskaRecepcija
{
    partial class KarakteristikeSoba
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
            System.Windows.Forms.Label kATLabel;
            System.Windows.Forms.Label cIJENA_NOCENJALabel;
            System.Windows.Forms.Label idLabel;
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CijenaNoćenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxKarakteristike = new System.Windows.Forms.GroupBox();
            this.jaccuzziCheckBox = new System.Windows.Forms.CheckBox();
            this.tvCheckBox = new System.Windows.Forms.CheckBox();
            this.minibarCheckBox = new System.Windows.Forms.CheckBox();
            this.klimaCheckBox = new System.Windows.Forms.CheckBox();
            this.pOGLEDCheckBox = new System.Windows.Forms.CheckBox();
            this.aPARTMANCheckBox = new System.Windows.Forms.CheckBox();
            this.kATTextBox = new System.Windows.Forms.TextBox();
            this.cIJENA_NOCENJATextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxDozvoliPromjene = new System.Windows.Forms.CheckBox();
            this.buttonZatvori = new System.Windows.Forms.Button();
            kATLabel = new System.Windows.Forms.Label();
            cIJENA_NOCENJALabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.groupBoxKarakteristike.SuspendLayout();
            this.SuspendLayout();
            // 
            // kATLabel
            // 
            kATLabel.AutoSize = true;
            kATLabel.Location = new System.Drawing.Point(85, 102);
            kATLabel.Name = "kATLabel";
            kATLabel.Size = new System.Drawing.Size(23, 13);
            kATLabel.TabIndex = 6;
            kATLabel.Text = "Kat";
            // 
            // cIJENA_NOCENJALabel
            // 
            cIJENA_NOCENJALabel.AutoSize = true;
            cIJENA_NOCENJALabel.Location = new System.Drawing.Point(31, 68);
            cIJENA_NOCENJALabel.Name = "cIJENA_NOCENJALabel";
            cIJENA_NOCENJALabel.Size = new System.Drawing.Size(77, 13);
            cIJENA_NOCENJALabel.TabIndex = 4;
            cIJENA_NOCENJALabel.Text = "Cijena noćenja";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(57, 38);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(51, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Broj sobe";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.CijenaNoćenja,
            this.Kat});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(242, 367);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Id
            // 
            this.Id.Text = "Id sobe";
            this.Id.Width = 74;
            // 
            // CijenaNoćenja
            // 
            this.CijenaNoćenja.Text = "Cijena noćenja";
            this.CijenaNoćenja.Width = 80;
            // 
            // Kat
            // 
            this.Kat.Text = "Kat";
            this.Kat.Width = 74;
            // 
            // groupBoxKarakteristike
            // 
            this.groupBoxKarakteristike.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKarakteristike.Controls.Add(this.jaccuzziCheckBox);
            this.groupBoxKarakteristike.Controls.Add(this.tvCheckBox);
            this.groupBoxKarakteristike.Controls.Add(this.minibarCheckBox);
            this.groupBoxKarakteristike.Controls.Add(this.klimaCheckBox);
            this.groupBoxKarakteristike.Controls.Add(this.pOGLEDCheckBox);
            this.groupBoxKarakteristike.Controls.Add(this.aPARTMANCheckBox);
            this.groupBoxKarakteristike.Controls.Add(this.kATTextBox);
            this.groupBoxKarakteristike.Controls.Add(kATLabel);
            this.groupBoxKarakteristike.Controls.Add(this.cIJENA_NOCENJATextBox);
            this.groupBoxKarakteristike.Controls.Add(cIJENA_NOCENJALabel);
            this.groupBoxKarakteristike.Controls.Add(idLabel);
            this.groupBoxKarakteristike.Controls.Add(this.idTextBox);
            this.groupBoxKarakteristike.Location = new System.Drawing.Point(274, 12);
            this.groupBoxKarakteristike.Name = "groupBoxKarakteristike";
            this.groupBoxKarakteristike.Size = new System.Drawing.Size(262, 292);
            this.groupBoxKarakteristike.TabIndex = 2;
            this.groupBoxKarakteristike.TabStop = false;
            this.groupBoxKarakteristike.Text = "Karakteristike sobe";
            // 
            // jaccuzziCheckBox
            // 
            this.jaccuzziCheckBox.AutoSize = true;
            this.jaccuzziCheckBox.Enabled = false;
            this.jaccuzziCheckBox.Location = new System.Drawing.Point(25, 261);
            this.jaccuzziCheckBox.Name = "jaccuzziCheckBox";
            this.jaccuzziCheckBox.Size = new System.Drawing.Size(61, 17);
            this.jaccuzziCheckBox.TabIndex = 20;
            this.jaccuzziCheckBox.Text = "Jacuzzi";
            this.jaccuzziCheckBox.UseVisualStyleBackColor = true;
            this.jaccuzziCheckBox.CheckedChanged += new System.EventHandler(this.jaccuzziCheckBox_CheckedChanged);
            // 
            // tvCheckBox
            // 
            this.tvCheckBox.AutoSize = true;
            this.tvCheckBox.Enabled = false;
            this.tvCheckBox.Location = new System.Drawing.Point(25, 238);
            this.tvCheckBox.Name = "tvCheckBox";
            this.tvCheckBox.Size = new System.Drawing.Size(40, 17);
            this.tvCheckBox.TabIndex = 18;
            this.tvCheckBox.Text = "TV";
            this.tvCheckBox.UseVisualStyleBackColor = true;
            this.tvCheckBox.CheckedChanged += new System.EventHandler(this.tvCheckBox_CheckedChanged);
            // 
            // minibarCheckBox
            // 
            this.minibarCheckBox.AutoSize = true;
            this.minibarCheckBox.Enabled = false;
            this.minibarCheckBox.Location = new System.Drawing.Point(25, 215);
            this.minibarCheckBox.Name = "minibarCheckBox";
            this.minibarCheckBox.Size = new System.Drawing.Size(94, 17);
            this.minibarCheckBox.TabIndex = 16;
            this.minibarCheckBox.Text = "Mini-bar u sobi";
            this.minibarCheckBox.UseVisualStyleBackColor = true;
            this.minibarCheckBox.CheckedChanged += new System.EventHandler(this.minibarCheckBox_CheckedChanged);
            // 
            // klimaCheckBox
            // 
            this.klimaCheckBox.AutoSize = true;
            this.klimaCheckBox.Enabled = false;
            this.klimaCheckBox.Location = new System.Drawing.Point(25, 192);
            this.klimaCheckBox.Name = "klimaCheckBox";
            this.klimaCheckBox.Size = new System.Drawing.Size(84, 17);
            this.klimaCheckBox.TabIndex = 14;
            this.klimaCheckBox.Text = "Klima uređaj";
            this.klimaCheckBox.UseVisualStyleBackColor = true;
            this.klimaCheckBox.CheckedChanged += new System.EventHandler(this.klimaCheckBox_CheckedChanged);
            // 
            // pOGLEDCheckBox
            // 
            this.pOGLEDCheckBox.AutoSize = true;
            this.pOGLEDCheckBox.Enabled = false;
            this.pOGLEDCheckBox.Location = new System.Drawing.Point(25, 169);
            this.pOGLEDCheckBox.Name = "pOGLEDCheckBox";
            this.pOGLEDCheckBox.Size = new System.Drawing.Size(100, 17);
            this.pOGLEDCheckBox.TabIndex = 10;
            this.pOGLEDCheckBox.Text = "Pogled na more";
            this.pOGLEDCheckBox.UseVisualStyleBackColor = true;
            this.pOGLEDCheckBox.CheckedChanged += new System.EventHandler(this.pOGLEDCheckBox_CheckedChanged);
            // 
            // aPARTMANCheckBox
            // 
            this.aPARTMANCheckBox.AutoSize = true;
            this.aPARTMANCheckBox.Enabled = false;
            this.aPARTMANCheckBox.Location = new System.Drawing.Point(25, 146);
            this.aPARTMANCheckBox.Name = "aPARTMANCheckBox";
            this.aPARTMANCheckBox.Size = new System.Drawing.Size(71, 17);
            this.aPARTMANCheckBox.TabIndex = 8;
            this.aPARTMANCheckBox.Text = "Apartman";
            this.aPARTMANCheckBox.UseVisualStyleBackColor = true;
            this.aPARTMANCheckBox.CheckedChanged += new System.EventHandler(this.aPARTMANCheckBox_CheckedChanged);
            // 
            // kATTextBox
            // 
            this.kATTextBox.Enabled = false;
            this.kATTextBox.Location = new System.Drawing.Point(114, 99);
            this.kATTextBox.Name = "kATTextBox";
            this.kATTextBox.Size = new System.Drawing.Size(104, 20);
            this.kATTextBox.TabIndex = 7;
            // 
            // cIJENA_NOCENJATextBox
            // 
            this.cIJENA_NOCENJATextBox.Enabled = false;
            this.cIJENA_NOCENJATextBox.Location = new System.Drawing.Point(114, 65);
            this.cIJENA_NOCENJATextBox.Name = "cIJENA_NOCENJATextBox";
            this.cIJENA_NOCENJATextBox.Size = new System.Drawing.Size(104, 20);
            this.cIJENA_NOCENJATextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(114, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // checkBoxDozvoliPromjene
            // 
            this.checkBoxDozvoliPromjene.AutoSize = true;
            this.checkBoxDozvoliPromjene.Location = new System.Drawing.Point(274, 322);
            this.checkBoxDozvoliPromjene.Name = "checkBoxDozvoliPromjene";
            this.checkBoxDozvoliPromjene.Size = new System.Drawing.Size(107, 17);
            this.checkBoxDozvoliPromjene.TabIndex = 3;
            this.checkBoxDozvoliPromjene.Text = "Dozvoli promjene";
            this.checkBoxDozvoliPromjene.UseVisualStyleBackColor = true;
            this.checkBoxDozvoliPromjene.CheckedChanged += new System.EventHandler(this.checkBoxDozvoliPromjene_CheckedChanged);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonZatvori.Location = new System.Drawing.Point(274, 354);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(262, 25);
            this.buttonZatvori.TabIndex = 11;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            // 
            // KarakteristikeSoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 394);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.checkBoxDozvoliPromjene);
            this.Controls.Add(this.groupBoxKarakteristike);
            this.Controls.Add(this.listView1);
            this.Name = "KarakteristikeSoba";
            this.Text = "KarakteristikeSoba";
            this.Load += new System.EventHandler(this.KarakteristikeSoba_Load);
            this.groupBoxKarakteristike.ResumeLayout(false);
            this.groupBoxKarakteristike.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader CijenaNoćenja;
        private System.Windows.Forms.ColumnHeader Kat;
        private System.Windows.Forms.GroupBox groupBoxKarakteristike;
        private System.Windows.Forms.CheckBox jaccuzziCheckBox;
        private System.Windows.Forms.CheckBox tvCheckBox;
        private System.Windows.Forms.CheckBox minibarCheckBox;
        private System.Windows.Forms.CheckBox klimaCheckBox;
        private System.Windows.Forms.CheckBox pOGLEDCheckBox;
        private System.Windows.Forms.CheckBox aPARTMANCheckBox;
        private System.Windows.Forms.TextBox kATTextBox;
        private System.Windows.Forms.TextBox cIJENA_NOCENJATextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.CheckBox checkBoxDozvoliPromjene;
        private System.Windows.Forms.Button buttonZatvori;
    }
}