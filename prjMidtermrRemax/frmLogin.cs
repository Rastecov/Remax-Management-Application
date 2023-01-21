using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace prjMidtermrRemax
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection mycon;
        OleDbCommand mycmd;
        OleDbDataReader myread;
        public static string mode = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to quit Remax Application ?";
            string title = "Application closing";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string passw = txtPassword.Text.Trim();
            string sql;
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\erast\Documents\SEMESTER 3\MULTI TIER APPS\prjMidtermrRemax\prjMidtermrRemax\Database\Remax.accdb");
            mycon.Open();
            if (radAdmin.Checked == true)
            {
                sql = "SELECT Email, EmpPassword FROM Admins WHERE Email = '" + email + "'AND EmpPassword = '" + passw + "'";
                mycmd = new OleDbCommand(sql, mycon);
                myread = mycmd.ExecuteReader();
                if (myread.HasRows == true)
                {
                    mycon.Close();
                    this.Close();
                    mode = "Admin";
                }
                else
                {
                    mycon.Close();
                    lblVerification.Text = "Email or Password not found! Try again.";
                    txtPassword.Clear();
                    txtEmail.Focus();
                }
            }
            else if (radAgent.Checked == true)
            {
                sql = "SELECT Email, EmpPassword FROM Agents WHERE Email = '" + email + "'AND EmpPassword = '" + passw + "'";
                mycmd = new OleDbCommand(sql, mycon);
                myread = mycmd.ExecuteReader();
                if (myread.HasRows == true)
                {
                    mycon.Close();
                    this.Close();
                    mode = "Agent";

                }
                else
                {
                    mycon.Close();
                    lblVerification.Text = "Email or Password not found! Try again.";
                    txtPassword.Clear();
                    txtEmail.Focus();
                }
            }
            else if (radBuyer.Checked == true)
            {
                sql = "SELECT Email, EmpPassword FROM ClientBuyers WHERE Email = '" + email + "'AND EmpPassword = '" + passw + "'";
                mycmd = new OleDbCommand(sql, mycon);
                myread = mycmd.ExecuteReader();
                if (myread.HasRows == true)
                {
                    mycon.Close();
                    this.Close();
                    mode = "Buyer";
                }
                else
                {
                    mycon.Close();
                    lblVerification.Text = "Email or Password not found! Try again.";
                    txtPassword.Clear();
                    txtEmail.Focus();
                }
            }
            else if (radSeller.Checked == true)
            {
                sql = "SELECT Email, EmpPassword FROM ClientSellers WHERE Email = '" + email + "'AND EmpPassword = '" + passw + "'";
                mycmd = new OleDbCommand(sql, mycon);
                myread = mycmd.ExecuteReader();
                if (myread.HasRows == true)
                {
                    mycon.Close();
                    this.Close();
                    mode = "Seller";
                }
                else
                {
                    mycon.Close();
                    lblVerification.Text = "Email or Password not found! Try again.";
                    txtPassword.Clear();
                    txtEmail.Focus();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtEmail.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
    

