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
    public partial class frmBuyers : Form
    {
        public frmBuyers()
        {
            InitializeComponent();
        }
        DataSet myset;
        OleDbDataAdapter myadpBuyer;
        DataTable tabBuyer, tabAgent;
        OleDbConnection mycon;
        int currentPosition;
        string mode;

      
        private void FillComboWithAgent()
        {
            //Databinding version
            cboAgent.DisplayMember = "FullName";
            cboAgent.ValueMember = "EmployeeID";
            cboAgent.DataSource = tabAgent;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPosition = tabBuyer.Rows.Count - 1;
            display();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPosition < (tabBuyer.Rows.Count - 1))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            display();
            ActivateButtons(true, false, true);
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
            string msg = "Are you sure to want to delete this Buyer ?";
            string title = "Warning : Buyer Deletion";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabBuyer.Rows[currentPosition].Delete();

                //Now we need to update (or synchronize) the contents of the dataset -> the database
                OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myadpBuyer);
                myadpBuyer.Update(myset, "ClientBuyers");

                //Update the contents of the database -> dataset
                myset.Tables.Remove("ClientBuyers");
                OleDbCommand mycmd = new OleDbCommand("SELECT * FROM ClientBuyers", mycon);
                myadpBuyer = new OleDbDataAdapter(mycmd);
                myadpBuyer.Fill(myset, "ClientBuyers");
                tabBuyer = myset.Tables["ClientBuyers"];

                currentPosition = 0;
                display();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime birth = dateTimeDob.Value;
            string pin = txtPassw.Text.Trim();
            int refAg = Convert.ToInt32(cboAgent.SelectedValue);
            DataRow myrow;

            if (mode == "add")
            {
                myrow = tabBuyer.NewRow();
                myrow["Name"] = name;
                myrow["Birthdate"] = birth;
                myrow["Email"] = email;
                myrow["Pin"] = pin;
                myrow["referAgent"] = refAg;
                tabBuyer.Rows.Add(myrow);
                currentPosition = tabBuyer.Rows.Count - 1;
            }
            else if (mode == "edit")
            {
                myrow = tabBuyer.Rows[currentPosition];
                myrow["Name"] = name;
                myrow["Birthdate"] = birth;
                myrow["Email"] = email;
                myrow["Pin"] = pin;
                myrow["referAgent"] = refAg;
            }
            //new record saved only in the table of the dataset
            //Now we need to update (or synchronize) the contents of the dataset -> the database
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myadpBuyer);
            myadpBuyer.Update(myset, "ClientBuyers");

            //Update the contents of the database -> dataset
            myset.Tables.Remove("ClientBuyers");
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM ClientBuyers", mycon);
            myadpBuyer = new OleDbDataAdapter(mycmd);
            myadpBuyer.Fill(myset, "ClientBuyers");
            tabBuyer = myset.Tables["ClientBuyers"];

            display();
            mode = "";
            ActivateButtons(true, false, true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            //dateTimeDob.Value = DateTime.Today;
            dateTimeDob.ResetText();
            txtEmail.Text = txtName.Text = txtPassw.Text = "";
            cboAgent.Text = "Select an Agent";
            txtName.Focus();
            lblInfo.Text = "--- Adding Mode ---";
            ActivateButtons(false, true, false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to quit BUYER MANAGEMENT ?";
            string title = "Management closing";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmBuyers_Load(object sender, EventArgs e)
        {
            myset = new DataSet();

             mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc123\Documents\SEMESTER 3\MULTI TIER APPS\prjMidtermrRemax\prjMidtermrRemax\Database\Remax.accdb");
            mycon.Open();

            //Load table companies in the dataset
            OleDbCommand mycmd = new OleDbCommand("SELECT EmployeeID, FullName FROM Agents", mycon);
            OleDbDataAdapter myadpAgent = new OleDbDataAdapter(mycmd);
            myadpAgent.Fill(myset, "Agents"); // The name of table we want -- We cam also change the name of table

            //Load table employee in the dataset
            mycmd = new OleDbCommand("SELECT * FROM ClientBuyers", mycon);
            myadpBuyer = new OleDbDataAdapter(mycmd);
            myadpBuyer.Fill(myset, "ClientBuyers");

            tabAgent = myset.Tables["Agents"];
            tabBuyer = myset.Tables["ClientBuyers"];


            currentPosition = 0;

            display();

            FillComboWithAgent();
        }
        private void display() //We create display() for display the comName, Loc, Cat, Web --> Avoid repeating
        {
            txtName.Text = tabBuyer.Rows[currentPosition]["FullName"].ToString(); //.ToString -> we display in property text
            dateTimeDob.Value = Convert.ToDateTime(tabBuyer.Rows[currentPosition]["Birthdate"]);
            txtEmail.Text = tabBuyer.Rows[currentPosition]["Email"].ToString();
            txtPassw.Text = tabBuyer.Rows[currentPosition]["EmpPassword"].ToString();

            int referAg = Convert.ToInt32(tabBuyer.Rows[currentPosition]["referAgent"]);


            //If we use this version, we dont need the line cboAdmin.Text = tabAgent.Rows[currentPosition]["referAdmin"].ToString(); 
            cboAgent.SelectedValue = referAg;

            lblInfo.Text = "Buyer " + (currentPosition + 1) + " on a total of " + tabBuyer.Rows.Count;
        }

        private void ActivateButtons(bool AdEdiDel, bool SaveCanc, bool Navig)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = AdEdiDel;
            btnSave.Enabled = btnCancel.Enabled = SaveCanc;
            btnFirst.Enabled = btnLast.Enabled = btnNext.Enabled = btnPrevious.Enabled = Navig;
        }
    }
}
