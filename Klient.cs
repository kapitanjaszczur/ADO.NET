using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO
{
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private static Klient _instance;
        public static Klient GetInstance()
        {
            if (_instance == null) _instance = new Klient();
            return _instance;
        }

        string connectionString = "Server=DESKTOP-JH1VST5\\SQLEXPRESS;Database=BT;Uid=DESKTOP-JH1VST5\\N;Pwd=;Trusted_Connection=True;";

        private void Klient_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            var dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Klient", connection);

            try
            {
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //dodawanie
        {
            string nazwa = textBox1.Text;
            decimal telefon = numericUpDown1.Value;
            string mail = textBox2.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Klient VALUES ('"+nazwa+"', "+telefon+", '"+mail+"');", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) //edytowanie
        {
            decimal id = numericUpDown3.Value;
            string nazwa = textBox3.Text;
            decimal telefon = numericUpDown2.Value;
            string mail = textBox4.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Klient " + "SET nazwa='" + nazwa + "', telefon=" + telefon + ", adres_mail='" + mail + "'" + "WHERE ID_klient=" + id, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //usuwanie
        {
            decimal id = numericUpDown3.Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Klient WHERE ID_klient="+id+"", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
