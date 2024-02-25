using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Assignment_PRN211_Slot17
{
    public partial class FrmLisencePlate : Form
    {
        string frame;
        string engine;
        bool phankhoi;
        string uid;
        public FrmLisencePlate()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();
        public FrmLisencePlate(string text1, string text2, string uID)
        {

            InitializeComponent();
            frame = text1;
            engine = text2;
            uid = uID;


        }
        private void PrmLisencePlate_Load(object sender, EventArgs e)
        {

        }

        private void pictureMotor_Click(object sender, EventArgs e)
        {

        }

        private void FrmLisencePlate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string bien = "";
            string cityCode = "";
            string huyenCode = "";
            string charCode = "";
            string bienFinal = "";
            int mId = -1;
            try
            {
                string strSQL1 = "Select a.UserID,b.Frame_number,b.Engine_number,License_plate,PhanKhoi , c.DistrictCode,d.CityCode from Users a JOIN Motorbike b ON a.UserID = b.UserID join Districts c on a.DistrictsID = c.DistrictID join Cities d on a.CityID = d.CityID Where a.UserID =@id  and b.Frame_number =@frame and b.Engine_number =@engine";

                SqlParameter[] sp1 = new SqlParameter[]
                {
                    new SqlParameter("@id",uid),
                    new SqlParameter("@frame",frame),
                    new SqlParameter("@engine",engine)

                };
                IDataReader dr1 = d.executeQuery2(strSQL1, sp1);
                while (dr1.Read())
                {
                    cityCode = dr1.GetString(6); // Đọc dữ liệu từ cột đầu tiên (index 0)
                    huyenCode = dr1.GetString(5);
                }




                dr1.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("bientren50 " + ex.Message);

            }

            string strSQL = "SELECT TOP 1 Number FROM Check_License_plate Where status = 0 and DistrictCode =@huyencode ORDER BY NEWID() ";
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@huyencode",huyenCode),
            };
            IDataReader dr = d.executeQuery2(strSQL, sp);
            while (dr.Read())
            {
                bien = dr.GetString(0); // Đọc dữ liệu từ cột đầu tiên (index 0)
            }
            dr.Close();


            
            bienFinal = cityCode + "-" + huyenCode + " " + bien;
            string strSQL2 = "UPDATE Motorbike SET License_plate =@bien  WHERE UserID=@uid and Frame_number =@frame and Engine_number=@engine";
            SqlParameter[] parameters2 = new SqlParameter[] {
                    new SqlParameter("@bien",bienFinal),
                    new SqlParameter("@uid",uid),
                     new SqlParameter("@frame",frame),
                      new SqlParameter("@engine",engine)

            };
            d.executeNonQuery(strSQL2, parameters2);


            string strSQL3 = "UPDATE Check_License_plate SET status = 1  WHERE DistrictCode=@code and Number =@number";
            SqlParameter[] parameters3 = new SqlParameter[] {
                    new SqlParameter("@bien",bienFinal),
                    new SqlParameter("@code",huyenCode),
                     new SqlParameter("@number",bien)
                     
            };
            d.executeNonQuery(strSQL3, parameters3);


            try
            {
                string strSQL5 = "select MotorbikeID from Motorbike where License_plate =@bien";

                SqlParameter[] sp5 = new SqlParameter[]
                {
                    new SqlParameter("@bien",bienFinal)


                };
                IDataReader dr5 = d.executeQuery2(strSQL5, sp5);
                while (dr5.Read())
                {
                    mId = dr5.GetInt32(0); // Đọc dữ liệu từ cột đầu tiên (index 0)
                }




                dr5.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("bientim" + ex.Message);

            }

            this.Hide();
            FrmFinal frmFinal = new FrmFinal(bienFinal, uid, mId);
            frmFinal.Show();
        }
    }
}