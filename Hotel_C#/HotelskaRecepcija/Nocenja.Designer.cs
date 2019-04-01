namespace HotelskaRecepcija
{
    partial class Nocenja
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
            this.hR_NOCENJADataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPregledNocenjaZatvori = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdSobe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CijenaNoćenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImeGosta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezimeGosta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojNocenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdNocenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJADataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hR_NOCENJADataGridView
            // 
            this.hR_NOCENJADataGridView.AllowUserToAddRows = false;
            this.hR_NOCENJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hR_NOCENJADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hR_NOCENJADataGridView.Location = new System.Drawing.Point(0, 0);
            this.hR_NOCENJADataGridView.Name = "hR_NOCENJADataGridView";
            this.hR_NOCENJADataGridView.ReadOnly = true;
            this.hR_NOCENJADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hR_NOCENJADataGridView.Size = new System.Drawing.Size(556, 363);
            this.hR_NOCENJADataGridView.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonPregledNocenjaZatvori);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 327);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 36);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonPregledNocenjaZatvori
            // 
            this.buttonPregledNocenjaZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPregledNocenjaZatvori.Location = new System.Drawing.Point(478, 3);
            this.buttonPregledNocenjaZatvori.Name = "buttonPregledNocenjaZatvori";
            this.buttonPregledNocenjaZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonPregledNocenjaZatvori.TabIndex = 1;
            this.buttonPregledNocenjaZatvori.Text = "Zatvori";
            this.buttonPregledNocenjaZatvori.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdNocenja,
            this.ImeGosta,
            this.PrezimeGosta,
            this.IdSobe,
            this.BrojNocenja,
            this.CijenaNoćenja,
            this.Datum});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(556, 327);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IdSobe
            // 
            this.IdSobe.DisplayIndex = 3;
            this.IdSobe.Text = "Id sobe";
            this.IdSobe.Width = 71;
            // 
            // CijenaNoćenja
            // 
            this.CijenaNoćenja.DisplayIndex = 5;
            this.CijenaNoćenja.Text = "Cijena noćenja";
            this.CijenaNoćenja.Width = 85;
            // 
            // Datum
            // 
            this.Datum.DisplayIndex = 6;
            this.Datum.Text = "Datum dolaska";
            this.Datum.Width = 90;
            // 
            // ImeGosta
            // 
            this.ImeGosta.DisplayIndex = 1;
            this.ImeGosta.Text = "Ime gosta";
            this.ImeGosta.Width = 78;
            // 
            // PrezimeGosta
            // 
            this.PrezimeGosta.DisplayIndex = 2;
            this.PrezimeGosta.Text = "Prezime gosta";
            this.PrezimeGosta.Width = 87;
            // 
            // BrojNocenja
            // 
            this.BrojNocenja.DisplayIndex = 4;
            this.BrojNocenja.Text = "Broj noćenja";
            this.BrojNocenja.Width = 71;
            // 
            // IdNocenja
            // 
            this.IdNocenja.DisplayIndex = 0;
            this.IdNocenja.Text = "Id noćenja";
            this.IdNocenja.Width = 65;
            // 
            // Nocenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 363);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.hR_NOCENJADataGridView);
            this.Name = "Nocenja";
            this.Text = "Nocenja";
            this.Load += new System.EventHandler(this.Nocenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJADataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hR_NOCENJADataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPregledNocenjaZatvori;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdSobe;
        private System.Windows.Forms.ColumnHeader CijenaNoćenja;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader ImeGosta;
        private System.Windows.Forms.ColumnHeader PrezimeGosta;
        private System.Windows.Forms.ColumnHeader BrojNocenja;
        private System.Windows.Forms.ColumnHeader IdNocenja;
    }
}