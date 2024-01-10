namespace FrontEnd.View.Customer
{
    partial class FrmCustomerUpdate
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
            GpbCustomer = new GroupBox();
            BtnBack = new Button();
            BtnUpdate = new Button();
            LblName = new Label();
            BtnAdd = new Button();
            LblStreet = new Label();
            LblNeighborhood = new Label();
            LblEmail = new Label();
            txtname = new TextBox();
            txtStreet = new TextBox();
            txtTelephone = new TextBox();
            TxtStreetNumber = new TextBox();
            cboNeighborhood = new ComboBox();
            LblStreetNumber = new Label();
            TxtLastName = new TextBox();
            LblTelephone = new Label();
            txtEmail = new TextBox();
            LblLastName = new Label();
            GpbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // GpbCustomer
            // 
            GpbCustomer.Controls.Add(BtnBack);
            GpbCustomer.Controls.Add(BtnUpdate);
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
            GpbCustomer.Location = new Point(12, 3);
            GpbCustomer.Name = "GpbCustomer";
            GpbCustomer.Size = new Size(742, 136);
            GpbCustomer.TabIndex = 0;
            GpbCustomer.TabStop = false;
            GpbCustomer.Text = "Customer";
            GpbCustomer.Enter += GpbCustomer_Enter;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(631, 103);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(97, 25);
            BtnBack.TabIndex = 15;
            BtnBack.Text = "back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(528, 103);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(97, 25);
            BtnUpdate.TabIndex = 14;
            BtnUpdate.Text = "update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // LblName
            // 
            LblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblName.AutoSize = true;
            LblName.Location = new Point(52, 19);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 0;
            LblName.Text = "Name";
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Bottom;
            BtnAdd.Location = new Point(1031, 206);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(89, 21);
            BtnAdd.TabIndex = 87;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // LblStreet
            // 
            LblStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblStreet.AutoSize = true;
            LblStreet.Location = new Point(52, 46);
            LblStreet.Name = "LblStreet";
            LblStreet.Size = new Size(37, 15);
            LblStreet.TabIndex = 4;
            LblStreet.Text = "Street";
            // 
            // LblNeighborhood
            // 
            LblNeighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblNeighborhood.AutoSize = true;
            LblNeighborhood.Location = new Point(6, 77);
            LblNeighborhood.Name = "LblNeighborhood";
            LblNeighborhood.Size = new Size(85, 15);
            LblNeighborhood.TabIndex = 8;
            LblNeighborhood.Text = "Neighborhood";
            // 
            // LblEmail
            // 
            LblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(48, 103);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(41, 15);
            LblEmail.TabIndex = 12;
            LblEmail.Text = "E-Mail";
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtname.Location = new Point(107, 16);
            txtname.Name = "txtname";
            txtname.Size = new Size(232, 23);
            txtname.TabIndex = 1;
            // 
            // txtStreet
            // 
            txtStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStreet.Location = new Point(107, 46);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(232, 23);
            txtStreet.TabIndex = 5;
            // 
            // txtTelephone
            // 
            txtTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelephone.Location = new Point(438, 74);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(296, 23);
            txtTelephone.TabIndex = 11;
            // 
            // TxtStreetNumber
            // 
            TxtStreetNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtStreetNumber.Location = new Point(438, 45);
            TxtStreetNumber.Name = "TxtStreetNumber";
            TxtStreetNumber.Size = new Size(296, 23);
            TxtStreetNumber.TabIndex = 7;
            // 
            // cboNeighborhood
            // 
            cboNeighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboNeighborhood.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNeighborhood.FormattingEnabled = true;
            cboNeighborhood.Location = new Point(107, 75);
            cboNeighborhood.Name = "cboNeighborhood";
            cboNeighborhood.Size = new Size(232, 23);
            cboNeighborhood.TabIndex = 9;
            // 
            // LblStreetNumber
            // 
            LblStreetNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblStreetNumber.AutoSize = true;
            LblStreetNumber.Location = new Point(348, 48);
            LblStreetNumber.Name = "LblStreetNumber";
            LblStreetNumber.Size = new Size(84, 15);
            LblStreetNumber.TabIndex = 6;
            LblStreetNumber.Text = "Street Number";
            // 
            // TxtLastName
            // 
            TxtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtLastName.Location = new Point(438, 16);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(296, 23);
            TxtLastName.TabIndex = 3;
            // 
            // LblTelephone
            // 
            LblTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblTelephone.AutoSize = true;
            LblTelephone.Location = new Point(371, 80);
            LblTelephone.Name = "LblTelephone";
            LblTelephone.Size = new Size(61, 15);
            LblTelephone.TabIndex = 10;
            LblTelephone.Text = "Telephone";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(107, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 13;
            // 
            // LblLastName
            // 
            LblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblLastName.AutoSize = true;
            LblLastName.Location = new Point(374, 19);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(58, 15);
            LblLastName.TabIndex = 2;
            LblLastName.Text = "Lastname";
            // 
            // FrmCustomerUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 147);
            Controls.Add(GpbCustomer);
            Name = "FrmCustomerUpdate";
            Text = "FrmCustomerUpdate";
            Load += FrmCustomerUpdate_Load;
            GpbCustomer.ResumeLayout(false);
            GpbCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GpbCustomer;
        private Button BtnBack;
        private Button BtnUpdate;
        private Label LblName;
        private Button BtnAdd;
        private Label LblStreet;
        private Label LblNeighborhood;
        private Label LblEmail;
        private TextBox txtname;
        private TextBox txtStreet;
        private TextBox txtTelephone;
        private TextBox TxtStreetNumber;
        public ComboBox cboNeighborhood;
        private Label LblStreetNumber;
        private TextBox TxtLastName;
        private Label LblTelephone;
        private TextBox txtEmail;
        private Label LblLastName;
    }
}