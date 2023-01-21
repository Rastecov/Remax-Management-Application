
namespace prjMidtermrRemax
{
    partial class frmLogin
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
            this.radSeller = new System.Windows.Forms.RadioButton();
            this.radBuyer = new System.Windows.Forms.RadioButton();
            this.radAgent = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVerification = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radSeller
            // 
            this.radSeller.AutoSize = true;
            this.radSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSeller.Location = new System.Drawing.Point(525, 113);
            this.radSeller.Margin = new System.Windows.Forms.Padding(2);
            this.radSeller.Name = "radSeller";
            this.radSeller.Size = new System.Drawing.Size(79, 24);
            this.radSeller.TabIndex = 35;
            this.radSeller.TabStop = true;
            this.radSeller.Text = "Seller";
            this.radSeller.UseVisualStyleBackColor = true;
            // 
            // radBuyer
            // 
            this.radBuyer.AutoSize = true;
            this.radBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBuyer.Location = new System.Drawing.Point(431, 113);
            this.radBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.radBuyer.Name = "radBuyer";
            this.radBuyer.Size = new System.Drawing.Size(79, 24);
            this.radBuyer.TabIndex = 34;
            this.radBuyer.TabStop = true;
            this.radBuyer.Text = "Buyer";
            this.radBuyer.UseVisualStyleBackColor = true;
            // 
            // radAgent
            // 
            this.radAgent.AutoSize = true;
            this.radAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAgent.Location = new System.Drawing.Point(328, 113);
            this.radAgent.Margin = new System.Windows.Forms.Padding(2);
            this.radAgent.Name = "radAgent";
            this.radAgent.Size = new System.Drawing.Size(78, 24);
            this.radAgent.TabIndex = 33;
            this.radAgent.TabStop = true;
            this.radAgent.Text = "Agent";
            this.radAgent.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.Location = new System.Drawing.Point(171, 113);
            this.radAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(143, 24);
            this.radAdmin.TabIndex = 32;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Administrator";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(588, 364);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 32);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblVerification
            // 
            this.lblVerification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblVerification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerification.ForeColor = System.Drawing.Color.Black;
            this.lblVerification.Location = new System.Drawing.Point(155, 294);
            this.lblVerification.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(457, 37);
            this.lblVerification.TabIndex = 30;
            this.lblVerification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(391, 239);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 32);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(274, 239);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(1);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(77, 32);
            this.btnEnter.TabIndex = 28;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(251, 198);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(340, 22);
            this.txtPassword.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(251, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 22);
            this.txtEmail.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(222, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Remax-Identification";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.radSeller);
            this.Controls.Add(this.radBuyer);
            this.Controls.Add(this.radAgent);
            this.Controls.Add(this.radAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVerification);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSeller;
        private System.Windows.Forms.RadioButton radBuyer;
        private System.Windows.Forms.RadioButton radAgent;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblVerification;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}