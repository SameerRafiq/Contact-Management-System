using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("E://Data.txt", true);
            sw.WriteLine("Full Name : " + Nametxt.Text);
            sw.WriteLine("Contact No : " + Contacttxt.Text);
            sw.WriteLine("E-mail : " + mailtxt.Text);
            sw.WriteLine("Address : " + addtxt.Text);
            sw.WriteLine("Gender : " + gendercombo.Text);
            sw.WriteLine("------------------------------");
            MessageBox.Show("Contact Info Added.");
            sw.Close();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            Nametxt.Clear();
            Contacttxt.Clear();
            mailtxt.Clear();
            addtxt.Clear();
            gendercombo.SelectedIndex = -1;
            MessageBox.Show("The Data is cleared.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String filePath = "E://Data.txt";
            string SearchName = txtsearch.Text.Trim();
            bool found = false;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File Not Found..!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            string fullRecord = "";
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Full Name :", StringComparison.OrdinalIgnoreCase) &&
                    lines[i].ToLower().Contains(SearchName.ToLower()))
                {
                    found = true;

                    textBox1.Text = lines[i].Replace("Full Name :", "").Trim();
                    textBox2.Text = lines[i + 1].Replace("Contact No :", "").Trim();
                    textBox3.Text = lines[i + 2].Replace("E-mail :", "").Trim();
                    textBox4.Text = lines[i + 3].Replace("Address :", "").Trim();
                    textBox5.Text = lines[i + 4].Replace("Gender :", "").Trim();

                    
                    textBox5.Visible = true;
                    textBox4.Visible = true;
                    textBox3.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Visible = true;
                    label11.Visible = true;
                    label10.Visible = true;
                    label8.Visible = true;
                    label7.Visible = true;
                    label6.Visible = true;

                    break;

                }
            }

            if (found)
            {
                MessageBox.Show("Record Found:\n\n" + fullRecord, "Search Result");
            }
            else
            {
                MessageBox.Show("No record found for '" + SearchName + "'.", "Search Result");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
