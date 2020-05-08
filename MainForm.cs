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
using Microsoft.EntityFrameworkCore;

namespace SQL_Multi_Flow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {


            await Task.Run(() =>
            {
                using (RushDataBasesServersListContext DB = new RushDataBasesServersListContext())
                {

                    DB.Database.OpenConnection();
                    DB.Database.CloseConnection();


                    if (DB.Database.CanConnect()==false)
                    {
                        MessageBox.Show("Connection error");
                        return;
                    }

                    this.comboBox1.Items.AddRange(new string[] { "Сценарий 1", "Сценарий 2", "Сценарий 3", "Сценарий 4" });
                    this.comboBox1.SelectedIndex = 0;

                    this.comboBox2.Items.Add("All");
                    this.comboBox2.SelectedIndex = 0;


                    this.comboBox2.Items.AddRange(DB.Markers.Select(s => s.MarkerName).ToArray());
                }
            });
        }

        private void ToolStripMenuItemOpenFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialogScripts.ShowDialog();

            if (string.IsNullOrEmpty(this.folderBrowserDialogScripts.SelectedPath) == false)
            {
                var filesPaths = Infrastructure.StaticMethods.getFilesNames(this.folderBrowserDialogScripts.SelectedPath);

                foreach (var i in filesPaths)
                {
                    if (this.checkedListBoxScripts.Items.Contains(i) == true)
                    {
                        continue;
                    }
                    this.checkedListBoxScripts.Items.Add(i, true);
                }

                if (checkedListBoxScripts.Items.Count > 0)
                {
                    this.checkedListBoxScripts.SelectedItem = checkedListBoxScripts.Items[0];
                }

                checkBoxOrder.Checked = false;
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            this.checkedListBoxScripts.Items.Clear();
            checkBoxOrder.Checked = false;

            this.richTextBox1.Text = "";
            this.labelScriptName.Text = "Скрипт:";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (checkedListBoxScripts.Items.Count > 1)
            {
                var itemToDelete = this.checkedListBoxScripts.SelectedItem;
                if (checkedListBoxScripts.SelectedIndex == 0)
                {
                    this.checkedListBoxScripts.SelectedIndex = checkedListBoxScripts.SelectedIndex + 1;
                }
                else
                {
                    this.checkedListBoxScripts.SelectedIndex = checkedListBoxScripts.SelectedIndex - 1;
                }
                this.checkedListBoxScripts.Items.Remove(itemToDelete);
            }
            else
            {
                checkedListBoxScripts.Items.Clear();
                this.richTextBox1.Text = "";
                this.labelScriptName.Text = "Скрипт:";
            }

            checkBoxOrder.Checked = false;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            this.openFileDialogSQL.FileName = "";
            this.openFileDialogSQL.ShowDialog();
            if (string.IsNullOrEmpty(this.openFileDialogSQL.FileName) == false)
            {
                if (this.checkedListBoxScripts.Items.Contains(openFileDialogSQL.FileName) == false)
                {
                    this.checkedListBoxScripts.Items.Add(openFileDialogSQL.FileName, true);
                }

                checkBoxOrder.Checked = false;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (this.checkedListBoxScripts.SelectedIndex > 0 && this.checkedListBoxScripts.SelectedIndex != -1)
            {
                checkedListBoxScripts.SelectedValueChanged -= checkedListBoxScripts_SelectedValueChanged;

                string temp = "";
                int selected = this.checkedListBoxScripts.SelectedIndex;

                var dataPrev = checkedListBoxScripts.Items[selected - 1].ToString();

                temp = dataPrev;

                checkedListBoxScripts.Items[selected - 1] = checkedListBoxScripts.Items[selected];
                checkedListBoxScripts.Items[selected] = temp;

                checkedListBoxScripts.SelectedItem = checkedListBoxScripts.Items[selected - 1];

                checkBoxOrder.Checked = false;

                checkedListBoxScripts.SelectedValueChanged += checkedListBoxScripts_SelectedValueChanged;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (this.checkedListBoxScripts.SelectedIndex < this.checkedListBoxScripts.Items.Count - 1 && this.checkedListBoxScripts.SelectedIndex != -1)
            {
                checkedListBoxScripts.SelectedValueChanged -= checkedListBoxScripts_SelectedValueChanged;

                string temp = "";
                int selected = this.checkedListBoxScripts.SelectedIndex;

                var dataNext = checkedListBoxScripts.Items[selected + 1].ToString();

                temp = dataNext;

                checkedListBoxScripts.Items[selected + 1] = checkedListBoxScripts.Items[selected];
                checkedListBoxScripts.Items[selected] = temp;

                checkedListBoxScripts.SelectedItem = checkedListBoxScripts.Items[selected + 1];

                checkBoxOrder.Checked = false;

                checkedListBoxScripts.SelectedValueChanged += checkedListBoxScripts_SelectedValueChanged;
            }
        }

        private void checkBoxOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOrder.CheckState.ToString() == "Checked")
            {

                List<string> elements = new List<string>();
                foreach (var i in checkedListBoxScripts.Items)
                {
                    elements.Add(i.ToString());
                }

                elements = elements.OrderBy(o => o).ToList();

                checkedListBoxScripts.Items.Clear();

                foreach (var i in elements)
                {
                    checkedListBoxScripts.Items.Add(i.ToString(), true);
                }

            }
        }


        private void checkedListBoxScripts_SelectedValueChanged(object sender, EventArgs e)
        {

            var fileContent = File.ReadAllText(this.checkedListBoxScripts.SelectedItem.ToString(), Encoding.UTF8);

            this.richTextBox1.Text = fileContent;

            labelScriptName.Text = $"Скрипт: {checkedListBoxScripts.SelectedItem.ToString()}";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            saveFileDialogSQL.ShowDialog();

            if (string.IsNullOrEmpty(saveFileDialogSQL.FileName) == false)
            {
                if (File.Exists(saveFileDialogSQL.FileName) == true)
                {
                    File.Delete(saveFileDialogSQL.FileName);
                }

                File.Create(saveFileDialogSQL.FileName).Close();

                this.checkedListBoxScripts.Items.Add(saveFileDialogSQL.FileName, CheckState.Checked);
                this.checkedListBoxScripts.SelectedItem = saveFileDialogSQL.FileName;

            }

        }


        private void buttonSaveScript_Click(object sender, EventArgs e)
        {

            if (this.checkedListBoxScripts.Items.Count > 0)
            {
                File.WriteAllText(this.checkedListBoxScripts.SelectedItem.ToString(),
                    this.richTextBox1.Text, Encoding.UTF8);
            }

        }

        private async void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                this.checkBoxDataBases.Checked = false;
                this.checkedListBoxDB.Items.Clear();
                using (RushDataBasesServersListContext DB = new RushDataBasesServersListContext())
                {
                    if (DB.Database.CanConnect() == false)
                    {
                        return;
                    }

                    if (comboBox2.SelectedItem.ToString() == "All")
                    {
                        this.checkedListBoxDB.Items.AddRange(
                            DB.ServerList.Select(s => s.ServerDomainName + "/" + s.DataBaseName).ToArray());
                    }
                    else
                    {
                        var data = (from relations in DB.Relations
                                    where relations.MarkerId == DB.Markers.Where(w => w.MarkerName == comboBox2.SelectedItem.ToString()).FirstOrDefault().Id
                                    join serverList in DB.ServerList
                                    on relations.ServerListId equals serverList.Id
                                    select new
                                    {
                                        serverName = serverList.ServerDomainName,
                                        DBName = serverList.DataBaseName
                                    }).Select(s => s.serverName + "/" + s.DBName).ToArray();

                        this.checkedListBoxDB.Items.AddRange(data);
                    }
                }
            });
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
    }
}