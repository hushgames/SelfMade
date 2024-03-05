namespace ParkingSystem
{
    partial class Login
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
            loginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            usernameTxtBox = new TextBox();
            PassTxtBox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(381, 324);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 35);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 179);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Admin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 227);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(355, 179);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(151, 27);
            usernameTxtBox.TabIndex = 3;
            // 
            // PassTxtBox
            // 
            PassTxtBox.Location = new Point(355, 227);
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.PasswordChar = '*';
            PassTxtBox.Size = new Size(151, 27);
            PassTxtBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_03_01_192221;
            pictureBox1.Location = new Point(355, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 160);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(PassTxtBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label label1;
        private Label label2;
        private TextBox usernameTxtBox;
        private TextBox PassTxtBox;
        private PictureBox pictureBox1;
    }
}
