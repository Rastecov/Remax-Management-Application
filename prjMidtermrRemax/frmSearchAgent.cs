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
    public partial class frmSearchAgent : Form
    {
        public frmSearchAgent()
        {
            InitializeComponent();
        }
        DataSet myset;
        DataTable tabAgent;

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (radAll.Checked == true)
            {
                var AgentFound = from DataRow agent in tabAgent.Rows
                                 select new
                                 {
                                     Names = agent.Field<string>("FullName"),
                                     Birthdates = agent.Field<DateTime>("Birthdate"),
                                     Emails = agent.Field<string>("Email")
                                 };

                if (AgentFound.Count() != 0)
                {
                    dataFindAgent.DataSource = AgentFound.ToList();
                }
                else
                {
                    dataFindAgent.DataSource = null;
                }
            }
            else if (radID.Checked == true)
            {
                var AgentFound = from DataRow agent in tabAgent.Rows
                                 where agent.Field<int>("EmployeeID") == Convert.ToInt32(cboEmpID.Text)
                                 select new
                                 {
                                     Names = agent.Field<string>("FullName"),
                                     Birthdates = agent.Field<DateTime>("Birthdate"),
                                     Emails = agent.Field<string>("Email")
                                 };

                if (AgentFound.Count() != 0)
                {
                    dataFindAgent.DataSource = AgentFound.ToList();
                }
                else
                {
                    dataFindAgent.DataSource = null;
                }
            }
        }

        private void frmSearchAgent_Load(object sender, EventArgs e)
        {
            myset = new DataSet();

            OleDbConnection mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc123\Documents\SEMESTER 3\MULTI TIER APPS\prjMidtermrRemax\prjMidtermrRemax\Database\Remax.accdb");
            mycon.Open();

            //Load table employee in the dataset
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Agents", mycon);
            OleDbDataAdapter myadpAgent = new OleDbDataAdapter(mycmd);
            myadpAgent.Fill(myset, "Agents");

            tabAgent = myset.Tables["Agents"];

            cboEmpID.DisplayMember = "EmployeeID";
            cboEmpID.DataSource = tabAgent;
        }

        private void radID_CheckedChanged(object sender, EventArgs e)
        {
            cboEmpID.Enabled = true;
            cboEmpID.Text = "Select a number";
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            cboEmpID.Enabled = false;

        }
    }
}
