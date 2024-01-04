namespace FrontEnd.View.Customer
{
    partial class FrmCustomerWatch
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
            dataGridView1 = new DataGridView();
            gpbCustomerSearch = new GroupBox();
            LblLastName = new Label();
            LblName = new Label();
            TxtLastName = new TextBox();
            TxtName = new TextBox();
            BtnSearch = new Button();
            BtnDelete = new Button();
            BtnModify = new Button();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gpbCustomerSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(674, 238);
            dataGridView1.TabIndex = 0;
            // 
            // gpbCustomerSearch
            // 
            gpbCustomerSearch.Controls.Add(LblLastName);
            gpbCustomerSearch.Controls.Add(LblName);
            gpbCustomerSearch.Controls.Add(TxtLastName);
            gpbCustomerSearch.Controls.Add(TxtName);
            gpbCustomerSearch.Controls.Add(BtnSearch);
            gpbCustomerSearch.Location = new Point(47, 12);
            gpbCustomerSearch.Name = "gpbCustomerSearch";
            gpbCustomerSearch.Size = new Size(674, 104);
            gpbCustomerSearch.TabIndex = 1;
            gpbCustomerSearch.TabStop = false;
            gpbCustomerSearch.Text = "Search Customers";
            // 
            // LblLastName
            // 
            LblLastName.AutoSize = true;
            LblLastName.Location = new Point(23, 67);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(60, 15);
            LblLastName.TabIndex = 9;
            LblLastName.Text = "LastName";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(44, 30);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 8;
            LblName.Text = "Name";
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(92, 64);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(245, 23);
            TxtLastName.TabIndex = 7;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(92, 30);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(245, 23);
            TxtName.TabIndex = 6;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(599, 75);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 5;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(47, 390);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(139, 390);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(75, 23);
            BtnModify.TabIndex = 3;
            BtnModify.Text = "Modify";
            BtnModify.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(646, 390);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // FrmCustomerWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 430);
            Controls.Add(BtnExit);
            Controls.Add(BtnModify);
            Controls.Add(BtnDelete);
            Controls.Add(gpbCustomerSearch);
            Controls.Add(dataGridView1);
            Name = "FrmCustomerWatch";
            Text = "FrmCustomerWatch";
            Load += FrmCustomerWatch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gpbCustomerSearch.ResumeLayout(false);
            gpbCustomerSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox gpbCustomerSearch;
        private Button BtnDelete;
        private Button BtnModify;
        private Button BtnExit;
        private Button BtnSearch;
        private TextBox TxtLastName;
        private TextBox TxtName;
        private Label LblLastName;
        private Label LblName;
    }
}