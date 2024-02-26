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
   
    public partial class edit_password : Form
    {
        NewsContext db;
        private string username;
        public edit_password(string username)
        {
            InitializeComponent();
            db = new NewsContext();
            this.username = username;
           
        }

        private void change_Click(object sender, EventArgs e)
        {
            author author=db.Authors.Where(a=>a.password==old_pass.Text && a.username==username).SingleOrDefault();
            if(author!=null )
            {
                author.password = new_pass.Text;

                db.SaveChanges();
                MessageBox.Show("Your password changed successfully");

            }
            else
            {
                MessageBox.Show("Invalid pass");
            }
           log log = new log();
            log.ShowDialog();
            this.Close();
        }
       
    }
}
