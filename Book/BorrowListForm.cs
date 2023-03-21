using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class txtName : Form
    {
        public txtName()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtCusID.Text);
            var db = new ModelSnD();
            var sb = db.Customers.Where(x => x.C_ID == txtCusID.Text).FirstOrDefault();
            if(txtCusName.Text.Length == 0 && sb != null)
            {
                txtCusName.AppendText(sb.C_Name);
                txtPhone.AppendText(sb.Phone_numb);
                txtAddress.AppendText(sb.Address);
                txtLendStatus.AppendText(sb.Lend_Status.ToString());
            }
            else if(sb == null)
            {
                MessageBox.Show("Can not find");
            }
            
           
        }
    }
}
