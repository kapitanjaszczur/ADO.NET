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

namespace ADO
{
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/2018272/preventing-multiple-instance-of-one-form-from-displaying
        private static Klient _instance;
        public static Klient GetInstance()
        {
            if (_instance == null) _instance = new Klient();
            return _instance;
        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'klientDataSet.Klient' . Możesz go przenieść lub usunąć.
            this.klientTableAdapter.Fill(this.klientDataSet.Klient);

        }
        //SqlConnection con = new SqlConnection("Server=DESKTOP-HQGJNCF\\SQLEXPRESS;Database=BT;Uid=DESKTOP-HQGJNCF\\N;Pwd=");
        string connectionString = "Server=DESKTOP-HQGJNCF\\SQLEXPRESS;Database=BT;Uid=DESKTOP-HQGJNCF\\N;Pwd=";





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazwa = textBox1.Text;
            decimal telefon = numericUpDown1.Value;
            string mail = textBox2.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Do work here.  
            }

            // SqlCommand cmd = new SqlCommand("INSERT INTO Klient VALUES ('" + nazwa + "'," + telefon + ",'" + mail + "')", con);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedItem; //zmiana na textbox?
            string nazwa = textBox3.Text;
            decimal telefon = numericUpDown2.Value;
            string mail = textBox4.Text;
            string kwerenda = "UPDATE Klient " + "SET nazwa='" + nazwa + "', telefon=" + telefon + ", adres_mail='" + mail + "'" + "WHERE ID_klient=" + id; //id w ''?
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedItem;
            string kwerenda = "DELETE FROM Klient WHERE ID_klient=" + id;//id w ''?
        }
    }
}
