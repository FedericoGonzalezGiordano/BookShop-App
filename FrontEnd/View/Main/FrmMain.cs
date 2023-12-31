using FrontEnd.Factory.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.View.Main
{
    public partial class FrmMain : Form
    {
        private IFactoryService factory;
        public FrmMain(IFactoryService factory)
        {
            this.factory = factory;
            InitializeComponent();
        }
    }
}
