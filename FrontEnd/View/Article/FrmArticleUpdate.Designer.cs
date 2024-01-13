namespace FrontEnd.View.Article
{
    partial class FrmArticleUpdate
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
            GpbArticle = new GroupBox();
            BtnBack = new Button();
            BtnUpdate = new Button();
            LblDescription = new Label();
            BtnAdd = new Button();
            LblStockMin = new Label();
            LblStock = new Label();
            TxtDescription = new TextBox();
            TxtStockMin = new TextBox();
            TxtObservation = new TextBox();
            LblObservation = new Label();
            TxtUnitPrice = new TextBox();
            TxtStock = new TextBox();
            LblPreUnit = new Label();
            GpbArticle.SuspendLayout();
            SuspendLayout();
            // 
            // GpbArticle
            // 
            GpbArticle.Controls.Add(BtnBack);
            GpbArticle.Controls.Add(BtnUpdate);
            GpbArticle.Controls.Add(LblDescription);
            GpbArticle.Controls.Add(BtnAdd);
            GpbArticle.Controls.Add(LblStockMin);
            GpbArticle.Controls.Add(LblStock);
            GpbArticle.Controls.Add(TxtDescription);
            GpbArticle.Controls.Add(TxtStockMin);
            GpbArticle.Controls.Add(TxtObservation);
            GpbArticle.Controls.Add(LblObservation);
            GpbArticle.Controls.Add(TxtUnitPrice);
            GpbArticle.Controls.Add(TxtStock);
            GpbArticle.Controls.Add(LblPreUnit);
            GpbArticle.Location = new Point(12, 12);
            GpbArticle.Name = "GpbArticle";
            GpbArticle.Size = new Size(733, 111);
            GpbArticle.TabIndex = 1;
            GpbArticle.TabStop = false;
            GpbArticle.Text = "Article ";
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(603, 80);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(97, 25);
            BtnBack.TabIndex = 15;
            BtnBack.Text = "back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(500, 80);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(97, 25);
            BtnUpdate.TabIndex = 14;
            BtnUpdate.Text = "update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // LblDescription
            // 
            LblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblDescription.AutoSize = true;
            LblDescription.Location = new Point(24, 19);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(67, 15);
            LblDescription.TabIndex = 0;
            LblDescription.Text = "Description";
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Bottom;
            BtnAdd.Location = new Point(1297, 217);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(89, 21);
            BtnAdd.TabIndex = 87;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // LblStockMin
            // 
            LblStockMin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblStockMin.AutoSize = true;
            LblStockMin.Location = new Point(6, 49);
            LblStockMin.Name = "LblStockMin";
            LblStockMin.Size = new Size(92, 15);
            LblStockMin.TabIndex = 4;
            LblStockMin.Text = "Stock Minimum";
            // 
            // LblStock
            // 
            LblStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblStock.AutoSize = true;
            LblStock.Location = new Point(55, 85);
            LblStock.Name = "LblStock";
            LblStock.Size = new Size(36, 15);
            LblStock.TabIndex = 12;
            LblStock.Text = "Stock";
            // 
            // TxtDescription
            // 
            TxtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtDescription.Location = new Point(107, 16);
            TxtDescription.Name = "TxtDescription";
            TxtDescription.Size = new Size(213, 23);
            TxtDescription.TabIndex = 1;
            // 
            // TxtStockMin
            // 
            TxtStockMin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtStockMin.Location = new Point(107, 46);
            TxtStockMin.Name = "TxtStockMin";
            TxtStockMin.Size = new Size(213, 23);
            TxtStockMin.TabIndex = 5;
            // 
            // TxtObservation
            // 
            TxtObservation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtObservation.Location = new Point(438, 45);
            TxtObservation.Name = "TxtObservation";
            TxtObservation.Size = new Size(253, 23);
            TxtObservation.TabIndex = 7;
            // 
            // LblObservation
            // 
            LblObservation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblObservation.AutoSize = true;
            LblObservation.Location = new Point(348, 46);
            LblObservation.Name = "LblObservation";
            LblObservation.Size = new Size(71, 15);
            LblObservation.TabIndex = 6;
            LblObservation.Text = "Observation";
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtUnitPrice.Location = new Point(438, 13);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(253, 23);
            TxtUnitPrice.TabIndex = 3;
            // 
            // TxtStock
            // 
            TxtStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtStock.Location = new Point(107, 82);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(213, 23);
            TxtStock.TabIndex = 13;
            // 
            // LblPreUnit
            // 
            LblPreUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblPreUnit.AutoSize = true;
            LblPreUnit.Location = new Point(361, 16);
            LblPreUnit.Name = "LblPreUnit";
            LblPreUnit.Size = new Size(58, 15);
            LblPreUnit.TabIndex = 2;
            LblPreUnit.Text = "Unit Price";
            // 
            // FrmArticleUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 134);
            Controls.Add(GpbArticle);
            Name = "FrmArticleUpdate";
            Text = "FrmArticleUpdate";
            Load += FrmArticleUpdate_Load;
            GpbArticle.ResumeLayout(false);
            GpbArticle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GpbArticle;
        private Button BtnBack;
        private Button BtnUpdate;
        private Label LblDescription;
        private Button BtnAdd;
        private Label LblStockMin;
        private Label LblStock;
        private TextBox TxtDescription;
        private TextBox TxtStockMin;
        private TextBox TxtObservation;
        private Label LblObservation;
        private TextBox TxtUnitPrice;
        private TextBox TxtStock;
        private Label LblPreUnit;
    }
}