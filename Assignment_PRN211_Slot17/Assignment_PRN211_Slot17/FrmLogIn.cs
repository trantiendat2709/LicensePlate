using System.Data.SqlClient;
using System.Data;
using System.Security.Principal;

namespace Assignment_PRN211_Slot17
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        
        public FrmLogIn(string text1, string text2)
        {
            InitializeComponent();
            txtCCCD.Text = text1;
            txtPW.Text = text2;
        }

        DataProvider d = new DataProvider();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {



            this.Hide();
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "select * from Users Where Citizen_Card_Code =@name  and Password =@password ";
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("name",txtCCCD.Text),
                    new SqlParameter("password",txtPW.Text)
                };
                IDataReader dr = d.executeQuery2(strSQL, sp);
                if (dr.Read())
                {
                    int UID = dr.GetInt32(0);
                    this.Hide();
                    FrmMotor frmMotor = new FrmMotor(dr.GetInt32(0).ToString());
                    frmMotor.Show();
                }
                else
                {
                   
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Login fail" + ex.Message);

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.Wheat;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            txtPW.BackColor = Color.White;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.White;
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            txtPW.BackColor = Color.Wheat;
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}