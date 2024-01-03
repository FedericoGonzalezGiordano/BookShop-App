namespace FrontEnd
{
    partial class FrmCustomerRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            LblEmail = new Label();
            cboNeighborhood = new ComboBox();
            txtTelephone = new TextBox();
            LblTelephone = new Label();
            LblStreet = new Label();
            LblNeighborhood = new Label();
            TxtLastName = new TextBox();
            LblLastName = new Label();
            txtname = new TextBox();
            LblName = new Label();
            txtStreet = new TextBox();
            TxtStreetNumber = new TextBox();
            LblStreetNumber = new Label();
            btnCancel = new Button();
            btnExit = new Button();
            btnLoad = new Button();
            DgvCustomer = new DataGridView();
            BtnAdd = new Button();
            GpbCustomer = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DgvCustomer).BeginInit();
            GpbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(107, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 70;
            // 
            // LblEmail
            // 
            LblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(48, 103);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(41, 15);
            LblEmail.TabIndex = 79;
            LblEmail.Text = "E-Mail";
            // 
            // cboNeighborhood
            // 
            cboNeighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboNeighborhood.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNeighborhood.FormattingEnabled = true;
            cboNeighborhood.Location = new Point(107, 74);
            cboNeighborhood.Name = "cboNeighborhood";
            cboNeighborhood.Size = new Size(183, 23);
            cboNeighborhood.TabIndex = 65;
            cboNeighborhood.SelectedIndexChanged += cboNeighborhood_SelectedIndexChanged;
            // 
            // txtTelephone
            // 
            txtTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelephone.Location = new Point(407, 74);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(199, 23);
            txtTelephone.TabIndex = 71;
            // 
            // LblTelephone
            // 
            LblTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblTelephone.AutoSize = true;
            LblTelephone.Location = new Point(329, 77);
            LblTelephone.Name = "LblTelephone";
            LblTelephone.Size = new Size(61, 15);
            LblTelephone.TabIndex = 78;
            LblTelephone.Text = "Telephone";
            // 
            // LblStreet
            // 
            LblStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblStreet.AutoSize = true;
            LblStreet.Location = new Point(52, 46);
            LblStreet.Name = "LblStreet";
            LblStreet.Size = new Size(37, 15);
            LblStreet.TabIndex = 76;
            LblStreet.Text = "Street";
            // 
            // LblNeighborhood
            // 
            LblNeighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblNeighborhood.AutoSize = true;
            LblNeighborhood.Location = new Point(6, 77);
            LblNeighborhood.Name = "LblNeighborhood";
            LblNeighborhood.Size = new Size(85, 15);
            LblNeighborhood.TabIndex = 75;
            LblNeighborhood.Text = "Neighborhood";
            // 
            // TxtLastName
            // 
            TxtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtLastName.Location = new Point(407, 16);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(199, 23);
            TxtLastName.TabIndex = 67;
            // 
            // LblLastName
            // 
            LblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblLastName.AutoSize = true;
            LblLastName.Location = new Point(332, 16);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(58, 15);
            LblLastName.TabIndex = 73;
            LblLastName.Text = "Lastname";
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtname.Location = new Point(107, 16);
            txtname.Name = "txtname";
            txtname.Size = new Size(183, 23);
            txtname.TabIndex = 66;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // LblName
            // 
            LblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblName.AutoSize = true;
            LblName.Location = new Point(52, 19);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 72;
            LblName.Text = "Name";
            // 
            // txtStreet
            // 
            txtStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStreet.Location = new Point(107, 46);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(183, 23);
            txtStreet.TabIndex = 80;
            txtStreet.TextChanged += txtStreet_TextChanged;
            // 
            // TxtStreetNumber
            // 
            TxtStreetNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtStreetNumber.Location = new Point(407, 45);
            TxtStreetNumber.Name = "TxtStreetNumber";
            TxtStreetNumber.Size = new Size(199, 23);
            TxtStreetNumber.TabIndex = 81;
            // 
            // LblStreetNumber
            // 
            LblStreetNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblStreetNumber.AutoSize = true;
            LblStreetNumber.Location = new Point(306, 45);
            LblStreetNumber.Name = "LblStreetNumber";
            LblStreetNumber.Size = new Size(84, 15);
            LblStreetNumber.TabIndex = 82;
            LblStreetNumber.Text = "Street Number";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Location = new Point(311, 443);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 26);
            btnCancel.TabIndex = 84;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.Location = new Point(577, 443);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 26);
            btnExit.TabIndex = 85;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom;
            btnLoad.Location = new Point(48, 443);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(108, 26);
            btnLoad.TabIndex = 83;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // DgvCustomer
            // 
            DgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCustomer.Location = new Point(45, 173);
            DgvCustomer.Name = "DgvCustomer";
            DgvCustomer.RowTemplate.Height = 25;
            DgvCustomer.Size = new Size(629, 254);
            DgvCustomer.TabIndex = 86;
            DgvCustomer.CellContentClick += DgvCustomer_CellContentClick;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Bottom;
            BtnAdd.Location = new Point(517, 114);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(89, 21);
            BtnAdd.TabIndex = 87;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // GpbCustomer
            // 
            GpbCustomer.Controls.Add(LblName);
            GpbCustomer.Controls.Add(BtnAdd);
            GpbCustomer.Controls.Add(LblStreet);
            GpbCustomer.Controls.Add(LblNeighborhood);
            GpbCustomer.Controls.Add(LblEmail);
            GpbCustomer.Controls.Add(txtname);
            GpbCustomer.Controls.Add(txtStreet);
            GpbCustomer.Controls.Add(txtTelephone);
            GpbCustomer.Controls.Add(TxtStreetNumber);
            GpbCustomer.Controls.Add(cboNeighborhood);
            GpbCustomer.Controls.Add(LblStreetNumber);
            GpbCustomer.Controls.Add(TxtLastName);
            GpbCustomer.Controls.Add(LblTelephone);
            GpbCustomer.Controls.Add(txtEmail);
            GpbCustomer.Controls.Add(LblLastName);
            GpbCustomer.Location = new Point(42, 12);
            GpbCustomer.Name = "GpbCustomer";
            GpbCustomer.Size = new Size(632, 141);
            GpbCustomer.TabIndex = 88;
            GpbCustomer.TabStop = false;
            GpbCustomer.Text = "Customer";
            // 
            // FrmCustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 481);
            Controls.Add(GpbCustomer);
            Controls.Add(DgvCustomer);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Controls.Add(btnLoad);
            Name = "FrmCustomerRegistration";
            Text = "CUSTOMER REGISTRATION";
            Load += FrmCustomerRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCustomer).EndInit();
            GpbCustomer.ResumeLayout(false);
            GpbCustomer.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TextBox txtEmail;
        private Label LblEmail;
        public ComboBox cboNeighborhood;
        private TextBox txtTelephone;
        private Label LblTelephone;
        private Label LblStreet;
        private Label LblNeighborhood;
        private TextBox TxtLastName;
        private Label LblLastName;
        private TextBox txtname;
        private Label LblName;
        private TextBox txtStreet;
        private TextBox TxtStreetNumber;
        private Label LblStreetNumber;
        private Button btnCancel;
        private Button btnExit;
        private Button btnLoad;
        private DataGridView DgvCustomer;
        private Button BtnAdd;
        private GroupBox GpbCustomer;
    }
}