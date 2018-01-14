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
        static List<Button> buttonlist;
        static int count = 0;
        int price = 5;
        static string film;
        private void Form2_Load(object sender, EventArgs e)
        {
           
            if (buttonlist != null)
            {
                foreach (var item in buttonlist)
                {
                    Controls.Add(item);
                    if (item.BackColor == Color.Green && Form1.films == film)
                    {
                        item.Visible = false;
                    }
                    else if(item.BackColor == Color.Green &&Form1.films != film)
                    {
                        item.Visible = true;
                        item.BackColor = SystemColors.Control;
                        
                    }

                }
                film = Form1.films;
            }
            else
            {
                film = Form1.films;
                buttonlist = new List<Button>();
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
                        Controls.Add(buttons);
                        buttons.Text = number.ToString();
                        buttons.Click += new EventHandler(btn_Click);
                        buttonlist.Add(buttons);
                        left += 50;
                    }
                    top += 30;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonlist.Find(x => x.Text == b.Text).BackColor = Color.Green;
            count += 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count > 0)
            {
                var persons = count / price;
            MessageBox.Show("Secilmis Kino :" + film + "\n" + "Biletlerin sayi : " + persons + "\n" + "Mebleg :" + count.ToString() + "AZN");
            }
            count = 0;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in buttonlist)
            {
                if (item.BackColor == Color.Green && item.Visible == true )
                {
                    item.BackColor = SystemColors.Control;
                }
            }
            count = 0;
            Hide();
        }
    }

}
