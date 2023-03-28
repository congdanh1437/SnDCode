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
    public partial class ImportListForm : Form
    {
        ModelSnd dbcontext = new ModelSnd();
        int dex = 0;
        Employee employee = new Employee();
        public ImportListForm(Employee e)
        {
            InitializeComponent();
            employee = e;
        }
        private void checksuplier(string s)
        {
            Suplier suplier = dbcontext.Supliers.Where(x => x.Sup_ID == s).FirstOrDefault();
            if (suplier != null)
            {
                txtalert2.Text = "";
                txtS_Name.Text = suplier.Sup_Name;
                txtTitle.Enabled = true;
            }
            else
            {
                txtalert2.Text = "Cant find Suplier";
                txtTitle.Enabled = false;
            }
        }
        private void ImportListForm_Load(object sender, EventArgs e)
        {
            checksuplier("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOldBook_Click(object sender, EventArgs e)
        {
            
            if(txtTitle.TextLength != 0 )
            {
                if(txtPrice.TextLength != 0 )
                {
                    if(txtBookID.TextLength != 0 )
                    {
                        if (txtQuantity.TextLength != 0)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[dex].Cells[0].Value = txtBookID.Text;
                            dataGridView1.Rows[dex].Cells[1].Value = txtType.Text;
                            dataGridView1.Rows[dex].Cells[2].Value = txtTitle.Text;
                            dataGridView1.Rows[dex].Cells[3].Value = txtPrice.Text;
                            dataGridView1.Rows[dex].Cells[4].Value = txtQuantity.Text;
                            dex++;
                        }
                        else
                        {
                            MessageBox.Show("Input quantity");
                        }                      
                    }
                    else
                    {
                        MessageBox.Show("Input title");
                    }
                }
                else
                {
                    MessageBox.Show("Input price");
                }
            }
            else
            {
                MessageBox.Show("Input Book ID");
            }
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Book book = dbcontext.Books.Where(x => x.Book_Title == txtTitle.Text).FirstOrDefault();
            
            if (book!=null)
            {
                txtalert.Text = "Book has store in libary";
                txtBookID.Text = book.BookID;
                txtPrice.Text = book.Price.ToString();
                txtType.Text = book.Type;
                txtQuantity.Text = "";
                txtBookID.Enabled = false;
                txtPrice.Enabled = false;
                txtType.Enabled = false;            
            }
            else
            {
                var countBook = dbcontext.Books.Count();
                int count = dbcontext.Books.Count() + 1;
               

                txtalert.Text = "this is new Book (cant find Title)";
                txtBookID.Text = "B" + count.ToString();
                txtPrice.Text = "";
                txtType.Text = "";
                txtQuantity.Text = "";
                txtBookID.Enabled = true;
                txtPrice.Enabled = true;
                txtType.Enabled = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
          
            Import_List list = new Import_List();
            int count = dbcontext.Import_List.Count() + 1;
            list.Import_List_ID = "IL" + count.ToString();
            
            list.Supplier_ID = txtSuplierID.Text;
            list.E_ID = employee.E_ID;
            list.Date_Import = DateTime.Now;
            dbcontext.Import_List.Add(list);
            
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string bi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                var bl = dbcontext.Books.Where(x => x.BookID == bi).FirstOrDefault();
                if(bl != null)
                {
                    bl.Quantity += Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                else
                {
                    var nBook = dbcontext.Books;
                    var newBook = new Book();
                    newBook.BookID = dataGridView1.Rows[i].Cells[0].Value.ToString(); 
                    newBook.Type = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    newBook.Book_Title = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    newBook.Price =float.Parse( dataGridView1.Rows[i].Cells[3].Value.ToString());
                    newBook.Quantity = Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    nBook.Add(newBook);
                    
                }
                
                
                
            }
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                Import b = new Import();
                string bi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                b.IL_ID = list.Import_List_ID;
                b.B_ID = bi;
                b.Quantity = Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                dbcontext.Imports.Add(b);
            }
            dbcontext.SaveChanges();
            MessageBox.Show("Save complete!!");
            btnReset_Click(sender, e);
        }

        private void txtSuplierID_TextChanged(object sender, EventArgs e)
        {
            txtalert.Text = "";
            checksuplier(txtSuplierID.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dex = 0;
            txtSuplierID.Text = string.Empty;
            txtS_Name.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtBookID.Text = string.Empty;
            txtType.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }

        
    }
}
