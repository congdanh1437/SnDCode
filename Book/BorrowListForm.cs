using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class BorrowListForm : Form
    {
        double totalprice = 0;
         ModelSnd db = new ModelSnd();
        public BorrowListForm()
        {
            InitializeComponent();
            pushday();
            txtIdBook.Enabled = false;
            txtQuantity.Enabled = false;
            btnAdd.Enabled = false;
            btnsave.Enabled = false;     
        }
        private void pushday()
        {
            DateTime calldate = DateTime.Now;
            txtcallday.AppendText(calldate.ToString());
            DateTime duedate = calldate.AddDays(30);
            txtdueday.AppendText(duedate.ToString());
        }
        
        private void textchange(string Cusid)
        { 
            var sb = db.Customers.Where(x => x.C_ID == Cusid).FirstOrDefault();
            int bl = db.Borrow_List.Count();
            if (sb != null)
            {
                txtIdBook.Enabled = true;
                txtQuantity.Enabled = true;
                btnAdd.Enabled = true;
                btnsave.Enabled = true;
                txtCusName.AppendText(sb.C_Name);
                txtPhone.AppendText(sb.Phone_numb);
                txtAddress.AppendText(sb.Address);
                txtLendStatus.AppendText(sb.Lend_Status.ToString());
                bl++;
                txtBorrowListID.AppendText(bl.ToString());
                txtArlert.Text = "";
                if (sb.Lend_Status==1)
                {
                    txtArlert.Text = "This customer has aldready call book";
                    txtIdBook.Enabled = false;
                    txtQuantity.Enabled = false;
                    btnAdd.Enabled = false;
                    btnsave.Enabled = false;
                }
            }
            else
            {
                txtCusName.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                txtLendStatus.Text = "";
                txtBorrowListID.Text = "";
                txtIdBook.Enabled = false;
                txtQuantity.Enabled = false;
                btnAdd.Enabled = false;
                btnsave.Enabled = false;

            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {  
            var sb = db.Customers.Where(x => x.C_ID == txtCusID.Text).FirstOrDefault();
            sb.Lend_Status = 1;
            db.Customers.Remove(db.Customers.Where(x => x.C_ID == txtCusID.Text).FirstOrDefault());
            db.Customers.Add(sb);

            for(int i=0;i<dataGridView1.RowCount;i++)
            {
                var bl = db.Books.Where(x => x.BookID == dataGridView1.Rows[i].Cells[0].ToString()).FirstOrDefault();
                bl.Quantity -= Int32.Parse(txtQuantity.Text);
                db.Books.Remove(db.Books.Where(x => x.BookID == dataGridView1.Rows[i].Cells[0].ToString()).FirstOrDefault());
                db.Books.Add(bl);
            }

            db.SaveChanges();
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
                else if(Int32.Parse(txtQuantity.Text) > 5)
                {
                    MessageBox.Show("Maximum 5 books");
                }
                else if(Int32.Parse(txtQuantity.Text) > sb.Quantity)
                {
                    MessageBox.Show("Out of book");
                }
                else
                {
                    int dex = 0;
                    double price = 10000 * double.Parse(txtQuantity.Text);
                    dataGridView1.Rows[dex].Cells[0].Value = sb.BookID.ToString();
                    dataGridView1.Rows[dex].Cells[1].Value = sb.Book_Title.ToString();
                    dataGridView1.Rows[dex].Cells[2].Value = txtQuantity.Text;
                    totalprice += price;
                    txtPrice.Text = totalprice.ToString(); 
                    txtPrice.AppendText("₫");
                }
            }           
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            textchange(txtCusID.Text);
        }

        private void BorrowListForm_Load(object sender, EventArgs e)
        {
            textchange("");
        }
    }
}
