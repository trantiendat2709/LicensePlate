namespace Assignment_PRN211_Slot17
{
    partial class FrmLisencePlate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLisencePlate));
            lblTest = new Label();
            btnBam = new Button();
            SuspendLayout();
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.BackColor = SystemColors.HighlightText;
            lblTest.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTest.ForeColor = SystemColors.Highlight;
            lblTest.Location = new Point(147, 43);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(480, 51);
            lblTest.TabIndex = 1;
            lblTest.Text = "Bấm nút để nhận biển số";
            // 
            // btnBam
            // 
            btnBam.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBam.Location = new Point(293, 123);
            btnBam.Name = "btnBam";
            btnBam.Size = new Size(223, 117);
            btnBam.TabIndex = 3;
            btnBam.Text = "Bấm Biển";
            btnBam.UseVisualStyleBackColor = true;
            btnBam.Click += button1_Click;
            // 
            // FrmLisencePlate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(795, 355);
            Controls.Add(btnBam);
            Controls.Add(lblTest);
            Name = "FrmLisencePlate";
            Text = "PrmLisencePlate";
            Load += FrmLisencePlate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTest;
        private Button btnBam;
    }
}