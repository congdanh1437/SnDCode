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
    public partial class DeleteCustomer : Form
    {
        ModelSnd db = new ModelSnd();
        public DeleteCustomer()
        {
            InitializeComponent();
        }
        private void find(string cId)
        {
            var delcus = db.Customers.Where(x => x.C_ID == cId).FirstOrDefault();
            if (delcus != null)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[0].Cells[0].Value = delcus.C_ID.ToString();
                dataGridView1.Rows[0].Cells[1].Value = delcus.C_Name.ToString();
                dataGridView1.Rows[0].Cells[2].Value = delcus.DoB.ToString();
                dataGridView1.Rows[0].Cells[3].Value = delcus.Age.ToString();
                dataGridView1.Rows[0].Cells[4].Value = delcus.Address.ToString();
                dataGridView1.Rows[0].Cells[5].Value = delcus.Phone_numb.ToString();
                dataGridView1.Rows[0].Cells[6].Value = delcus.Date_Create.ToString();
                dataGridView1.Rows[0].Cells[7].Value = delcus.Lend_Status.ToString();

            }

        }
        private void txtIdCustomer_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            find(txtIdCustomer.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var getCus = db.Customers.Where(x => x.C_ID == txtIdCustomer.Text).FirstOrDefault();
            var getBorrowListID = db.Borrow_List.Where(x => x.C_ID == txtIdCustomer.Text).Select(x => x.Borrow_List_ID).ToArray();
            if(getCus != null)
            {
                if (Int32.Parse(dataGridView1.Rows[0].Cells[7].Value.ToString()) == 0)
                {
                    foreach (var item in getBorrowListID)
                    {
                        var delBorrow = db.Borrows.Where(x => x.BL_ID == item).FirstOrDefault();
                        db.Borrows.Remove(delBorrow);
                        db.SaveChanges();
                    }

                    foreach (var item in getBorrowListID)
                    {
                        var delBorrowList = db.Borrow_List.Where(x => x.Borrow_List_ID == item).FirstOrDefault();
                        db.Borrow_List.Remove(delBorrowList);
                        db.SaveChanges();
                    }

                    var delcus = db.Customers.Where(x => x.C_ID == txtIdCustomer.Text).FirstOrDefault();
                    db.Customers.Remove(delcus);
                    db.SaveChanges();
                    txtIdCustomer = null;
                    dataGridView1.Rows.Clear();
                    MessageBox.Show("Delete complete");
                }
                else
                {
                    MessageBox.Show("The customer has not return the book");
                }
            }
            else
            {
                MessageBox.Show("The customer does not exist");
            }
        }
    }
}
