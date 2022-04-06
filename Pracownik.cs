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

        private static Pracownik _instance;
        public static Pracownik GetInstance()
        {
            if (_instance == null) _instance = new Pracownik();
            return _instance;
        }

        private void Języki_Load(object sender, EventArgs e)
        {
            
        }

    }
}
