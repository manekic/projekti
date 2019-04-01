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
    public partial class PromjenaZaduženja : Form
    {
        public PromjenaZaduženja()
        {
            InitializeComponent();
            novoZaduzenje.Items.Add("Kuhinja");
            novoZaduzenje.Items.Add("Teretana");
            novoZaduzenje.Items.Add("Recepcija");
            novoZaduzenje.Items.Add("Wellness");
            novoZaduzenje.Items.Add("Sobarica");
            novaSmjena.Items.Add("07:00");
            novaSmjena.Items.Add("08:00");
            novaSmjena.Items.Add("14:00");
            novaSmjena.Items.Add("15:00");
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            if(imePromjena.Text == "" || prezimePromjena.Text == "")
            {
                MessageBox.Show("Morate unijeti tražene podatke!");
                return;
            }

            string ime = imePromjena.Text;
            string prezime = prezimePromjena.Text;
            string zaduzenje = novoZaduzenje.Text;
            string smjena = novaSmjena.Text;

            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

                con.Open();
                
                string select = "SELECT * FROM OSOBLJE WHERE ime=@ime AND prezime=@prezime";
                SqlCommand cmds = new SqlCommand(select, con);
                cmds.Parameters.AddWithValue("@ime", ime);
                cmds.Parameters.AddWithValue("@prezime", prezime);

                SqlDataAdapter sdas = new SqlDataAdapter(cmds);
                DataTable dts = new DataTable();
                sdas.Fill(dts);

                if (dts.Rows.Count == 0)
                {
                    MessageBox.Show("Ne postoji zaposlenik pod tim imenom i prezimenom.");
                    imePromjena.Text = "";
                    prezimePromjena.Text = "";
                    return;
                }

                string update = " UPDATE OSOBLJE SET zaduženje=@zaduzenje, " +
                    " početak=@pocetak, " + " kraj=@kraj, " + " smjena=@smjena WHERE ime=@ime AND prezime=@prezime";
                SqlCommand cmd = new SqlCommand(update, con);

                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@zaduzenje", zaduzenje);
                cmd.Parameters.Add("@pocetak", SqlDbType.Date).Value = pocNovogZaduzenja.Value.Date;
                cmd.Parameters.Add("@kraj", SqlDbType.Date).Value = krajNovogZad.Value.Date;
                cmd.Parameters.AddWithValue("@smjena", smjena);
                
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                
                cmd.ExecuteNonQuery();
                sda.Update(dt);
                con.Close();
                MessageBox.Show("Zaduženje promijenjeno.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
