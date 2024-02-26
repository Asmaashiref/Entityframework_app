namespace EFtask2
{
    partial class profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            add = new Button();
            label1 = new Label();
            text_title = new TextBox();
            cm_category = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            text_bref = new TextBox();
            label3 = new Label();
            shownew = new Button();
            dgv_news = new DataGridView();
            mynew = new Button();
            aut_name = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // add
            // 
            add.BackColor = Color.Lavender;
            add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(330, 402);
            add.Name = "add";
            add.Size = new Size(333, 98);
            add.TabIndex = 0;
            add.Text = "Add news";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(196, 72);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // text_title
            // 
            text_title.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_title.Location = new Point(752, 22);
            text_title.Name = "text_title";
            text_title.Size = new Size(438, 78);
            text_title.TabIndex = 2;
            // 
            // cm_category
            // 
            cm_category.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cm_category.FormattingEnabled = true;
            cm_category.Location = new Point(752, 268);
            cm_category.Name = "cm_category";
            cm_category.Size = new Size(438, 79);
            cm_category.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(578, 17);
            label2.Name = "label2";
            label2.Size = new Size(159, 81);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(578, 115);
            label4.Name = "label4";
            label4.Size = new Size(151, 81);
            label4.TabIndex = 7;
            label4.Text = "bref";
            // 
            // text_bref
            // 
            text_bref.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_bref.Location = new Point(752, 139);
            text_bref.Name = "text_bref";
            text_bref.Size = new Size(438, 78);
            text_bref.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 242);
            label3.Name = "label3";
            label3.Size = new Size(291, 81);
            label3.TabIndex = 13;
            label3.Text = "Category";
            // 
            // shownew
            // 
            shownew.BackColor = Color.Lavender;
            shownew.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shownew.Location = new Point(1155, 402);
            shownew.Name = "shownew";
            shownew.Size = new Size(440, 98);
            shownew.TabIndex = 14;
            shownew.Text = "Show all news";
            shownew.UseVisualStyleBackColor = false;
            shownew.Click += shownew_Click;
            // 
            // dgv_news
            // 
            dgv_news.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(154, 538);
            dgv_news.Name = "dgv_news";
            dgv_news.RowHeadersWidth = 102;
            dgv_news.Size = new Size(1564, 442);
            dgv_news.TabIndex = 15;
            // 
            // mynew
            // 
            mynew.BackColor = Color.Lavender;
            mynew.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mynew.Location = new Point(736, 402);
            mynew.Name = "mynew";
            mynew.Size = new Size(333, 98);
            mynew.TabIndex = 16;
            mynew.Text = "My news";
            mynew.UseVisualStyleBackColor = false;
            mynew.Click += mynew_Click;
            // 
            // aut_name
            // 
            aut_name.AutoSize = true;
            aut_name.BackColor = Color.Transparent;
            aut_name.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aut_name.Location = new Point(226, 28);
            aut_name.Name = "aut_name";
            aut_name.Size = new Size(0, 72);
            aut_name.TabIndex = 17;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.profile;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1901, 1024);
            Controls.Add(aut_name);
            Controls.Add(mynew);
            Controls.Add(dgv_news);
            Controls.Add(shownew);
            Controls.Add(label3);
            Controls.Add(text_bref);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cm_category);
            Controls.Add(text_title);
            Controls.Add(label1);
            Controls.Add(add);
            Name = "profile";
            Text = "profile";
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private Label label1;
        private TextBox text_title;
        private ComboBox cm_category;
        private Label label2;
        private Label label4;
        private TextBox text_bref;
        private Label label3;
        private Button shownew;
        private DataGridView dgv_news;
        private Button mynew;
        private Label aut_name;
    }
}