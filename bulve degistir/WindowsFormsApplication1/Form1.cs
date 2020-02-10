using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] dersler = {"Matematik", "PTM", "BTT", "Edebiyat"};
        string[] yenidersler = { "Matematik", "PTM", "BTT", "Edebiyat" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                string bul, degistir;
                bul = textBox1.Text;
                degistir = textBox2.Text;
                for (int i = 0; i < dersler.Length; i++)
                {
                    if (dersler[i] == bul)
                    {
                        yenidersler[i] = degistir;
                    }
                }
                for (int i = 0; i < yenidersler.Length; i++)
                {
                    listBox2.Items.Add(yenidersler[i]);
                }
                for (int i = 0; i < dersler.Length; i++)
                {
                    dersler[i] = yenidersler[i];
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli bir değer girin!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dersler.Length; i++)
			{
			 listBox1.Items.Add(dersler[i]);
			}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < dersler.Length; i++)
            {
                listBox1.Items.Add(dersler[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList dersler = new ArrayList();
            ArrayList yenidersler = new ArrayList();
            string x;
            x = textBox1.Text + textBox2.Text;
            dersler.Add(x);
            yenidersler.Add(x);
            listBox1.Items.Add(x);
            
        }
    }
}
