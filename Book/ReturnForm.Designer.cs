namespace WindowsFormsApp1
{
    partial class ReturnForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBorrowListID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtDueDay = new System.Windows.Forms.TextBox();
            this.txtCallDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReturnDay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFined = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveReturnBook = new System.Windows.Forms.Button();
            this.txtArlert = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrow list ID";
            // 
            // txtBorrowListID
            // 
            this.txtBorrowListID.Location = new System.Drawing.Point(399, 63);
            this.txtBorrowListID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrowListID.Name = "txtBorrowListID";
            this.txtBorrowListID.Size = new System.Drawing.Size(251, 22);
            this.txtBorrowListID.TabIndex = 2;
            this.txtBorrowListID.TextChanged += new System.EventHandler(this.txtBorrowListID_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(716, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(51, 393);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 318);
            this.dataGridView1.TabIndex = 7;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name Customer";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(117, 127);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(243, 22);
            this.txtCusID.TabIndex = 11;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(544, 130);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.Size = new System.Drawing.Size(179, 22);
            this.txtCusName.TabIndex = 13;
            // 
            // txtDueDay
            // 
            this.txtDueDay.Enabled = false;
            this.txtDueDay.Location = new System.Drawing.Point(117, 219);
            this.txtDueDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDueDay.Name = "txtDueDay";
            this.txtDueDay.ReadOnly = true;
            this.txtDueDay.Size = new System.Drawing.Size(243, 22);
            this.txtDueDay.TabIndex = 32;
            // 
            // txtCallDay
            // 
            this.txtCallDay.Enabled = false;
            this.txtCallDay.Location = new System.Drawing.Point(117, 178);
            this.txtCallDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtCallDay.Name = "txtCallDay";
            this.txtCallDay.ReadOnly = true;
            this.txtCallDay.Size = new System.Drawing.Size(243, 22);
            this.txtCallDay.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Due Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Call Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Return day";
            // 
            // txtReturnDay
            // 
            this.txtReturnDay.Enabled = false;
            this.txtReturnDay.Location = new System.Drawing.Point(117, 263);
            this.txtReturnDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnDay.Name = "txtReturnDay";
            this.txtReturnDay.ReadOnly = true;
            this.txtReturnDay.Size = new System.Drawing.Size(243, 22);
            this.txtReturnDay.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Save Return Day";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(839, 247);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Total Price";
            // 
            // txtFined
            // 
            this.txtFined.Enabled = false;
            this.txtFined.Location = new System.Drawing.Point(117, 308);
            this.txtFined.Margin = new System.Windows.Forms.Padding(4);
            this.txtFined.Name = "txtFined";
            this.txtFined.ReadOnly = true;
            this.txtFined.Size = new System.Drawing.Size(243, 22);
            this.txtFined.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Finded";
            // 
            // btnSaveReturnBook
            // 
            this.btnSaveReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReturnBook.Location = new System.Drawing.Point(753, 659);
            this.btnSaveReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveReturnBook.Name = "btnSaveReturnBook";
            this.btnSaveReturnBook.Size = new System.Drawing.Size(173, 52);
            this.btnSaveReturnBook.TabIndex = 40;
            this.btnSaveReturnBook.Text = "Save";
            this.btnSaveReturnBook.UseVisualStyleBackColor = true;
            this.btnSaveReturnBook.Click += new System.EventHandler(this.btnSaveReturnBook_Click);
            // 
            // txtArlert
            // 
            this.txtArlert.BackColor = System.Drawing.SystemColors.Control;
            this.txtArlert.ForeColor = System.Drawing.Color.Red;
            this.txtArlert.Location = new System.Drawing.Point(117, 347);
            this.txtArlert.Name = "txtArlert";
            this.txtArlert.Size = new System.Drawing.Size(243, 22);
            this.txtArlert.TabIndex = 41;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(943, 659);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 51);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 725);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtArlert);
            this.Controls.Add(this.btnSaveReturnBook);
            this.Controls.Add(this.txtFined);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReturnDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDueDay);
            this.Controls.Add(this.txtCallDay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBorrowListID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBorrowListID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtDueDay;
        private System.Windows.Forms.TextBox txtCallDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReturnDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFined;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveReturnBook;
        private System.Windows.Forms.TextBox txtArlert;
        private System.Windows.Forms.Button btnReset;
    }
}