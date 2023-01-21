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
    public partial class frmSearchHouse : Form
    {
        public frmSearchHouse()
        {
            InitializeComponent();
        }
        DataSet myset;
        DataTable tabHouse;

        private void frmSearchHouse_Load(object sender, EventArgs e)
        {
            myset = new DataSet();

            OleDbConnection mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc123\Documents\SEMESTER 3\MULTI TIER APPS\prjMidtermrRemax\prjMidtermrRemax\Database\Remax.accdb");
            mycon.Open();

            //Load table employee in the dataset
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Houses", mycon);
            OleDbDataAdapter myadpHouse = new OleDbDataAdapter(mycmd);
            myadpHouse.Fill(myset, "Houses");

            tabHouse = myset.Tables["Houses"];

            cboNumberHouse.DisplayMember = "Number";
            cboNumberHouse.DataSource = tabHouse;
            cboNumberHouse.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {


            if (radAll.Checked == true)
            {
                var HouseFound = from DataRow house in tabHouse.Rows
                                 select new
                                 {
                                     Addresses = house.Field<string>("Address"),
                                     Cities = house.Field<string>("City"),
                                     Provinces = house.Field<string>("Province"),
                                     Prices = house.Field<decimal>("Price"),
                                     YearofHouses = house.Field<int>("YearofHouse"),
                                     Status = house.Field<string>("Status")
                                 };

                if (HouseFound.Count() != 0)
                {
                    dataFindHouse.DataSource = HouseFound.ToList();
                }
                else
                {
                    dataFindHouse.DataSource = null;
                }
            }
            else if (radNumHouse.Checked == true)
            {
                var HouseFound = from DataRow house in tabHouse.Rows
                                 where house.Field<int>("Number") == Convert.ToInt32(cboNumberHouse.Text)
                                 select new
                                 {
                                     Addresses = house.Field<string>("Address"),
                                     Cities = house.Field<string>("City"),
                                     Provinces = house.Field<string>("Province"),
                                     Prices = house.Field<decimal>("Price"),
                                     YearofHouses = house.Field<int>("YearofHouse"),
                                     Status = house.Field<string>("Status")
                                 };

                if (HouseFound.Count() != 0)
                {
                    dataFindHouse.DataSource = HouseFound.ToList();
                }
                else
                {
                    dataFindHouse.DataSource = null;
                }
            }
        }

        private void radNumHouse_CheckedChanged(object sender, EventArgs e)
        {
            cboNumberHouse.Enabled = true;
            cboNumberHouse.Text = "Select a number";


        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            cboNumberHouse.Enabled = false;

        }
    }
}
