using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_PRN211_Slot17
{
    public partial class FrmMotor : Form
    {
        public FrmMotor()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();
        string uID;
        public FrmMotor(string v1)
        {

            InitializeComponent();
            uID = v1;
        }

        private string imagePath = "";
        private int v;

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính cho hộp thoại mở tập tin
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Ảnh Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tập tin

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lưu đường dẫn của ảnh vào biến imagePath
                    imagePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    pbMotor.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải lên ảnh: " + ex.Message);
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                lblName.Text = "Chưa nhập tên xe";
            }
            else
            {
                lblName.Text = "";
            }

            if (txtColor.Text.Length == 0)
            {
                lblColor.Text = "Chưa nhập màu xe";
            }
            else
            {
                lblColor.Text = "";
            }


            try
            {
                string strSQL = "Select * from Motorbike where Frame_number =@frame";
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("frame",txtFrame.Text),

                };
                IDataReader dr = d.executeQuery2(strSQL, sp);
                if (dr.Read())
                {
                    lblFrame.Text = "Số khung đã tồn tại";
                }
                else
                {
                    if (txtFrame.Text.Length != 10)
                    {
                        lblFrame.Text = "Số khung gồm 10 chữ số";
                    }
                    else
                    {
                        lblFrame.Text = "";
                    }
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Frame_number fail" + ex.Message);

            }

           //-----

            try
            {
                string strSQL = "Select * from Motorbike where Engine_number =@engine";
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("engine",txtEngine.Text),

                };
                IDataReader dr = d.executeQuery2(strSQL, sp);
                if (dr.Read())
                {
                    lblFrame.Text = "Số máy đã tồn tại";
                }
                else
                {
                    if (txtEngine.Text.Length != 10)
                    {
                        lblEngine.Text = "Số máy gồm 10 chữ số";
                    }
                    else
                    {
                        lblEngine.Text = "";
                    }
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Engine_number fail" + ex.Message);

            }




            // Sao chép ảnh vào thư mục trong project
            string destinationFilePath = "";
            string destinationPath = @"D:\PRN211\Assignment_PRN211_Slot17\Assignment_PRN211_Slot17\Images";
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }
            string fileName = Path.GetFileName(imagePath);


            if (pbMotor.Image == null)
            {
                lblAnh.Text = "Chưa chọn ảnh";
            }
            else
            {
                lblAnh.Text = "";
                destinationFilePath = Path.Combine(destinationPath, fileName);
                File.Copy(imagePath, destinationFilePath, true);
            }



            if (lblAnh.Text.Length == 0 && lblColor.Text.Length == 0 && lblEngine.Text.Length == 0
                && lblFrame.Text.Length == 0 && lblName.Text.Length == 0)
            {

               
                // Trên 50 là 1 dưới 50 là 0
                string strSQL = "INSERT INTO Motorbike(MotorName,Color,Frame_number,Engine_number,UserID,Picture)" +
                    "VALUES(@name,@color,@frame,@engine,@uid,@picture)";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@name",txtName.Text),
                new SqlParameter("@color",txtColor.Text),
                new SqlParameter("@frame",txtFrame.Text),
                new SqlParameter("@engine",txtEngine.Text),
                new SqlParameter("@uid",uID),
                    new SqlParameter("@picture",destinationFilePath)
                    


            };
                if (d.executeNonQuery(strSQL, parameters))
                {

                   
                    this.Hide();
                    FrmLisencePlate frmLisence = new FrmLisencePlate(txtEngine.Text, txtFrame.Text, uID);
                    frmLisence.Show();
                }

            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pbMotor.Image = null;
        }

        private void FrmMotor_Load(object sender, EventArgs e)
        {




        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

