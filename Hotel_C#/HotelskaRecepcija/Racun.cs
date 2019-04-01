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
    public partial class Racun : Form
    {
        int idGosta;
        public Racun()
        {
            InitializeComponent();
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            idGosta = 0;
            float suma = 0;
            float cijena = 0;
            String ukupanIznos;

            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

                con.Open();

                SqlCommand cmdd = new SqlCommand("SELECT Id FROM GOSTI WHERE ime=@ime AND prezime=@prezime", con);
                cmdd.Parameters.AddWithValue("@ime", racunIme.Text);
                cmdd.Parameters.AddWithValue("@prezime", racunPrezime.Text);

                SqlDataAdapter sda1 = new SqlDataAdapter(cmdd);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    idGosta = Int32.Parse(dr["Id"].ToString());
                }

                SqlCommand cmd = new SqlCommand("SELECT datum, soba_id, broj_noćenja, cijena_noćenja FROM NOCENJA WHERE gost_id = @IdGost", con);
                cmd.Parameters.AddWithValue("@IdGost", idGosta);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["datum"].ToString());
                    item.SubItems.Add(dr["soba_id"].ToString());
                    item.SubItems.Add(dr["broj_noćenja"].ToString());
                    item.SubItems.Add(dr["cijena_noćenja"].ToString());

                    int ukupno_int = Int32.Parse(dr["broj_noćenja"].ToString()) * Int32.Parse(dr["cijena_noćenja"].ToString());
                    ukupanIznos = ukupno_int.ToString();
                    cijena = float.Parse(ukupanIznos);
                    suma += cijena;
                    listView1.Items.Add(item);
                }

                label5.Text = suma.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}