
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
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_employee = new System.Windows.Forms.ComboBox();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_insertOrder = new System.Windows.Forms.Button();
            this.numericUpDown_pages = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_graphics = new System.Windows.Forms.NumericUpDown();
            this.button_calculatePrice = new System.Windows.Forms.Button();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.comboBox_translationType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_graphics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.AllowUserToAddRows = false;
            this.dataGridView_orders.AllowUserToDeleteRows = false;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.ReadOnly = true;
            this.dataGridView_orders.Size = new System.Drawing.Size(854, 150);
            this.dataGridView_orders.TabIndex = 0;
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
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(155, 325);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_startDate.TabIndex = 18;
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(155, 354);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_endDate.TabIndex = 19;
            // 
            // comboBox_employee
            // 
            this.comboBox_employee.FormattingEnabled = true;
            this.comboBox_employee.Location = new System.Drawing.Point(155, 179);
            this.comboBox_employee.Name = "comboBox_employee";
            this.comboBox_employee.Size = new System.Drawing.Size(121, 21);
            this.comboBox_employee.TabIndex = 20;
            this.comboBox_employee.ValueMember = "ID_pracownik";
            // 
            // comboBox_client
            // 
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(155, 206);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(121, 21);
            this.comboBox_client.TabIndex = 21;
            // 
            // comboBox_language
            // 
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Location = new System.Drawing.Point(155, 233);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(121, 21);
            this.comboBox_language.TabIndex = 22;
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
            // button_insertOrder
            // 
            this.button_insertOrder.Location = new System.Drawing.Point(550, 283);
            this.button_insertOrder.Name = "button_insertOrder";
            this.button_insertOrder.Size = new System.Drawing.Size(316, 23);
            this.button_insertOrder.TabIndex = 24;
            this.button_insertOrder.Text = "Wprowadź zamówienie";
            this.button_insertOrder.UseVisualStyleBackColor = true;
            this.button_insertOrder.Click += new System.EventHandler(this.button_insertOrder_Click_1);
            // 
            // numericUpDown_pages
            // 
            this.numericUpDown_pages.Location = new System.Drawing.Point(155, 262);
            this.numericUpDown_pages.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_pages.Name = "numericUpDown_pages";
            this.numericUpDown_pages.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown_pages.TabIndex = 26;
            this.numericUpDown_pages.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown_graphics
            // 
            this.numericUpDown_graphics.Location = new System.Drawing.Point(155, 291);
            this.numericUpDown_graphics.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_graphics.Name = "numericUpDown_graphics";
            this.numericUpDown_graphics.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown_graphics.TabIndex = 27;
            // 
            // button_calculatePrice
            // 
            this.button_calculatePrice.Location = new System.Drawing.Point(550, 180);
            this.button_calculatePrice.Name = "button_calculatePrice";
            this.button_calculatePrice.Size = new System.Drawing.Size(316, 23);
            this.button_calculatePrice.TabIndex = 28;
            this.button_calculatePrice.Text = "Oblicz cenę";
            this.button_calculatePrice.UseVisualStyleBackColor = true;
            this.button_calculatePrice.Click += new System.EventHandler(this.button_calculatePrice_Click);
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.Enabled = false;
            this.numericUpDown_price.Location = new System.Drawing.Point(695, 217);
            this.numericUpDown_price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.ReadOnly = true;
            this.numericUpDown_price.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown_price.TabIndex = 29;
            // 
            // comboBox_translationType
            // 
            this.comboBox_translationType.FormattingEnabled = true;
            this.comboBox_translationType.Location = new System.Drawing.Point(305, 201);
            this.comboBox_translationType.Name = "comboBox_translationType";
            this.comboBox_translationType.Size = new System.Drawing.Size(175, 21);
            this.comboBox_translationType.TabIndex = 30;
            // 
            // Zamówienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.comboBox_translationType);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(this.button_calculatePrice);
            this.Controls.Add(this.numericUpDown_graphics);
            this.Controls.Add(this.numericUpDown_pages);
            this.Controls.Add(this.button_insertOrder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_language);
            this.Controls.Add(this.comboBox_client);
            this.Controls.Add(this.comboBox_employee);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_orders);
            this.Name = "Zamówienia";
            this.Text = "Zamówienia";
            this.Load += new System.EventHandler(this.Zamówienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_graphics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.ComboBox comboBox_employee;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_insertOrder;
        private System.Windows.Forms.NumericUpDown numericUpDown_pages;
        private System.Windows.Forms.NumericUpDown numericUpDown_graphics;
        private System.Windows.Forms.Button button_calculatePrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
        private System.Windows.Forms.ComboBox comboBox_translationType;
    }
}