using EFtask2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFtask2
{
    public partial class log : Form
    {
        NewsContext db;
        public log()
        {
            InitializeComponent();
            db = new NewsContext();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            var user = db.Authors.FirstOrDefault(a => a.username == text_user.Text && a.password == textpassword.Text);
            if (user != null)
            {
                profile profile = new profile(user.Name, user.Id);
                profile.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid name or password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit_password edit_Password = new edit_password(text_user.Text);  
            edit_Password.ShowDialog();
            this.Close();
        }
    }
}
