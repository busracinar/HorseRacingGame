using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışıOyunu
{
    public partial class Form2 : Form
    {
        List<List<string>> bahisler;
        List<string> skorTablosu;
        public Form2(List<List<string>> a, List<string> b )
        {
            InitializeComponent();
            bahisler = a;
            skorTablosu = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kazananKuponlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void kaybedenKuponlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            foreach (List<string> item in bahisler)
            {
                if (item[1] == skorTablosu[0] && item[2] == skorTablosu[1] && item[3] == skorTablosu[2] && item[4] == skorTablosu[3] && item[5] == skorTablosu[4] && item[6] == skorTablosu[5])
                {
                    this.dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], int.Parse(item[7]) * 4);
                }
                else
                {
                    this.dataGridView2.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7]);
                }
            }
        }
    }
}
