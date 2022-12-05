using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class MainActivity : Form
    {
        public MainActivity()
        {
            InitializeComponent();
            this.Text = "Form Calculator";
        }

        private void proses(int nilaiA, int nilaiB, string operasi, int hasil)
        {
            listBox1.Items.Add(String.Format("Hasil dari {0} {1} {2} = {3}", nilaiA, operasi, nilaiB, hasil));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculateActivity calculateActivity = new CalculateActivity();
            calculateActivity.prosesEvent += proses;
            calculateActivity.ShowDialog();
        }
    }
}