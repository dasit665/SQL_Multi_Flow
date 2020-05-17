using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Multi_Flow
{
    public partial class DBListConfig : Form
    {
        public DBListConfig()
        {
            InitializeComponent();
        }

        private void DBListConfig_Load(object sender, EventArgs e)
        {
            this.textBoxServer.Text = ConfigurationManager.AppSettings["server"];
            this.textBoxDB.Text = ConfigurationManager.AppSettings["database"];
            this.textBoxLogin.Text = ConfigurationManager.AppSettings["login"];
            this.textBoxPassword.Text = ConfigurationManager.AppSettings["password"];
            this.numericUpDownThreads.Value = Convert.ToInt32(ConfigurationManager.AppSettings["threads"]);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if(string.IsNullOrEmpty(textBoxServer.Text) ==false)
            {
                currentConfig.AppSettings.Settings["server"].Value = textBoxServer.Text;
            }

            if (string.IsNullOrEmpty(textBoxDB.Text) == false)
            {
                currentConfig.AppSettings.Settings["database"].Value = textBoxDB.Text;
            }

            if (string.IsNullOrEmpty(textBoxLogin.Text) == false)
            {
                currentConfig.AppSettings.Settings["login"].Value = textBoxLogin.Text;
            }

            if (string.IsNullOrEmpty(textBoxPassword.Text) == false)
            {
                currentConfig.AppSettings.Settings["password"].Value = textBoxPassword.Text;
            }

            currentConfig.AppSettings.Settings["threads"].Value = this.numericUpDownThreads.Value.ToString();

            currentConfig.Save(ConfigurationSaveMode.Modified);

            this.Owner.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
