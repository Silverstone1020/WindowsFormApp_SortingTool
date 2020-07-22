using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPractice10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "textfile|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("write error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "textfile|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (sr.Peek() > -1)
                {
                    listBox2.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;

        }
    }
}
