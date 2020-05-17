namespace SQL_Multi_Flow
{
    partial class NewScriptName
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
            this.labelScriptName = new System.Windows.Forms.Label();
            this.textBoxScriptName = new System.Windows.Forms.TextBox();
            this.buttonNewScriptOk = new System.Windows.Forms.Button();
            this.buttonNewScriptCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelScriptName
            // 
            this.labelScriptName.AutoSize = true;
            this.labelScriptName.Location = new System.Drawing.Point(13, 17);
            this.labelScriptName.Name = "labelScriptName";
            this.labelScriptName.Size = new System.Drawing.Size(76, 13);
            this.labelScriptName.TabIndex = 0;
            this.labelScriptName.Text = "Имя скрипта:";
            // 
            // textBoxScriptName
            // 
            this.textBoxScriptName.Location = new System.Drawing.Point(96, 13);
            this.textBoxScriptName.Name = "textBoxScriptName";
            this.textBoxScriptName.Size = new System.Drawing.Size(215, 20);
            this.textBoxScriptName.TabIndex = 1;
            // 
            // buttonNewScriptOk
            // 
            this.buttonNewScriptOk.Location = new System.Drawing.Point(323, 12);
            this.buttonNewScriptOk.Name = "buttonNewScriptOk";
            this.buttonNewScriptOk.Size = new System.Drawing.Size(56, 23);
            this.buttonNewScriptOk.TabIndex = 2;
            this.buttonNewScriptOk.Text = "Ok";
            this.buttonNewScriptOk.UseVisualStyleBackColor = true;
            this.buttonNewScriptOk.Click += new System.EventHandler(this.buttonNewScriptOk_Click);
            // 
            // buttonNewScriptCancel
            // 
            this.buttonNewScriptCancel.Location = new System.Drawing.Point(385, 12);
            this.buttonNewScriptCancel.Name = "buttonNewScriptCancel";
            this.buttonNewScriptCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonNewScriptCancel.TabIndex = 3;
            this.buttonNewScriptCancel.Text = "Cancel";
            this.buttonNewScriptCancel.UseVisualStyleBackColor = true;
            this.buttonNewScriptCancel.Click += new System.EventHandler(this.buttonNewScriptCancel_Click);
            // 
            // NewScriptName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 51);
            this.Controls.Add(this.buttonNewScriptCancel);
            this.Controls.Add(this.buttonNewScriptOk);
            this.Controls.Add(this.textBoxScriptName);
            this.Controls.Add(this.labelScriptName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewScriptName";
            this.Text = "Новый скрипт в БД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScriptName;
        private System.Windows.Forms.TextBox textBoxScriptName;
        private System.Windows.Forms.Button buttonNewScriptOk;
        private System.Windows.Forms.Button buttonNewScriptCancel;
    }
}