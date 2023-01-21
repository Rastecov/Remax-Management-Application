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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchAgent fs = new frmSearchAgent();

            fs.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchHouse fs = new frmSearchHouse();

            fs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {

        }
    }
}
