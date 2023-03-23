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
        double totalprice = 0;
        public txtName()
        {
            InitializeComponent();
            pushday();
        }
        private void pushday()
        {
            DateTime calldate = DateTime.Now;
            txtcallday.AppendText(calldate.ToString());
            DateTime duedate = calldate.AddDays(30);
            txtdueday.AppendText(duedate.ToString());
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtCusID.Text);
            var db = new ModelSnd();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtIdBook.Text);
            Console.WriteLine(txtQuantity.Text);
            var db = new ModelSnd();
            var sb = db.Books.Where(x => x.BookID == txtIdBook.Text).FirstOrDefault();
            if (txtQuantity.TextLength == 0)
            {
                MessageBox.Show("Input Quantity!!!");    
            }
            else
            {
                if (sb == null)
                {
                    MessageBox.Show("Can not find");
                }
                else
                {
                    int dex = 0;
                    double price = 10000* double.Parse(txtQuantity.Text);
                    dataGridView1.Rows[dex].Cells[0].Value = sb.BookID.ToString();
                    dataGridView1.Rows[dex].Cells[1].Value = sb.Book_Title.ToString();
                    dataGridView1.Rows[dex].Cells[2].Value = txtQuantity.Text;
                    totalprice += price;
                    txtPrice.AppendText(totalprice.ToString()); 
                    txtPrice.AppendText("₫");

                }
            }
            
        }
    }
}
