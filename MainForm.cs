using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Configuration;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using System.Data.Linq;

using static SQL_Multi_Flow.Infrastructure.StaticMethods;
using System.Threading;
using System.Timers;

namespace SQL_Multi_Flow
{
    public partial class MainForm : Form
    {
        string connectionString = $@"Server={ConfigurationManager.AppSettings["server"]};Database={ConfigurationManager.AppSettings["database"]};User={ConfigurationManager.AppSettings["login"]};Password={ConfigurationManager.AppSettings["password"]}";

        public MainForm()
        {
            InitializeComponent();
        }


        #region Main Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            string markers = "SELECT m.MarkerName FROM ServersAndMarkers.Markers m";
            string scripts = "SELECT st.ScriptName FROM Scripts.ScriptsTable AS st";

            try
            {
                using (SqlConnection SQLConnection = new SqlConnection(connectionString))
                {
                    SQLConnection.Open();

                    List<string> scriptsList = new List<string>();

                    var SQLCommand = new SqlCommand(scripts, SQLConnection);
                    var reader = SQLCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        scriptsList.Add($"{reader.GetValue(0)}");
                    }


                    this.checkedListBoxScripts.Items.AddRange(scriptsList.ToArray());
                    if (checkedListBoxScripts.Items.Count > 0)
                    {
                        this.checkedListBoxScripts.SelectedIndex = 0;
                    }
                }

                using (SqlConnection SQLConnection = new SqlConnection(connectionString))
                {
                    SQLConnection.Open();

                    List<string> markersList = new List<string>();

                    var SQLCommand = new SqlCommand(markers, SQLConnection);
                    var reader = SQLCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        markersList.Add(reader.GetValue(0).ToString());
                    }

                    this.comboBox1.Items.AddRange(new string[] { "Сценарий 1", "Сценарий 2", "Сценарий 3", "Сценарий 4", "Сценарий 5" });
                    this.comboBox1.SelectedIndex = 0;

                    this.comboBox2.Items.Add("All");
                    this.comboBox2.Items.AddRange(markersList.ToArray());

                    this.comboBox2.SelectedIndex = 0;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                new DBListConfig().Show();
            }

        }
        #endregion Main Form Load

        #region Scripts

        private void checkBoxOrder_CheckedChanged(object sender, EventArgs e)
        {
            List<string> dataToSort = new List<string>();

            foreach (var i in checkedListBoxScripts.Items)
            {
                dataToSort.Add(i.ToString());
            }

            checkedListBoxScripts.Items.Clear();

            dataToSort.Sort();
            checkedListBoxScripts.Items.AddRange(dataToSort.ToArray());

            if (checkedListBoxScripts.Items.Count > 0)
            {
                checkedListBoxScripts.SelectedIndex = 0;
            }

            List<string> Vals = new List<string>();

            foreach (var i in checkedListBoxScripts.Items)
            {
                Vals.Add(i.ToString());
            }

            checkedListBoxScripts.Items.Clear();

            foreach (var i in Vals)
            {
                checkedListBoxScripts.Items.Add(i.ToString(), checkBoxOrder.Checked);
            }
        }

        private void ToolStripMenuItemImportToDB_Click(object sender, EventArgs e)
        {
            folderBrowserDialogScripts.ShowDialog();

            if (string.IsNullOrEmpty(folderBrowserDialogScripts.SelectedPath) == false)
            {
                var filesInDirectory = Directory.GetFiles(folderBrowserDialogScripts.SelectedPath, "*.sql");
                string fileName = "", fileContent = "";

                using (SqlConnection SQLConnection = new SqlConnection(connectionString))
                {
                    SQLConnection.Open();

                    var command = new SqlCommand("", SQLConnection);

                    command.CommandText = "Scripts.AddScript";
                    command.CommandType = CommandType.StoredProcedure;

                    foreach (var i in filesInDirectory)
                    {

                        fileName = i.Split('\\').Last();
                        fileContent = File.ReadAllText(i, Encoding.ASCII);

                        command.Parameters.AddWithValue("@ScriptName", fileName);
                        command.Parameters.AddWithValue("@ScriptContent", fileContent);

                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                    }

                    checkedListBoxScripts.Items.Clear();

                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT st.ScriptName FROM Scripts.ScriptsTable st";

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        checkedListBoxScripts.Items.Add(reader.GetValue(0));
                    }

                    if (checkedListBoxScripts.Items.Count > 0)
                    {
                        checkedListBoxScripts.SelectedIndex = 0;
                    }
                }
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "Scripts.TruncateTables";

                command.ExecuteNonQuery();

                checkedListBoxScripts.Items.Clear();
            }

            richTextBox1.Text = "";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";

            if (checkedListBoxScripts.Items.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"DELETE Scripts.ScriptsTable WHERE ScriptName = '{checkedListBoxScripts.SelectedItem.ToString()}'", connection);

                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT st.ScriptName FROM Scripts.ScriptsTable st";

                    SqlDataReader reader = command.ExecuteReader();

                    checkedListBoxScripts.Items.Clear();

                    while (reader.Read())
                    {
                        checkedListBoxScripts.Items.Add(reader.GetValue(0));
                    }

                    if (checkedListBoxScripts.Items.Count > 0)
                    {
                        checkedListBoxScripts.SelectedIndex = 0;
                    }
                }
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (checkedListBoxScripts.SelectedIndex > 0)
            {
                int selectedIndex = checkedListBoxScripts.SelectedIndex;

                bool prevCheked = checkedListBoxScripts.GetItemChecked(selectedIndex - 1);
                bool selectedChecked = checkedListBoxScripts.GetItemChecked(selectedIndex);

                string prevValue = checkedListBoxScripts.Items[checkedListBoxScripts.SelectedIndex - 1].ToString();
                string temp = checkedListBoxScripts.SelectedItem.ToString();

                checkedListBoxScripts.Items[selectedIndex] = prevValue;
                checkedListBoxScripts.SetItemChecked(selectedIndex, prevCheked);

                checkedListBoxScripts.Items[selectedIndex - 1] = temp;
                checkedListBoxScripts.SetItemChecked(selectedIndex - 1, selectedChecked);

                checkedListBoxScripts.SetSelected(selectedIndex - 1, true);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (checkedListBoxScripts.SelectedIndex < checkedListBoxScripts.Items.Count - 1)
            {
                int selectedIndex = checkedListBoxScripts.SelectedIndex;

                bool nextCheked = checkedListBoxScripts.GetItemChecked(selectedIndex + 1);
                bool selectedChecked = checkedListBoxScripts.GetItemChecked(selectedIndex);

                string nextValue = checkedListBoxScripts.Items[checkedListBoxScripts.SelectedIndex + 1].ToString();
                string temp = checkedListBoxScripts.SelectedItem.ToString();

                checkedListBoxScripts.Items[selectedIndex] = nextValue;
                checkedListBoxScripts.SetItemChecked(selectedIndex, nextCheked);

                checkedListBoxScripts.Items[selectedIndex + 1] = temp;
                checkedListBoxScripts.SetItemChecked(selectedIndex + 1, selectedChecked);

                checkedListBoxScripts.SetSelected(selectedIndex + 1, true);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewScriptName newScript = new NewScriptName(checkedListBoxScripts, connectionString);
            newScript.Show(this);
        }

        private void checkedListBoxScripts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((checkedListBoxScripts.SelectedItem is null) == false)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"SELECT st.ScriptContent FROM Scripts.ScriptsTable st WHERE st.ScriptName = '{checkedListBoxScripts.SelectedItem.ToString()}'", connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        richTextBox1.Text = reader.GetValue(0).ToString();
                    }
                }
            }
        }

        #endregion Scripts

        #region richTextBox
        private void buttonSaveScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text) == false)
            {
                string scriptName = checkedListBoxScripts.SelectedItem.ToString();

                DataContext dataContext = new DataContext(connectionString);

                dataContext.ExecuteCommand("UPDATE Scripts.ScriptsTable SET ScriptContent = {0} WHERE ScriptName = {1}", richTextBox1.Text.ToString(), checkedListBoxScripts.SelectedItem.ToString());
            }
        }
        #endregion richTextBox

        #region Servers


        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            string SQLQuery = $@"SELECT sl.ServerDomainName + '#' + sl.DataBaseName FROM ServersAndMarkers.Relations r JOIN ServersAndMarkers.ServerList sl ON r.ServerListID = sl.ID JOIN ServersAndMarkers.Markers m ON r.MarkerID = m.ID";

            try
            {
                using (SqlConnection SQLConnection = new SqlConnection(connectionString))
                {
                    SQLConnection.Open();

                    if (comboBox2.Text != "All")
                    {
                        SQLQuery += $" WHERE m.MarkerName = '{comboBox2.Text}'";
                    }

                    var SQLCommand = new SqlCommand(SQLQuery, SQLConnection);
                    var reader = SQLCommand.ExecuteReader();

                    checkedListBoxDB.Items.Clear();

                    while (reader.Read())
                    {
                        checkedListBoxDB.Items.Add(reader.GetValue(0));
                    }
                }
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void buttonConfiguration_Click(object sender, EventArgs e)
        {
            var DBListConfig = new DBListConfig();
            DBListConfig.Show(this);
        }

        private void checkBoxDataBases_CheckedChanged(object sender, EventArgs e)
        {
            var temp = new List<string>();

            foreach (var i in checkedListBoxDB.Items)
            {
                temp.Add(i.ToString());
            }

            checkedListBoxDB.Items.Clear();

            if (checkBoxDataBases.Checked == true)
            {
                foreach (var i in temp)
                {
                    checkedListBoxDB.Items.Add(i.ToString(), true);
                }
            }
            else
            {
                foreach (var i in temp)
                {
                    checkedListBoxDB.Items.Add(i.ToString(), false);
                }
            }
        }
        #endregion Servers

        #region Parse
        private async void buttonParseScript_Click(object sender, EventArgs e)
        {
            List<string> scriptsList = new List<string>();
            List<string> serversList = new List<string>();
            int Threads = int.Parse(ConfigurationSettings.AppSettings["threads"]);

            foreach (var i in checkedListBoxScripts.CheckedItems)
            {
                scriptsList.Add(i.ToString());
            }

            foreach (var i in checkedListBoxDB.CheckedItems)
            {
                serversList.Add(i.ToString());
            }

            //using (var timer = new System.Windows.Forms.Timer())
            //{
            //    timer.Tick += Timer_Tick;
            //    timer.Interval = 250;
            //    timer.Start();


            //    timer.Stop();
            //}

            await Dispatcher(connectionString, serversList, scriptsList, Threads);



            await Task.Run(() =>
            {
                MessageBox.Show("Завершено");
            });

            await Task.Run(async () =>
            {
                await ShowResults(connectionString, dataGridViewSuccess, dataGridViewInfo, dataGridViewErrors);
            });



        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await ShowResults(connectionString, dataGridViewSuccess, dataGridViewInfo, dataGridViewErrors);
            });

        }

        #endregion Parse
    }
}