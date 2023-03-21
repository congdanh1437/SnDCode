namespace WindowsFormsApp1.Customer
{
    partial class DeleteCustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Customer = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameCus,
            this.AddressCus,
            this.PhoneCus});
            this.dataGridView1.Location = new System.Drawing.Point(152, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID_Customer
            // 
            this.ID_Customer.AutoSize = true;
            this.ID_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Customer.Location = new System.Drawing.Point(96, 97);
            this.ID_Customer.Name = "ID_Customer";
            this.ID_Customer.Size = new System.Drawing.Size(118, 24);
            this.ID_Customer.TabIndex = 2;
            this.ID_Customer.Text = "ID_Customer";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(261, 100);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(248, 20);
            this.txtIdCustomer.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(571, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(548, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 24);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NameCus
            // 
            this.NameCus.HeaderText = "Name";
            this.NameCus.Name = "NameCus";
            // 
            // AddressCus
            // 
            this.AddressCus.HeaderText = "Address";
            this.AddressCus.Name = "AddressCus";
            // 
            // PhoneCus
            // 
            this.PhoneCus.HeaderText = "Phone";
            this.PhoneCus.Name = "PhoneCus";
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 501);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.ID_Customer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCus;
        private System.Windows.Forms.Label ID_Customer;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
    }
}