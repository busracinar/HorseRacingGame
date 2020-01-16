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
    public partial class frm1 : Form
    {
        static Random r = new Random();
        List<List<string>> bahisler = new List<List<string>>();
        List<string> kisiler = new List<string> { "Ayberk", "Oğuzhan", "İlker", 
            "Emirhan", "Emre", "Eda", 
            "Yiğit", "Tayfun", "Büşra", 
            "Harun", "Nurullah", "Özgür", 
            "Kadir", "Butkan" };
        List<string> skor= new List<string>();
        List<string> atList = new List<string> { "CiciAt", "TatlıAt", "GüzelAt", "AkıllıAt", "UsluAt", "SevimliAt" };
        public frm1()
        {
            InitializeComponent();
        }
        private void frm1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            panel1.Visible = false;
            panel2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox15.Visible = false;
            pictureBox2.Visible = false;
            pictureBox10.Visible = true;
            pictureBox16.Visible = false;
            pictureBox3.Visible = false;
            pictureBox11.Visible = true;
            pictureBox17.Visible = false;
            pictureBox4.Visible = false;
            pictureBox12.Visible = true;
            pictureBox18.Visible = false;
            pictureBox5.Visible = false;
            pictureBox13.Visible = true;
            pictureBox6.Visible = false;
            pictureBox19.Visible = false;
            pictureBox14.Visible = true;
            pictureBox20.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void kumZeminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void çimZeminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        private enum atlar
        {
            CiciAt , TatlıAt, GüzelAt, UsluAt, AkıllıAt, SevimliAt
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int ileri = 0;
            if (this.BackColor==Color.Green)
            {
                ileri = r.Next(1, 20);
            }
            else
            {
                ileri = r.Next(1, 10);
            }
            pictureBox1.Location = new Point(pictureBox1.Location.X + ileri, pictureBox1.Location.Y);
            if (pictureBox1.Location.X >= 870)
            {
                skor.Add(label1.Text);
                timer1.Stop();
                pictureBox1.Visible = false;
                pictureBox15.Visible = true;
                panel1.Visible = true;
                listBox1.Items.Add(label1.Text);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int ileri = 0;
            if (this.BackColor == Color.Green)
            {
                ileri = r.Next(1, 20);
            }
            else
            {
                ileri = r.Next(1, 10);
            }
            pictureBox2.Location = new Point(pictureBox2.Location.X + ileri, pictureBox2.Location.Y);
            if (pictureBox2.Location.X >= 870)
            {
                skor.Add(label2.Text);
                timer2.Stop();
                pictureBox2.Visible = false;
                pictureBox16.Visible = true;
                panel1.Visible = true;
                listBox1.Items.Add(label2.Text);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int ileri = 0;
            if (this.BackColor == Color.Green)
            {
                ileri = r.Next(1, 20);
            }
            else
            {
                ileri = r.Next(1, 10);
            }
            pictureBox3.Location = new Point(pictureBox3.Location.X + ileri, pictureBox3.Location.Y);
            if (pictureBox3.Location.X >= 870)
            {
                skor.Add(label3.Text);
                timer3.Stop();
                pictureBox3.Visible = false;
                pictureBox17.Visible = true;
                panel1.Visible = true;
                listBox1.Items.Add(label3.Text);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int ileri = 0;
            if (this.BackColor == Color.Green)
            {
                ileri = r.Next(1, 20);
            }
            else
            {
                ileri = r.Next(1, 10);
            }
            pictureBox4.Location = new Point(pictureBox4.Location.X + ileri, pictureBox4.Location.Y);
            if (pictureBox4.Location.X >= 870)
            {
                skor.Add(label4.Text);
                timer4.Stop();
                pictureBox4.Visible = false;
                pictureBox18.Visible = true;
                panel1.Visible = true;
                listBox1.Items.Add(label4.Text);
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int ileri = 0;
            if (this.BackColor == Color.Green)
            {
                ileri = r.Next(1, 20);
            }
            else
            {
                ileri = r.Next(1, 10);
            }
            pictureBox5.Location = new Point(pictureBox5.Location.X + ileri, pictureBox5.Location.Y);
            if (pictureBox5.Location.X >= 870)
            {
                skor.Add(label5.Text);
                timer5.Stop();
                pictureBox5.Visible = false;
                pictureBox19.Visible = true;
                panel1.Visible = true;
                listBox1.Items.Add(label5.Text);
                
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int ileri = 0;
            if (this.BackColor == Color.Green)
            {
                ileri = r.Next(1, 20);
            }
            else
            {
                ileri = r.Next(1, 10);
            }
            pictureBox6.Location = new Point(pictureBox6.Location.X + ileri, pictureBox6.Location.Y);
            if (pictureBox6.Location.X >= 870)
            {
                skor.Add(label6.Text);
                timer6.Stop();
                pictureBox6.Visible = false;
                pictureBox20.Visible = true;
                panel1.Visible = true;
                listBox1.Items.Add(label6.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textBox1.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            textBox2.Text = null;
        }

        private void tekliBahisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> bahis =new List<string> { textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, textBox2.Text };
            this.dataGridView1.Rows.Add(bahis[0], bahis[1], bahis[2], bahis[3], bahis[4], bahis[5], bahis[6], bahis[7]);
            bahisler.Add(bahis);
            textBox1.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            textBox2.Text = null;
        }

        private void kuponlarıGörToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void çokluRandomBahisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int randSayi = Convert.ToInt32(textBox3.Text);
            int[] sayac = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < randSayi; i++)
            {
                List<string> atListesi = new List<string>(6);
                int kisi = r.Next(0, 14);
                int index = r.Next(1, 400);
                string indexliKisi = kisiler[kisi] + index.ToString();
                foreach (List<string> item in bahisler)
                {
                    if (item[0].Contains(indexliKisi))
                    {
                        i--;
                        continue;
                    }
                }
                for (int j = 0; j < 6; j++)
                {
                    int a = r.Next(0, 6);
                    if (atListesi.Contains(((atlar)a).ToString()))
                    {
                        j--;
                    }
                    else
                    {
                        atListesi.Add(((atlar)a).ToString());
                    }
                }

                int ganyan = r.Next(100, 500);
                List<string> bahis = new List<string> { indexliKisi, atListesi[0], atListesi[1], atListesi[2], atListesi[3], atListesi[4], atListesi[5], ganyan.ToString() };
                this.dataGridView1.Rows.Add(bahis[0], bahis[1], bahis[2], bahis[3], bahis[4], bahis[5], bahis[6], bahis[7] );
                bahisler.Add(bahis);
            }
        }

        private void kazananKaybedenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(bahisler, skor);
            f.Show();
        }

        private void yarışBaşlasınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 10;
            pictureBox2.Left = 10;
            pictureBox3.Left = 10;
            pictureBox4.Left = 10;
            pictureBox5.Left = 10;
            pictureBox6.Left = 10;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            pictureBox1.Visible = true;
            pictureBox9.Visible = false;
            pictureBox20.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            pictureBox17.Visible = false;
            pictureBox16.Visible = false;
            pictureBox15.Visible = false;
            pictureBox2.Visible = true;
            pictureBox10.Visible = false;
            pictureBox3.Visible = true;
            pictureBox11.Visible = false;
            pictureBox4.Visible = true;
            pictureBox12.Visible = false;
            pictureBox5.Visible = true;
            pictureBox13.Visible = false;
            pictureBox6.Visible = true;
            pictureBox14.Visible = false;
        }

        private void bahisleriSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox20.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            pictureBox17.Visible = false;
            pictureBox16.Visible = false;
            pictureBox15.Visible = false;
            pictureBox2.Visible = false;
            pictureBox10.Visible = true;
            pictureBox3.Visible = false;
            pictureBox11.Visible = true;
            pictureBox4.Visible = false;
            pictureBox12.Visible = true;
            pictureBox5.Visible = false;
            pictureBox13.Visible = true;
            pictureBox6.Visible = false;
            pictureBox14.Visible = true;
            panel1.Visible = false;
            listBox1.Items.Clear();
            skor.Clear();
            bahisler.Clear();
            dataGridView1.Rows.Clear();
            textBox1.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            textBox2.Text = null;
            MessageBox.Show("Tüm bahisler sıfırlandı...","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (string item in atList)
            {
                if (item!=comboBox1.Text)
                {
                    comboBox2.Items.Add(item);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            foreach (string item in atList)
            {
                if (item != comboBox2.Text&&item!=comboBox1.Text)
                {
                    comboBox3.Items.Add(item);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            foreach (string item in atList)
            {
                if (item != comboBox3.Text&&item!=comboBox2.Text&&item!=comboBox1.Text)
                {
                    comboBox4.Items.Add(item);
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            foreach (string item in atList)
            {
                if (item != comboBox4.Text&&item!=comboBox3.Text&&item!=comboBox2.Text&&item!=comboBox1.Text)
                {
                    comboBox5.Items.Add(item);
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Items.Clear();
            foreach (string item in atList)
            {
                if (item != comboBox5.Text&& item != comboBox4.Text && item != comboBox3.Text && item != comboBox2.Text && item != comboBox1.Text)
                {
                    comboBox6.Items.Add(item);
                }
            }
        }
    }
}