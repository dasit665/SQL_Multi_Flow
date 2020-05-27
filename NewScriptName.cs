using Microsoft.Data.SqlClient;
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
    public partial class NewScriptName : Form
    {
        string connectionString;
        CheckedListBox checkedListBoxScripts;

        public NewScriptName(CheckedListBox checkedListBoxScripts, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.checkedListBoxScripts = checkedListBoxScripts;
        }

        private void buttonNewScriptOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxScriptName.Text) == false)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("Scripts.AddScript", connection);
                    command.Parameters.AddWithValue("@ScriptName", textBoxScriptName.Text.ToString());
                    command.Parameters.AddWithValue("@ScriptContent", "");

                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();

                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT st.ScriptName FROM Scripts.ScriptsTable st";

                    SqlDataReader reader = command.ExecuteReader();

                    checkedListBoxScripts.Items.Clear();

                    while (reader.Read())
                    {
                        checkedListBoxScripts.Items.Add(reader.GetValue(0));
                    }

                    checkedListBoxScripts.SelectedItem = textBoxScriptName.Text.ToString();

                }
            }
            this.Close();
        }

        private void buttonNewScriptCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
