using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace combobox1
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
        private void load(string filePath)
        {
            
            StreamReader sr = new StreamReader(filePath);
            //string[] y = x.Split(',');
            string x = sr.ReadToEnd();
            string[] z = x.Split('\n');
            
            foreach (string j in z)
            {
                comboBox1.Items.Add(j);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textFilePath.Text = openFileDialog1.FileName;
            load(textFilePath.Text);
        }
        
    }
}
