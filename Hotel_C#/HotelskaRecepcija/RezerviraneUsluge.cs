using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class RezerviraneUsluge : Form
    {
        Panel panel_usluge;
        DataGridView dataGridView = new DataGridView()
        {
            BackgroundColor = Color.White,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
            
        };

        public RezerviraneUsluge()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.Text = "Popis svih usluga";
            // this.PerformLayout();

            panel_usluge = new Panel() { Location = new Point(0, 20), BackColor = Color.Transparent, Size = new Size(ClientRectangle.Width, ClientRectangle.Height) };

            this.Controls.Add(panel_usluge);

            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from REZERVACIJE_USLUGA", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                panel_usluge.Controls.Add(dataGridView);

                dataGridView.DataSource = bSource;

                int height = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                    height += row.Height;
                height += dataGridView.ColumnHeadersHeight;

                int width = 0;
                foreach (DataGridViewColumn col in dataGridView.Columns)
                    width += col.Width;
                width += dataGridView.RowHeadersWidth;

                dataGridView.ClientSize = new Size(width * 2, height + 2);
                dataGridView.Location = new Point(0, 20);

                sda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
