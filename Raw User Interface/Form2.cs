using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raw_User_Interface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIntermittentFasting_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form3 descIntermittent = new Form3()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel3.Controls.Add(descIntermittent);
            descIntermittent.Show();
            this.pbBanana.Hide();
            this.lblLetsChooseYourDiet.Hide();

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void btnVeganDiet_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form4 descIntermittent = new Form4()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel3.Controls.Add(descIntermittent);
            descIntermittent.Show();
            this.pbBanana.Hide();
            this.lblLetsChooseYourDiet.Hide();
        }

        private void btnVegetarianDiet_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form5 descIntermittent = new Form5()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel3.Controls.Add(descIntermittent);
            descIntermittent.Show();
            this.pbBanana.Hide();
            this.lblLetsChooseYourDiet.Hide();
        }
        private void btnPaleoDiet_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form7 descIntermittent = new Form7()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel3.Controls.Add(descIntermittent);
            descIntermittent.Show();
            this.pbBanana.Hide();
            this.lblLetsChooseYourDiet.Hide();
        }

        private void btnLowCarbDiet_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form8 descIntermittent = new Form8()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel3.Controls.Add(descIntermittent);
            descIntermittent.Show();
            this.pbBanana.Hide();
            this.lblLetsChooseYourDiet.Hide();
        }

        private void btnCetogenicDiet_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form9 descIntermittent = new Form9()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel3.Controls.Add(descIntermittent);
            descIntermittent.Show();
            this.pbBanana.Hide();
            this.lblLetsChooseYourDiet.Hide();
        }
    }
}
