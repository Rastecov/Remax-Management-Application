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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        DataSet myset;
        OleDbDataAdapter myadpAgent;
        DataTable tabAdmin, tabAgent;
        OleDbConnection mycon;
        int currentPosition;
        string mode;

      
        private void display() //We create display() for display the comName, Loc, Cat, Web --> Avoid repeating
        {
            txtName.Text = tabAgent.Rows[currentPosition]["FullName"].ToString(); //.ToString -> we display in property text
            dateTimeDob.Value = Convert.ToDateTime(tabAgent.Rows[currentPosition]["Birthdate"]);
            txtEmail.Text = tabAgent.Rows[currentPosition]["Email"].ToString();
            txtPassw.Text = tabAgent.Rows[currentPosition]["EmpPassword"].ToString();
            //cboAdmin.Text = tabAgent.Rows[currentPosition]["referAdmin"].ToString();

            //Find the company name that has the same refcompany
            //Version Loop
            int referAd = Convert.ToInt32(tabAgent.Rows[currentPosition]["referAdmin"]);

            
            //If we use this version, we dont need the line cboAdmin.Text = tabAgent.Rows[currentPosition]["referAdmin"].ToString(); 
            cboAdmin.SelectedValue = referAd;

            lblInfo.Text = "Employee (Agent) " + (currentPosition + 1) + " on a total of " + tabAgent.Rows.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPosition = tabAgent.Rows.Count - 1;
            display();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPosition < (tabAgent.Rows.Count - 1))
            {
                currentPosition = currentPosition + 1;
                display();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPosition > 0) // 0 is not include because 0 cannot -1
            {
                currentPosition = currentPosition - 1;
                display();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPosition = 0;
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            //dateTimeDob.Value = DateTime.Today;
            dateTimeDob.ResetText();
            txtEmail.Text = txtName.Text = txtPassw.Text = "";
            cboAdmin.Text = "Select an Admin";
            txtName.Focus();
            lblInfo.Text = "--- Adding Mode ---";
            ActivateButtons(false, true, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtName.Focus();
            lblInfo.Text = "--- Editing Mode ---";
            ActivateButtons(false, true, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to want to delete this Agent ?";
            string title = "Warning : Agent Deletion";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    tabAgent.Rows[currentPosition].Delete();

                    //Now we need to update (or synchronize) the contents of the dataset -> the database
                    OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myadpAgent);
                    myadpAgent.Update(myset, "Agents");

                    //Update the contents of the database -> dataset
                    myset.Tables.Remove("Agents");
                    OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Agents", mycon);
                    myadpAgent = new OleDbDataAdapter(mycmd);
                    myadpAgent.Fill(myset, "Agents");
                    tabAgent = myset.Tables["Agents"];

                    currentPosition = 0;
                    display();
                }
                catch
                {
                    MessageBox.Show("You cannot delete an agent within clients(SELLERS/BUYRER), Delete the clients first !",
                       "Deleting the AGENT that has clients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            display();
            ActivateButtons(true, false, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime birth = dateTimeDob.Value;
            string pin = txtPassw.Text.Trim();
            int refAd = Convert.ToInt32(cboAdmin.SelectedValue);
            DataRow myrow;

            if (mode == "add")
            {
                myrow = tabAgent.NewRow();
                myrow["Name"] = name;
                myrow["Birthdate"] = birth;
                myrow["Email"] = email;
                myrow["Pin"] = pin;
                myrow["referAdmin"] = refAd;
                tabAgent.Rows.Add(myrow);
                currentPosition = tabAgent.Rows.Count - 1;
            }
            else if (mode == "edit")
            {
                myrow = tabAgent.Rows[currentPosition];
                myrow["Name"] = name;
                myrow["Birthdate"] = birth;
                myrow["Email"] = email;
                myrow["Pin"] = pin;
                myrow["referAdmin"] = refAd;
            }
            //new record saved only in the table of the dataset
            //Now we need to update (or synchronize) the contents of the dataset -> the database
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myadpAgent);
            myadpAgent.Update(myset, "Agents");

            //Update the contents of the database -> dataset
            myset.Tables.Remove("Agents");
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Agents", mycon);
            myadpAgent = new OleDbDataAdapter(mycmd);
            myadpAgent.Fill(myset, "Agents");
            tabAgent = myset.Tables["Agents"];


            display();
            mode = "";
            ActivateButtons(true, false, true);
        }

        private void FillComboWithAdmin()
        {
            //Databinding version
            cboAdmin.DisplayMember = "FullName";
            cboAdmin.ValueMember = "EmployeeID";
            cboAdmin.DataSource = tabAdmin;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to quit AGENT MANAGEMENT ?";
            string title = "Management closing";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            myset = new DataSet();

             mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc123\Documents\SEMESTER 3\MULTI TIER APPS\prjMidtermrRemax\prjMidtermrRemax\Database\Remax.accdb");
            mycon.Open();

            //Load table companies in the dataset
            OleDbCommand mycmd = new OleDbCommand("SELECT EmployeeID, FullName FROM Admins", mycon);
            OleDbDataAdapter myadpAdmin = new OleDbDataAdapter(mycmd);
            myadpAdmin.Fill(myset, "Admins"); // The name of table we want -- We cam also change the name of table

            //Load table employee in the dataset
            mycmd = new OleDbCommand("SELECT * FROM Agents", mycon);
            myadpAgent = new OleDbDataAdapter(mycmd);
            myadpAgent.Fill(myset, "Agents");

            tabAdmin = myset.Tables["Admins"];
            tabAgent = myset.Tables["Agents"];


            currentPosition = 0;

            display();

            FillComboWithAdmin();
        }

        private void ActivateButtons(bool AdEdiDel, bool SaveCanc, bool Navig)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = AdEdiDel;
            btnSave.Enabled = btnCancel.Enabled = SaveCanc;
            btnFirst.Enabled = btnLast.Enabled = btnNext.Enabled = btnPrevious.Enabled = Navig;
        }

    }
}
