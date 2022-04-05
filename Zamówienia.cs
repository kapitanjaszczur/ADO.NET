using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading;
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
        private bool _isPriceSet;
        private DataSet _zamowienieDataSet;
        private DataSet _zamowienieDisplayDataSet;
        private DataSet _jezykiPracownikDataSet;
        private DataSet _typTlumaczenDataSet;
        private DataSet _pracownicyDataSet;
        private DataSet _klienciDataSet;

        public static Zamówienia GetInstance()
        {
            if (_instance == null) _instance = new Zamówienia();
            return _instance;
        }

        private void Zamówienia_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            RefreshOrdersData();
            RefreshEmployeesData();
            RefreshClientData();
            RefreshEmployeeLanguageData();
            RefreshTranslationTypeData();

            SetUpHandlers();

            dateTimePicker_startDate.MinDate = DateTime.Today;
            dateTimePicker_endDate.MinDate = DateTime.Today;
        }

        private void RefreshOrdersData()
        {
            string queryText = "select * from [dbo].[Zamówienie]";
            SqlConnection connection = new SqlConnection("Server=DESKTOP-IH4LM0K;Database=BT;Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

            _zamowienieDataSet = new DataSet();
            adapter.Fill(_zamowienieDataSet, "Zamówienie");

            string secondQuery = @"SELECT 
                zamowienie.ID_zamówienie as [Numer zamówienia], 
                pracownik.imię + ' ' + pracownik.nazwisko as [Pracownik],
                klient.nazwa as [Nazwa klienta],
                jezyk.język as [Język],
                zamowienie.data_początkowa as [Data rozpoczęcia],
                zamowienie.data_końcowa as [Data zakończenia],
                zamowienie.liczba_stron as [Strony],
                zamowienie.liczba_grafik as [Grafiki],
                zamowienie.cena as [Cena]
                FROM [dbo].[Zamówienie] zamowienie
                LEFT JOIN [dbo].[Pracownik] pracownik ON pracownik.ID_pracownik = zamowienie.ID_pracownik
                LEFT JOIN [dbo].[Klient] klient ON klient.ID_klient = zamowienie.ID_klient
                LEFT JOIN [dbo].[Słownik_języków] jezyk ON jezyk.ID_język = zamowienie.ID_język
                LEFT JOIN [dbo].[Typ_tlumaczen] typ_tlumaczenia ON typ_tlumaczenia.ID_typ_tlumaczenia = zamowienie.ID_typ_tlumaczenia";

            adapter = new SqlDataAdapter(secondQuery, connection);
            _zamowienieDisplayDataSet = new DataSet();
            adapter.Fill(_zamowienieDisplayDataSet, "ZamówienieDisplay");

            dataGridView_orders.DataSource = _zamowienieDisplayDataSet.Tables[0];

            dataGridView_orders.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView_orders.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView_orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshEmployeesData()
        {
            string queryText = @"SELECT [ID_pracownik] AS [ID], [imię] + ' ' + [nazwisko] AS [Pracownik] FROM [dbo].[Pracownik]";
            SqlConnection connection = new SqlConnection("Server=DESKTOP-IH4LM0K;Database=BT;Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

            adapter = new SqlDataAdapter(queryText, connection);
            _pracownicyDataSet = new DataSet();
            adapter.Fill(_pracownicyDataSet, "Pracownicy");

            comboBox_employee.DataSource = _pracownicyDataSet.Tables[0];
            comboBox_employee.ValueMember = "ID";
            comboBox_employee.DisplayMember = "Pracownik";
        }

        private void RefreshClientData()
        {
            string queryText = @"SELECT [ID_klient] as [ID], [nazwa] as [Nazwa] FROM [dbo].[Klient]";
            SqlConnection connection = new SqlConnection("Server=DESKTOP-IH4LM0K;Database=BT;Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

            adapter = new SqlDataAdapter(queryText, connection);
            _klienciDataSet = new DataSet();
            adapter.Fill(_klienciDataSet, "Klienci");

            comboBox_client.DataSource = _klienciDataSet.Tables[0];
            comboBox_client.ValueMember = "ID";
            comboBox_client.DisplayMember = "Nazwa";
        }

        private void RefreshEmployeeLanguageData()
        {
            string queryText = @"SELECT prac.ID_język as [ID], slow.język as [Nazwa] FROM [dbo].[Język_pracownika] prac
                LEFT JOIN [dbo].[Słownik_języków] slow ON slow.ID_język = prac.ID_język";

            SqlConnection connection = new SqlConnection("Server=DESKTOP-IH4LM0K;Database=BT;Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

            adapter = new SqlDataAdapter(queryText, connection);
            _jezykiPracownikDataSet = new DataSet();
            adapter.Fill(_jezykiPracownikDataSet, "Jezyki");

            comboBox_language.DataSource = _jezykiPracownikDataSet.Tables[0];
            comboBox_language.ValueMember = "ID";
            comboBox_language.DisplayMember = "Nazwa";
        }

        private void RefreshTranslationTypeData()
        {
            string queryText = @"SELECT [ID_typ_tlumaczenia] AS [ID], [Nazwa] FROM [dbo].[Typ_tlumaczen]";

            SqlConnection connection = new SqlConnection("Server=DESKTOP-IH4LM0K;Database=BT;Trusted_Connection=True;");
            SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

            adapter = new SqlDataAdapter(queryText, connection);
            _typTlumaczenDataSet = new DataSet();
            adapter.Fill(_typTlumaczenDataSet, "TypyTlumaczen");

            comboBox_translationType.DataSource = _typTlumaczenDataSet.Tables[0];
            comboBox_translationType.ValueMember = "ID";
            comboBox_translationType.DisplayMember = "Nazwa";
        }

        private void LoadDataFromDb()
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamowienieJezykDataSet.Słownik_języków' . Możesz go przenieść lub usunąć.
            //this.słownik_językówTableAdapter.Fill(this.zamowienieJezykDataSet.Słownik_języków);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamowienieKlientDataSet.Klient' . Możesz go przenieść lub usunąć.
            //this.klientTableAdapter.Fill(this.zamowienieKlientDataSet.Klient);
            //// TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamowieniePracownikDataSet.Pracownik' . Możesz go przenieść lub usunąć.
            //this.pracownikTableAdapter.Fill(this.zamowieniePracownikDataSet.Pracownik);
            //// TODO: Ten wiersz kodu wczytuje dane do tabeli 'zamówienieDataSet.Zamówienie' . Możesz go przenieść lub usunąć.
            //this.zamówienieTableAdapter.Fill(this.zamówienieDataSet.Zamówienie);
        }

        private void button_insertOrder_Click_1(object sender, EventArgs e)
        {
            if (!IsDateRangeValid())
            {
                MessageBox.Show(
                    "Data końcowa nie może być mniejsza bądź równa początkowej!",
                    "Błąd!",
                    MessageBoxButtons.OK);

                return;
            }

            if (!_isPriceSet)
            {
                MessageBox.Show(
                    "Cena nie została wyliczona",
                    "Błąd!",
                    MessageBoxButtons.OK);

                return;
            }

            InsertOrder();
            RefreshOrdersData();
        }

        private void button_calculatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown_price.Value = (decimal)CalculatePrice();
                _isPriceSet = true;
            }
            catch (Exception ex)
            {
                _isPriceSet = false;
                MessageBox.Show($"Błąd podczas obliczania ceny: {ex.Message}");
            }
        }

        private double CalculatePrice()
        {
            int pages = (int)numericUpDown_pages.Value;
            int graphics = (int)numericUpDown_graphics.Value;

            return (pages * 5) + (graphics * 10) * GetTranslationPriceRate();
        }

        private double GetTranslationPriceRate()
        {

            switch (comboBox_translationType.SelectedValue)
            {
                case 1:
                    return 1;
                case 2:
                    return 1.5;
                case 3:
                    return 2;
                default:
                    throw new ArgumentOutOfRangeException("Nie wybrano rodzaju tłumaczenia");
            };
        }

        private void SetUpHandlers()
        {
            var numerics = Controls
                .OfType<NumericUpDown>()
                .Where(x => x.Name != numericUpDown_price.Name);

            var radioButtons = Controls
                .OfType<RadioButton>();

            foreach (NumericUpDown control in Controls.OfType<NumericUpDown>().Where(x => x.Name != numericUpDown_price.Name))
            {
                control.ValueChanged += new EventHandler(PriceDeterminantControlChangedHandler);
            }
            foreach (RadioButton control in Controls.OfType<RadioButton>())
            {
                control.CheckedChanged += new EventHandler(PriceDeterminantControlChangedHandler);
            }
        }

        private bool IsDateRangeValid()
        {
            DateTime startDate = dateTimePicker_startDate.Value;
            DateTime endDate = dateTimePicker_endDate.Value;

            return !(DateTime.Compare(startDate, endDate) >= 0);
        }

        private void PriceDeterminantControlChangedHandler(object sender, EventArgs e)
        {
            _isPriceSet = false;
        }

        private void InsertOrder()
        {
            string commandText =
                @"INSERT INTO [dbo].[Zamówienie]
                ([ID_pracownik], [ID_klient], [ID_język], [data_początkowa], [data_końcowa], [liczba_stron], [liczba_grafik], [ID_typ_tlumaczenia], [cena]) 
                VALUES (@id_pr, @id_kl, @id_jz, @d_po, @d_ko, @str, @gra, @typ, @cena)";

            SqlConnection connection = new SqlConnection("Server=DESKTOP-IH4LM0K;Database=BT;Trusted_Connection=True;");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                var employee = comboBox_employee.SelectedValue;
                var client = comboBox_client.SelectedValue;
                var language = comboBox_language.SelectedValue;
                var start_date = dateTimePicker_startDate.Value;
                var end_date = dateTimePicker_endDate.Value;
                var pages = numericUpDown_pages.Value;
                var graphics = numericUpDown_graphics.Value;
                var translationType = comboBox_translationType.SelectedValue;
                var price = numericUpDown_price.Value;

                dataAdapter.InsertCommand = command;
                command.Parameters.AddWithValue("@id_pr", employee);
                command.Parameters.AddWithValue("@id_kl", client);
                command.Parameters.AddWithValue("@id_jz", language);
                command.Parameters.AddWithValue("@d_po", start_date);
                command.Parameters.AddWithValue("@d_ko", end_date);
                command.Parameters.AddWithValue("@str", pages);
                command.Parameters.AddWithValue("@gra", graphics);
                command.Parameters.AddWithValue("@typ", translationType);
                command.Parameters.AddWithValue("@cena", price);

                var dataRow = _zamowienieDataSet.Tables[0].NewRow();
                dataRow["ID_pracownik"] = employee;
                dataRow["ID_klient"] = client;
                dataRow["ID_język"] = language;
                dataRow["data_początkowa"] = start_date;
                dataRow["data_końcowa"] = end_date;
                dataRow["liczba_stron"] = pages;
                dataRow["liczba_grafik"] = graphics;
                dataRow["ID_typ_tlumaczenia"] = translationType;
                dataRow["cena"] = price;

                _zamowienieDataSet.Tables[0].Rows.Add(dataRow);

                dataAdapter.Update(_zamowienieDataSet, "Zamówienie");
                RefreshOrdersData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}