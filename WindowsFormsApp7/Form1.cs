using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public static string films;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            films = comboBox1.Text;
            form2.Text = comboBox1.Text;
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Cinema";
            comboBox1.Items.Add("1+1 Intouchables");
            comboBox1.Items.Add("I Origins");
            comboBox1.Items.Add("The Wolf of Wall Wtreet");
        }
    }

}
