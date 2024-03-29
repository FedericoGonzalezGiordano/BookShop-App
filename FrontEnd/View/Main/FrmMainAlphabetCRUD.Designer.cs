﻿namespace FrontEnd.View.Main
{
    partial class FrmMainAlphabetCRUD
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            seeClientsToolStripMenuItem = new ToolStripMenuItem();
            newCustomerToolStripMenuItem = new ToolStripMenuItem();
            invoiceToolStripMenuItem = new ToolStripMenuItem();
            watchToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            articlesToolStripMenuItem = new ToolStripMenuItem();
            watchToolStripMenuItem1 = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            LblWelcome = new Label();
            TimerWelcome = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, customerToolStripMenuItem, invoiceToolStripMenuItem, articlesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(776, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, exitToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(59, 20);
            archivoToolStripMenuItem.Text = "Archive";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(99, 22);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(99, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seeClientsToolStripMenuItem, newCustomerToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(71, 20);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // seeClientsToolStripMenuItem
            // 
            seeClientsToolStripMenuItem.Name = "seeClientsToolStripMenuItem";
            seeClientsToolStripMenuItem.Size = new Size(108, 22);
            seeClientsToolStripMenuItem.Text = "Watch";
            seeClientsToolStripMenuItem.Click += seeClientsToolStripMenuItem_Click;
            // 
            // newCustomerToolStripMenuItem
            // 
            newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            newCustomerToolStripMenuItem.Size = new Size(108, 22);
            newCustomerToolStripMenuItem.Text = "New";
            newCustomerToolStripMenuItem.Click += newCustomerToolStripMenuItem_Click;
            // 
            // invoiceToolStripMenuItem
            // 
            invoiceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { watchToolStripMenuItem, newToolStripMenuItem });
            invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            invoiceToolStripMenuItem.Size = new Size(57, 20);
            invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // watchToolStripMenuItem
            // 
            watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            watchToolStripMenuItem.Size = new Size(108, 22);
            watchToolStripMenuItem.Text = "Watch";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(108, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // articlesToolStripMenuItem
            // 
            articlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { watchToolStripMenuItem1, newToolStripMenuItem1 });
            articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            articlesToolStripMenuItem.Size = new Size(58, 20);
            articlesToolStripMenuItem.Text = "Articles";
            // 
            // watchToolStripMenuItem1
            // 
            watchToolStripMenuItem1.Name = "watchToolStripMenuItem1";
            watchToolStripMenuItem1.Size = new Size(108, 22);
            watchToolStripMenuItem1.Text = "Watch";
            watchToolStripMenuItem1.Click += watchToolStripMenuItem1_Click;
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(108, 22);
            newToolStripMenuItem1.Text = "New";
            newToolStripMenuItem1.Click += newToolStripMenuItem1_Click;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.BackColor = SystemColors.ActiveCaptionText;
            LblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblWelcome.ForeColor = Color.FromArgb(255, 128, 0);
            LblWelcome.Location = new Point(33, 47);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(0, 25);
            LblWelcome.TabIndex = 2;
            // 
            // FrmMainAlphabetCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_magda_ehlers_1337386;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(776, 379);
            Controls.Add(LblWelcome);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMainAlphabetCRUD";
            Text = "FrmMain";
            Load += FrmMainAlphabetCRUD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem seeClientsToolStripMenuItem;
        private ToolStripMenuItem newCustomerToolStripMenuItem;
        private ToolStripMenuItem invoiceToolStripMenuItem;
        private ToolStripMenuItem watchToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem articlesToolStripMenuItem;
        private ToolStripMenuItem watchToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem1;
        private Label LblWelcome;
        private System.Windows.Forms.Timer TimerWelcome;
    }
}