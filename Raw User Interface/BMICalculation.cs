using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace Raw_User_Interface
{
    public partial class BMICalculation : Form
    {
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "6m6zyWPWdYf7sGpaZQa8jEtdXTMGiC9cT0ONEtal",
            BasePath = "https://remindertime-96a3c-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };


        public BMICalculation()
        {
            InitializeComponent();
        }

        IFirebaseClient client;
        private void BMICalculation_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Terdapat permasalahan jaringan");
            }
        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDietForYou_Click(object sender, EventArgs e)
        {
            Form2 DietReference = new Form2();
            DietReference.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(tbWeight.Text);
            double height = double.Parse(tbHeight.Text);
            double BMI = ((weight / (height * height)) * 10000);
            tbBMIResult.Text = Math.Round(BMI, 2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime history = DateTime.Now;
            string date = history.ToString("dd/MMM/yyyy");
            Profil user = new Profil()
            {
                jejak = date,
                BMI = tbBMIResult.Text
            };
            var setter = client.Set("history/" +  Guid.NewGuid().ToString(), user);


        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form6().Show();
        }
    }
}
