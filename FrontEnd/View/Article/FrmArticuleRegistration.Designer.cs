namespace FrontEnd.View.Article
{
    partial class FrmArticuleRegistration
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
            GbpArticle = new GroupBox();
            ButonAdd = new Button();
            LblDescription = new Label();
            BtnAdd = new Button();
            LblObervations = new Label();
            LblUnitPrice = new Label();
            TxtDescription = new TextBox();
            TxtObservation = new TextBox();
            TxtMinStock = new TextBox();
            LblMinimumStock = new Label();
            TxtStock = new TextBox();
            txtUnitPrice = new TextBox();
            LblStock = new Label();
            DgvArticle = new DataGridView();
            btnCancel = new Button();
            btnExit = new Button();
            btnLoad = new Button();
            GbpArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvArticle).BeginInit();
            SuspendLayout();
            // 
            // GbpArticle
            // 
            GbpArticle.Controls.Add(ButonAdd);
            GbpArticle.Controls.Add(LblDescription);
            GbpArticle.Controls.Add(BtnAdd);
            GbpArticle.Controls.Add(LblObervations);
            GbpArticle.Controls.Add(LblUnitPrice);
            GbpArticle.Controls.Add(TxtDescription);
            GbpArticle.Controls.Add(TxtObservation);
            GbpArticle.Controls.Add(TxtMinStock);
            GbpArticle.Controls.Add(LblMinimumStock);
            GbpArticle.Controls.Add(TxtStock);
            GbpArticle.Controls.Add(txtUnitPrice);
            GbpArticle.Controls.Add(LblStock);
            GbpArticle.Location = new Point(42, 12);
            GbpArticle.Name = "GbpArticle";
            GbpArticle.Size = new Size(546, 103);
            GbpArticle.TabIndex = 5;
            GbpArticle.TabStop = false;
            GbpArticle.Text = "Article";
            // 
            // ButonAdd
            // 
            ButonAdd.Anchor = AnchorStyles.Bottom;
            ButonAdd.Location = new Point(435, 77);
            ButonAdd.Name = "ButonAdd";
            ButonAdd.Size = new Size(108, 26);
            ButonAdd.TabIndex = 10;
            ButonAdd.Text = "Add";
            ButonAdd.UseVisualStyleBackColor = true;
            ButonAdd.Click += ButonAdd_Click;
            // 
            // LblDescription
            // 
            LblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblDescription.AutoSize = true;
            LblDescription.Location = new Point(6, 16);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(67, 15);
            LblDescription.TabIndex = 0;
            LblDescription.Text = "Description";
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Bottom;
            BtnAdd.Location = new Point(697, 117);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(89, 21);
            BtnAdd.TabIndex = 14;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // LblObervations
            // 
            LblObervations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblObervations.AutoSize = true;
            LblObervations.Location = new Point(212, 51);
            LblObervations.Name = "LblObervations";
            LblObervations.Size = new Size(71, 15);
            LblObervations.TabIndex = 4;
            LblObervations.Text = "Observation";
            // 
            // LblUnitPrice
            // 
            LblUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblUnitPrice.AutoSize = true;
            LblUnitPrice.Location = new Point(6, 48);
            LblUnitPrice.Name = "LblUnitPrice";
            LblUnitPrice.Size = new Size(58, 15);
            LblUnitPrice.TabIndex = 12;
            LblUnitPrice.Text = "Unit price";
            // 
            // TxtDescription
            // 
            TxtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtDescription.Location = new Point(80, 16);
            TxtDescription.Name = "TxtDescription";
            TxtDescription.Size = new Size(152, 23);
            TxtDescription.TabIndex = 1;
            // 
            // TxtObservation
            // 
            TxtObservation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtObservation.Location = new Point(289, 48);
            TxtObservation.Name = "TxtObservation";
            TxtObservation.Size = new Size(234, 23);
            TxtObservation.TabIndex = 5;
            // 
            // TxtMinStock
            // 
            TxtMinStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtMinStock.Location = new Point(468, 16);
            TxtMinStock.Name = "TxtMinStock";
            TxtMinStock.Size = new Size(55, 23);
            TxtMinStock.TabIndex = 7;
            // 
            // LblMinimumStock
            // 
            LblMinimumStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblMinimumStock.AutoSize = true;
            LblMinimumStock.Location = new Point(371, 19);
            LblMinimumStock.Name = "LblMinimumStock";
            LblMinimumStock.Size = new Size(91, 15);
            LblMinimumStock.TabIndex = 6;
            LblMinimumStock.Text = "Minimum stock";
            // 
            // TxtStock
            // 
            TxtStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtStock.Location = new Point(289, 16);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(55, 23);
            TxtStock.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Location = new Point(80, 48);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(120, 23);
            txtUnitPrice.TabIndex = 13;
            // 
            // LblStock
            // 
            LblStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblStock.AutoSize = true;
            LblStock.Location = new Point(244, 19);
            LblStock.Name = "LblStock";
            LblStock.Size = new Size(39, 15);
            LblStock.TabIndex = 2;
            LblStock.Text = "Stock ";
            // 
            // DgvArticle
            // 
            DgvArticle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvArticle.Location = new Point(42, 121);
            DgvArticle.Name = "DgvArticle";
            DgvArticle.RowTemplate.Height = 25;
            DgvArticle.Size = new Size(546, 254);
            DgvArticle.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Location = new Point(265, 387);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 26);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.Location = new Point(487, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 26);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom;
            btnLoad.Location = new Point(43, 387);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(108, 26);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // FrmArticuleRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 437);
            Controls.Add(GbpArticle);
            Controls.Add(DgvArticle);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Controls.Add(btnLoad);
            Name = "FrmArticuleRegistration";
            Text = "FrmArticuleRegistration";
            Load += FrmArticuleRegistration_Load;
            GbpArticle.ResumeLayout(false);
            GbpArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvArticle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbpArticle;
        private Label LblDescription;
        private Button BtnAdd;
        private Label LblObervations;
        private Label LblUnitPrice;
        private TextBox TxtDescription;
        private TextBox TxtObservation;
        private TextBox TxtMinStock;
        private Label LblMinimumStock;
        private TextBox TxtStock;
        private TextBox txtUnitPrice;
        private Label LblStock;
        private DataGridView DgvArticle;
        private Button btnCancel;
        private Button btnExit;
        private Button btnLoad;
        private Button ButonAdd;
    }
}