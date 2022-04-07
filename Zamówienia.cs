using System;
using System.Configuration;
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
        private string _connectionString = ConfigurationManager.ConnectionStrings["ADO.Properties.Settings.MainConnectionString"].ConnectionString;

        public static Zamówienia GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Zamówienia();
            }
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
            IsDateRangeValid();
        }

        private void RefreshOrdersData()
        {
            try
            {
                string queryText = "SELECT * from [dbo].[Zamówienie]";
                SqlConnection connection = new SqlConnection(_connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

                _zamowienieDataSet = new DataSet();
                adapter.Fill(_zamowienieDataSet, "Zamówienie");
                var column = _zamowienieDataSet.Tables[0].Columns[0];
                column.AutoIncrement = true;
                DataColumn[] primaryKeyColumn = new DataColumn[] { _zamowienieDataSet.Tables[0].Columns[0] };
                _zamowienieDataSet.Tables[0].PrimaryKey = primaryKeyColumn;

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
                LEFT JOIN [dbo].[Typ_tlumaczen] typ_tlumaczenia ON typ_tlumaczenia.ID_typ_tlumaczenia = zamowienie.ID_typ_tlumaczenia
                WHERE zamowienie.[usunięte] = 0";

                adapter = new SqlDataAdapter(secondQuery, connection);
                _zamowienieDisplayDataSet = new DataSet();
                adapter.Fill(_zamowienieDisplayDataSet, "ZamówienieDisplay");

                dataGridView_orders.DataSource = _zamowienieDisplayDataSet.Tables[0];

                dataGridView_orders.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView_orders.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView_orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas pobierania danych zamówień", "Błąd");
            }
        }

        private void RefreshEmployeesData()
        {
            try
            {
                string queryText = @"SELECT [ID_pracownik] AS [ID], [imię] + ' ' + [nazwisko] AS [Pracownik] FROM [dbo].[Pracownik]";
                var connectionString = ConfigurationManager.ConnectionStrings["ADO.Properties.Settings.MainConnectionString"];
                SqlConnection connection = new SqlConnection(_connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

                adapter = new SqlDataAdapter(queryText, connection);
                _pracownicyDataSet = new DataSet();
                adapter.Fill(_pracownicyDataSet, "Pracownicy");

                comboBox_employee.DataSource = _pracownicyDataSet.Tables[0];
                comboBox_employee.ValueMember = "ID";
                comboBox_employee.DisplayMember = "Pracownik";
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas pobierania danych pracowników", "Błąd");
            }
        }

        private void RefreshClientData()
        {
            try
            {
                string queryText = @"SELECT [ID_klient] as [ID], [nazwa] as [Nazwa] FROM [dbo].[Klient]";
                SqlConnection connection = new SqlConnection(_connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(queryText, connection);

                adapter = new SqlDataAdapter(queryText, connection);
                _klienciDataSet = new DataSet();
                adapter.Fill(_klienciDataSet, "Klienci");

                comboBox_client.DataSource = _klienciDataSet.Tables[0];
                comboBox_client.ValueMember = "ID";
                comboBox_client.DisplayMember = "Nazwa";
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas pobierania danych klientów", "Błąd");
            }
        }

        private void RefreshEmployeeLanguageData()
        {
            if (comboBox_employee.SelectedIndex == -1)
            {
                return;
            }

            string queryText = $@"SELECT prac.ID_język as [ID], slow.język as [Nazwa] FROM [dbo].[Język_pracownika] prac
                LEFT JOIN [dbo].[Słownik_języków] slow ON slow.ID_język = prac.ID_język
                WHERE prac.ID_pracownik = {comboBox_employee.SelectedValue}";

            SqlConnection connection = new SqlConnection(_connectionString);
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
            string queryText = @"SELECT [ID_typ_tlumaczenia] AS [ID], [Nazwa], [Wskaźnik_ceny] FROM [dbo].[Typ_tlumaczen]";

            SqlConnection connection = new SqlConnection(_connectionString);

            var adapter = new SqlDataAdapter(queryText, connection);
            _typTlumaczenDataSet = new DataSet();
            adapter.Fill(_typTlumaczenDataSet, "TypyTlumaczen");

            comboBox_translationType.DataSource = _typTlumaczenDataSet.Tables[0];
            comboBox_translationType.ValueMember = "ID";
            comboBox_translationType.DisplayMember = "Nazwa";
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
                RefreshButtonAvaliability();
            }
            catch (Exception ex)
            {
                _isPriceSet = false;
                MessageBox.Show($"Błąd podczas obliczania ceny: {ex.Message}");
            }
        }

        private void button_edition_Click(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void button_deleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }

        private double CalculatePrice()
        {
            int pages = (int)numericUpDown_pages.Value;
            int graphics = (int)numericUpDown_graphics.Value;

            return ((pages * 5) + (graphics * 10)) * GetTranslationPriceRate();
        }

        private double GetTranslationPriceRate()
        {
            var translationType = comboBox_translationType.SelectedItem as DataRowView;
            if (translationType == null)
            {
                throw new ArgumentOutOfRangeException("Nie zdefiniowano rodzaju tłumaczenia");
            }

            var a = translationType[2];

            Double.TryParse(a.ToString(), out double result);
            return result;
        }

        private void SetUpHandlers()
        {
            var numerics = Controls
                .OfType<NumericUpDown>()
                .Where(x => x.Name != numericUpDown_price.Name);
            foreach (NumericUpDown control in numerics)
            {
                control.ValueChanged += new EventHandler(PriceDeterminantControlChangedHandler);
            }

            var combo = Controls
                .OfType<ComboBox>();
            foreach (ComboBox comboBox in combo)
            {
                comboBox.SelectedValueChanged += new EventHandler(ValueChangedHandler);
            }

            var datetimepicker = Controls
                .OfType<DateTimePicker>();
            foreach (DateTimePicker dateTimePicker in datetimepicker)
            {
                dateTimePicker.ValueChanged += new EventHandler(ValueChangedHandler);
            }

            comboBox_translationType.SelectedValueChanged += new EventHandler(PriceDeterminantControlChangedHandler);
            comboBox_employee.SelectedValueChanged += new EventHandler(SelectedEmployeeChangedHandler);
            dataGridView_orders.SelectionChanged += new EventHandler(SelectedGridViewRowChangedHandler);
        }

        private bool IsDateRangeValid()
        {
            DateTime startDate = dateTimePicker_startDate.Value;
            DateTime endDate = dateTimePicker_endDate.Value;

            var isValid = !(DateTime.Compare(startDate, endDate) >= 0);

            if (isValid)
            {
                label_dateValidation.Visible = false;
                return isValid;
            }
            else
            {
                label_dateValidation.Visible = true;
                return isValid;
            }
        }

        private void PriceDeterminantControlChangedHandler(object sender, EventArgs e)
        {
            _isPriceSet = false;
            RefreshButtonAvaliability();
        }

        private void SelectedGridViewRowChangedHandler(object sender, EventArgs e)
        {
            _isPriceSet = false;
            if (dataGridView_orders.SelectedRows.Count != 1)
            {
                button_deleteOrder.Enabled = false;
                button_edition.Enabled = false;
                ClearAllForms();
                return;
            }

            var row = dataGridView_orders.SelectedRows[0];
            if (row == null)
            {
                button_deleteOrder.Enabled = false;
                button_edition.Enabled = false;
                ClearAllForms();
                return;
            }

            button_deleteOrder.Enabled = true;

            if (IsCreateUpdateAllowed())
                button_edition.Enabled = true;

            var id = row.Cells[0].Value;
            var order = _zamowienieDataSet.Tables[0].Rows.Find(id);

            comboBox_employee.SelectedValue = order[1];
            comboBox_client.SelectedValue = order[2];
            comboBox_language.SelectedValue = order[3];
            dateTimePicker_startDate.Value = (DateTime)order[4];
            dateTimePicker_endDate.Value = (DateTime)order[5];
            numericUpDown_pages.Value = (int)order[6];
            numericUpDown_graphics.Value = (int)order[7];
            comboBox_translationType.SelectedValue = order[8];

            Decimal.TryParse(order[9].ToString(), out decimal price);
            numericUpDown_price.Value = price;
        }

        private void ValueChangedHandler(object sender, EventArgs e)
        {
            RefreshButtonAvaliability();
        }

        private void SelectedEmployeeChangedHandler(object sender, EventArgs e)
        {
            comboBox_language.SelectedIndex = -1;
            RefreshEmployeeLanguageData();
        }

        private void InsertOrder()
        {
            string commandText =
                @"INSERT INTO [dbo].[Zamówienie]
                ([ID_pracownik], [ID_klient], [ID_język], [data_początkowa], [data_końcowa], [liczba_stron], [liczba_grafik], [ID_typ_tlumaczenia], [cena]) 
                VALUES (@id_pr, @id_kl, @id_jz, @d_po, @d_ko, @str, @gra, @typ, @cena)";

            SqlConnection connection = new SqlConnection(_connectionString);
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

        private void DeleteOrder()
        {
            string commandText =
                @"UPDATE [dbo].[Zamówienie]
                SET [Usunięte] = 1
                WHERE ID_zamówienie = @id";

            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                dataAdapter.UpdateCommand = command;
                var id_zam = dataGridView_orders.SelectedRows[0].Cells[0].Value;
                var param = dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", dataGridView_orders.SelectedRows[0].Cells[0].Value);
                param.Direction = ParameterDirection.Input;
                param.SourceVersion = DataRowVersion.Original;

                var dataRow = _zamowienieDataSet.Tables[0].Rows.Find(id_zam);
                dataRow["Usunięte"] = 1;

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

        private void UpdateOrder()
        {
            string commandText =
                @"UPDATE [dbo].[Zamówienie]
                    SET [ID_pracownik] = @id_pr
                      ,[ID_klient] = @id_kl
                      ,[ID_język] = @id_jz
                      ,[data_początkowa] = @d_po
                      ,[data_końcowa] = @d_ko
                      ,[liczba_stron] = @str
                      ,[liczba_grafik] = @gra
                      ,[ID_typ_tlumaczenia] = @typ
                      ,[cena] = @cena
                    WHERE [ID_zamówienie] = @id";

            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                var id_zam = dataGridView_orders.SelectedRows[0].Cells[0].Value;
                dataAdapter.UpdateCommand = command;
                var param = dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", id_zam);
                param.Direction = ParameterDirection.Input;
                param.SourceVersion = DataRowVersion.Original;

                var dataRow = _zamowienieDataSet.Tables[0].Rows.Find(id_zam);

                var employee = comboBox_employee.SelectedValue;
                var client = comboBox_client.SelectedValue;
                var language = comboBox_language.SelectedValue;
                var start_date = dateTimePicker_startDate.Value;
                var end_date = dateTimePicker_endDate.Value;
                var pages = numericUpDown_pages.Value;
                var graphics = numericUpDown_graphics.Value;
                var translationType = comboBox_translationType.SelectedValue;
                var price = numericUpDown_price.Value;

                command.Parameters.AddWithValue("@id_pr", employee);
                command.Parameters.AddWithValue("@id_kl", client);
                command.Parameters.AddWithValue("@id_jz", language);
                command.Parameters.AddWithValue("@d_po", start_date);
                command.Parameters.AddWithValue("@d_ko", end_date);
                command.Parameters.AddWithValue("@str", pages);
                command.Parameters.AddWithValue("@gra", graphics);
                command.Parameters.AddWithValue("@typ", translationType);
                command.Parameters.AddWithValue("@cena", price);

                dataRow["ID_pracownik"] = employee;
                dataRow["ID_klient"] = client;
                dataRow["ID_język"] = language;
                dataRow["data_początkowa"] = start_date;
                dataRow["data_końcowa"] = end_date;
                dataRow["liczba_stron"] = pages;
                dataRow["liczba_grafik"] = graphics;
                dataRow["ID_typ_tlumaczenia"] = translationType;
                dataRow["cena"] = price;

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

        private bool IsCreateUpdateAllowed()
        {
            return
                !(comboBox_client.SelectedIndex == -1 ||
                comboBox_employee.SelectedIndex == -1 ||
                comboBox_language.SelectedIndex == -1 ||
                comboBox_translationType.SelectedIndex == -1 ||
                numericUpDown_pages.Value < 1 ||
                !IsDateRangeValid() ||
                !_isPriceSet);
        }

        private void RefreshButtonAvaliability()
        {
            if (IsCreateUpdateAllowed())
            {
                button_insertOrder.Enabled = true;

                if (dataGridView_orders.SelectedRows.Count == 1)
                {
                    button_edition.Enabled = true;
                }
            }
            else
            {
                button_insertOrder.Enabled = false;
                button_edition.Enabled = false;
            }

            if (_isPriceSet)
            {
                label_priceValidation.Visible = false;
            }
            else
            {
                label_priceValidation.Visible = true;
            }
        }

        private void ClearAllForms()
        {
            _isPriceSet = false;
            var numerics = Controls
                .OfType<NumericUpDown>()
                .Where(x => x.Name != numericUpDown_pages.Name);

            foreach (NumericUpDown numeric in numerics)
            {
                numeric.Value = 0;
            }

            numericUpDown_pages.Value = 1;

            var combo = Controls
                .OfType<ComboBox>();

            foreach (ComboBox comboBox in combo)
            {
                comboBox.SelectedIndex = 0;
            }

            var datetimepicker = Controls
                .OfType<DateTimePicker>();

            foreach (DateTimePicker dateTimePicker in datetimepicker)
            {
                dateTimePicker.Value = DateTime.Now;
            }
        }
    }
}