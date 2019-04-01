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
    public partial class KarakteristikeSoba : Form
    {
        int[] polje = new int[100];
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Klara\Desktop\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katarina\Documents\GitHub\RP3_Hotel\HotelskaRecepcija\HotelskaRecepcija\Recepcija.mdf;Integrated Security=True");

        public KarakteristikeSoba()
        {
            InitializeComponent();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String ids = listView1.SelectedItems[0].SubItems[0].Text;
            String cns = listView1.SelectedItems[0].SubItems[1].Text;
            String k = listView1.SelectedItems[0].SubItems[2].Text;

            idTextBox.Text = ids;
            cIJENA_NOCENJATextBox.Text = cns;
            kATTextBox.Text = k;

            SqlCommand cmd = new SqlCommand("SELECT SOBE.apartman, SOBE.pogled, SOBE.klima, SOBE.minibar, SOBE.tv, SOBE.jacuzzi FROM SOBE WHERE SOBE.Id = @IdSoba", con);
            cmd.Parameters.AddWithValue("@IdSoba", Int32.Parse(ids));

            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                if (dr["apartman"].ToString() == "True") aPARTMANCheckBox.Checked = true;
                else aPARTMANCheckBox.Checked = false;
                if (dr["pogled"].ToString() == "True") pOGLEDCheckBox.Checked = true;
                else pOGLEDCheckBox.Checked = false;
                if (dr["klima"].ToString() == "True") klimaCheckBox.Checked = true;
                else klimaCheckBox.Checked = false;
                if (dr["minibar"].ToString() == "True") minibarCheckBox.Checked = true;
                else minibarCheckBox.Checked = false;
                if (dr["tv"].ToString() == "True") tvCheckBox.Checked = true;
                else tvCheckBox.Checked = false;
                if (dr["jacuzzi"].ToString() == "True") jaccuzziCheckBox.Checked = true;
                else jaccuzziCheckBox.Checked = false;
            }
        }

        private void checkBoxDozvoliPromjene_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDozvoliPromjene.Checked)
            {
                cIJENA_NOCENJATextBox.Enabled = true;
                aPARTMANCheckBox.Enabled = true;
                pOGLEDCheckBox.Enabled = true;
                klimaCheckBox.Enabled = true;
                minibarCheckBox.Enabled = true;
                tvCheckBox.Enabled = true;
                jaccuzziCheckBox.Enabled = true;
            }
            else
            {
                cIJENA_NOCENJATextBox.Enabled = false;
                aPARTMANCheckBox.Enabled = false;
                pOGLEDCheckBox.Enabled = false;
                klimaCheckBox.Enabled = false;
                minibarCheckBox.Enabled = false;
                tvCheckBox.Enabled = false;
                jaccuzziCheckBox.Enabled = false;
            }
        }

        private void aPARTMANCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool boolNakonPromjene = aPARTMANCheckBox.Checked;
            int id = Int32.Parse(idTextBox.Text);

            SqlCommand cmd = new SqlCommand("UPDATE SOBE SET SOBE.apartman=@a WHERE SOBE.Id=@ids", con);
            cmd.Parameters.AddWithValue("@a", boolNakonPromjene);
            cmd.Parameters.AddWithValue("@ids", id);
            cmd.ExecuteNonQuery();
        }

        private void pOGLEDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool boolNakonPromjene = pOGLEDCheckBox.Checked;
            int id = Int32.Parse(idTextBox.Text);

            SqlCommand cmd = new SqlCommand("UPDATE SOBE SET SOBE.pogled=@a WHERE SOBE.Id=@ids", con);
            cmd.Parameters.AddWithValue("@a", boolNakonPromjene);
            cmd.Parameters.AddWithValue("@ids", id);
            cmd.ExecuteNonQuery();
        }

        private void klimaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool boolNakonPromjene = klimaCheckBox.Checked;
            int id = Int32.Parse(idTextBox.Text);

            SqlCommand cmd = new SqlCommand("UPDATE SOBE SET SOBE.klima=@a WHERE SOBE.Id=@ids", con);
            cmd.Parameters.AddWithValue("@a", boolNakonPromjene);
            cmd.Parameters.AddWithValue("@ids", id);
            cmd.ExecuteNonQuery();
        }

        private void minibarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool boolNakonPromjene = minibarCheckBox.Checked;
            int id = Int32.Parse(idTextBox.Text);

            SqlCommand cmd = new SqlCommand("UPDATE SOBE SET SOBE.minibar=@a WHERE SOBE.Id=@ids", con);
            cmd.Parameters.AddWithValue("@a", boolNakonPromjene);
            cmd.Parameters.AddWithValue("@ids", id);
            cmd.ExecuteNonQuery();
        }

        private void tvCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool boolNakonPromjene = tvCheckBox.Checked;
            int id = Int32.Parse(idTextBox.Text);

            SqlCommand cmd = new SqlCommand("UPDATE SOBE SET SOBE.tv=@a WHERE SOBE.Id=@ids", con);
            cmd.Parameters.AddWithValue("@a", boolNakonPromjene);
            cmd.Parameters.AddWithValue("@ids", id);
            cmd.ExecuteNonQuery();
        }

        private void jaccuzziCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool boolNakonPromjene = jaccuzziCheckBox.Checked;
            int id = Int32.Parse(idTextBox.Text);

            SqlCommand cmd = new SqlCommand("UPDATE SOBE SET SOBE.jacuzzi=@a WHERE SOBE.Id=@ids", con);
            cmd.Parameters.AddWithValue("@a", boolNakonPromjene);
            cmd.Parameters.AddWithValue("@ids", id);
            cmd.ExecuteNonQuery();
        }

        private void KarakteristikeSoba_Load(object sender, EventArgs e)
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

            SqlCommand cmd = new SqlCommand("SELECT SOBE.Id, SOBE.cijena_noćenja, SOBE.kat FROM SOBE", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["cijena_noćenja"].ToString());
                    item.SubItems.Add(dr["kat"].ToString());
                    
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
