using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_PRN211_Slot17
{
    public partial class FrmFinal : Form
    {
        string liCuoi;
        string userID;
        int motorID;
       
        public FrmFinal()
        {
            InitializeComponent();
        }

        public FrmFinal(string bienFinal, string uid, int mId)
        {
            InitializeComponent();
            liCuoi = bienFinal;
            userID = uid;
            motorID = mId;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataProvider d = new DataProvider();
        string userName = "";
        string motorName = "";
        string pic = "";

        private void FrmFinal_Load(object sender, EventArgs e)
        {
            string strSQL = "Select UserName from Users where UserID = @id";
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@id",userID),
            };
            IDataReader dr = d.executeQuery2(strSQL, sp);
            while (dr.Read())
            {
                userName = dr.GetString(0); // Đọc dữ liệu từ cột đầu tiên (index 0)
            }
            dr.Close();


            string strSQL1 = "select MotorName,Picture from Motorbike where MotorbikeID = @id";
            SqlParameter[] sp1 = new SqlParameter[]
            {
                 new SqlParameter("@id",motorID),
            };
            IDataReader dr1 = d.executeQuery2(strSQL1, sp1);
            while (dr1.Read())
            {
                motorName = dr1.GetString(0); // Đọc dữ liệu từ cột đầu tiên (index 0)
                pic = dr1.GetString(1);
            }
            dr1.Close();






            lblName.Text = "Chúc mừng " + userName + " đã bốc được biển số";
            lblBien.Text = liCuoi;
            lblXe.Text = "Cho chiếc xe " + motorName;
            pbAnh.Image = Image.FromFile(pic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
