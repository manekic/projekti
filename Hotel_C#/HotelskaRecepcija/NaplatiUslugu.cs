using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class NaplatiUslugu : Form
    {
        string ukupno;
        int uk = 0;
        public NaplatiUslugu()
        {
            InitializeComponent();
            
            uslugaNaplatiOdabir.Items.Add("teretana");
            uslugaNaplatiOdabir.Items.Add("masaža");
            uslugaNaplatiOdabir.Items.Add("buđenje");
            uslugaNaplatiOdabir.Items.Add("posluga u sobu");
            uslugaNaplatiOdabir.Items.Add("wellness");
        }


        private void btnIspisiRacunZaUslugu_Click(object sender, EventArgs e)
        {
            ukupno = "";
            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT naziv_usluge, cijena FROM TIP_USLUGE WHERE naziv_usluge = @usluga", con);
                cmd.Parameters.AddWithValue("@usluga", uslugaNaplatiOdabir.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["naziv_usluge"].ToString());
                    item.SubItems.Add(dr["cijena"].ToString());
                    listView1.Items.Add(item);
                    ukupno = dr["cijena"].ToString();
                    uk += Int32.Parse(dr["cijena"].ToString());
                }

                kuna.Text = uk.ToString();
                MessageBox.Show("Uspješno naplatili uslugu!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

