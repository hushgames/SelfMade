namespace ParkingSystem
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            homeMenu = new ToolStripMenuItem();
            historyMenu = new ToolStripMenuItem();
            logoutMenu = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            parkInBtn = new Button();
            ParkOutBtn = new Button();
            historyList = new ListBox();
            plateNoTxt = new Label();
            txtbPlateNo = new TextBox();
            homeBackBtn = new Button();
            typeTxt = new Label();
            typeCB = new ComboBox();
            brandTxt = new Label();
            brandCB = new ComboBox();
            parkOutTxt = new Label();
            parkOutBoxP = new ListBox();
            adminPic = new PictureBox();
            label1 = new Label();
            confirmPark = new Button();
            parkOutBack = new Button();
            parkOutConfirm = new Button();
            plateNoPOD = new TextBox();
            typePOD = new TextBox();
            brandPOD = new TextBox();
            plateNoTxtPOD = new Label();
            typeTextPOD = new Label();
            brandTextPOD = new Label();
            timeInText = new Label();
            timeInBox = new TextBox();
            timeOutType = new TextBox();
            timeOutText = new Label();
            hrsParkedTxt = new Label();
            hrsParkedBox = new TextBox();
            feeText = new Label();
            feeBox = new TextBox();
            plateNoH = new Label();
            timeInH = new Label();
            timeOutH = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminPic).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeMenu, historyMenu, logoutMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(76, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeMenu
            // 
            homeMenu.Name = "homeMenu";
            homeMenu.Size = new Size(63, 24);
            homeMenu.Text = "Home";
            homeMenu.Click += home_Click;
            // 
            // historyMenu
            // 
            historyMenu.Name = "historyMenu";
            historyMenu.Size = new Size(63, 24);
            historyMenu.Text = "History";
            historyMenu.Click += historyToolStripMenuItem_Click;
            // 
            // logoutMenu
            // 
            logoutMenu.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            logoutMenu.Name = "logoutMenu";
            logoutMenu.Size = new Size(63, 24);
            logoutMenu.Text = "Logout";
            logoutMenu.Click += logout_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // parkInBtn
            // 
            parkInBtn.Location = new Point(302, 106);
            parkInBtn.Name = "parkInBtn";
            parkInBtn.Size = new Size(151, 57);
            parkInBtn.TabIndex = 1;
            parkInBtn.Text = "Park In";
            parkInBtn.UseVisualStyleBackColor = true;
            parkInBtn.Click += parkInBtn_Click;
            // 
            // ParkOutBtn
            // 
            ParkOutBtn.Location = new Point(302, 196);
            ParkOutBtn.Name = "ParkOutBtn";
            ParkOutBtn.Size = new Size(151, 57);
            ParkOutBtn.TabIndex = 2;
            ParkOutBtn.Text = "Park Out";
            ParkOutBtn.UseVisualStyleBackColor = true;
            ParkOutBtn.Click += ParkOutBtn_Click;
            // 
            // historyList
            // 
            historyList.FormattingEnabled = true;
            historyList.Location = new Point(125, 72);
            historyList.Name = "historyList";
            historyList.Size = new Size(626, 304);
            historyList.TabIndex = 3;
            historyList.Visible = false;
            // 
            // plateNoTxt
            // 
            plateNoTxt.AutoSize = true;
            plateNoTxt.Location = new Point(247, 83);
            plateNoTxt.Name = "plateNoTxt";
            plateNoTxt.Size = new Size(69, 20);
            plateNoTxt.TabIndex = 4;
            plateNoTxt.Text = "Plate No:";
            plateNoTxt.Visible = false;
            // 
            // txtbPlateNo
            // 
            txtbPlateNo.Location = new Point(322, 80);
            txtbPlateNo.Name = "txtbPlateNo";
            txtbPlateNo.Size = new Size(163, 27);
            txtbPlateNo.TabIndex = 5;
            txtbPlateNo.Visible = false;
            // 
            // homeBackBtn
            // 
            homeBackBtn.Location = new Point(220, 307);
            homeBackBtn.Name = "homeBackBtn";
            homeBackBtn.Size = new Size(94, 29);
            homeBackBtn.TabIndex = 6;
            homeBackBtn.Text = "Back";
            homeBackBtn.UseVisualStyleBackColor = true;
            homeBackBtn.Visible = false;
            homeBackBtn.Click += backBtn_Click;
            // 
            // typeTxt
            // 
            typeTxt.AutoSize = true;
            typeTxt.Location = new Point(247, 129);
            typeTxt.Name = "typeTxt";
            typeTxt.Size = new Size(43, 20);
            typeTxt.TabIndex = 7;
            typeTxt.Text = "Type:";
            typeTxt.Visible = false;
            // 
            // typeCB
            // 
            typeCB.FormattingEnabled = true;
            typeCB.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan" });
            typeCB.Location = new Point(322, 129);
            typeCB.Name = "typeCB";
            typeCB.Size = new Size(163, 28);
            typeCB.TabIndex = 8;
            typeCB.Text = "Select Vehicle Type";
            typeCB.Visible = false;
            typeCB.SelectedIndexChanged += typeCB_SelectedIndexChanged;
            // 
            // brandTxt
            // 
            brandTxt.AutoSize = true;
            brandTxt.Location = new Point(247, 173);
            brandTxt.Name = "brandTxt";
            brandTxt.Size = new Size(51, 20);
            brandTxt.TabIndex = 9;
            brandTxt.Text = "Brand:";
            brandTxt.Visible = false;
            // 
            // brandCB
            // 
            brandCB.FormattingEnabled = true;
            brandCB.Location = new Point(322, 173);
            brandCB.Name = "brandCB";
            brandCB.Size = new Size(163, 28);
            brandCB.TabIndex = 10;
            brandCB.Text = "Select Vehicle Brand";
            brandCB.Visible = false;
            brandCB.SelectedIndexChanged += brandCB_SelectedIndexChanged;
            // 
            // parkOutTxt
            // 
            parkOutTxt.AutoSize = true;
            parkOutTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkOutTxt.Location = new Point(322, 12);
            parkOutTxt.Name = "parkOutTxt";
            parkOutTxt.Size = new Size(232, 25);
            parkOutTxt.TabIndex = 11;
            parkOutTxt.Text = "Select Vehicle to Park Out";
            parkOutTxt.Visible = false;
            // 
            // parkOutBoxP
            // 
            parkOutBoxP.FormattingEnabled = true;
            parkOutBoxP.Location = new Point(575, 57);
            parkOutBoxP.Name = "parkOutBoxP";
            parkOutBoxP.Size = new Size(162, 364);
            parkOutBoxP.TabIndex = 12;
            parkOutBoxP.Visible = false;
            parkOutBoxP.SelectedIndexChanged += parkOutBoxP_SelectedIndexChanged;
            // 
            // adminPic
            // 
            adminPic.Image = Properties.Resources.Screenshot_2024_03_01_192221;
            adminPic.Location = new Point(12, 352);
            adminPic.Name = "adminPic";
            adminPic.Size = new Size(50, 49);
            adminPic.TabIndex = 13;
            adminPic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 404);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 14;
            label1.Text = "Admin";
            // 
            // confirmPark
            // 
            confirmPark.Location = new Point(492, 307);
            confirmPark.Name = "confirmPark";
            confirmPark.Size = new Size(94, 29);
            confirmPark.TabIndex = 15;
            confirmPark.Text = "Confirm";
            confirmPark.UseVisualStyleBackColor = true;
            confirmPark.Visible = false;
            confirmPark.Click += button1_Click;
            // 
            // parkOutBack
            // 
            parkOutBack.Location = new Point(186, 395);
            parkOutBack.Name = "parkOutBack";
            parkOutBack.Size = new Size(94, 29);
            parkOutBack.TabIndex = 16;
            parkOutBack.Text = "Back";
            parkOutBack.UseVisualStyleBackColor = true;
            parkOutBack.Visible = false;
            parkOutBack.Click += parkOutBack_Click;
            // 
            // parkOutConfirm
            // 
            parkOutConfirm.Location = new Point(460, 395);
            parkOutConfirm.Name = "parkOutConfirm";
            parkOutConfirm.Size = new Size(94, 29);
            parkOutConfirm.TabIndex = 17;
            parkOutConfirm.Text = "Confirm";
            parkOutConfirm.UseVisualStyleBackColor = true;
            parkOutConfirm.Visible = false;
            parkOutConfirm.Click += parkOutConfirm_Click;
            // 
            // plateNoPOD
            // 
            plateNoPOD.Enabled = false;
            plateNoPOD.Location = new Point(322, 80);
            plateNoPOD.Name = "plateNoPOD";
            plateNoPOD.Size = new Size(163, 27);
            plateNoPOD.TabIndex = 18;
            plateNoPOD.Visible = false;
            // 
            // typePOD
            // 
            typePOD.Enabled = false;
            typePOD.Location = new Point(322, 130);
            typePOD.Name = "typePOD";
            typePOD.Size = new Size(163, 27);
            typePOD.TabIndex = 19;
            typePOD.Visible = false;
            // 
            // brandPOD
            // 
            brandPOD.Enabled = false;
            brandPOD.Location = new Point(322, 173);
            brandPOD.Name = "brandPOD";
            brandPOD.Size = new Size(163, 27);
            brandPOD.TabIndex = 20;
            brandPOD.Visible = false;
            // 
            // plateNoTxtPOD
            // 
            plateNoTxtPOD.AutoSize = true;
            plateNoTxtPOD.Location = new Point(229, 83);
            plateNoTxtPOD.Name = "plateNoTxtPOD";
            plateNoTxtPOD.Size = new Size(69, 20);
            plateNoTxtPOD.TabIndex = 21;
            plateNoTxtPOD.Text = "Plate No:";
            plateNoTxtPOD.Visible = false;
            // 
            // typeTextPOD
            // 
            typeTextPOD.AutoSize = true;
            typeTextPOD.Location = new Point(229, 132);
            typeTextPOD.Name = "typeTextPOD";
            typeTextPOD.Size = new Size(43, 20);
            typeTextPOD.TabIndex = 22;
            typeTextPOD.Text = "Type:";
            typeTextPOD.Visible = false;
            // 
            // brandTextPOD
            // 
            brandTextPOD.AutoSize = true;
            brandTextPOD.Location = new Point(229, 176);
            brandTextPOD.Name = "brandTextPOD";
            brandTextPOD.Size = new Size(51, 20);
            brandTextPOD.TabIndex = 23;
            brandTextPOD.Text = "Brand:";
            brandTextPOD.Visible = false;
            // 
            // timeInText
            // 
            timeInText.AutoSize = true;
            timeInText.Location = new Point(229, 219);
            timeInText.Name = "timeInText";
            timeInText.Size = new Size(61, 20);
            timeInText.TabIndex = 24;
            timeInText.Text = "Time In:";
            timeInText.Visible = false;
            // 
            // timeInBox
            // 
            timeInBox.Enabled = false;
            timeInBox.Location = new Point(322, 216);
            timeInBox.Name = "timeInBox";
            timeInBox.Size = new Size(163, 27);
            timeInBox.TabIndex = 25;
            timeInBox.Visible = false;
            // 
            // timeOutType
            // 
            timeOutType.Location = new Point(322, 259);
            timeOutType.Name = "timeOutType";
            timeOutType.Size = new Size(163, 27);
            timeOutType.TabIndex = 26;
            timeOutType.Visible = false;
            // 
            // timeOutText
            // 
            timeOutText.AutoSize = true;
            timeOutText.Location = new Point(229, 262);
            timeOutText.Name = "timeOutText";
            timeOutText.Size = new Size(73, 20);
            timeOutText.TabIndex = 27;
            timeOutText.Text = "Time Out:";
            timeOutText.Visible = false;
            // 
            // hrsParkedTxt
            // 
            hrsParkedTxt.AutoSize = true;
            hrsParkedTxt.Location = new Point(230, 307);
            hrsParkedTxt.Name = "hrsParkedTxt";
            hrsParkedTxt.Size = new Size(82, 20);
            hrsParkedTxt.TabIndex = 28;
            hrsParkedTxt.Text = "Hrs Parked:";
            hrsParkedTxt.Visible = false;
            hrsParkedTxt.Click += label2_Click;
            // 
            // hrsParkedBox
            // 
            hrsParkedBox.Enabled = false;
            hrsParkedBox.Location = new Point(322, 304);
            hrsParkedBox.Name = "hrsParkedBox";
            hrsParkedBox.Size = new Size(163, 27);
            hrsParkedBox.TabIndex = 29;
            hrsParkedBox.Visible = false;
            // 
            // feeText
            // 
            feeText.AutoSize = true;
            feeText.Location = new Point(230, 352);
            feeText.Name = "feeText";
            feeText.Size = new Size(72, 20);
            feeText.TabIndex = 30;
            feeText.Text = "Total Fee:";
            feeText.Visible = false;
            feeText.Click += label2_Click_1;
            // 
            // feeBox
            // 
            feeBox.Enabled = false;
            feeBox.Location = new Point(322, 349);
            feeBox.Name = "feeBox";
            feeBox.Size = new Size(163, 27);
            feeBox.TabIndex = 31;
            feeBox.Visible = false;
            // 
            // plateNoH
            // 
            plateNoH.AutoSize = true;
            plateNoH.Location = new Point(154, 49);
            plateNoH.Name = "plateNoH";
            plateNoH.Size = new Size(66, 20);
            plateNoH.TabIndex = 32;
            plateNoH.Text = "Plate No";
            plateNoH.Visible = false;
            // 
            // timeInH
            // 
            timeInH.AutoSize = true;
            timeInH.Location = new Point(405, 49);
            timeInH.Name = "timeInH";
            timeInH.Size = new Size(58, 20);
            timeInH.TabIndex = 33;
            timeInH.Text = "Time In";
            timeInH.Visible = false;
            // 
            // timeOutH
            // 
            timeOutH.AutoSize = true;
            timeOutH.Location = new Point(616, 49);
            timeOutH.Name = "timeOutH";
            timeOutH.Size = new Size(70, 20);
            timeOutH.TabIndex = 34;
            timeOutH.Text = "Time Out";
            timeOutH.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(timeOutH);
            Controls.Add(timeInH);
            Controls.Add(plateNoH);
            Controls.Add(feeBox);
            Controls.Add(feeText);
            Controls.Add(hrsParkedBox);
            Controls.Add(hrsParkedTxt);
            Controls.Add(timeOutText);
            Controls.Add(timeOutType);
            Controls.Add(timeInBox);
            Controls.Add(timeInText);
            Controls.Add(brandTextPOD);
            Controls.Add(typeTextPOD);
            Controls.Add(plateNoTxtPOD);
            Controls.Add(brandPOD);
            Controls.Add(typePOD);
            Controls.Add(plateNoPOD);
            Controls.Add(parkOutConfirm);
            Controls.Add(parkOutBack);
            Controls.Add(confirmPark);
            Controls.Add(label1);
            Controls.Add(adminPic);
            Controls.Add(parkOutBoxP);
            Controls.Add(parkOutTxt);
            Controls.Add(brandCB);
            Controls.Add(brandTxt);
            Controls.Add(typeCB);
            Controls.Add(typeTxt);
            Controls.Add(homeBackBtn);
            Controls.Add(txtbPlateNo);
            Controls.Add(plateNoTxt);
            Controls.Add(historyList);
            Controls.Add(ParkOutBtn);
            Controls.Add(parkInBtn);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeMenu;
        private ToolStripMenuItem historyMenu;
        private ToolStripMenuItem logoutMenu;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Button parkInBtn;
        private Button ParkOutBtn;
        private ListBox historyList;
        private Label plateNoTxt;
        private TextBox txtbPlateNo;
        private Button homeBackBtn;
        private Label brandTxt;
        private Label typeTxt;
        private ComboBox typeCB;
        private ComboBox brandCB;
        private Label parkOutTxt;
        private ListBox parkOutBoxP;
        private PictureBox adminPic;
        private Label label1;
        private Button confirmPark;
        private Button parkOutBack;
        private Button parkOutConfirm;
        private TextBox plateNoPOD;
        private TextBox typePOD;
        private TextBox brandPOD;
        private Label plateNoTxtPOD;
        private Label typeTextPOD;
        private Label brandTextPOD;
        private Label timeInText;
        private TextBox timeInBox;
        private TextBox timeOutType;
        private Label timeOutText;
        private Label hrsParkedTxt;
        private TextBox hrsParkedBox;
        private Label feeText;
        private TextBox feeBox;
        private Label plateNoH;
        private Label timeInH;
        private Label timeOutH;
    }
}