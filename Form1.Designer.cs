namespace EFtask2
{
    partial class signup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            sign = new Label();
            text_name = new TextBox();
            btnsign = new Button();
            name = new Label();
            age = new Label();
            text_age = new TextBox();
            label1 = new Label();
            text_pass = new TextBox();
            label2 = new Label();
            text_username = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // sign
            // 
            sign.AutoSize = true;
            sign.BackColor = Color.Transparent;
            sign.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign.Location = new Point(586, -1);
            sign.Name = "sign";
            sign.Size = new Size(542, 159);
            sign.TabIndex = 0;
            sign.Text = "Sign Up ";
            // 
            // text_name
            // 
            text_name.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_name.Location = new Point(669, 245);
            text_name.Name = "text_name";
            text_name.Size = new Size(466, 97);
            text_name.TabIndex = 1;
            // 
            // btnsign
            // 
            btnsign.BackColor = Color.Thistle;
            btnsign.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsign.Location = new Point(386, 861);
            btnsign.Name = "btnsign";
            btnsign.Size = new Size(347, 98);
            btnsign.TabIndex = 2;
            btnsign.Text = "sign up";
            btnsign.UseVisualStyleBackColor = false;
            btnsign.Click += btnsign_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(424, 248);
            name.Name = "name";
            name.Size = new Size(224, 89);
            name.TabIndex = 3;
            name.Text = "Name";
            // 
            // age
            // 
            age.AutoSize = true;
            age.BackColor = Color.Transparent;
            age.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            age.Location = new Point(447, 396);
            age.Name = "age";
            age.Size = new Size(162, 89);
            age.TabIndex = 4;
            age.Text = "Age";
            // 
            // text_age
            // 
            text_age.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_age.Location = new Point(669, 393);
            text_age.Name = "text_age";
            text_age.Size = new Size(466, 97);
            text_age.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 552);
            label1.Name = "label1";
            label1.Size = new Size(333, 89);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // text_pass
            // 
            text_pass.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_pass.Location = new Point(669, 552);
            text_pass.Name = "text_pass";
            text_pass.Size = new Size(466, 97);
            text_pass.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 704);
            label2.Name = "label2";
            label2.Size = new Size(352, 89);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // text_username
            // 
            text_username.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_username.Location = new Point(669, 701);
            text_username.Name = "text_username";
            text_username.Size = new Size(466, 97);
            text_username.TabIndex = 9;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Thistle;
            btnlogin.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(833, 861);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(347, 98);
            btnlogin.TabIndex = 10;
            btnlogin.Text = "login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1782, 995);
            Controls.Add(btnlogin);
            Controls.Add(text_username);
            Controls.Add(label2);
            Controls.Add(text_pass);
            Controls.Add(label1);
            Controls.Add(text_age);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(btnsign);
            Controls.Add(text_name);
            Controls.Add(sign);
            Name = "signup";
            Text = "sign up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label sign;
        private TextBox text_name;
        private Label name;
        private Label age;
        private TextBox text_age;
        private TextBox text_pass;
        private TextBox text_username;
        private Button btnsign;
        private Button btnlogin;
    }
}
