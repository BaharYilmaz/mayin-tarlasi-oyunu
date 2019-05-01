using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
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

        private void btnUret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0, mayin2 = 0, mayin3 = 0;
            Random rnd = new Random();
            mayin1 = rnd.Next(1, 15);
            mayin2 = rnd.Next(16, 35);
            mayin3 = rnd.Next(36, 50);

            for (int i = 1; i <= 50; i++)
            {
                Button btntemp = new Button();
                btntemp.Name = "btn" + i.ToString();
                btntemp.Size = new System.Drawing.Size(35, 35);
                btntemp.Text = i.ToString();
                btntemp.UseVisualStyleBackColor = true;
                if(mayin1==i||mayin2==i||mayin3==i)
                {
                    btntemp.Tag = true;

                }
                else
                {
                    btntemp.Tag = false;
                }
                
                btntemp.Click += Btntemp_Click;
                flowLayoutPanel1.Controls.Add(btntemp);

            }

        }

        private void Btntemp_Click(object sender, EventArgs e)
        {
            Button basilanButton = ((Button)sender);
            bool mayin =(bool)basilanButton.Tag;
            if (mayin)
            {
                MessageBox.Show("Mayin bulundu");
                basilanButton.BackColor = Color.Red;
                int mayinInt=0;
                mayinInt++;
                if (mayinInt==3)
                {
                    MessageBox.Show("oyun bitti");
                    
                }

            }
            else
            {
                basilanButton.BackColor = Color.Green;
                int skor = int.Parse(lbl_skor.Text);
                skor++;
                lbl_skor.Text = skor.ToString();

            }
        }
    }
}
