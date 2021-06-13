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
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Raw_User_Interface
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "6m6zyWPWdYf7sGpaZQa8jEtdXTMGiC9cT0ONEtal",
            BasePath = "https://remindertime-96a3c-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void Form10_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var res = client.Get("history");
            Dictionary<string, Profil> user = res.ResultAs<Dictionary<string, Profil>>();

            foreach (var u in user)
            {
                dataGridView1.Rows.Add(u.Value.jejak, u.Value.BMI);
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}
