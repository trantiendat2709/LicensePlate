namespace Assignment_PRN211_Slot17
{
    partial class FrmFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinal));
            lblName = new Label();
            lblBien = new Label();
            lblXe = new Label();
            pbAnh = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAnh).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(187, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(334, 22);
            lblName.TabIndex = 0;
            lblName.Text = "g anh Nguyễn Văn A đã bốc được biển số";
            lblName.Click += lblName_Click;
            // 
            // lblBien
            // 
            lblBien.AutoSize = true;
            lblBien.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBien.Location = new Point(282, 81);
            lblBien.Name = "lblBien";
            lblBien.Size = new Size(168, 53);
            lblBien.TabIndex = 1;
            lblBien.Text = "Biển số";
            lblBien.Click += label2_Click;
            // 
            // lblXe
            // 
            lblXe.AutoSize = true;
            lblXe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblXe.Location = new Point(216, 171);
            lblXe.Name = "lblXe";
            lblXe.Size = new Size(360, 22);
            lblXe.TabIndex = 2;
            lblXe.Text = "Cho chiếc xe mang nhãn hiệu Honda EX 150";
            // 
            // pbAnh
            // 
            pbAnh.Location = new Point(244, 205);
            pbAnh.Name = "pbAnh";
            pbAnh.Size = new Size(269, 179);
            pbAnh.TabIndex = 3;
            pbAnh.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(268, 401);
            button1.Name = "button1";
            button1.Size = new Size(182, 29);
            button1.TabIndex = 4;
            button1.Text = "Back To Homepage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmFinal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 455);
            Controls.Add(button1);
            Controls.Add(pbAnh);
            Controls.Add(lblXe);
            Controls.Add(lblBien);
            Controls.Add(lblName);
            Name = "FrmFinal";
            Text = "FrmFinal";
            Load += FrmFinal_Load;
            ((System.ComponentModel.ISupportInitialize)pbAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblBien;
        private Label lblXe;
        private PictureBox pbAnh;
        private Button button1;
    }
}