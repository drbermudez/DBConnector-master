namespace DBConnectorTester
{
    partial class frmMain
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbPersist = new System.Windows.Forms.ComboBox();
            this.chkIntegrated = new System.Windows.Forms.CheckBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(111, 246);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 32);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Test &Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(27, 82);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(85, 13);
            this.lblDB.TabIndex = 0;
            this.lblDB.Text = "Database name:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(27, 57);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(27, 107);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 132);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persist security info.:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(118, 54);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(211, 20);
            this.txtServer.TabIndex = 5;
            this.txtServer.Text = "Win10PC\\SQL2014EXPRESS";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(118, 79);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(211, 20);
            this.txtDBName.TabIndex = 6;
            this.txtDBName.Text = "MovieCatalogue";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(211, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // cmbPersist
            // 
            this.cmbPersist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersist.FormattingEnabled = true;
            this.cmbPersist.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbPersist.Location = new System.Drawing.Point(136, 153);
            this.cmbPersist.Name = "cmbPersist";
            this.cmbPersist.Size = new System.Drawing.Size(69, 21);
            this.cmbPersist.TabIndex = 9;
            // 
            // chkIntegrated
            // 
            this.chkIntegrated.AutoSize = true;
            this.chkIntegrated.Location = new System.Drawing.Point(211, 155);
            this.chkIntegrated.Name = "chkIntegrated";
            this.chkIntegrated.Size = new System.Drawing.Size(113, 17);
            this.chkIntegrated.TabIndex = 14;
            this.chkIntegrated.Text = "Integrated security";
            this.chkIntegrated.UseVisualStyleBackColor = true;
            this.chkIntegrated.CheckedChanged += new System.EventHandler(this.chkIntegrated_CheckedChanged);
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(27, 31);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(38, 13);
            this.lblDriver.TabIndex = 15;
            this.lblDriver.Text = "Driver:";
            // 
            // cmbDriver
            // 
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Items.AddRange(new object[] {
            "IBM DB2 10",
            "Oracle 12g",
            "MS SQL 2014",
            "Postgre SQL 3.0.1",
            "MySql 6.9"});
            this.cmbDriver.Location = new System.Drawing.Point(118, 28);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(211, 21);
            this.cmbDriver.TabIndex = 16;
            this.cmbDriver.DropDownClosed += new System.EventHandler(this.cmbDriver_DropDownClosed);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 309);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.chkIntegrated);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbPersist);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Connector Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbPersist;
        private System.Windows.Forms.CheckBox chkIntegrated;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.ComboBox cmbDriver;
    }
}

