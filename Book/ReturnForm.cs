using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }
        ModelSnd db = new ModelSnd();
        private void textchange(string Blid)
        {
            var sb = db.Borrow_List.Where(x => x.Borrow_List_ID == Blid).FirstOrDefault();
            
            if (sb != null)
            {
                
               

                var cus = db.Customers.Where(c => c.C_ID == sb.C_ID).FirstOrDefault();
                txtCusID.Text = cus.C_ID.ToString();
                txtCusName.Text = cus.C_Name.ToString();

                txtCallDay.Text = sb.Call_Day.ToString();
                txtReturnDay.Text = sb.Return_Day.ToString();
                txtDueDay.Text = sb.Due_Date.ToString();
                txtFined.Text = sb.Fine.ToString();

                if (sb.Return_Day != null)
                {
                    
                   
                    txtArlert.Text = "The books has been return";
                }
                else
                {
                    txtReturnDay.Text = DateTime.Now.ToString();
                    if(DateTime.Parse(txtReturnDay.Text) > DateTime.Parse(txtDueDay.Text))
                    {
                        TimeSpan count = DateTime.Parse(txtReturnDay.Text).Subtract( DateTime.Parse(txtDueDay.Text));
                        float fined = 10000 * ((float)count.TotalDays);
                        txtFined.Text = fined.ToString();
                    }
                }


            }
            else
            {
                txtCusID.Text = "";
                txtCusName.Text = "";
                txtCallDay.Text = "";
                txtDueDay.Text = "";
                txtReturnDay.Text = "";
                txtArlert.Text = "";

                txtCusID.Enabled = false;
                txtCusName.Enabled = false;
                txtCallDay.Enabled = false;
                txtDueDay.Enabled = false;
                txtReturnDay.Enabled = false;
                txtFined.Enabled = false;

            }
        }
        

        private void getBorrowBook(String Blid)
        {
            var b = db.Borrows.Where(x => x.BL_ID == Blid).Select(x => x.B_ID).ToArray();
            var getQuantity = db.Borrows.Where(x => x.BL_ID == Blid).FirstOrDefault();
            if (b != null)
            {

                var i = 0;
                foreach (var item in b)
                {
                    
                    
                    var gb = db.Borrows.Where(x => x.B_ID == item).FirstOrDefault();
                    var getTitle = db.Books.Where(x => x.BookID == item).FirstOrDefault();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = gb.B_ID.ToString();
                    dataGridView1.Rows[i].Cells[1].Value = getTitle.Book_Title.ToString();
                    dataGridView1.Rows[i].Cells[2].Value = getQuantity.Quantity.ToString();

                    i++;
                }
            }
        }

        private void loadBook(String Blid)
        {
            
            var br = db.Borrows.Where(x => x.BL_ID == Blid).FirstOrDefault();
           
        }
        private void txtBorrowListID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textchange(txtBorrowListID.Text);
            getBorrowBook(txtBorrowListID.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm();
            returnForm.MdiParent = MainForm.ActiveForm;
            returnForm.Show();
            this.Close();
        }

        private void btnSaveReturnBook_Click(object sender, EventArgs e)
        {
            if(txtArlert.Text == "")
            {
                var cus = db.Customers.Where(x => x.C_ID == txtCusID.Text).FirstOrDefault();
                cus.Lend_Status = 0;
                db.Customers.AddOrUpdate();

                var bl = db.Borrow_List.Where(x => x.Borrow_List_ID == txtBorrowListID.Text).FirstOrDefault();
                bl.Return_Day = DateTime.Parse(txtReturnDay.Text);
                bl.Fine = float.Parse(txtFined.Text);
                db.Borrow_List.AddOrUpdate();

                var b = db.Borrows.Where(x => x.BL_ID == txtBorrowListID.Text).Select(x => x.B_ID).ToArray();
                
                if (b != null)
                {

                    var i = 0;
                    foreach (var item in b)
                    {
                        var updateQuantity = db.Books.Where(x => x.BookID == item).FirstOrDefault();
                        updateQuantity.Quantity += Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        db.Books.AddOrUpdate();
                        i++;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
