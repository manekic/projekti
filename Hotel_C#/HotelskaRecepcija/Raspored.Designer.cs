namespace HotelskaRecepcija
{
    partial class Raspored
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
            this.rasporedZaposlenika = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rasporedZaposlenika
            // 
            this.rasporedZaposlenika.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.rasporedZaposlenika.FormattingEnabled = true;
            this.rasporedZaposlenika.ItemHeight = 15;
            this.rasporedZaposlenika.Location = new System.Drawing.Point(10, 11);
            this.rasporedZaposlenika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rasporedZaposlenika.Name = "rasporedZaposlenika";
            this.rasporedZaposlenika.Size = new System.Drawing.Size(573, 334);
            this.rasporedZaposlenika.TabIndex = 0;
            // 
            // Raspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.rasporedZaposlenika);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Raspored";
            this.Text = "Raspored";
            this.Load += new System.EventHandler(this.Raspored_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rasporedZaposlenika;
    }
}