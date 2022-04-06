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

        readonly string connectionString = "Server=DESKTOP-JH1VST5\\SQLEXPRESS;Database=BT;Uid=DESKTOP-JH1VST5\\N;Pwd=;Trusted_Connection=True;";

        private void Klient_Load(object sender, EventArgs e)
        {
            
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
            int telefon = 0;
            if (maskedTextBox1.Text == null)
            {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else if (int.Parse(maskedTextBox1.Text) <1) {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else
            {
                telefon = int.Parse(maskedTextBox1.Text);
            }
            string mail = textBox2.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (nazwa.Length >10 && telefon >0 && mail.Length >10) {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Klient VALUES ('" + nazwa + "', " + telefon + ", '" + mail + "');", connection);
                        //connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadź poprawne wartości");
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e) //edytowanie
        {
            decimal id = numericUpDown3.Value;
            string nazwa = textBox3.Text;
            int telefon = 0;
            if (maskedTextBox2.Text == null)
            {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else if (int.Parse(maskedTextBox2.Text) < 1)
            {
                MessageBox.Show("Wprowadź poprawne wartości");
            }
            else
            {
                telefon = int.Parse(maskedTextBox2.Text);
            }
            string mail = textBox4.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (nazwa.Length >10 && telefon >0 && mail.Length >10)
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
                else
                {
                    MessageBox.Show("Wprowadź poprawne wartości");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //usuwanie
        {
            /*decimal id = numericUpDown3.Value; //usuń po id
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
            }*/

            string cb = comboBox1.SelectedItem.ToString(); //usuń po nazwie
            using (SqlConnection connection = new SqlConnection(connectionString))
                try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Klient WHERE nazwa='" + cb + "'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) //odśwież grid i combobox
        {
            SqlConnection connection = new SqlConnection(connectionString);//odśwież grid
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

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))//odśwież combobox
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT ID_klient, nazwa FROM dbo.Klient", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (sqlReader.Read())
                {
                    comboBox1.Items.Add(sqlReader["nazwa"].ToString());
                }

                sqlReader.Close();
            }
        }
    }
}
