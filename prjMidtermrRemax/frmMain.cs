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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();

            if (frmLogin.mode == "Admin")
            {
                ActiveMB(true, true, true, true);

            }
            else if (frmLogin.mode == "Agent")
            {
                ActiveMB(true, false,false,false);
            }

            else if (frmLogin.mode == "Buyer")
            {
                ActiveMB(false, false, true, true);
            }
            else if (frmLogin.mode == "Seller")
            {
                ActiveMB(false, false, true, true);
            }
        }


        private void ActiveMB(bool manageClients,  bool manageAgent, bool Buyer, bool Sellers )
        {

            this.mnuClients.Enabled = manageClients;
            this.MnuAgents.Enabled = manageAgent;
            this.MnuClientSearch.Enabled = Buyer;
            this.MnuClientSearch.Enabled = Sellers;




        }



        private void MnuAgents_Click(object sender, EventArgs e)
        {
            frmAdmin fs = new frmAdmin();

            fs.Show();

        }

        private void MnuClientSearch_Click(object sender, EventArgs e)
        {
            frmClient fs = new frmClient();

            fs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mnuClients_Click(object sender, EventArgs e)
        {
            frmClientManagement fs = new frmClientManagement();
            
            fs.Show();
        }
    }
}
