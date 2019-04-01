using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace HotelskaRecepcija
{
    public partial class DostupneSobe : Form
    {
        int[] polje = new int[100];
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

        public DostupneSobe()
        {
            InitializeComponent();
        }

        private void prikaziKarakteristikeButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Unesite broj sobe!");
                return;
            }

            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }

            listView1.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM SOBE WHERE SOBE.Id=@ids", con);
            cmd.Parameters.AddWithValue("@ids", Int32.Parse(idTextBox.Text));

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    textBoxCijena.Text = dr["cijena_noćenja"].ToString();
                    textBoxKat.Text = dr["kat"].ToString();

                    if (dr["apartman"].ToString() == "True")
                    {
                        ListViewItem item2 = new ListViewItem("- apartman");
                        listView1.Items.Add(item2);
                    }
                    if (dr["pogled"].ToString() == "True")
                    {
                        ListViewItem item3 = new ListViewItem("- pogled");
                        listView1.Items.Add(item3);
                    }
                    if (dr["klima"].ToString() == "True")
                    {
                        ListViewItem item4 = new ListViewItem("- klima");
                        listView1.Items.Add(item4);
                    }
                    if (dr["minibar"].ToString() == "True")
                    {
                        ListViewItem item5 = new ListViewItem("- minibar");
                        listView1.Items.Add(item5);
                    }
                    if (dr["tv"].ToString() == "True")
                    {
                        ListViewItem item6 = new ListViewItem("- tv");
                        listView1.Items.Add(item6);
                    }
                    if (dr["jacuzzi"].ToString() == "True")
                    {
                        ListViewItem item7 = new ListViewItem("- jacuzzi");
                        listView1.Items.Add(item7);
                    }
                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ne postoji soba s brojem " + idTextBox.Text);
                    idTextBox.Text = "";
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Unesite broj sobe!");
            }

            else
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                }

                SqlCommand cmd1 = new SqlCommand("SELECT NOCENJA.broj_noćenja, NOCENJA.datum FROM NOCENJA WHERE NOCENJA.soba_id=@ids", con);
                cmd1.Parameters.AddWithValue("@ids", Int32.Parse(idTextBox.Text));

                try
                {
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    foreach (DataRow dr in dt1.Rows)
                    {
                        string s1 = dr["datum"].ToString();
                        
                        int brojNocenjaBaza = Int32.Parse(dr["broj_noćenja"].ToString());

                        DateTime prvi = DateTime.Parse(s1);
                        DateTime zadnji = prvi.AddDays(brojNocenjaBaza);
                        DateTime trazeni = monthCalendar1.SelectionStart;

                        if (trazeni == prvi)
                            textBox1.Text = "NIJE DOSTUPNO";
                        else if (trazeni.Ticks > prvi.Ticks && trazeni.Ticks < zadnji.Ticks)
                            textBox1.Text = "NIJE DOSTUPNO";
                        else
                            textBox1.Text = "DOSTUPNO";

                    }
                    if (dt1.Rows.Count == 0)
                    {
                        textBox1.Text = "DOSTUPNO";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }

        }
        
        private void DostupneSobe_Load(object sender, EventArgs e)
        {
            
        }


    }
}
