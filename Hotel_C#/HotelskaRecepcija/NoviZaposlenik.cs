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
    public partial class DodajZaposlenika : Form
    {
        public DodajZaposlenika()
        {
            InitializeComponent();

            zaposlenikZaduzenje.Items.Add("Kuhinja");
            zaposlenikZaduzenje.Items.Add("Teretana");
            zaposlenikZaduzenje.Items.Add("Recepcija");
            zaposlenikZaduzenje.Items.Add("Wellness");
            zaposlenikZaduzenje.Items.Add("Sobarica");
            smjenaZaposlenik.Items.Add("07:00");
            smjenaZaposlenik.Items.Add("08:00");
            smjenaZaposlenik.Items.Add("14:00");
            smjenaZaposlenik.Items.Add("15:00");
        }

        private void btnDodajZap_Click(object sender, EventArgs e)
        {
            if(zaposlenikIme.Text == "" || zaposlenikPrezime.Text == "" || zaposlenikAdresa.Text =="")
            {
                MessageBox.Show("Morate unijeti sve podatke!");
                return;
            }
            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                con.Open();

                string insert = "INSERT INTO OSOBLJE (ime, prezime, zaduženje, početak, kraj, smjena) VALUES ('" + zaposlenikIme.Text + "','" + zaposlenikPrezime.Text + "','"
                                                        + zaposlenikZaduzenje.Text + "', @Pocetak, @Kraj,'" + smjenaZaposlenik.Text + "')";
         
                
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.Add("@Pocetak", SqlDbType.Date).Value = zaposlenikPocRada.Value.Date;
                cmd.Parameters.Add("@Kraj", SqlDbType.Date).Value = zaposlenikKrajRada.Value.Date;
                cmd.ExecuteNonQuery();
                sda.Update(dt);
                con.Close();
                MessageBox.Show("Uspješno ste dodali novog zaposlenika.");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e) // ispis ugovora
        {
            if (zaposlenikIme.Text == "" || zaposlenikPrezime.Text == "" || zaposlenikAdresa.Text == "")
            {
                MessageBox.Show("Morate unijeti sve podatke!");
                return;
            }
            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                con.Open();

                DateTime pickerDate1 = zaposlenikKrajRada.Value;
                DateTime pickerDate2 = zaposlenikPocRada.Value;
                TimeSpan tspan = pickerDate1 - pickerDate2;
                int differenceInDays = tspan.Days;
                string differenceAsString = differenceInDays.ToString();

                string tekst = "UGOVOR O RADU \n\n\n"+
                    "Osoba " + zaposlenikIme.Text + " "+ zaposlenikPrezime.Text + " iz mjesta " + zaposlenikAdresa.Text + 
                    " \n dobiva ugovor na " + differenceAsString + " dana. \n" +
                    "Ovim ugovorom o radu na određeno vrijeme " +
                    "\n poslodavac i radnik uređuju međusobna prava \n" +
                    " i obveze koje proizlaze iz ovim ugovorom \n o radu zasnovanog radnog odnosa. \n " +
                    "Radnik zasniva radni odnos na određeno \n vrijeme za radno mjesto "+ zaposlenikZaduzenje.Text + ",\n"+ 
                    "a prema potrebi će obavljati i druge \n poslove u skladu s prirodom radnog mjesta, \n" +
                    "prema nalogu poslodavca ili osobe koju \n na davanje naloga ovlasti poslodavac. " +
                    "\n\n Potpis __________________";

                tekstUgovora.Text = tekst;
                MessageBox.Show("Ugovor uspješno ispisan.");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}
