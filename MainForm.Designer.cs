namespace SQL_Multi_Flow
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemImportToDB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDBConnectionSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExpandDB = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonParseScript = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.checkedListBoxScripts = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveScript = new System.Windows.Forms.Button();
            this.labelScriptName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDBList = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBoxDataBases = new System.Windows.Forms.CheckBox();
            this.checkedListBoxDB = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlResults = new System.Windows.Forms.TabControl();
            this.tabPageSuccess = new System.Windows.Forms.TabPage();
            this.listViewCompleate = new System.Windows.Forms.ListView();
            this.ID_Compleate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTime_Compleate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerDBUserPasswd_Compleate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScriptName_Compleate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.ID_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerDB_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Script_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageInfo_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageErrorsSQL = new System.Windows.Forms.TabPage();
            this.listViewErrorsSQL = new System.Windows.Forms.ListView();
            this.ID_Errors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTime_Errors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerDBUserPasswd_Errors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScriptName_Errors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorCode_Errors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorMessage_Errors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRaportsClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewServers = new System.Windows.Forms.ListView();
            this.Server_compleate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.labelExecutedScripts = new System.Windows.Forms.Label();
            this.listViewSuccessesScripts = new System.Windows.Forms.ListView();
            this.Scripts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialogScripts = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tabControlResults.SuspendLayout();
            this.tabPageSuccess.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.tabPageErrorsSQL.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemImportToDB,
            this.ToolStripMenuItemClose});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItemFile.Text = "Фаил";
            // 
            // ToolStripMenuItemImportToDB
            // 
            this.ToolStripMenuItemImportToDB.Name = "ToolStripMenuItemImportToDB";
            this.ToolStripMenuItemImportToDB.Size = new System.Drawing.Size(239, 22);
            this.ToolStripMenuItemImportToDB.Text = "Импортировать скрипты в БД";
            this.ToolStripMenuItemImportToDB.Click += new System.EventHandler(this.ToolStripMenuItemImportToDB_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(239, 22);
            this.ToolStripMenuItemClose.Text = "Закрыть";
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItemHelp.Text = "Помощь";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.инструментыToolStripMenuItem,
            this.ToolStripMenuItemHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1353, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main menu";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDBConnectionSetup,
            this.toolStripMenuItemExpandDB});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // ToolStripMenuItemDBConnectionSetup
            // 
            this.ToolStripMenuItemDBConnectionSetup.Name = "ToolStripMenuItemDBConnectionSetup";
            this.ToolStripMenuItemDBConnectionSetup.Size = new System.Drawing.Size(227, 22);
            this.ToolStripMenuItemDBConnectionSetup.Text = "Настройка соеденения с БД";
            this.ToolStripMenuItemDBConnectionSetup.Click += new System.EventHandler(this.connectionDBConfiguration);
            // 
            // toolStripMenuItemExpandDB
            // 
            this.toolStripMenuItemExpandDB.Name = "toolStripMenuItemExpandDB";
            this.toolStripMenuItemExpandDB.Size = new System.Drawing.Size(227, 22);
            this.toolStripMenuItemExpandDB.Text = "Не запускать";
            this.toolStripMenuItemExpandDB.Click += new System.EventHandler(this.toolStripMenuItemExpandDB_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1353, 716);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15711F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.818317F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.95011F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelStatus, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelStatusMessage, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1343, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.buttonParseScript);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonParseScript
            // 
            this.buttonParseScript.Location = new System.Drawing.Point(0, 0);
            this.buttonParseScript.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParseScript.Name = "buttonParseScript";
            this.buttonParseScript.Size = new System.Drawing.Size(166, 25);
            this.buttonParseScript.TabIndex = 0;
            this.buttonParseScript.Text = "Парсть скрипты(Ctr+F5)";
            this.buttonParseScript.UseVisualStyleBackColor = true;
            this.buttonParseScript.Click += new System.EventHandler(this.buttonParseScript_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(343, 3);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 20);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Статус:";
            // 
            // labelStatusMessage
            // 
            this.labelStatusMessage.AutoSize = true;
            this.labelStatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusMessage.Location = new System.Drawing.Point(426, 3);
            this.labelStatusMessage.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.labelStatusMessage.Name = "labelStatusMessage";
            this.labelStatusMessage.Size = new System.Drawing.Size(81, 20);
            this.labelStatusMessage.TabIndex = 2;
            this.labelStatusMessage.Text = "Message";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 25);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1343, 345);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.checkBoxOrder, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.checkedListBoxScripts, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(335, 345);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скрипты для выполнения";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonUp);
            this.flowLayoutPanel2.Controls.Add(this.buttonDown);
            this.flowLayoutPanel2.Controls.Add(this.buttonNew);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 25);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUp.Location = new System.Drawing.Point(0, 0);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(25, 25);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDown.Location = new System.Drawing.Point(30, 0);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(25, 25);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNew.Location = new System.Drawing.Point(65, 0);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(60, 25);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Новый";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(3, 56);
            this.checkBoxOrder.Margin = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(131, 17);
            this.checkBoxOrder.TabIndex = 4;
            this.checkBoxOrder.Text = "Сорт.    Имя скрипта";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            this.checkBoxOrder.CheckedChanged += new System.EventHandler(this.checkBoxOrder_CheckedChanged);
            // 
            // checkedListBoxScripts
            // 
            this.checkedListBoxScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxScripts.FormattingEnabled = true;
            this.checkedListBoxScripts.Location = new System.Drawing.Point(0, 75);
            this.checkedListBoxScripts.Margin = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.checkedListBoxScripts.Name = "checkedListBoxScripts";
            this.checkedListBoxScripts.Size = new System.Drawing.Size(332, 244);
            this.checkedListBoxScripts.TabIndex = 5;
            this.checkedListBoxScripts.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxScripts_SelectedIndexChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.buttonRemoveAll, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonRemove, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 320);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(335, 25);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveAll.Location = new System.Drawing.Point(242, 0);
            this.buttonRemoveAll.Margin = new System.Windows.Forms.Padding(75, 0, 3, 0);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(90, 25);
            this.buttonRemoveAll.TabIndex = 1;
            this.buttonRemoveAll.Text = "Удалить все";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(0, 0);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(92, 25);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.buttonSaveScript, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelScriptName, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.richTextBox1, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(335, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(671, 345);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // buttonSaveScript
            // 
            this.buttonSaveScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveScript.Location = new System.Drawing.Point(528, 27);
            this.buttonSaveScript.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonSaveScript.Name = "buttonSaveScript";
            this.buttonSaveScript.Size = new System.Drawing.Size(140, 23);
            this.buttonSaveScript.TabIndex = 0;
            this.buttonSaveScript.Text = "Сохранить скрипт(Ctr+S)";
            this.buttonSaveScript.UseVisualStyleBackColor = true;
            this.buttonSaveScript.Click += new System.EventHandler(this.buttonSaveScript_Click);
            // 
            // labelScriptName
            // 
            this.labelScriptName.AutoSize = true;
            this.labelScriptName.Location = new System.Drawing.Point(5, 56);
            this.labelScriptName.Margin = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.labelScriptName.Name = "labelScriptName";
            this.labelScriptName.Size = new System.Drawing.Size(46, 13);
            this.labelScriptName.TabIndex = 1;
            this.labelScriptName.Text = "Скрипт:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.richTextBox1.Location = new System.Drawing.Point(3, 75);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(665, 267);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.labelDBList, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.checkBoxDataBases, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.checkedListBoxDB, 0, 3);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1006, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(337, 345);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // labelDBList
            // 
            this.labelDBList.AutoSize = true;
            this.labelDBList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDBList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDBList.Location = new System.Drawing.Point(6, 7);
            this.labelDBList.Margin = new System.Windows.Forms.Padding(6, 0, 0, 2);
            this.labelDBList.Name = "labelDBList";
            this.labelDBList.Size = new System.Drawing.Size(331, 16);
            this.labelDBList.TabIndex = 0;
            this.labelDBList.Text = "Список предоставленных БД";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.comboBox2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(337, 25);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(334, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // checkBoxDataBases
            // 
            this.checkBoxDataBases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDataBases.AutoSize = true;
            this.checkBoxDataBases.Location = new System.Drawing.Point(6, 56);
            this.checkBoxDataBases.Margin = new System.Windows.Forms.Padding(6, 0, 0, 2);
            this.checkBoxDataBases.Name = "checkBoxDataBases";
            this.checkBoxDataBases.Size = new System.Drawing.Size(42, 17);
            this.checkBoxDataBases.TabIndex = 2;
            this.checkBoxDataBases.Text = "БД";
            this.checkBoxDataBases.UseVisualStyleBackColor = true;
            this.checkBoxDataBases.CheckedChanged += new System.EventHandler(this.checkBoxDataBases_CheckedChanged);
            // 
            // checkedListBoxDB
            // 
            this.checkedListBoxDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxDB.FormattingEnabled = true;
            this.checkedListBoxDB.Location = new System.Drawing.Point(3, 75);
            this.checkedListBoxDB.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.checkedListBoxDB.Name = "checkedListBoxDB";
            this.checkedListBoxDB.Size = new System.Drawing.Size(334, 270);
            this.checkedListBoxDB.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 370);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 346F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1343, 346);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.tabControlResults, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(539, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(804, 346);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tabControlResults
            // 
            this.tabControlResults.Controls.Add(this.tabPageSuccess);
            this.tabControlResults.Controls.Add(this.tabPageMessages);
            this.tabControlResults.Controls.Add(this.tabPageErrorsSQL);
            this.tabControlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlResults.Location = new System.Drawing.Point(0, 25);
            this.tabControlResults.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlResults.Name = "tabControlResults";
            this.tabControlResults.Padding = new System.Drawing.Point(0, 0);
            this.tabControlResults.SelectedIndex = 0;
            this.tabControlResults.Size = new System.Drawing.Size(804, 321);
            this.tabControlResults.TabIndex = 0;
            // 
            // tabPageSuccess
            // 
            this.tabPageSuccess.Controls.Add(this.listViewCompleate);
            this.tabPageSuccess.Location = new System.Drawing.Point(4, 22);
            this.tabPageSuccess.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSuccess.Name = "tabPageSuccess";
            this.tabPageSuccess.Size = new System.Drawing.Size(796, 295);
            this.tabPageSuccess.TabIndex = 1;
            this.tabPageSuccess.Text = "Успешные";
            this.tabPageSuccess.UseVisualStyleBackColor = true;
            // 
            // listViewCompleate
            // 
            this.listViewCompleate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Compleate,
            this.DataTime_Compleate,
            this.ServerDBUserPasswd_Compleate,
            this.ScriptName_Compleate});
            this.listViewCompleate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCompleate.HideSelection = false;
            this.listViewCompleate.Location = new System.Drawing.Point(0, 0);
            this.listViewCompleate.Name = "listViewCompleate";
            this.listViewCompleate.Size = new System.Drawing.Size(796, 295);
            this.listViewCompleate.TabIndex = 0;
            this.listViewCompleate.UseCompatibleStateImageBehavior = false;
            this.listViewCompleate.View = System.Windows.Forms.View.Details;
            // 
            // ID_Compleate
            // 
            this.ID_Compleate.Text = "ID";
            this.ID_Compleate.Width = 33;
            // 
            // DataTime_Compleate
            // 
            this.DataTime_Compleate.Text = "Дата и время";
            this.DataTime_Compleate.Width = 125;
            // 
            // ServerDBUserPasswd_Compleate
            // 
            this.ServerDBUserPasswd_Compleate.Text = "Сервер и БД";
            this.ServerDBUserPasswd_Compleate.Width = 250;
            // 
            // ScriptName_Compleate
            // 
            this.ScriptName_Compleate.Text = "Скрипт";
            this.ScriptName_Compleate.Width = 175;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.listViewInfo);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessages.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Size = new System.Drawing.Size(796, 295);
            this.tabPageMessages.TabIndex = 0;
            this.tabPageMessages.Text = "Cообщения";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // listViewInfo
            // 
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Info,
            this.Data_Info,
            this.ServerDB_Info,
            this.Script_Info,
            this.MessageInfo_Info});
            this.listViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(0, 0);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(796, 295);
            this.listViewInfo.TabIndex = 0;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            // 
            // ID_Info
            // 
            this.ID_Info.Text = "ID";
            this.ID_Info.Width = 33;
            // 
            // Data_Info
            // 
            this.Data_Info.Text = "Дата и время";
            this.Data_Info.Width = 125;
            // 
            // ServerDB_Info
            // 
            this.ServerDB_Info.Text = "Сервер и БД";
            this.ServerDB_Info.Width = 250;
            // 
            // Script_Info
            // 
            this.Script_Info.Text = "Скрипт";
            this.Script_Info.Width = 100;
            // 
            // MessageInfo_Info
            // 
            this.MessageInfo_Info.Text = "Сообщение";
            this.MessageInfo_Info.Width = 400;
            // 
            // tabPageErrorsSQL
            // 
            this.tabPageErrorsSQL.Controls.Add(this.listViewErrorsSQL);
            this.tabPageErrorsSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageErrorsSQL.Name = "tabPageErrorsSQL";
            this.tabPageErrorsSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageErrorsSQL.Size = new System.Drawing.Size(796, 295);
            this.tabPageErrorsSQL.TabIndex = 2;
            this.tabPageErrorsSQL.Text = "Ошибки SQL";
            this.tabPageErrorsSQL.UseVisualStyleBackColor = true;
            // 
            // listViewErrorsSQL
            // 
            this.listViewErrorsSQL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Errors,
            this.DataTime_Errors,
            this.ServerDBUserPasswd_Errors,
            this.ScriptName_Errors,
            this.ErrorCode_Errors,
            this.ErrorMessage_Errors});
            this.listViewErrorsSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewErrorsSQL.HideSelection = false;
            this.listViewErrorsSQL.Location = new System.Drawing.Point(3, 3);
            this.listViewErrorsSQL.Margin = new System.Windows.Forms.Padding(0);
            this.listViewErrorsSQL.Name = "listViewErrorsSQL";
            this.listViewErrorsSQL.Size = new System.Drawing.Size(790, 289);
            this.listViewErrorsSQL.TabIndex = 0;
            this.listViewErrorsSQL.UseCompatibleStateImageBehavior = false;
            this.listViewErrorsSQL.View = System.Windows.Forms.View.Details;
            // 
            // ID_Errors
            // 
            this.ID_Errors.Text = "ID";
            this.ID_Errors.Width = 33;
            // 
            // DataTime_Errors
            // 
            this.DataTime_Errors.Text = "Дата и время";
            this.DataTime_Errors.Width = 125;
            // 
            // ServerDBUserPasswd_Errors
            // 
            this.ServerDBUserPasswd_Errors.Text = "Сервер и БД";
            this.ServerDBUserPasswd_Errors.Width = 250;
            // 
            // ScriptName_Errors
            // 
            this.ScriptName_Errors.Text = "Скрипт";
            this.ScriptName_Errors.Width = 100;
            // 
            // ErrorCode_Errors
            // 
            this.ErrorCode_Errors.Text = "Код";
            this.ErrorCode_Errors.Width = 33;
            // 
            // ErrorMessage_Errors
            // 
            this.ErrorMessage_Errors.Text = "Сообщение";
            this.ErrorMessage_Errors.Width = 400;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.buttonRaportsClear);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(804, 25);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // buttonRaportsClear
            // 
            this.buttonRaportsClear.Location = new System.Drawing.Point(0, 0);
            this.buttonRaportsClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRaportsClear.Name = "buttonRaportsClear";
            this.buttonRaportsClear.Size = new System.Drawing.Size(108, 23);
            this.buttonRaportsClear.TabIndex = 0;
            this.buttonRaportsClear.Text = "Очистить отчеты";
            this.buttonRaportsClear.UseVisualStyleBackColor = true;
            this.buttonRaportsClear.Click += new System.EventHandler(this.buttonRaportsClear_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.listViewServers, 0, 2);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(268, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(268, 346);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // listViewServers
            // 
            this.listViewServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Server_compleate});
            this.listViewServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewServers.HideSelection = false;
            this.listViewServers.Location = new System.Drawing.Point(3, 78);
            this.listViewServers.Name = "listViewServers";
            this.listViewServers.Size = new System.Drawing.Size(262, 265);
            this.listViewServers.TabIndex = 0;
            this.listViewServers.UseCompatibleStateImageBehavior = false;
            this.listViewServers.View = System.Windows.Forms.View.Details;
            this.listViewServers.SelectedIndexChanged += new System.EventHandler(this.listViewServers_SelectedIndexChanged);
            // 
            // Server_compleate
            // 
            this.Server_compleate.Text = "Сервер";
            this.Server_compleate.Width = 300;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.labelExecutedScripts, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.listViewSuccessesScripts, 0, 2);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(265, 346);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // labelExecutedScripts
            // 
            this.labelExecutedScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelExecutedScripts.AutoSize = true;
            this.labelExecutedScripts.Location = new System.Drawing.Point(0, 58);
            this.labelExecutedScripts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelExecutedScripts.Name = "labelExecutedScripts";
            this.labelExecutedScripts.Size = new System.Drawing.Size(127, 13);
            this.labelExecutedScripts.TabIndex = 1;
            this.labelExecutedScripts.Text = "Выполненные скрипты:";
            // 
            // listViewSuccessesScripts
            // 
            this.listViewSuccessesScripts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Scripts});
            this.listViewSuccessesScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSuccessesScripts.HideSelection = false;
            this.listViewSuccessesScripts.Location = new System.Drawing.Point(3, 78);
            this.listViewSuccessesScripts.Name = "listViewSuccessesScripts";
            this.listViewSuccessesScripts.Size = new System.Drawing.Size(259, 265);
            this.listViewSuccessesScripts.TabIndex = 2;
            this.listViewSuccessesScripts.UseCompatibleStateImageBehavior = false;
            this.listViewSuccessesScripts.View = System.Windows.Forms.View.Details;
            // 
            // Scripts
            // 
            this.Scripts.Text = "Скрипты";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 740);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "SQL Multy Flow";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tabControlResults.ResumeLayout(false);
            this.tabPageSuccess.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            this.tabPageErrorsSQL.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonParseScript;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckedListBox checkedListBoxScripts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button buttonSaveScript;
        private System.Windows.Forms.Label labelScriptName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label labelDBList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBoxDataBases;
        private System.Windows.Forms.CheckedListBox checkedListBoxDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label labelExecutedScripts;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogScripts;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImportToDB;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TabControl tabControlResults;
        private System.Windows.Forms.TabPage tabPageSuccess;
        private System.Windows.Forms.ListView listViewCompleate;
        private System.Windows.Forms.ColumnHeader ID_Compleate;
        private System.Windows.Forms.ColumnHeader DataTime_Compleate;
        private System.Windows.Forms.ColumnHeader ServerDBUserPasswd_Compleate;
        private System.Windows.Forms.ColumnHeader ScriptName_Compleate;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.ColumnHeader ID_Info;
        private System.Windows.Forms.ColumnHeader Data_Info;
        private System.Windows.Forms.ColumnHeader ServerDB_Info;
        private System.Windows.Forms.ColumnHeader Script_Info;
        private System.Windows.Forms.ColumnHeader MessageInfo_Info;
        private System.Windows.Forms.TabPage tabPageErrorsSQL;
        private System.Windows.Forms.ListView listViewErrorsSQL;
        private System.Windows.Forms.ColumnHeader ID_Errors;
        private System.Windows.Forms.ColumnHeader DataTime_Errors;
        private System.Windows.Forms.ColumnHeader ServerDBUserPasswd_Errors;
        private System.Windows.Forms.ColumnHeader ScriptName_Errors;
        private System.Windows.Forms.ColumnHeader ErrorCode_Errors;
        private System.Windows.Forms.ColumnHeader ErrorMessage_Errors;
        private System.Windows.Forms.Button buttonRaportsClear;
        private System.Windows.Forms.ListView listViewServers;
        private System.Windows.Forms.ColumnHeader Server_compleate;
        private System.Windows.Forms.ListView listViewSuccessesScripts;
        private System.Windows.Forms.ColumnHeader Scripts;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusMessage;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDBConnectionSetup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExpandDB;
    }
}

