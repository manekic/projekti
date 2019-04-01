using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelskaRecepcija
{
    public partial class NoviGost : Form
    {
        int idG, cijena;
        public NoviGost()
        {
            InitializeComponent();
        }


        private void btnDodajGosta_Click(object sender, EventArgs e)
        {
            try
            {
                if (noviGostIme.Text != "" && noviGostPrezime.Text != "" && noviGostId.Text != "" && noviGostBrojNocenja.Text != "")
                {
                    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
                    con.Open();
                    string insert = "INSERT INTO GOSTI (ime, prezime) VALUES ('" + noviGostIme.Text + "', '" + noviGostPrezime.Text + "') ";
                    DataTable dt0 = new DataTable();
                    SqlDataAdapter sda0 = new SqlDataAdapter();

                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                    sda0.Update(dt0);

                    SqlCommand cmd1 = new SqlCommand("SELECT Id, ime, prezime FROM GOSTI WHERE ime = @ime1 AND prezime = @prezime1 ", con);
                    cmd1.Parameters.AddWithValue("@ime1", noviGostIme.Text);
                    cmd1.Parameters.AddWithValue("@prezime1", noviGostPrezime.Text);

                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    foreach (DataRow dr in dt1.Rows)
                    {
                        idG = Int32.Parse(dr["Id"].ToString());
                    }

                    SqlCommand cmd2 = new SqlCommand("SELECT cijena_noćenja FROM SOBE WHERE id = @idS  ", con);
                    cmd2.Parameters.AddWithValue("@idS", noviGostId.Text);

                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                                        
                    foreach (DataRow dr in dt2.Rows)
                    {
                        string s1;
                        s1 = dr["cijena_noćenja"].ToString();
                        cijena = Int32.Parse(s1);
                    }
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO NOCENJA (gost_id, soba_id, broj_noćenja, cijena_noćenja, datum) VALUES" +
                        "('" + idG + "', '" + noviGostId.Text + "', '" + noviGostBrojNocenja.Text + "', '" + cijena + "',@Date) ", con);

                    cmd3.Parameters.Add("@Date", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                    MessageBox.Show("Uspješno dodano!" + idG + ", " + noviGostId.Text + ", " + cijena);
                    cmd3.ExecuteNonQuery();
                    sda.Update(dt);
                    MessageBox.Show("Uspješno dodano!");

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Niste unijeli sve podatke!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
