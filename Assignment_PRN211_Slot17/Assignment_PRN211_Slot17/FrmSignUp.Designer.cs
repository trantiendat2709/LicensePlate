namespace Assignment_PRN211_Slot17
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbCity = new ComboBox();
            lbl = new Label();
            cbHuyen = new ComboBox();
            label5 = new Label();
            txtAdress = new TextBox();
            txtName = new TextBox();
            txtCCCD = new TextBox();
            label7 = new Label();
            txtSDT = new TextBox();
            btnSignUp = new Button();
            btnBack = new Button();
            label8 = new Label();
            label9 = new Label();
            label17 = new Label();
            txtAge = new TextBox();
            txtPW = new TextBox();
            txtCFPW = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            label15 = new Label();
            label6 = new Label();
            lblName = new Label();
            lblGender = new Label();
            lblCCCD = new Label();
            lblAge = new Label();
            lblPhoneNumber = new Label();
            lblPW = new Label();
            lblCFPW = new Label();
            lblCity = new Label();
            lblHuyen = new Label();
            lblAd = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(5, 191);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 267);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 1;
            label2.Text = "Số CCCD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(5, 494);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 2;
            label3.Text = "Địa Chỉ:";
            // 
            // cbCity
            // 
            cbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(73, 494);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(151, 28);
            cbCity.TabIndex = 3;
            cbCity.SelectedIndexChanged += cbCity_SelectedIndexChanged;
            cbCity.Enter += comboBox1_Enter;
            cbCity.Leave += comboBox1_Leave;
            cbCity.MouseEnter += comboBox1_MouseEnter;
            cbCity.MouseLeave += comboBox1_MouseLeave;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(72, 472);
            lbl.Name = "lbl";
            lbl.Size = new Size(78, 20);
            lbl.TabIndex = 4;
            lbl.Text = "Thành Phố";
            // 
            // cbHuyen
            // 
            cbHuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHuyen.FormattingEnabled = true;
            cbHuyen.Location = new Point(240, 494);
            cbHuyen.Name = "cbHuyen";
            cbHuyen.Size = new Size(151, 28);
            cbHuyen.TabIndex = 5;
            cbHuyen.Enter += cbHuyen_Enter;
            cbHuyen.Leave += cbHuyen_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 473);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 6;
            label5.Text = "Quận/Huyện/Thị Xã";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(411, 491);
            txtAdress.Name = "txtAdress";
            txtAdress.PlaceholderText = "Số nhà, Thôn, Xã, Phường, Ấp, Cụm...";
            txtAdress.Size = new Size(307, 27);
            txtAdress.TabIndex = 7;
            txtAdress.Enter += txtAdress_Enter;
            txtAdress.Leave += txtAdress_Leave;
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 191);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nhập họ và tên";
            txtName.Size = new Size(208, 27);
            txtName.TabIndex = 9;
            txtName.Enter += textBox2_Enter;
            txtName.KeyPress += txtName_KeyPress;
            txtName.Leave += textBox2_Leave;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(91, 264);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.PlaceholderText = "Nhập số căn cước công dân";
            txtCCCD.Size = new Size(210, 27);
            txtCCCD.TabIndex = 10;
            txtCCCD.Enter += textBox3_Enter;
            txtCCCD.KeyPress += txtCCCD_KeyPress;
            txtCCCD.Leave += textBox3_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Aquamarine;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(12, 339);
            label7.Name = "label7";
            label7.Size = new Size(41, 22);
            label7.TabIndex = 11;
            label7.Text = "SĐT:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(91, 336);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Nhập số điện thoại";
            txtSDT.Size = new Size(151, 27);
            txtSDT.TabIndex = 12;
            txtSDT.Enter += textBox4_Enter;
            txtSDT.KeyPress += txtSDT_KeyPress;
            txtSDT.Leave += textBox4_Leave;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.PaleTurquoise;
            btnSignUp.Location = new Point(411, 564);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 13;
            btnSignUp.Text = "Đăng Ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveBorder;
            btnBack.Location = new Point(624, 564);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Aquamarine;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(12, 399);
            label8.Name = "label8";
            label8.Size = new Size(77, 22);
            label8.TabIndex = 15;
            label8.Text = "Mật Khẩu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Aquamarine;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(328, 267);
            label9.Name = "label9";
            label9.Size = new Size(43, 22);
            label9.TabIndex = 16;
            label9.Text = "Tuổi:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Aquamarine;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Location = new Point(328, 396);
            label17.Name = "label17";
            label17.Size = new Size(135, 22);
            label17.TabIndex = 24;
            label17.Text = "Nhập lại mật khẩu:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(389, 262);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Nhập tuổi";
            txtAge.Size = new Size(140, 27);
            txtAge.TabIndex = 25;
            txtAge.Enter += txtAge_Enter;
            txtAge.KeyPress += txtAge_KeyPress;
            txtAge.Leave += txtAge_Leave;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(96, 396);
            txtPW.Name = "txtPW";
            txtPW.PasswordChar = '*';
            txtPW.PlaceholderText = "Nhập mật khẩu";
            txtPW.Size = new Size(134, 27);
            txtPW.TabIndex = 26;
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // txtCFPW
            // 
            txtCFPW.Location = new Point(469, 394);
            txtCFPW.Name = "txtCFPW";
            txtCFPW.PasswordChar = '*';
            txtCFPW.PlaceholderText = "Nhắc lại mật khẩu";
            txtCFPW.Size = new Size(138, 27);
            txtCFPW.TabIndex = 27;
            txtCFPW.Enter += txtCFPW_Enter;
            txtCFPW.Leave += txtCFPW_Leave;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(411, 189);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 28;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(479, 189);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 29;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(411, 468);
            label15.Name = "label15";
            label15.Size = new Size(212, 20);
            label15.TabIndex = 30;
            label15.Text = "Xã/Thôn/Cụm/Phường/Số Nhà";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Aquamarine;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(328, 191);
            label6.Name = "label6";
            label6.Size = new Size(70, 22);
            label6.TabIndex = 31;
            label6.Text = "Giới tính:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Red;
            lblName.Location = new Point(91, 168);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 20);
            lblName.TabIndex = 32;
            lblName.Text = "label10";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Red;
            lblGender.Location = new Point(411, 166);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(58, 20);
            lblGender.TabIndex = 33;
            lblGender.Text = "label11";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.BackColor = Color.Red;
            lblCCCD.Location = new Point(92, 241);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(58, 20);
            lblCCCD.TabIndex = 34;
            lblCCCD.Text = "label12";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Red;
            lblAge.Location = new Point(389, 239);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(58, 20);
            lblAge.TabIndex = 35;
            lblAge.Text = "label13";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.Red;
            lblPhoneNumber.Location = new Point(91, 313);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(58, 20);
            lblPhoneNumber.TabIndex = 36;
            lblPhoneNumber.Text = "label14";
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.BackColor = Color.Red;
            lblPW.Location = new Point(96, 373);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(58, 20);
            lblPW.TabIndex = 37;
            lblPW.Text = "label16";
            // 
            // lblCFPW
            // 
            lblCFPW.AutoSize = true;
            lblCFPW.BackColor = Color.Red;
            lblCFPW.Location = new Point(469, 371);
            lblCFPW.Name = "lblCFPW";
            lblCFPW.Size = new Size(58, 20);
            lblCFPW.TabIndex = 38;
            lblCFPW.Text = "label18";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Red;
            lblCity.Location = new Point(73, 527);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(58, 20);
            lblCity.TabIndex = 39;
            lblCity.Text = "label19";
            // 
            // lblHuyen
            // 
            lblHuyen.AutoSize = true;
            lblHuyen.BackColor = Color.Red;
            lblHuyen.Location = new Point(243, 523);
            lblHuyen.Name = "lblHuyen";
            lblHuyen.Size = new Size(58, 20);
            lblHuyen.TabIndex = 40;
            lblHuyen.Text = "label20";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = Color.Red;
            lblAd.Location = new Point(413, 521);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(58, 20);
            lblAd.TabIndex = 41;
            lblAd.Text = "label21";
            // 
            // FrmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(751, 614);
            Controls.Add(lblAd);
            Controls.Add(lblHuyen);
            Controls.Add(lblCity);
            Controls.Add(lblCFPW);
            Controls.Add(lblPW);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblAge);
            Controls.Add(lblCCCD);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Controls.Add(label6);
            Controls.Add(label15);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtCFPW);
            Controls.Add(txtPW);
            Controls.Add(txtAge);
            Controls.Add(label17);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnBack);
            Controls.Add(btnSignUp);
            Controls.Add(txtSDT);
            Controls.Add(label7);
            Controls.Add(txtCCCD);
            Controls.Add(txtName);
            Controls.Add(txtAdress);
            Controls.Add(label5);
            Controls.Add(cbHuyen);
            Controls.Add(lbl);
            Controls.Add(cbCity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSignUp";
            Text = "Sign Up";
            Load += FrmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbCity;
        private Label lbl;
        private ComboBox cbHuyen;
        private Label label5;
        private TextBox txtAdress;

        private TextBox txtName;
        private TextBox txtCCCD;
        private Label label7;
        private TextBox txtSDT;
        private Button btnSignUp;
        private Button btnBack;
        private Label label8;
        private Label label9;

        private Label label17;
        private TextBox txtAge;
        private TextBox txtPW;
        private TextBox txtCFPW;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label label15;
        private Label label6;
        private Label lblName;
        private Label lblGender;
        private Label lblCCCD;
        private Label lblAge;
        private Label lblPhoneNumber;
        private Label lblPW;
        private Label lblCFPW;
        private Label lblCity;
        private Label lblHuyen;
        private Label lblAd;
    }
}