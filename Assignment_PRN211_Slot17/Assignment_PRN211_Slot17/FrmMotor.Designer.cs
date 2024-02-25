namespace Assignment_PRN211_Slot17
{
    partial class FrmMotor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMotor));
            label1 = new Label();
            lblENameMotor = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtColor = new TextBox();
            lblEFrame = new Label();
            label5 = new Label();
            txtFrame = new TextBox();
            txtEngine = new TextBox();
            imageList1 = new ImageList(components);
            pbMotor = new PictureBox();
            lblEPic = new Label();
            label7 = new Label();
            lblEColor = new Label();
            label9 = new Label();
            lblEEngine = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            btnUpload = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblAnh = new Label();
            lblColor = new Label();
            lblFrame = new Label();
            lblEngine = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMotor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(121, 24);
            label1.Name = "label1";
            label1.Size = new Size(585, 53);
            label1.TabIndex = 0;
            label1.Text = "Phiếu điền thông tin xe máy";
            // 
            // lblENameMotor
            // 
            lblENameMotor.AutoSize = true;
            lblENameMotor.Location = new Point(153, 94);
            lblENameMotor.Name = "lblENameMotor";
            lblENameMotor.Size = new Size(0, 20);
            lblENameMotor.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 182);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Màu sắc:";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(98, 182);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(167, 27);
            txtColor.TabIndex = 4;
            // 
            // lblEFrame
            // 
            lblEFrame.AutoSize = true;
            lblEFrame.Location = new Point(153, 228);
            lblEFrame.Name = "lblEFrame";
            lblEFrame.Size = new Size(0, 20);
            lblEFrame.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 251);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Số Khung:";
            // 
            // txtFrame
            // 
            txtFrame.Location = new Point(98, 251);
            txtFrame.Name = "txtFrame";
            txtFrame.Size = new Size(167, 27);
            txtFrame.TabIndex = 7;
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(98, 316);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(167, 27);
            txtEngine.TabIndex = 8;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pbMotor
            // 
            pbMotor.Location = new Point(425, 117);
            pbMotor.Name = "pbMotor";
            pbMotor.Size = new Size(238, 194);
            pbMotor.TabIndex = 9;
            pbMotor.TabStop = false;
            // 
            // lblEPic
            // 
            lblEPic.AutoSize = true;
            lblEPic.Location = new Point(400, 94);
            lblEPic.Name = "lblEPic";
            lblEPic.Size = new Size(0, 20);
            lblEPic.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 120);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 11;
            label7.Text = "Tên:";
            // 
            // lblEColor
            // 
            lblEColor.AutoSize = true;
            lblEColor.Location = new Point(153, 166);
            lblEColor.Name = "lblEColor";
            lblEColor.Size = new Size(0, 20);
            lblEColor.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 319);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 13;
            label9.Text = "Số máy:";
            // 
            // lblEEngine
            // 
            lblEEngine.AutoSize = true;
            lblEEngine.Location = new Point(153, 296);
            lblEEngine.Name = "lblEEngine";
            lblEEngine.Size = new Size(0, 20);
            lblEEngine.TabIndex = 14;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(85, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(236, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(460, 322);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 17;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(560, 322);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Red;
            lblName.Location = new Point(97, 94);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 19;
            lblName.Text = "label2";
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.BackColor = Color.Red;
            lblAnh.Location = new Point(425, 77);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(50, 20);
            lblAnh.TabIndex = 20;
            lblAnh.Text = "label4";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.BackColor = Color.Red;
            lblColor.Location = new Point(97, 159);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(50, 20);
            lblColor.TabIndex = 21;
            lblColor.Text = "label6";
            // 
            // lblFrame
            // 
            lblFrame.AutoSize = true;
            lblFrame.BackColor = Color.Red;
            lblFrame.Location = new Point(97, 228);
            lblFrame.Name = "lblFrame";
            lblFrame.Size = new Size(50, 20);
            lblFrame.TabIndex = 22;
            lblFrame.Text = "label8";
            // 
            // lblEngine
            // 
            lblEngine.AutoSize = true;
            lblEngine.BackColor = Color.Red;
            lblEngine.Location = new Point(97, 296);
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new Size(58, 20);
            lblEngine.TabIndex = 23;
            lblEngine.Text = "label10";
            // 
            // FrmMotor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(776, 503);
            Controls.Add(lblEngine);
            Controls.Add(lblFrame);
            Controls.Add(lblColor);
            Controls.Add(lblAnh);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnUpload);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(lblEEngine);
            Controls.Add(label9);
            Controls.Add(lblEColor);
            Controls.Add(label7);
            Controls.Add(lblEPic);
            Controls.Add(pbMotor);
            Controls.Add(txtEngine);
            Controls.Add(txtFrame);
            Controls.Add(label5);
            Controls.Add(lblEFrame);
            Controls.Add(txtColor);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(lblENameMotor);
            Controls.Add(label1);
            Name = "FrmMotor";
            Text = "FrmMotor";
            Load += FrmMotor_Load;
            ((System.ComponentModel.ISupportInitialize)pbMotor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblENameMotor;
        private TextBox txtName;
        private Label label3;
        private TextBox txtColor;
        private Label lblEFrame;
        private Label label5;
        private TextBox txtFrame;
        private TextBox txtEngine;
        private ImageList imageList1;
        private PictureBox pbMotor;
        private Label lblEPic;
        private Label label7;
        private Label lblEColor;
        private Label label9;
        private Label lblEEngine;
        private Button btnSubmit;
        private Button btnBack;
        private Button btnUpload;
        private Button btnCancel;
        private Label lblName;
        private Label lblAnh;
        private Label lblColor;
        private Label lblFrame;
        private Label lblEngine;
    }
}