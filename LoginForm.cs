using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        
        String strCon = @"Data Source=LAPTOP-M5AVS4UF;Initial Catalog=SnD;Persist Security Info=True;User ID=danh;Password=123";
        SqlConnection sqlCon = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtID == null 
                || txtID.Text.Length == 0 
                ) {
                MessageBox.Show("ID can not be plank");
                txtID.Focus();
               
            }else if(txtPassword == null || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Password can not be plank");
                txtPassword.Focus();
            }
            else
            {
                String Id = txtID.Text;
                String pass = txtPassword.Text;

                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from Employee where E_ID = '" + Id
                    + "' and password = '" + pass + "'";
                sqlCmd.Connection = sqlCon;

                SqlDataReader rs = sqlCmd.ExecuteReader();
                if (rs.Read())
                {
                    String result = (String)rs.GetString(2);
                    MessageBox.Show("Hello " + result);
                    sqlCon.Close();
                    this.Hide();
                    MainForm form2 = new MainForm();
                    form2.Show();
                }
                else
                {
                    sqlCon.Close();
                    MessageBox.Show("ID Or Password Incorrect");

                }
            }
            
                                 
        }
    }
}
