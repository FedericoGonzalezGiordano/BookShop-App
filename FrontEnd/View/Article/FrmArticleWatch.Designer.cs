namespace FrontEnd.View.Article
{
    partial class FrmArticleWatch
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
            BtnExit = new Button();
            BtnModify = new Button();
            BtnDelete = new Button();
            GpbArticles = new GroupBox();
            LblDescrition = new Label();
            TxtDescription = new TextBox();
            BtnSearch = new Button();
            DgvArticleWatch = new DataGridView();
            GpbArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvArticleWatch).BeginInit();
            SuspendLayout();
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(569, 321);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 9;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(93, 321);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(75, 23);
            BtnModify.TabIndex = 8;
            BtnModify.Text = "Modify";
            BtnModify.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(12, 321);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // GpbArticles
            // 
            GpbArticles.Controls.Add(LblDescrition);
            GpbArticles.Controls.Add(TxtDescription);
            GpbArticles.Controls.Add(BtnSearch);
            GpbArticles.Location = new Point(12, 12);
            GpbArticles.Name = "GpbArticles";
            GpbArticles.Size = new Size(632, 50);
            GpbArticles.TabIndex = 5;
            GpbArticles.TabStop = false;
            GpbArticles.Text = "Search Articles";
            // 
            // LblDescrition
            // 
            LblDescrition.AutoSize = true;
            LblDescrition.Location = new Point(20, 24);
            LblDescrition.Name = "LblDescrition";
            LblDescrition.Size = new Size(67, 15);
            LblDescrition.TabIndex = 0;
            LblDescrition.Text = "Description";
            // 
            // TxtDescription
            // 
            TxtDescription.Location = new Point(93, 21);
            TxtDescription.Name = "TxtDescription";
            TxtDescription.Size = new Size(263, 23);
            TxtDescription.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(551, 20);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // DgvArticleWatch
            // 
            DgvArticleWatch.AllowUserToAddRows = false;
            DgvArticleWatch.AllowUserToDeleteRows = false;
            DgvArticleWatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvArticleWatch.Location = new Point(13, 68);
            DgvArticleWatch.Name = "DgvArticleWatch";
            DgvArticleWatch.ReadOnly = true;
            DgvArticleWatch.RowTemplate.Height = 25;
            DgvArticleWatch.Size = new Size(632, 238);
            DgvArticleWatch.TabIndex = 6;
            // 
            // FrmArticleWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 354);
            Controls.Add(BtnExit);
            Controls.Add(BtnModify);
            Controls.Add(BtnDelete);
            Controls.Add(GpbArticles);
            Controls.Add(DgvArticleWatch);
            Name = "FrmArticleWatch";
            Text = "FrmArticleWatch";
            Load += FrmArticleWatch_Load;
            GpbArticles.ResumeLayout(false);
            GpbArticles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvArticleWatch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnExit;
        private Button BtnModify;
        private Button BtnDelete;
        private GroupBox GpbArticles;
        private Label LblDescrition;
        private TextBox TxtDescription;
        private Button BtnSearch;
        private DataGridView DgvArticleWatch;
    }
}