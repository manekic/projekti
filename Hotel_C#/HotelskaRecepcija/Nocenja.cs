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
    public partial class Nocenja : Form
    {
        int[] polje = new int[100];
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

        public Nocenja()
        {
            InitializeComponent();
        }

        private void Nocenja_Load(object sender, EventArgs e)
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

            listView1.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM NOCENJA", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["id"].ToString());

                    int idGosta = Int32.Parse(dr["gost_id"].ToString());
                    SqlCommand cmd1 = new SqlCommand("SELECT GOSTI.ime, GOSTI.prezime FROM GOSTI WHERE GOSTI.Id=@gid", con);
                    cmd1.Parameters.AddWithValue("@gid", idGosta);

                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        item.SubItems.Add(dr1["ime"].ToString());
                        item.SubItems.Add(dr1["prezime"].ToString());
                    }
                    item.SubItems.Add(dr["soba_id"].ToString());
                    item.SubItems.Add(dr["broj_noćenja"].ToString());
                    item.SubItems.Add(dr["cijena_noćenja"].ToString());
                    item.SubItems.Add(dr["datum"].ToString());

                    listView1.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
