namespace Assignment_PRN211_Slot17
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            label1 = new Label();
            label2 = new Label();
            txtCCCD = new TextBox();
            txtPW = new TextBox();
            lblErrorCCCD = new Label();
            lblErorPW = new Label();
            btnLogIn = new Button();
            btnSignUp = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(54, 225);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Số CCCD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(54, 308);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(149, 225);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.PlaceholderText = "Nhập số căn cước công dân";
            txtCCCD.Size = new Size(209, 27);
            txtCCCD.TabIndex = 2;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            txtCCCD.Enter += textBox1_Enter;
            txtCCCD.Leave += textBox1_Leave;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(149, 305);
            txtPW.Name = "txtPW";
            txtPW.PasswordChar = '*';
            txtPW.PlaceholderText = "Nhập mật khẩu";
            txtPW.Size = new Size(209, 27);
            txtPW.TabIndex = 3;
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += textBox2_Leave;
            // 
            // lblErrorCCCD
            // 
            lblErrorCCCD.AutoSize = true;
            lblErrorCCCD.Location = new Point(149, 202);
            lblErrorCCCD.Name = "lblErrorCCCD";
            lblErrorCCCD.Size = new Size(0, 20);
            lblErrorCCCD.TabIndex = 4;
            // 
            // lblErorPW
            // 
            lblErorPW.AutoSize = true;
            lblErorPW.Location = new Point(149, 282);
            lblErorPW.Name = "lblErorPW";
            lblErorPW.Size = new Size(0, 20);
            lblErorPW.TabIndex = 5;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.PaleTurquoise;
            btnLogIn.Location = new Point(149, 370);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 29);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Đăng Nhập";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.PaleTurquoise;
            btnSignUp.Location = new Point(264, 370);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(411, 225);
            label5.Name = "label5";
            label5.Size = new Size(262, 122);
            label5.TabIndex = 8;
            label5.Text = "1. Winformapp mô phỏng quá trình\r\n đăng ký và bốc biển số xe máy.\r\n\r\n2. Đã bỏ qua hết các quy trình kiểm \r\ntra cùng các loại giấy tờ liên quan \r\nnhư phiếu xuất xưởng, giấy nộp thuế...\r\n";
            label5.Click += label5_Click;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(714, 450);
            Controls.Add(label5);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogIn);
            Controls.Add(lblErorPW);
            Controls.Add(lblErrorCCCD);
            Controls.Add(txtPW);
            Controls.Add(txtCCCD);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogIn";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCCCD;
        private TextBox txtPW;
        private Label lblErrorCCCD;
        private Label lblErorPW;
        private Button btnLogIn;
        private Button btnSignUp;
        private Label label5;
    }
}