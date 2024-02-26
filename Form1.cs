

using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using EFtask2.Models;
using System;
namespace EFtask2
{
    public partial class signup : Form
    {
        NewsContext db;
        public signup()
        {
            InitializeComponent();
            db = new NewsContext();
        }



        private void btnsign_Click(object sender, EventArgs e)
        {
            author a = new author()
            {
                Name = text_name.Text,
                age = int.Parse(text_age.Text),
                password = text_pass.Text,
                username = text_username.Text,

            };
            db.Authors.Add(a);
            db.SaveChanges();
            int autherid = a.Id;
            MessageBox.Show("data added");
            profile profile = new profile(text_name.Text, autherid);
            text_name.Text = text_age.Text = text_pass.Text = text_username.Text = " ";

            profile.ShowDialog();
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            log login = new log();
            login.ShowDialog();
            this.Close();
        }
    }
}
