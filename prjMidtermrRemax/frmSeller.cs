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
    public partial class frmSeller : Form
    {
        public frmSeller()
        {
            InitializeComponent();
        }
        DataSet myset;
        OleDbDataAdapter myadpSeller;
        DataTable tabSeller, tabAgent;
        OleDbConnection mycon;
        int currentPosition;
        string mode;
        private void frmSeller_Load(object sender, EventArgs e)
        {
            myset = new DataSet();

            OleDbConnection mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc123\Documents\SEMESTER 3\MULTI TIER APPS\prjMidtermrRemax\prjMidtermrRemax\Database\Remax.accdb");
            mycon.Open();

            //Load table companies in the dataset
            OleDbCommand mycmd = new OleDbCommand("SELECT EmployeeID, FullName FROM Agents", mycon);
            OleDbDataAdapter myadpAgent = new OleDbDataAdapter(mycmd);
            myadpAgent.Fill(myset, "Agents"); // The name of table we want -- We cam also change the name of table

            //Load table employee in the dataset
            mycmd = new OleDbCommand("SELECT * FROM ClientSellers", mycon);
            myadpSeller = new OleDbDataAdapter(mycmd);
            myadpSeller.Fill(myset, "ClientSellers");

            tabAgent = myset.Tables["Agents"];
            tabSeller = myset.Tables["ClientSellers"];


            currentPosition = 0;

            display();

            FillComboWithAgent();
        }
        private void display() //We create display() for display the comName, Loc, Cat, Web --> Avoid repeating
        {
            txtName.Text = tabSeller.Rows[currentPosition]["FullName"].ToString(); //.ToString -> we display in property text
            dateTimeDob.Value = Convert.ToDateTime(tabSeller.Rows[currentPosition]["Birthdate"]);
            txtEmail.Text = tabSeller.Rows[currentPosition]["Email"].ToString();
            txtPassw.Text = tabSeller.Rows[currentPosition]["EmpPassword"].ToString();

            //Find the company name that has the same refcompany
            //Version Loop
            int referAg = Convert.ToInt32(tabSeller.Rows[currentPosition]["referAgent"]);

           
            //If we use this version, we dont need the line cboAdmin.Text = tabAgent.Rows[currentPosition]["referAdmin"].ToString(); 
            cboAgent.SelectedValue = referAg;

            lblInfo.Text = "Seller " + (currentPosition + 1) + " on a total of " + tabSeller.Rows.Count;
        }
        private void FillComboWithAgent()
        {
            //Databinding version
            cboAgent.DisplayMember = "FullName";
            cboAgent.ValueMember = "EmployeeID";
            cboAgent.DataSource = tabAgent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to quit SELLER MANAGEMENT ?";
            string title = "Management closing";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPosition = 0;
            display();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPosition > 0)
            {
                currentPosition = currentPosition - 1;
                display();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPosition < (tabSeller.Rows.Count - 1))
            {
                currentPosition = currentPosition + 1;
                display();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPosition = tabSeller.Rows.Count - 1;
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            dateTimeDob.ResetText();
            txtEmail.Text = txtName.Text = txtPassw.Text = "";
            cboAgent.Text = "Select an Agent";
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
            string msg = "Are you sure to want to delete this Seller ?";
            string title = "Warning : Seller Deletion";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabSeller.Rows[currentPosition].Delete();

                //Now we need to update (or synchronize) the contents of the dataset -> the database
                OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myadpSeller);
                myadpSeller.Update(myset, "ClientSellers");

                //Update the contents of the database -> dataset
                myset.Tables.Remove("ClientSellers");
                OleDbCommand mycmd = new OleDbCommand("SELECT * FROM ClientSellers", mycon);
                myadpSeller = new OleDbDataAdapter(mycmd);
                myadpSeller.Fill(myset, "ClientSellers");
                tabSeller = myset.Tables["ClientSellers"];

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
                myrow = tabSeller.NewRow();
                myrow["Name"] = name;
                myrow["Birthdate"] = birth;
                myrow["Email"] = email;
                myrow["Pin"] = pin;
                myrow["referAgent"] = refAg;
                tabSeller.Rows.Add(myrow);
                currentPosition = tabSeller.Rows.Count - 1;
            }
            else if (mode == "edit")
            {
                myrow = tabSeller.Rows[currentPosition];
                myrow["Name"] = name;
                myrow["Birthdate"] = birth;
                myrow["Email"] = email;
                myrow["Pin"] = pin;
                myrow["referAgent"] = refAg;
            }
            //new record saved only in the table of the dataset
            //Now we need to update (or synchronize) the contents of the dataset -> the database
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myadpSeller);
            myadpSeller.Update(myset, "ClientSellers");

            //Update the contents of the database -> dataset
            myset.Tables.Remove("ClientSellers");
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM ClientSellers", mycon);
            myadpSeller = new OleDbDataAdapter(mycmd);
            myadpSeller.Fill(myset, "ClientSellers");
            tabSeller = myset.Tables["ClientSellers"];

            display();
            mode = "";
            ActivateButtons(true, false, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            display();
            ActivateButtons(true, false, true);
        }

        private void ActivateButtons(bool AdEdiDel, bool SaveCanc, bool Navig)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = AdEdiDel;
            btnSave.Enabled = btnCancel.Enabled = SaveCanc;
            btnFirst.Enabled = btnLast.Enabled = btnNext.Enabled = btnPrevious.Enabled = Navig;
        }
    }
}
