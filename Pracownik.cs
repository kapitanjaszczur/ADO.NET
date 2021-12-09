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
    public partial class Pracownik : Form
    {
        public Pracownik()
        {
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/2018272/preventing-multiple-instance-of-one-form-from-displaying
        private static Pracownik _instance;
        public static Pracownik GetInstance()
        {
            if (_instance == null) _instance = new Pracownik();
            return _instance;
        }

        private void Języki_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'językiDataSet.Słownik_języków' . Możesz go przenieść lub usunąć.
            this.słownik_językówTableAdapter.Fill(this.językiDataSet.Słownik_języków);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'językiPracownikaDataSet.Język_pracownika' . Możesz go przenieść lub usunąć.
            this.język_pracownikaTableAdapter.Fill(this.językiPracownikaDataSet.Język_pracownika);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pracownikDataSet.Pracownik' . Możesz go przenieść lub usunąć.
            this.pracownikTableAdapter.Fill(this.pracownikDataSet.Pracownik);

        }

    }
}
