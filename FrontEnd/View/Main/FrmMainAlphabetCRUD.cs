using FrontEnd.Factory.Interface;
using FrontEnd.View.Article;
using FrontEnd.View.Customer;
using FrontEnd.View.Invoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.View.Main
{
    public partial class FrmMainAlphabetCRUD : Form
    {
        private IFactoryService factory;
        private SellerModel sellermodel;
        private System.Windows.Forms.Timer timer;
        public FrmMainAlphabetCRUD(IFactoryService factory, SellerModel model)
        {
            this.factory = factory;
            InitializeComponent();
            InitializeTimer();
            this.sellermodel = model;
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; 
            timer.Tick += Timer_Tick;
            timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            LblWelcome.Visible = false;
            timer.Stop();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpMessage = "Thank you for reaching out to Alphabet Bookshop's Help Center.\n\n";
            helpMessage += "Central Office Location:\n";
            helpMessage += "----------------------\n";
            helpMessage += "Our central office is located in the vibrant city of Springfield, USA. Feel free to contact us at:\n\n";
            helpMessage += "Alphabet Bookshop\n";
            helpMessage += "Central Office\n";
            helpMessage += "123 Main Street, Suite 456\n";
            helpMessage += "Springfield, USA\n\n";
            helpMessage += "For System-Related Issues:\n";
            helpMessage += "-------------------------\n";
            helpMessage += "If you encounter any problems with our system, please contact our dedicated support team at:\n";
            helpMessage += "Phone: +1 (555) 123-4567\n";
            helpMessage += "Email: support@alphabetbookshop.com\n\n";
            helpMessage += "Visit Our Local Branch:\n";
            helpMessage += "----------------------\n";
            helpMessage += "We also invite you to visit our local branch nearest to you for personalized assistance. Our friendly staff will be happy to help you with any inquiries.\n\n";
            helpMessage += "Thank you for choosing Alphabet Bookshop!\n";

            MessageBox.Show(helpMessage, "Alphabet Bookshop Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for visiting! We hope to see you soon!", "Farewell", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }


        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerRegistration frmCustomerRegistration = new FrmCustomerRegistration(factory);
            frmCustomerRegistration.ShowDialog();
        }

        private void FrmMainAlphabetCRUD_Load(object sender, EventArgs e)
        {
            string msg = "Welcome Seller!!" + sellermodel.CompleteName.ToString() + "\nYou can now use the system";
            LblWelcome.Text = msg;

        }

        private void seeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerWatch frmCustomerWatch = new FrmCustomerWatch(factory);
            frmCustomerWatch.ShowDialog();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmArticuleRegistration frmArticuleRegistration = new FrmArticuleRegistration(factory);
            frmArticuleRegistration.ShowDialog();
        }

        private void watchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmArticleWatch frmArticleWatch = new FrmArticleWatch(factory);
            frmArticleWatch.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoiceRegistration frmInvoiceRegistration = new FrmInvoiceRegistration(factory, sellermodel);
            frmInvoiceRegistration.ShowDialog();
        }
    }
}
