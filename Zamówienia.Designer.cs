
namespace ADO
{
    partial class Zamówienia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDzamówienieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDjęzykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapoczątkowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datakońcowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbastronDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbagrafikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specjalistyczneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ekspresoweDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamówienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamówienieDataSet = new ADO.ZamówienieDataSet();
            this.zamówienieTableAdapter = new ADO.ZamówienieDataSetTableAdapters.ZamówienieTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.zamowieniePracownikDataSet = new ADO.ZamowieniePracownikDataSet();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikTableAdapter = new ADO.ZamowieniePracownikDataSetTableAdapters.PracownikTableAdapter();
            this.zamowienieKlientDataSet = new ADO.ZamowienieKlientDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new ADO.ZamowienieKlientDataSetTableAdapters.KlientTableAdapter();
            this.zamowienieJezykDataSet = new ADO.ZamowienieJezykDataSet();
            this.słownikjęzykówBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.słownik_językówTableAdapter = new ADO.ZamowienieJezykDataSetTableAdapters.Słownik_językówTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówienieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniePracownikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieKlientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieJezykDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.słownikjęzykówBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzamówienieDataGridViewTextBoxColumn,
            this.iDpracownikDataGridViewTextBoxColumn,
            this.iDklientDataGridViewTextBoxColumn,
            this.iDjęzykDataGridViewTextBoxColumn,
            this.datapoczątkowaDataGridViewTextBoxColumn,
            this.datakońcowaDataGridViewTextBoxColumn,
            this.liczbastronDataGridViewTextBoxColumn,
            this.liczbagrafikDataGridViewTextBoxColumn,
            this.specjalistyczneDataGridViewCheckBoxColumn,
            this.ekspresoweDataGridViewCheckBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamówienieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(854, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDzamówienieDataGridViewTextBoxColumn
            // 
            this.iDzamówienieDataGridViewTextBoxColumn.DataPropertyName = "ID_zamówienie";
            this.iDzamówienieDataGridViewTextBoxColumn.HeaderText = "ID_zamówienie";
            this.iDzamówienieDataGridViewTextBoxColumn.Name = "iDzamówienieDataGridViewTextBoxColumn";
            this.iDzamówienieDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDzamówienieDataGridViewTextBoxColumn.Width = 85;
            // 
            // iDpracownikDataGridViewTextBoxColumn
            // 
            this.iDpracownikDataGridViewTextBoxColumn.DataPropertyName = "ID_pracownik";
            this.iDpracownikDataGridViewTextBoxColumn.HeaderText = "ID_pracownik";
            this.iDpracownikDataGridViewTextBoxColumn.Name = "iDpracownikDataGridViewTextBoxColumn";
            this.iDpracownikDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDpracownikDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDklientDataGridViewTextBoxColumn
            // 
            this.iDklientDataGridViewTextBoxColumn.DataPropertyName = "ID_klient";
            this.iDklientDataGridViewTextBoxColumn.HeaderText = "ID_klient";
            this.iDklientDataGridViewTextBoxColumn.Name = "iDklientDataGridViewTextBoxColumn";
            this.iDklientDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDklientDataGridViewTextBoxColumn.Width = 55;
            // 
            // iDjęzykDataGridViewTextBoxColumn
            // 
            this.iDjęzykDataGridViewTextBoxColumn.DataPropertyName = "ID_język";
            this.iDjęzykDataGridViewTextBoxColumn.HeaderText = "ID_język";
            this.iDjęzykDataGridViewTextBoxColumn.Name = "iDjęzykDataGridViewTextBoxColumn";
            this.iDjęzykDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDjęzykDataGridViewTextBoxColumn.Width = 55;
            // 
            // datapoczątkowaDataGridViewTextBoxColumn
            // 
            this.datapoczątkowaDataGridViewTextBoxColumn.DataPropertyName = "data_początkowa";
            this.datapoczątkowaDataGridViewTextBoxColumn.HeaderText = "data_początkowa";
            this.datapoczątkowaDataGridViewTextBoxColumn.Name = "datapoczątkowaDataGridViewTextBoxColumn";
            this.datapoczątkowaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datakońcowaDataGridViewTextBoxColumn
            // 
            this.datakońcowaDataGridViewTextBoxColumn.DataPropertyName = "data_końcowa";
            this.datakońcowaDataGridViewTextBoxColumn.HeaderText = "data_końcowa";
            this.datakońcowaDataGridViewTextBoxColumn.Name = "datakońcowaDataGridViewTextBoxColumn";
            this.datakońcowaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datakońcowaDataGridViewTextBoxColumn.Width = 85;
            // 
            // liczbastronDataGridViewTextBoxColumn
            // 
            this.liczbastronDataGridViewTextBoxColumn.DataPropertyName = "liczba_stron";
            this.liczbastronDataGridViewTextBoxColumn.HeaderText = "liczba_stron";
            this.liczbastronDataGridViewTextBoxColumn.Name = "liczbastronDataGridViewTextBoxColumn";
            this.liczbastronDataGridViewTextBoxColumn.ReadOnly = true;
            this.liczbastronDataGridViewTextBoxColumn.Width = 70;
            // 
            // liczbagrafikDataGridViewTextBoxColumn
            // 
            this.liczbagrafikDataGridViewTextBoxColumn.DataPropertyName = "liczba_grafik";
            this.liczbagrafikDataGridViewTextBoxColumn.HeaderText = "liczba_grafik";
            this.liczbagrafikDataGridViewTextBoxColumn.Name = "liczbagrafikDataGridViewTextBoxColumn";
            this.liczbagrafikDataGridViewTextBoxColumn.ReadOnly = true;
            this.liczbagrafikDataGridViewTextBoxColumn.Width = 70;
            // 
            // specjalistyczneDataGridViewCheckBoxColumn
            // 
            this.specjalistyczneDataGridViewCheckBoxColumn.DataPropertyName = "specjalistyczne";
            this.specjalistyczneDataGridViewCheckBoxColumn.HeaderText = "specjalistyczne";
            this.specjalistyczneDataGridViewCheckBoxColumn.Name = "specjalistyczneDataGridViewCheckBoxColumn";
            this.specjalistyczneDataGridViewCheckBoxColumn.ReadOnly = true;
            this.specjalistyczneDataGridViewCheckBoxColumn.Width = 85;
            // 
            // ekspresoweDataGridViewCheckBoxColumn
            // 
            this.ekspresoweDataGridViewCheckBoxColumn.DataPropertyName = "ekspresowe";
            this.ekspresoweDataGridViewCheckBoxColumn.HeaderText = "ekspresowe";
            this.ekspresoweDataGridViewCheckBoxColumn.Name = "ekspresoweDataGridViewCheckBoxColumn";
            this.ekspresoweDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ekspresoweDataGridViewCheckBoxColumn.Width = 75;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaDataGridViewTextBoxColumn.Width = 40;
            // 
            // zamówienieBindingSource
            // 
            this.zamówienieBindingSource.DataMember = "Zamówienie";
            this.zamówienieBindingSource.DataSource = this.zamówienieDataSet;
            // 
            // zamówienieDataSet
            // 
            this.zamówienieDataSet.DataSetName = "ZamówienieDataSet";
            this.zamówienieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamówienieTableAdapter
            // 
            this.zamówienieTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID_pracownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID_klient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID_język";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data początkowa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data końcowa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Liczba stron";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Liczba grafik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cena";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(348, 213);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "specjalistyczne";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(348, 236);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "ekspresowe";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(348, 259);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "zwykłe";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 325);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(155, 354);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pracownikBindingSource;
            this.comboBox1.DisplayMember = "ID_pracownik";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "ID_pracownik";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.klientBindingSource;
            this.comboBox2.DisplayMember = "ID_klient";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(155, 206);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "ID_klient";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.słownikjęzykówBindingSource;
            this.comboBox3.DisplayMember = "język";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(155, 233);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "język";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tłumaczenie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Wprowadź zamówienie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 262);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(155, 291);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown2.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Oblicz cenę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(695, 217);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown3.TabIndex = 29;
            // 
            // zamowieniePracownikDataSet
            // 
            this.zamowieniePracownikDataSet.DataSetName = "ZamowieniePracownikDataSet";
            this.zamowieniePracownikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.zamowieniePracownikDataSet;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // zamowienieKlientDataSet
            // 
            this.zamowienieKlientDataSet.DataSetName = "ZamowienieKlientDataSet";
            this.zamowienieKlientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.zamowienieKlientDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // zamowienieJezykDataSet
            // 
            this.zamowienieJezykDataSet.DataSetName = "ZamowienieJezykDataSet";
            this.zamowienieJezykDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // słownikjęzykówBindingSource
            // 
            this.słownikjęzykówBindingSource.DataMember = "Słownik_języków";
            this.słownikjęzykówBindingSource.DataSource = this.zamowienieJezykDataSet;
            // 
            // słownik_językówTableAdapter
            // 
            this.słownik_językówTableAdapter.ClearBeforeFill = true;
            // 
            // Zamówienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zamówienia";
            this.Text = "Zamówienia";
            this.Load += new System.EventHandler(this.Zamówienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówienieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniePracownikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieKlientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieJezykDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.słownikjęzykówBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZamówienieDataSet zamówienieDataSet;
        private System.Windows.Forms.BindingSource zamówienieBindingSource;
        private ZamówienieDataSetTableAdapters.ZamówienieTableAdapter zamówienieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzamówienieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDjęzykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapoczątkowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datakońcowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbastronDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbagrafikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn specjalistyczneDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ekspresoweDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private ZamowieniePracownikDataSet zamowieniePracownikDataSet;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private ZamowieniePracownikDataSetTableAdapters.PracownikTableAdapter pracownikTableAdapter;
        private ZamowienieKlientDataSet zamowienieKlientDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private ZamowienieKlientDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private ZamowienieJezykDataSet zamowienieJezykDataSet;
        private System.Windows.Forms.BindingSource słownikjęzykówBindingSource;
        private ZamowienieJezykDataSetTableAdapters.Słownik_językówTableAdapter słownik_językówTableAdapter;
    }
}