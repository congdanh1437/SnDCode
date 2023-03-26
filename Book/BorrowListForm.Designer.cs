namespace WindowsFormsApp1
{
    partial class BorrowListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbCusName = new System.Windows.Forms.Label();
            this.lbCusID = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lbEID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLendStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBorrowListID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdueday = new System.Windows.Forms.TextBox();
            this.txtcallday = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtArlert = new System.Windows.Forms.TextBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.txtEID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow Book";
            // 
            // lbCusName
            // 
            this.lbCusName.AutoSize = true;
            this.lbCusName.Location = new System.Drawing.Point(15, 122);
            this.lbCusName.Name = "lbCusName";
            this.lbCusName.Size = new System.Drawing.Size(104, 16);
            this.lbCusName.TabIndex = 1;
            this.lbCusName.Text = "Customer Name";
            // 
            // lbCusID
            // 
            this.lbCusID.AutoSize = true;
            this.lbCusID.Location = new System.Drawing.Point(16, 82);
            this.lbCusID.Name = "lbCusID";
            this.lbCusID.Size = new System.Drawing.Size(80, 16);
            this.lbCusID.TabIndex = 2;
            this.lbCusID.Text = "Customer ID";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(141, 74);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(345, 22);
            this.txtCusID.TabIndex = 3;
            this.txtCusID.TextChanged += new System.EventHandler(this.txtCusID_TextChanged);
            // 
            // txtCusName
            // 
            this.txtCusName.Enabled = false;
            this.txtCusName.Location = new System.Drawing.Point(141, 122);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(345, 22);
            this.txtCusName.TabIndex = 4;
            // 
            // lbEID
            // 
            this.lbEID.AutoSize = true;
            this.lbEID.Enabled = false;
            this.lbEID.Location = new System.Drawing.Point(12, 9);
            this.lbEID.Name = "lbEID";
            this.lbEID.Size = new System.Drawing.Size(91, 16);
            this.lbEID.TabIndex = 5;
            this.lbEID.Text = "Employee ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(21, 362);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 342);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Title";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(141, 159);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(345, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(141, 207);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(345, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // txtLendStatus
            // 
            this.txtLendStatus.Enabled = false;
            this.txtLendStatus.Location = new System.Drawing.Point(141, 250);
            this.txtLendStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLendStatus.Name = "txtLendStatus";
            this.txtLendStatus.Size = new System.Drawing.Size(345, 22);
            this.txtLendStatus.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lend Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Borrow List ID";
            // 
            // txtBorrowListID
            // 
            this.txtBorrowListID.Enabled = false;
            this.txtBorrowListID.Location = new System.Drawing.Point(141, 288);
            this.txtBorrowListID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBorrowListID.Name = "txtBorrowListID";
            this.txtBorrowListID.Size = new System.Drawing.Size(345, 22);
            this.txtBorrowListID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(859, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "BOOK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID Book";
            // 
            // txtIdBook
            // 
            this.txtIdBook.Location = new System.Drawing.Point(801, 94);
            this.txtIdBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(243, 22);
            this.txtIdBook.TabIndex = 18;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(700, 146);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(55, 16);
            this.Quantity.TabIndex = 19;
            this.Quantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(801, 143);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(243, 22);
            this.txtQuantity.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1053, 105);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(801, 606);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(192, 50);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 242);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Call Day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(704, 292);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Due Day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(877, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 36);
            this.label11.TabIndex = 26;
            this.label11.Text = "Time";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtdueday
            // 
            this.txtdueday.Enabled = false;
            this.txtdueday.Location = new System.Drawing.Point(801, 283);
            this.txtdueday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdueday.Name = "txtdueday";
            this.txtdueday.Size = new System.Drawing.Size(243, 22);
            this.txtdueday.TabIndex = 28;
            // 
            // txtcallday
            // 
            this.txtcallday.Enabled = false;
            this.txtcallday.Location = new System.Drawing.Point(801, 234);
            this.txtcallday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcallday.Name = "txtcallday";
            this.txtcallday.Size = new System.Drawing.Size(243, 22);
            this.txtcallday.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(152, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 36);
            this.label12.TabIndex = 29;
            this.label12.Text = "Customer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(876, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 36);
            this.label8.TabIndex = 30;
            this.label8.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(801, 414);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(243, 22);
            this.txtPrice.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(704, 422);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Total Price";
            // 
            // txtArlert
            // 
            this.txtArlert.BackColor = System.Drawing.SystemColors.Control;
            this.txtArlert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArlert.ForeColor = System.Drawing.Color.Red;
            this.txtArlert.Location = new System.Drawing.Point(141, 331);
            this.txtArlert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArlert.Name = "txtArlert";
            this.txtArlert.Size = new System.Drawing.Size(347, 15);
            this.txtArlert.TabIndex = 33;
            // 
            // btnchange
            // 
            this.btnchange.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnchange.Location = new System.Drawing.Point(1053, 140);
            this.btnchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(100, 28);
            this.btnchange.TabIndex = 34;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // txtEID
            // 
            this.txtEID.BackColor = System.Drawing.SystemColors.Control;
            this.txtEID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEID.Enabled = false;
            this.txtEID.Location = new System.Drawing.Point(110, 9);
            this.txtEID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(133, 15);
            this.txtEID.TabIndex = 35;
            // 
            // BorrowListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 720);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.txtArlert);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdueday);
            this.Controls.Add(this.txtcallday);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txtIdBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBorrowListID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLendStatus);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbEID);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.lbCusID);
            this.Controls.Add(this.lbCusName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BorrowListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "BorrowListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BorrowListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.Label lbCusID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lbEID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLendStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBorrowListID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdBook;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdueday;
        private System.Windows.Forms.TextBox txtcallday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtArlert;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.TextBox txtEID;
    }
}