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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static int count = 0;
        int price = 5;
        // static string film;
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.films == "1+1 Intouchables")
            {
                Second();
            }
            else if (Form1.films == "I Origins")
            {
                First();
            }
            else if (Form1.films == "The Wolf of Wall Wtreet")
            {
                Third();
            }

        }
        public void First()
        {
            if (Form1.Iorigin.Count != 0)
            {
                foreach (var item in Form1.Iorigin)
                {
                    Controls.Add(item);
                    if (item.BackColor == Color.Green)
                    {
                        item.Visible = false;
                    }
                    else if (item.BackColor != Color.Green)
                    {
                        item.Visible = true;
                        item.BackColor = SystemColors.Control;
                    }
                }

            }
            else
            {
                int top = 10;
                int number = 0;
                for (int i = 0; i < 5; i++)
                {
                    int left = 80;
                    for (int j = 0; j < 4; j++)
                    {
                        Button buttons = new Button();
                        number++;
                        buttons.Width = 30;
                        buttons.Height = 25;
                        buttons.Left = left;
                        buttons.Top = top;
                        buttons.Visible = true;
                        buttons.BackColor = SystemColors.Control;
                        Controls.Add(buttons);
                        buttons.Text = number.ToString();
                        buttons.Click += new EventHandler(btn_Click);
                        Form1.Iorigin.Add(buttons);
                        left += 50;
                    }
                    top += 30;
                }
            }
        }
        public void Second()
        {
            if (Form1.Intouchables.Count != 0)
            {
                foreach (var item in Form1.Intouchables)
                {
                    Controls.Add(item);
                    if (item.BackColor == Color.Green)
                    {
                        item.Visible = false;
                    }
                    else if (item.BackColor != Color.Green)
                    {
                        item.Visible = true;
                        item.BackColor = SystemColors.Control;
                    }
                }

            }
            else
            {
                int top = 10;
                int number = 0;
                for (int i = 0; i < 5; i++)
                {
                    int left = 80;
                    for (int j = 0; j < 4; j++)
                    {
                        Button buttons = new Button();
                        number++;
                        buttons.Width = 30;
                        buttons.Height = 25;
                        buttons.Left = left;
                        buttons.Top = top;
                        buttons.Visible = true;
                        buttons.BackColor = SystemColors.Control;
                        Controls.Add(buttons);
                        buttons.Text = number.ToString();
                        buttons.Click += new EventHandler(btn_Click);
                        Form1.Intouchables.Add(buttons);
                        left += 50;
                    }
                    top += 30;
                }
            }
        }
        public void Third()
        {
            if (Form1.TheWolfofWallWtreet.Count != 0)
            {
                foreach (var item in Form1.TheWolfofWallWtreet)
                {
                    Controls.Add(item);
                    if (item.BackColor == Color.Green)
                    {
                        item.Visible = false;
                    }
                    else if (item.BackColor != Color.Green)
                    {
                        item.Visible = true;
                        item.BackColor = SystemColors.Control;
                    }
                }

            }
            else
            {
                int top = 10;
                int number = 0;
                for (int i = 0; i < 5; i++)
                {
                    int left = 80;
                    for (int j = 0; j < 4; j++)
                    {
                        Button buttons = new Button();
                        number++;
                        buttons.Width = 30;
                        buttons.Height = 25;
                        buttons.Left = left;
                        buttons.Top = top;
                        buttons.Visible = true;
                        buttons.BackColor = SystemColors.Control;
                        Controls.Add(buttons);
                        buttons.Text = number.ToString();
                        buttons.Click += new EventHandler(btn_Click);
                        Form1.TheWolfofWallWtreet.Add(buttons);
                        left += 50;
                    }
                    top += 30;
                }
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Green) { return; }
            else if (Form1.films == "1+1 Intouchables" && btn.BackColor == SystemColors.Control)
            {
                Form1.Intouchables.Find(x => x.Text == btn.Text).BackColor = Color.Green;
            }
            else if (Form1.films == "1+1 Intouchables" && btn.BackColor == Color.Green)
            {
                Form1.Intouchables.Find(x => x.Text == btn.Text).BackColor = SystemColors.Control;
            }
            else if (Form1.films == "I Origins" && btn.BackColor == SystemColors.Control)
            {
                Form1.Iorigin.Find(x => x.Text == btn.Text).BackColor = Color.Green;
            }
            else if (Form1.films == "I Origins" && btn.BackColor == Color.Green)
            {
                Form1.Iorigin.Find(x => x.Text == btn.Text).BackColor = SystemColors.Control;
            }
            else if (Form1.films == "The Wolf of Wall Wtreet" && btn.BackColor == SystemColors.Control)
            {
                Form1.TheWolfofWallWtreet.Find(x => x.Text == btn.Text).BackColor = Color.Green;
            }
            else if (Form1.films == "The Wolf of Wall Wtreet" && btn.BackColor == Color.Green)
            {
                Form1.TheWolfofWallWtreet.Find(x => x.Text == btn.Text).BackColor = SystemColors.Control;
            }
            count += 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                var persons = count / price;
                MessageBox.Show("Secilmis Kino :" + Form1.films + "\n" + "Biletlerin sayi : " + persons + "\n" + "Mebleg :" + count.ToString() + "AZN");
            }
            count = 0;
            Hide();
        }

        
    }

}
