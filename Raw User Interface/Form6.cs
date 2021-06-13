using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Raw_User_Interface
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            ControlBox = false;
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "6m6zyWPWdYf7sGpaZQa8jEtdXTMGiC9cT0ONEtal",
            BasePath = "https://remindertime-96a3c-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void pbBack_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var res = client.Get("users");
            Dictionary<string, Profil> users = res.ResultAs<Dictionary<string, Profil>>();

            foreach(var u in users)
            {
                dataGridView1.Rows.Add(u.Value.tanggal, u.Value.waktu, u.Value.kegiatan);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form11().Show();
        }

        private void Form6_Load(object sender, EventArgs e)
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
    }
}
