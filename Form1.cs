using System;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/2018272/preventing-multiple-instance-of-one-form-from-displaying
            Zamówienia formz = Zamówienia.GetInstance();
            if (!formz.Visible)
            {
                formz.Show();
            }
            else
            {
                formz.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klient formk = Klient.GetInstance();
            if (!formk.Visible)
            {
                formk.Show();
            }
            else
            {
                formk.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pracownik formj = Pracownik.GetInstance();
            if (!formj.Visible)
            {
                formj.Show();
            }
            else
            {
                formj.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
