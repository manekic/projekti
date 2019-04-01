using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace HotelskaRecepcija
{
    public partial class PopisUsluga : Form
    {
        SqlConnection connection;
        string connectionString;


        public PopisUsluga()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["HotelskaRecepcija.Properties.Settings.RecepcijaConnectionString"].ConnectionString;
        }


        private void PopisUsluga_Load(object sender, System.EventArgs e)
        {
            Usluge();
        }

        private void Usluge()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select naziv_usluge+' '+cijena+' kn' from TIP_USLUGE";
                //query.Font = "Constantia; 9,75pt; style = Bold";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read() == true)
                {
                    uslugePopis.Items.Add(dr[0].ToString());
                }
                connection.Close();
            }
        }

    }
}