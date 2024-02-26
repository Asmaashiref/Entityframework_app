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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EFtask2
{
    public partial class profile : Form
    {
        private string name;
        private int autherid;
        NewsContext db;
        public profile(string name, int autherid)
        {
            InitializeComponent();
            this.name = name;
            this.autherid = autherid;
            db = new NewsContext();
        }


        private void profile_Load(object sender, EventArgs e)
        {
            aut_name.Text = name;

            cm_category.DataSource = db.Catalogs.ToList();
            cm_category.ValueMember = "Id";
            cm_category.DisplayMember = "Name";



        }

        private void shownew_Click(object sender, EventArgs e)
        {
            dgv_news.DataSource = db.News.Select(n => new { n.Id, n.title, n.bref, n.time, n.date, n.Catalog.Name }).ToList();
        }

        private void add_Click(object sender, EventArgs e)
        {



            news n = new news()
            {
                title = text_title.Text,
                bref = text_bref.Text,
                //time = TimeOnly.Parse(text_time.Text),
                time = TimeOnly.FromDateTime(DateTime.Now),
                date = DateOnly.FromDateTime(DateTime.Now),
                cat_id = (int)cm_category.SelectedValue,
                aut_id = autherid

            };

            db.News.Add(n);
            db.SaveChanges();

            MessageBox.Show("news added successfully");
            text_bref.Text = text_title.Text =  cm_category.Text= " ";
        }

        private void mynew_Click(object sender, EventArgs e)
        {
            dgv_news.DataSource = db.News.Where(n => n.aut_id == autherid).Select(n => new { n.Id, n.title, n.bref, n.time, n.date, n.Catalog.Name }).ToList();

        }
    }
}
