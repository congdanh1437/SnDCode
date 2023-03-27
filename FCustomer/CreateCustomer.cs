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

namespace WindowsFormsApp1.FCustomer
{
    public partial class CreateCustomer : Form
    {
        ModelSnd db = new ModelSnd();
        Employee employee = new Employee();
        public CreateCustomer(Employee e)
        {
            InitializeComponent();
            txtEID.Text = e.E_ID;
            employee = e;
        }     
        private void button1_Click(object sender, EventArgs e)
        {
           
            int hi = dateTimePicker1.Value.CompareTo(DateTime.Now);
            if (txtName.Text != null && txtPhone.Text != null && txtAddress.Text != null && txtMail.Text != null && hi == 1) 
            {
                var sb = db.Customers;
                Customer c = new Customer();
                var id = sb.Count() + 1;
                c.C_ID = "C" + id.ToString();
                c.C_Name = txtName.Text;
                c.Email = txtMail.Text;
                c.Phone_numb= txtPhone.Text;
                c.Address= txtAddress.Text;
                c.Date_Create = DateTime.Now;
                c.DoB = dateTimePicker1.Value;
                c.Lend_Status = 0;
                c.E_ID = employee.E_ID;
                var age = DateTime.Now.Year - dateTimePicker1.Value.Year;
                c.Age = age;

                sb.Add(c);
                db.SaveChanges();

                MessageBox.Show("Create complete!");
            }
            else
            {
                MessageBox.Show("NOT NULL !");
            }
        }
    }
}
