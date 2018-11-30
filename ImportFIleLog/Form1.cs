using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportFIleLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            Model1 db = new Model1();
            dtgvImport.DataSource = db.ChiTietSuDungs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
