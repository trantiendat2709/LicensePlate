using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_PRN211_Slot17
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Wheat;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.Wheat;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            txtSDT.BackColor = Color.Wheat;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            txtSDT.BackColor = Color.White;
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            cbCity.BackColor = Color.Wheat;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            cbCity.BackColor = Color.White;
        }
        DataProvider d = new DataProvider();
        Dictionary<string, int> myDictionaryCity = new Dictionary<string, int>();
        Dictionary<string, int> myDictionaryHuyen = new Dictionary<string, int>();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
           


            if (txtName.Text.Equals(""))
            {
                lblName.Text = "Chưa nhập họ và tên";
            }
            else
            {
                lblName.Text = "";
            }
            try
            {
                string strSQL = "Select * from Users where Citizen_Card_Code =@cccd";
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("cccd",txtCCCD.Text),

                };
                IDataReader dr = d.executeQuery2(strSQL, sp);
                if (dr.Read())
                {
                    lblCCCD.Text = "Số CCCD đã tồn tại";
                }
                else
                {
                    if (txtCCCD.Text.Length != 12)
                    {
                        lblCCCD.Text = "Căn cước công dân gồm 12 chữ số";
                    }
                    else
                    {
                        lblCCCD.Text = "";
                    }
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Login fail" + ex.Message);

            }




            if (txtSDT.Text.Length != 10)
            {
                lblPhoneNumber.Text = "Số điện thoại gồm 10 số";
            }
            else if (!txtSDT.Text.StartsWith("0"))
            {
                lblPhoneNumber.Text = "Số điện thoại bắt đầu bằng 0";
            }
            else
            {
                lblPhoneNumber.Text = "";
            }




            if (cbCity.SelectedIndex == -1)
            {
                lblCity.Text = "Chưa chọn Thành Phố";
            }
            else
            {
                lblCity.Text = "";
            }


            if (cbHuyen.SelectedIndex == -1)
            {
                lblHuyen.Text = "Chưa chọn Huyện";

            }
            else
            {
                lblHuyen.Text = "";
            }

            if (txtAdress.Text.Length == 0)
            {
                lblAd.Text = "Chưa nhập địa chỉ còn thiếu";
            }
            else
            {
                lblAd.Text = "";
            }

            if (txtAge.Text.Length == 0)
            {
                lblAge.Text = "Bạn chưa nhập tuổi";
            }
            else
            {
                int age;
                if (int.TryParse(txtAge.Text, out age))
                {
                    if (age < 18)
                    {
                        lblAge.Text = "Bạn chưa đủ tuổi đăng ký";
                    }
                    else
                    {
                        lblAge.Text = ""; // Đảm bảo rằng label được xóa khi tuổi hợp lệ
                    }
                }
                else
                {
                    lblAge.Text = "Tuổi không hợp lệ"; // Hiển thị thông báo khi tuổi không thể chuyển đổi thành số nguyên
                }
            }

            if (!rbFemale.Checked && !rbMale.Checked)
            {
                lblGender.Text = "Bạn chưa chọn giời tính";
            }
            else
            {
                lblGender.Text = "";
            }



            if (txtPW.Text.Length < 4 || txtPW.Text.Length > 10)
            {
                lblPW.Text = "Mật khẩu từ 4 đến 10 kí tự";
            }
            else
            {
                lblPW.Text = "";
            }

            if (txtPW.Text != txtCFPW.Text)
            {
                lblCFPW.Text = "Mật khẩu nhắc lại chưa đúng";
            }
            else
            {
                lblCFPW.Text = "";
            }








            if (lblName.Text.Length == 0 && lblGender.Text.Length == 0
                && lblCCCD.Text.Length == 0 && lblAge.Text.Length == 0
                && lblPhoneNumber.Text.Length == 0 && lblPW.Text.Length == 0 &&
                lblCFPW.Text.Length == 0 && lblCity.Text.Length == 0 && lblHuyen.Text.Length == 0 &&
                lblAd.Text.Length == 0)
            {
                string address = txtAdress.Text + "," + cbHuyen.SelectedItem + "," + cbCity.SelectedItem;
                MessageBox.Show(address);

                bool gender = true;
                if (rbFemale.Checked)
                {
                    gender = false;
                }


                string strSQL1 = "INSERT INTO Users(UserName,UserAddress,UserPhoneNumber,UserGender,UserAge,Citizen_Card_Code,Password,CityID,DistrictsID)" +
                    "Values(@name,@add,@phone, @gen,@age,@cccd,@pw,@cityid,@huyenid)";
                SqlParameter[] parameters1 = new SqlParameter[] {

                new SqlParameter("@name",txtName.Text),
                new SqlParameter("@add",address),
                new SqlParameter("@phone",txtSDT.Text),
                new SqlParameter("@gen",gender),
                new SqlParameter("@age",txtAge.Text),
                    new SqlParameter("@cccd",txtCCCD.Text),
                    new SqlParameter("@pw",txtCFPW.Text),
                    new SqlParameter("@cityid",myDictionaryCity[cbCity.SelectedItem.ToString()]),
                    new SqlParameter("@huyenid",myDictionaryHuyen[cbHuyen.SelectedItem.ToString()])

            };
                if (d.executeNonQuery(strSQL1, parameters1))
                {
                 
                    this.Hide();
                    FrmLogIn frmLogIn = new FrmLogIn(txtCCCD.Text, txtPW.Text);
                    frmLogIn.Show();
                }
                else
                {
                   

                }

            }

        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
           
            try
            {
                string strSQL = "Select * from Cities";
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("cccd",txtCCCD.Text),

                };
                IDataReader dr = d.executeQuery2(strSQL, sp);
                while (dr.Read())
                {
                    string cityName = dr.GetString(2); // Đọc dữ liệu từ cột đầu tiên (index 0)
                    int CityID = dr.GetInt32(0);
                    // Thêm đối tượng chứa thông tin thành phố vào combobox
                    cbCity.Items.Add(cityName);
                    myDictionaryCity.Add(cityName, CityID);
                }



                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Add city to combobox fail" + ex.Message);

            }








        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào ô TextBox
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào ô TextBox
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào ô TextBox
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào ô TextBox
                e.Handled = true;
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            cbHuyen.SelectedIndex = -1;
           
            cbHuyen.Items.Clear();

            
            string selectedCityName = cbCity.SelectedItem.ToString();

            if (myDictionaryCity.ContainsKey(selectedCityName))
            {
                // Lấy CityID tương ứng từ từ điển
                int selectedCityID = myDictionaryCity[selectedCityName];
                try
                {
                    string strSQL1 = "Select * from Districts Where CityId =@id";
                    SqlParameter[] sp1 = new SqlParameter[]
                    {
                    new SqlParameter("id",selectedCityID),

                    };
                    IDataReader dr = d.executeQuery2(strSQL1, sp1);
                    while (dr.Read())
                    {
                        string DisName = dr.GetString(3); // Đọc dữ liệu từ cột đầu tiên (index 0)
                        int DisID = dr.GetInt32(0);

                        cbHuyen.Items.Add(DisName);
                        if (!myDictionaryHuyen.ContainsKey(DisName))
                        {
                            myDictionaryHuyen.Add(DisName, DisID);
                        }
                        



                    }



                    dr.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Add city to combobox fail" + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Selected city not found in dictionary.");
            }
        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            txtAge.BackColor = Color.Wheat;
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            txtAge.BackColor = Color.White;
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            txtPW.BackColor = Color.Wheat;
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            txtPW.BackColor = Color.White;
        }

        private void txtCFPW_Enter(object sender, EventArgs e)
        {
            txtCFPW.BackColor = Color.Wheat;
        }

        private void txtCFPW_Leave(object sender, EventArgs e)
        {
            txtCFPW.BackColor = Color.White;
        }

        private void txtAdress_Enter(object sender, EventArgs e)
        {
            txtAdress.BackColor = Color.Wheat;
        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {
            txtAdress.BackColor = Color.White;
        }

        private void cbHuyen_Enter(object sender, EventArgs e)
        {
            cbHuyen.BackColor = Color.Wheat;
        }

        private void cbHuyen_Leave(object sender, EventArgs e)
        {
            cbHuyen.BackColor = Color.White;
        }
    }


}
