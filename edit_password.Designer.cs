namespace EFtask2
{
    partial class edit_password
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
            label1 = new Label();
            old_pass = new TextBox();
            change = new Button();
            label2 = new Label();
            new_pass = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 235);
            label1.Name = "label1";
            label1.Size = new Size(151, 81);
            label1.TabIndex = 0;
            label1.Text = "Old ";
            // 
            // old_pass
            // 
            old_pass.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            old_pass.Location = new Point(269, 235);
            old_pass.Name = "old_pass";
            old_pass.Size = new Size(366, 78);
            old_pass.TabIndex = 1;
            // 
            // change
            // 
            change.BackColor = Color.Thistle;
            change.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change.Location = new Point(144, 638);
            change.Name = "change";
            change.Size = new Size(446, 93);
            change.TabIndex = 2;
            change.Text = "Change password";
            change.UseVisualStyleBackColor = false;
            change.Click += change_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 424);
            label2.Name = "label2";
            label2.Size = new Size(162, 81);
            label2.TabIndex = 3;
            label2.Text = "New";
            // 
            // new_pass
            // 
            new_pass.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_pass.Location = new Point(264, 429);
            new_pass.Name = "new_pass";
            new_pass.Size = new Size(366, 78);
            new_pass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 47);
            label3.Name = "label3";
            label3.Size = new Size(427, 81);
            label3.TabIndex = 5;
            label3.Text = "Edit password";
            // 
            // edit_password
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sign1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 1025);
            Controls.Add(label3);
            Controls.Add(new_pass);
            Controls.Add(label2);
            Controls.Add(change);
            Controls.Add(old_pass);
            Controls.Add(label1);
            Name = "edit_password";
            Text = "edit_password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox old_pass;
        private Button change;
        private Label label2;
        private TextBox new_pass;
        private Label label3;
    }
}