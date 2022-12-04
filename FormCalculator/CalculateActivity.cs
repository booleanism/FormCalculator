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
    public partial class CalculateActivity : Form
    {
        public CalculateActivity()
        {
            InitializeComponent();
            CalcInit();
        }

        private void CalcInit()
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;
        }

        public delegate void Proses(int nilaiA, int nilaiB, string operasi, int hasil);

        public event Proses prosesEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(textBox1.Text);
            int nilaiB = int.Parse(textBox2.Text);
            int hasil = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                hasil = nilaiA + nilaiB;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                hasil = nilaiA - nilaiB;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                hasil = nilaiA * nilaiB;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                hasil = nilaiA / nilaiB;
            }
            prosesEvent(nilaiA, nilaiB, comboBox1.Text, hasil);
        }

    }
}