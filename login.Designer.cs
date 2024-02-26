namespace EFtask2
{
    partial class log
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
            btn_log = new Button();
            text_user = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textpassword = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_log
            // 
            btn_log.BackColor = Color.Thistle;
            btn_log.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_log.Location = new Point(46, 818);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(338, 103);
            btn_log.TabIndex = 0;
            btn_log.Text = "Login";
            btn_log.UseVisualStyleBackColor = false;
            btn_log.Click += btn_log_Click;
            // 
            // text_user
            // 
            text_user.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_user.Location = new Point(381, 479);
            text_user.Name = "text_user";
            text_user.Size = new Size(370, 78);
            text_user.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 463);
            label1.Name = "label1";
            label1.Size = new Size(332, 81);
            label1.TabIndex = 3;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 629);
            label2.Name = "label2";
            label2.Size = new Size(301, 81);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.profile__1_;
            pictureBox1.Location = new Point(312, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 194);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 26.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 41);
            label3.Name = "label3";
            label3.Size = new Size(302, 116);
            label3.TabIndex = 6;
            label3.Text = "Log in";
            // 
            // textpassword
            // 
            textpassword.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textpassword.Location = new Point(381, 634);
            textpassword.Name = "textpassword";
            textpassword.Size = new Size(370, 78);
            textpassword.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(458, 818);
            button1.Name = "button1";
            button1.Size = new Size(435, 103);
            button1.TabIndex = 8;
            button1.Text = "Edit password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // log
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sign;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 1046);
            Controls.Add(button1);
            Controls.Add(textpassword);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_user);
            Controls.Add(btn_log);
            Name = "log";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_log;
        private TextBox text_user;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textpassword;
        private Button button1;
    }
}