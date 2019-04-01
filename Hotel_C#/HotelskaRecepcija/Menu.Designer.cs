namespace HotelskaRecepcija
{
    partial class Menu
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
            this.slastice = new System.Windows.Forms.Button();
            this.dorucak = new System.Windows.Forms.Button();
            this.rucakVecera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slastice
            // 
            this.slastice.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.slastice.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.slastice.Location = new System.Drawing.Point(40, 212);
            this.slastice.Name = "slastice";
            this.slastice.Size = new System.Drawing.Size(304, 50);
            this.slastice.TabIndex = 2;
            this.slastice.Text = "Slastice";
            this.slastice.UseVisualStyleBackColor = false;
            this.slastice.Click += new System.EventHandler(this.slastice_Click);
            // 
            // dorucak
            // 
            this.dorucak.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.dorucak.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.dorucak.Location = new System.Drawing.Point(40, 25);
            this.dorucak.Name = "dorucak";
            this.dorucak.Size = new System.Drawing.Size(304, 50);
            this.dorucak.TabIndex = 3;
            this.dorucak.Text = "Doručak";
            this.dorucak.UseVisualStyleBackColor = false;
            this.dorucak.Click += new System.EventHandler(this.dorucak_Click);
            // 
            // rucakVecera
            // 
            this.rucakVecera.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.rucakVecera.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.rucakVecera.Location = new System.Drawing.Point(40, 118);
            this.rucakVecera.Name = "rucakVecera";
            this.rucakVecera.Size = new System.Drawing.Size(304, 50);
            this.rucakVecera.TabIndex = 4;
            this.rucakVecera.Text = "Jela po izboru";
            this.rucakVecera.UseVisualStyleBackColor = false;
            this.rucakVecera.Click += new System.EventHandler(this.rucakVecera_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(385, 293);
            this.Controls.Add(this.rucakVecera);
            this.Controls.Add(this.dorucak);
            this.Controls.Add(this.slastice);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button slastice;
        private System.Windows.Forms.Button dorucak;
        private System.Windows.Forms.Button rucakVecera;
    }
}