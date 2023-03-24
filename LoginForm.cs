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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        
        
        ModelSnd dbcontext;
        private Employee Find_e(string id, List<Employee> list_e)
        {
            foreach (Employee e in list_e)
            {
                if (id==e.E_ID)
                {
                    return e;
                }
            }
            return null; 
        }
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
                dbcontext = new ModelSnd();
                List<Employee> list_e = dbcontext.Employees.ToList();
                
                string id = txtID.Text;
                string password = txtPassword.Text;

               Employee sel = Find_e(id, list_e);
                if(sel == null)
                {
                    MessageBox.Show("Cannot find id");
                }
                else
                {
                    if(password != sel.Password)
                    {
                        MessageBox.Show("Cannot find pass");
                    }
                    else
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        LoginForm login = new LoginForm();
                        login.Dispose();
                    }
                }
                
            }                                
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }    
    }
}
