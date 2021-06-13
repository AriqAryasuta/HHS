using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Config;

namespace Raw_User_Interface
{
    public partial class Form11 : Form
    {

        public Form11()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "6m6zyWPWdYf7sGpaZQa8jEtdXTMGiC9cT0ONEtal",
            BasePath = "https://remindertime-96a3c-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;


        private void button1_Click(object sender, EventArgs e)
        {
            Profil user = new Profil()
            {
                tanggal = dateTimePicker1.Value.ToString("dd/MMM/yyyy"),
                waktu = dateTimePicker2.Value.ToString("hh:mm"),
                kegiatan = textBox1.Text
            };
            var setter = client.Set("users/" + Guid.NewGuid().ToString(), user);
            MessageBox.Show("data tersimpan");
        }

        private void Form11_Load(object sender, EventArgs e)
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form6().Show();
        }
    }
}
