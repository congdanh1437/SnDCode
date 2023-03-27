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
        int dex = 0;
        ModelSnd db = new ModelSnd();
        Employee employee = new Employee();
        public BorrowListForm(Employee e)
        {
            InitializeComponent();
            pushday();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtIdBook.Enabled = false;
            txtQuantity.Enabled = false;
            btnAdd.Enabled = false;
            btnsave.Enabled = false;
            txtEID.Text = e.E_ID;
            employee = e;
        }
        private void pushday()
        {
            DateTime calldate = DateTime.Now;
            txtcallday.AppendText(calldate.ToString());
            DateTime duedate = calldate.AddDays(30);
            txtdueday.AppendText(duedate.ToString());
        }
        private Book checkbook(Book sb)
        {
            for(int i=0;i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == sb.BookID)
                {
                    return null;
                }
            }
            return sb;
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
                txtBorrowListID.AppendText("BL");
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
            int totalquantity = 0;

            var sb = db.Customers.Where(x => x.C_ID == txtCusID.Text).FirstOrDefault();
            sb.Lend_Status = 1;
            //db.Customers.AddOrUpdate();

            Borrow_List list = new Borrow_List();
            list.Borrow_List_ID = txtBorrowListID.Text;
            list.C_ID = txtCusID.Text;
            list.Call_Day = DateTime.Now;
            list.Due_Date = list.Call_Day.AddDays(30);            
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                Borrow b = new Borrow();
                string bi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                var bl = db.Books.Where(x => x.BookID == bi).FirstOrDefault();
                bl.Quantity -= Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                totalquantity += Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                b.BL_ID = txtBorrowListID.Text;
                b.B_ID = bi;
                b.Quantity = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                db.Borrows.Add(b);
            }
            list.Total_Price = float.Parse(txtPrice.Text);
            list.Quality = totalquantity;
            list.E_ID = employee.E_ID;
            db.Borrow_List.Add(list);
            db.SaveChanges();





            MessageBox.Show("Save complete! Your Borrow List ID :" + txtBorrowListID.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtIdBook.Text);
            Console.WriteLine(txtQuantity.Text);
            var db = new ModelSnd();
            var sb = db.Books.Where(x => x.BookID == txtIdBook.Text).FirstOrDefault();
            Book check = checkbook(sb);
            if(check!=null)
            {
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

                    else if (Int32.Parse(txtQuantity.Text) > sb.Quantity)
                    {
                        MessageBox.Show("Out of book");
                    }
                    else
                    {
                        dataGridView1.Rows.Add();
                        double price = 10000 * double.Parse(txtQuantity.Text);
                        dataGridView1.Rows[dex].Cells[0].Value = sb.BookID.ToString();
                        dataGridView1.Rows[dex].Cells[1].Value = sb.Book_Title.ToString();
                        dataGridView1.Rows[dex].Cells[2].Value = txtQuantity.Text;
                        totalprice += price;
                        txtPrice.Text = totalprice.ToString();
                        
                        dex++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Book has added");
            }
            
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            txtArlert.Text = "";
            textchange(txtCusID.Text);
        }

        private void BorrowListForm_Load(object sender, EventArgs e)
        {
            textchange("");
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    var bl = db.Books.Where(x => x.BookID == txtIdBook.Text).FirstOrDefault();
                    if (bl != null)
                    {
                        dataGridView1.SelectedRows[0].Cells[0].Value = txtIdBook.Text;
                        dataGridView1.SelectedRows[0].Cells[2].Value = txtQuantity.Text;
                    }
                    else
                    {
                        MessageBox.Show("Can not find");
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    int selIndex = dataGridView1.SelectedRows[0].Index;
                    txtIdBook.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
        }
    }
}
