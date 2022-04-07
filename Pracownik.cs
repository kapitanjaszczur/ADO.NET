using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO
{
    public partial class Pracownik : Form
    {
        public Pracownik()
        {
            InitializeComponent();
        }

        private static Pracownik _instance;
        readonly string connectionString = ConfigurationManager.ConnectionStrings["ADO.Properties.Settings.MainConnectionString"].ConnectionString;
        public static Pracownik GetInstance()
        {
            if (_instance == null || _instance.IsDisposed) _instance = new Pracownik();
            return _instance;
        }

        private void Języki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //dodaj pracownika
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string mail = textBox3.Text;
            int telefon = 0;
            if (maskedTextBox1.Text == null)
            {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else if (int.Parse(maskedTextBox1.Text) < 1)
            {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else
            {
                telefon = int.Parse(maskedTextBox1.Text);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pracownik VALUES ('" + imie + "', '" + nazwisko + "', " + telefon + ", '" + mail + "');", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //modyfikuj pracownika
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string mail = textBox3.Text;
            int telefon = 0;
            if (maskedTextBox1.Text == null)
            {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else if (int.Parse(maskedTextBox1.Text) < 1)
            {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else
            {
                telefon = int.Parse(maskedTextBox1.Text);
            }
            decimal id = numericUpDown1.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Pracownik " +
                                                    "SET imię='" + imie + "', nazwisko='" + nazwisko + "', telefon=" + telefon + ", adres_mail='" + mail + "' " +
                                                    "WHERE ID_pracownik=" + id, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //usuń pracownika
        {
            decimal id = numericUpDown1.Value; //usuń po id
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Pracownik WHERE ID_pracownik=" + id + "", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e) //odśwież gridy
        {
            SqlConnection connection = new SqlConnection(connectionString);
            var dataAdapter1 = new SqlDataAdapter("SELECT * FROM dbo.Pracownik", connection);
            var dataAdapter2 = new SqlDataAdapter("SELECT ID_język_pracownika, ID_pracownik, ID_język FROM dbo.Język_pracownika", connection);
            var dataAdapter3 = new SqlDataAdapter("SELECT ID_język, język FROM dbo.Słownik_języków", connection);
            try
            {
                var commandBuilder = new SqlCommandBuilder(dataAdapter1);
                var ds1 = new DataSet();
                var ds2 = new DataSet();
                var ds3 = new DataSet();
                dataAdapter1.Fill(ds1);
                dataAdapter2.Fill(ds2);
                dataAdapter3.Fill(ds3);
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView3.DataSource = ds3.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //dodanie języka pracownikowi
        {
            decimal id_prac = numericUpDown2.Value;
            decimal id_język = numericUpDown3.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Język_pracownika VALUES (" + id_prac + ", " + id_język + ", 0);", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            decimal id = numericUpDown4.Value; //usuń po id
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Język_pracownika WHERE ID_język_pracownika=" + id + "", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) //dodaj język do słownika
        {
            string język = textBox7.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Słownik_języków VALUES ('" + język + "', 'C2');", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) //usuń język ze słownika
        {
            decimal id = numericUpDown5.Value; //usuń po id
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Słownik_języków WHERE ID_język=" + id + "", connection);
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
