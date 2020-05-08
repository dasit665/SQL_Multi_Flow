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
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
