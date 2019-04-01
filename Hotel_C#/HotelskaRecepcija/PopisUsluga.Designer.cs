namespace HotelskaRecepcija
{
    partial class PopisUsluga
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
            this.components = new System.ComponentModel.Container();
            this.recepcijaDataSet = new HotelskaRecepcija.RecepcijaDataSet();
            this.recepcijaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugePopis = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.recepcijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcijaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // recepcijaDataSet
            // 
            this.recepcijaDataSet.DataSetName = "RecepcijaDataSet";
            this.recepcijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recepcijaDataSetBindingSource
            // 
            this.recepcijaDataSetBindingSource.DataSource = this.recepcijaDataSet;
            this.recepcijaDataSetBindingSource.Position = 0;
            // 
            // uslugePopis
            // 
            this.uslugePopis.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.uslugePopis.FormattingEnabled = true;
            this.uslugePopis.ItemHeight = 15;
            this.uslugePopis.Location = new System.Drawing.Point(9, 15);
            this.uslugePopis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uslugePopis.Name = "uslugePopis";
            this.uslugePopis.Size = new System.Drawing.Size(573, 304);
            this.uslugePopis.TabIndex = 0;
            // 
            // PopisUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uslugePopis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PopisUsluga";
            this.Text = "Popis Usluga";
            this.Load += new System.EventHandler(this.PopisUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recepcijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcijaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource recepcijaDataSetBindingSource;
        private RecepcijaDataSet recepcijaDataSet;
        private System.Windows.Forms.ListBox uslugePopis;
    }
}