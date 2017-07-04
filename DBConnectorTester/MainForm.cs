using DBInterface;
using System;
using System.Windows.Forms;

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

		private void CreateQueryForDB2()
		{
			DBConnectorDB2 conn = new DBConnectorDB2(@txtServer.Text, int.Parse(txtPortNum.Text), @txtUsername.Text, @txtPassword.Text, txtDBName.Text, chkIntegrated.Checked);

			if (conn.CanConnect())
			{
				conn.LoadTable("select * from Drugs", System.Data.CommandType.Text);
				if(conn.Table.Rows.Count > 0)
				{
					Console.WriteLine(string.Format("I found this information: {0}, {1}, {2}", conn.Table.Rows[0]["DrugKey"], conn.Table.Rows[0]["DrugName"], conn.Table.Rows[0]["Quantity"]));
				}
			}
		}

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbDriver.SelectedIndex == 0)
            {
				DBConnectorDB2 conn = new DBConnectorDB2(@txtServer.Text, int.Parse(txtPortNum.Text), @txtUsername.Text, @txtPassword.Text, txtDBName.Text, chkIntegrated.Checked);
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

		private void txtPortNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
			{
				e.Handled = true;
			}
		}
	}
}
