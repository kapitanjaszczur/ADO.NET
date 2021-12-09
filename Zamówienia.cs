using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class Zamówienia : Form
    {
        public Zamówienia()
        {
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/2018272/preventing-multiple-instance-of-one-form-from-displaying
        private static Zamówienia _instance;
        public static Zamówienia GetInstance()
        {
            if (_instance == null) _instance = new Zamówienia();
            return _instance;
        }

        private void Zamówienia_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamowienieJezykDataSet.Słownik_języków' . Możesz go przenieść lub usunąć.
            this.słownik_językówTableAdapter.Fill(this.zamowienieJezykDataSet.Słownik_języków);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamowienieKlientDataSet.Klient' . Możesz go przenieść lub usunąć.
            this.klientTableAdapter.Fill(this.zamowienieKlientDataSet.Klient);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamowieniePracownikDataSet.Pracownik' . Możesz go przenieść lub usunąć.
            this.pracownikTableAdapter.Fill(this.zamowieniePracownikDataSet.Pracownik);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamówienieDataSet.Zamówienie' . Możesz go przenieść lub usunąć.
            this.zamówienieTableAdapter.Fill(this.zamówienieDataSet.Zamówienie);

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = new DateTime(2030,12,30);
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker2.MaxDate = new DateTime(2030, 12, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal liczbaStron = numericUpDown1.Value;
            decimal liczbaGrafik = numericUpDown2.Value;
            DateTime dataPoczatkowa = dateTimePicker1.Value;
            DateTime dataKoncowa= dateTimePicker2.Value;


            int porownaniedat = DateTime.Compare(dataPoczatkowa, dataKoncowa);
            if (porownaniedat>=0)
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Data końcowa nie może być równa lub wcześniejsza niż data początkowa!";
                string caption = "Błąd!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e) //obliczanie kosztu
        {
            double koszt = 0;
            double liczbaStron = (double)numericUpDown1.Value;
            double liczbaGrafik = (double)numericUpDown2.Value;
            if (radioButton1.Checked || radioButton2.Checked)
            {
                koszt = ((liczbaStron * 5) + (liczbaGrafik * 10))*1.35;
                numericUpDown3.Value = (decimal)koszt;
            }
            else
            {
                koszt = liczbaStron * 5 + liczbaGrafik * 10;
                numericUpDown3.Value = (decimal)koszt;
            }
            
        }
    }
}
