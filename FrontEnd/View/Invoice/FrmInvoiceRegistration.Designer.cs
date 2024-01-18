namespace FrontEnd.View.Invoice
{
    partial class FrmInvoiceRegistration
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
            CboSeller = new ComboBox();
            CboCustomer = new ComboBox();
            GpbInvoice = new GroupBox();
            TxtAmount = new TextBox();
            TxtUnitPrice = new TextBox();
            LblArticle = new Label();
            CboArticle = new ComboBox();
            LblCantidad = new Label();
            LblUnitPrice = new Label();
            dateTimePicker1 = new DateTimePicker();
            LblDate = new Label();
            lblCustomer = new Label();
            lblSeller = new Label();
            dataGridView1 = new DataGridView();
            LblTotally = new Label();
            BtnRegistration = new Button();
            BtnExit = new Button();
            GpbInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CboSeller
            // 
            CboSeller.FormattingEnabled = true;
            CboSeller.Location = new Point(93, 54);
            CboSeller.Name = "CboSeller";
            CboSeller.Size = new Size(200, 23);
            CboSeller.TabIndex = 0;
            // 
            // CboCustomer
            // 
            CboCustomer.FormattingEnabled = true;
            CboCustomer.Location = new Point(93, 83);
            CboCustomer.Name = "CboCustomer";
            CboCustomer.Size = new Size(200, 23);
            CboCustomer.TabIndex = 1;
            // 
            // GpbInvoice
            // 
            GpbInvoice.Controls.Add(TxtAmount);
            GpbInvoice.Controls.Add(TxtUnitPrice);
            GpbInvoice.Controls.Add(LblArticle);
            GpbInvoice.Controls.Add(CboArticle);
            GpbInvoice.Controls.Add(LblCantidad);
            GpbInvoice.Controls.Add(LblUnitPrice);
            GpbInvoice.Controls.Add(dateTimePicker1);
            GpbInvoice.Controls.Add(LblDate);
            GpbInvoice.Controls.Add(lblCustomer);
            GpbInvoice.Controls.Add(lblSeller);
            GpbInvoice.Controls.Add(CboSeller);
            GpbInvoice.Controls.Add(CboCustomer);
            GpbInvoice.Location = new Point(12, 12);
            GpbInvoice.Name = "GpbInvoice";
            GpbInvoice.Size = new Size(596, 122);
            GpbInvoice.TabIndex = 2;
            GpbInvoice.TabStop = false;
            GpbInvoice.Text = "Invoice registration";
            GpbInvoice.Enter += groupBox1_Enter;
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(388, 83);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(100, 23);
            TxtAmount.TabIndex = 11;
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.Location = new Point(388, 54);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(100, 23);
            TxtUnitPrice.TabIndex = 10;
            // 
            // LblArticle
            // 
            LblArticle.AutoSize = true;
            LblArticle.Location = new Point(331, 31);
            LblArticle.Name = "LblArticle";
            LblArticle.Size = new Size(41, 15);
            LblArticle.TabIndex = 9;
            LblArticle.Text = "Article";
            // 
            // CboArticle
            // 
            CboArticle.FormattingEnabled = true;
            CboArticle.Location = new Point(388, 25);
            CboArticle.Name = "CboArticle";
            CboArticle.Size = new Size(200, 23);
            CboArticle.TabIndex = 8;
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Location = new Point(321, 83);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(51, 15);
            LblCantidad.TabIndex = 6;
            LblCantidad.Text = "Amount";
            // 
            // LblUnitPrice
            // 
            LblUnitPrice.AutoSize = true;
            LblUnitPrice.Location = new Point(314, 57);
            LblUnitPrice.Name = "LblUnitPrice";
            LblUnitPrice.Size = new Size(58, 15);
            LblUnitPrice.TabIndex = 7;
            LblUnitPrice.Text = "Unit Price";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(93, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Location = new Point(35, 31);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(31, 15);
            LblDate.TabIndex = 4;
            LblDate.Text = "Date";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(11, 86);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(59, 15);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer";
            // 
            // lblSeller
            // 
            lblSeller.AutoSize = true;
            lblSeller.Location = new Point(35, 57);
            lblSeller.Name = "lblSeller";
            lblSeller.Size = new Size(35, 15);
            lblSeller.TabIndex = 2;
            lblSeller.Text = "Seller";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(596, 239);
            dataGridView1.TabIndex = 3;
            // 
            // LblTotally
            // 
            LblTotally.AutoSize = true;
            LblTotally.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotally.Location = new Point(439, 386);
            LblTotally.Name = "LblTotally";
            LblTotally.Size = new Size(70, 25);
            LblTotally.TabIndex = 4;
            LblTotally.Text = "Totally";
            // 
            // BtnRegistration
            // 
            BtnRegistration.Location = new Point(12, 386);
            BtnRegistration.Name = "BtnRegistration";
            BtnRegistration.Size = new Size(75, 23);
            BtnRegistration.TabIndex = 5;
            BtnRegistration.Text = "Register";
            BtnRegistration.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(105, 386);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 6;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // FrmInvoiceRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 418);
            Controls.Add(BtnExit);
            Controls.Add(BtnRegistration);
            Controls.Add(LblTotally);
            Controls.Add(dataGridView1);
            Controls.Add(GpbInvoice);
            Name = "FrmInvoiceRegistration";
            Text = "FrmInvoiceRegistration";
            Load += FrmInvoiceRegistration_Load;
            GpbInvoice.ResumeLayout(false);
            GpbInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CboSeller;
        private ComboBox CboCustomer;
        private GroupBox GpbInvoice;
        private Label lblSeller;
        private Label lblCustomer;
        private DateTimePicker dateTimePicker1;
        private Label LblDate;
        private DataGridView dataGridView1;
        private Label LblUnitPrice;
        private Label LblCantidad;
        private Label LblArticle;
        private ComboBox CboArticle;
        private TextBox TxtAmount;
        private TextBox TxtUnitPrice;
        private Label LblTotally;
        private Button BtnRegistration;
        private Button BtnExit;
    }
}