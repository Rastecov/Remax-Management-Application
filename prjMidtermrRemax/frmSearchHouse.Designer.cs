
namespace prjMidtermrRemax
{
    partial class frmSearchHouse
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
            this.dataFindHouse = new System.Windows.Forms.DataGridView();
            this.grid = new System.Windows.Forms.GroupBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radNumHouse = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.cboNumberHouse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataFindHouse)).BeginInit();
            this.grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFindHouse
            // 
            this.dataFindHouse.AllowUserToAddRows = false;
            this.dataFindHouse.AllowUserToDeleteRows = false;
            this.dataFindHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFindHouse.Location = new System.Drawing.Point(35, 190);
            this.dataFindHouse.Name = "dataFindHouse";
            this.dataFindHouse.ReadOnly = true;
            this.dataFindHouse.RowHeadersWidth = 51;
            this.dataFindHouse.RowTemplate.Height = 24;
            this.dataFindHouse.Size = new System.Drawing.Size(730, 241);
            this.dataFindHouse.TabIndex = 5;
            // 
            // grid
            // 
            this.grid.Controls.Add(this.radAll);
            this.grid.Controls.Add(this.radNumHouse);
            this.grid.Controls.Add(this.btnFind);
            this.grid.Controls.Add(this.cboNumberHouse);
            this.grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.Location = new System.Drawing.Point(35, 19);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(730, 165);
            this.grid.TabIndex = 4;
            this.grid.TabStop = false;
            this.grid.Text = "Searh a house";
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(78, 78);
            this.radAll.Margin = new System.Windows.Forms.Padding(2);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(181, 24);
            this.radAll.TabIndex = 7;
            this.radAll.TabStop = true;
            this.radAll.Text = "Search all houses";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radNumHouse
            // 
            this.radNumHouse.AutoSize = true;
            this.radNumHouse.Location = new System.Drawing.Point(78, 40);
            this.radNumHouse.Margin = new System.Windows.Forms.Padding(2);
            this.radNumHouse.Name = "radNumHouse";
            this.radNumHouse.Size = new System.Drawing.Size(245, 24);
            this.radNumHouse.TabIndex = 5;
            this.radNumHouse.TabStop = true;
            this.radNumHouse.Text = "Search by House Number";
            this.radNumHouse.UseVisualStyleBackColor = true;
            this.radNumHouse.CheckedChanged += new System.EventHandler(this.radNumHouse_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(545, 104);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(162, 49);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboNumberHouse
            // 
            this.cboNumberHouse.FormattingEnabled = true;
            this.cboNumberHouse.Location = new System.Drawing.Point(362, 38);
            this.cboNumberHouse.Name = "cboNumberHouse";
            this.cboNumberHouse.Size = new System.Drawing.Size(198, 28);
            this.cboNumberHouse.TabIndex = 2;
            // 
            // frmSearchHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataFindHouse);
            this.Controls.Add(this.grid);
            this.Name = "frmSearchHouse";
            this.Text = "frmSearchHouse";
            this.Load += new System.EventHandler(this.frmSearchHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFindHouse)).EndInit();
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFindHouse;
        private System.Windows.Forms.GroupBox grid;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radNumHouse;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboNumberHouse;
    }
}