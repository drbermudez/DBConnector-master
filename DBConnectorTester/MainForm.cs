using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBInterface;

namespace DBConnectorTester
{
    public partial class frmMain : Form
    {
        private bool integratedSecurity = false;

        public frmMain()
        {
            InitializeComponent();
            cmbPersist.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbDriver.SelectedIndex == 0)
            {
                DBConnectorDB2 conn = new DBConnectorDB2(@txtServer.Text, @txtDBName.Text, @txtUsername.Text, txtPassword.Text,
                                                    Convert.ToBoolean(cmbPersist.SelectedItem), 40, 40);
                if (conn.CanConnect())
                {
                    MessageBox.Show("Connection successful!");
                }
                else
                {
                    string tmpMessage = "";
                    foreach (Error error in conn.ErrorList)
                    {
                        tmpMessage += error.Message + " " + error.RoutineName + Environment.NewLine;
                    }
                    MessageBox.Show(tmpMessage);
                }
            }
            else if (cmbDriver.SelectedIndex == 1)
            {
                DBConnectorOracle conn = new DBConnectorOracle(@txtServer.Text, @txtDBName.Text, @txtUsername.Text, txtPassword.Text,
                                                    Convert.ToBoolean(cmbPersist.SelectedItem), integratedSecurity, 40);
                if (conn.CanConnect())
                {
                    MessageBox.Show("Connection successful!");
                }
                else
                {
                    string tmpMessage = "";
                    foreach (Error error in conn.ErrorList)
                    {
                        tmpMessage += error.Message + " " + error.RoutineName + Environment.NewLine;
                    }
                    MessageBox.Show(tmpMessage);
                }
            }
            else if (cmbDriver.SelectedIndex == 2)
            {
                DBConnectorMSSQL conn = new DBConnectorMSSQL(@txtServer.Text, @txtDBName.Text, @txtUsername.Text, txtPassword.Text,
                                               Convert.ToBoolean(cmbPersist.SelectedItem), integratedSecurity, 40);

                if (conn.CanConnect())
                {
                    MessageBox.Show("Connection successful!");
                }
                else
                {
                    string tmpMessage = "";
                    foreach (Error error in conn.ErrorList)
                    {
                        tmpMessage += error.Message + " " + error.RoutineName + Environment.NewLine;
                    }
                    MessageBox.Show(tmpMessage);
                }
            }
            else if (cmbDriver.SelectedIndex == 3)
            {
                DBConnectorPostgreSQL conn = new DBConnectorPostgreSQL(@txtServer.Text, @txtDBName.Text, @txtUsername.Text, txtPassword.Text,
                                               Convert.ToBoolean(cmbPersist.SelectedItem), 40, 40);

                if (conn.CanConnect())
                {
                    MessageBox.Show("Connection successful!");
                }
                else
                {
                    string tmpMessage = "";
                    foreach (Error error in conn.ErrorList)
                    {
                        tmpMessage += error.Message + " " + error.RoutineName + Environment.NewLine;
                    }
                    MessageBox.Show(tmpMessage);
                }
            }
            else if (cmbDriver.SelectedIndex == 4)
            {
                DBConnectorMySQL conn = new DBConnectorMySQL(@txtServer.Text, @txtDBName.Text, @txtUsername.Text, txtPassword.Text,
                                                       Convert.ToBoolean(cmbPersist.SelectedItem), integratedSecurity, 40, 40);

                if (conn.CanConnect())
                {
                    MessageBox.Show("Connection successful!");
                }
                else
                {
                    string tmpMessage = "";
                    foreach (Error error in conn.ErrorList)
                    {
                        tmpMessage += error.Message + " " + error.RoutineName + Environment.NewLine;
                    }
                    MessageBox.Show(tmpMessage);
                }
            }                        
        }       

        private void chkIntegrated_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = !chkIntegrated.Checked;
            txtUsername.Enabled = !chkIntegrated.Checked;
            integratedSecurity = chkIntegrated.Checked;
            if (chkIntegrated.Checked)
            {
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void cmbDriver_DropDownClosed(object sender, EventArgs e)
        {           
            btnConnect.Enabled = Convert.ToBoolean(cmbDriver.SelectedIndex >= 0);
        }
    }
}
