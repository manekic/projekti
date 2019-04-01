using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace HotelskaRecepcija
{
    public partial class Raspored : Form
    {
        SqlConnection connection;
        string connectionString;
        public Raspored()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["HotelskaRecepcija.Properties.Settings.RecepcijaConnectionString"].ConnectionString;
        }

        private void Raspored_Load(object sender, EventArgs e)
        {
            RasporedZaposlenika();
        }

        private void RasporedZaposlenika()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select 'Zaposlenik '+ime+' '+prezime+'; zaduženje: '+zaduženje+'. Smjena počinje u '+smjena+' sati.' from OSOBLJE";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                    rasporedZaposlenika.Items.Add(dr[0].ToString());
                connection.Close();
            }
        }

    }
}