namespace FrontEnd.View.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            LblUser = new Label();
            LblPassword = new Label();
            TxtPassword = new TextBox();
            cboSeller = new ComboBox();
            btnLog = new Button();
            SuspendLayout();
            // 
            // LblUser
            // 
            LblUser.AutoSize = true;
            LblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblUser.Location = new Point(103, 71);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(42, 21);
            LblUser.TabIndex = 0;
            LblUser.Text = "User";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPassword.Location = new Point(69, 133);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(76, 21);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(171, 131);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(230, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // cboSeller
            // 
            cboSeller.FormattingEnabled = true;
            cboSeller.Location = new Point(171, 73);
            cboSeller.Name = "cboSeller";
            cboSeller.Size = new Size(230, 23);
            cboSeller.TabIndex = 4;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(256, 191);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 23);
            btnLog.TabIndex = 5;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(588, 241);
            Controls.Add(btnLog);
            Controls.Add(cboSeller);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(LblUser);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUser;
        private Label LblPassword;
        private TextBox TxtPassword;
        private ComboBox cboSeller;
        private Button btnLog;
    }
}