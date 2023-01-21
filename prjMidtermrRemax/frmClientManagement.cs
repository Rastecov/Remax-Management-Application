using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermrRemax
{
    public partial class frmClientManagement : Form
    {
        public frmClientManagement()
        {
            InitializeComponent();
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuyers fs = new frmBuyers();

            fs.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeller fs = new frmSeller();

            fs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmClientManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
