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
    public partial class RezervacijaUsluge : Form
    {
        public RezervacijaUsluge()
        {
            InitializeComponent();
            rezUsluga.Items.Add("ručak");
            rezUsluga.Items.Add("teretana");
            rezUsluga.Items.Add("masaza");
            rezUsluga.Items.Add("buđenje");
            rezUsluga.Items.Add("wellness");
            rezUsluga.Items.Add("posluga u sobu");
            terminRezUsluge.Items.Add("07:00");
            terminRezUsluge.Items.Add("08:00");
            terminRezUsluge.Items.Add("10:00");
            terminRezUsluge.Items.Add("15:00");
            terminRezUsluge.Items.Add("17:00");

        }

        private void btnRezUslugu_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

                con.Open();


                string insert = "insert into REZERVACIJE_USLUGA (ime, prezime, usluga, datum, termin) values ('" + rezUslugaIme.Text + "','" + rezUslugaPrezime.Text + "','"
                                                        + rezUsluga.Text + "',@Date ,'"
                                                        + terminRezUsluge.Text + "')";

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = datumrezUsluge.Value.Date;
                cmd.ExecuteNonQuery();
                sda.Update(dt);
                con.Close();
                MessageBox.Show("Uspješno ste rezervirali uslugu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
