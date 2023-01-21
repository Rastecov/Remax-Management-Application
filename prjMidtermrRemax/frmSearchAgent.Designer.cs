
namespace prjMidtermrRemax
{
    partial class frmSearchAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataFindAgent = new System.Windows.Forms.DataGridView();
            this.grid = new System.Windows.Forms.GroupBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radID = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataFindAgent)).BeginInit();
            this.grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFindAgent
            // 
            this.dataFindAgent.AllowUserToAddRows = false;
            this.dataFindAgent.AllowUserToDeleteRows = false;
            this.dataFindAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFindAgent.Location = new System.Drawing.Point(35, 190);
            this.dataFindAgent.Name = "dataFindAgent";
            this.dataFindAgent.ReadOnly = true;
            this.dataFindAgent.RowHeadersWidth = 51;
            this.dataFindAgent.RowTemplate.Height = 24;
            this.dataFindAgent.Size = new System.Drawing.Size(730, 241);
            this.dataFindAgent.TabIndex = 7;
            // 
            // grid
            // 
            this.grid.Controls.Add(this.radAll);
            this.grid.Controls.Add(this.radID);
            this.grid.Controls.Add(this.btnFind);
            this.grid.Controls.Add(this.cboEmpID);
            this.grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.Location = new System.Drawing.Point(35, 19);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(730, 165);
            this.grid.TabIndex = 6;
            this.grid.TabStop = false;
            this.grid.Text = "Searh an agent";
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(78, 78);
            this.radAll.Margin = new System.Windows.Forms.Padding(2);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(179, 24);
            this.radAll.TabIndex = 7;
            this.radAll.TabStop = true;
            this.radAll.Text = "Search all Agents";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radID
            // 
            this.radID.AutoSize = true;
            this.radID.Location = new System.Drawing.Point(78, 40);
            this.radID.Margin = new System.Windows.Forms.Padding(2);
            this.radID.Name = "radID";
            this.radID.Size = new System.Drawing.Size(226, 24);
            this.radID.TabIndex = 5;
            this.radID.TabStop = true;
            this.radID.Text = "Search by Employee ID";
            this.radID.UseVisualStyleBackColor = true;
            this.radID.CheckedChanged += new System.EventHandler(this.radID_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(539, 110);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(162, 49);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboEmpID
            // 
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(363, 40);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(198, 28);
            this.cboEmpID.TabIndex = 2;
            // 
            // frmSearchAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataFindAgent);
            this.Controls.Add(this.grid);
            this.Name = "frmSearchAgent";
            this.Text = "frmSearchAgent";
            this.Load += new System.EventHandler(this.frmSearchAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFindAgent)).EndInit();
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFindAgent;
        private System.Windows.Forms.GroupBox grid;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboEmpID;
    }
}