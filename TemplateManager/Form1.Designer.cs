﻿namespace Codenesium.TemplateGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParameters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxErrorsAndWarnings = new System.Windows.Forms.TextBox();
            this.comboBoxDatabaseInterface = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.buttonSaveToDisk = new System.Windows.Forms.Button();
            this.labelFilenamePlaceHolder = new System.Windows.Forms.Label();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonViewTemplate = new System.Windows.Forms.Button();
            this.checkBoxAllTables = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveToDisk = new System.Windows.Forms.CheckBox();
            this.linkLabelOutputDirectory = new System.Windows.Forms.LinkLabel();
            this.toolTipOutputDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCanvas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(471, 642);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.Location = new System.Drawing.Point(14, 33);
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(363, 21);
            this.comboBoxTemplate.TabIndex = 3;
            this.comboBoxTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Controls.Add(this.label1);
            this.panelCanvas.Controls.Add(this.textBoxParameters);
            this.panelCanvas.Location = new System.Drawing.Point(12, 91);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(548, 206);
            this.panelCanvas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parameters";
            // 
            // textBoxParameters
            // 
            this.textBoxParameters.Location = new System.Drawing.Point(3, 16);
            this.textBoxParameters.Multiline = true;
            this.textBoxParameters.Name = "textBoxParameters";
            this.textBoxParameters.Size = new System.Drawing.Size(526, 184);
            this.textBoxParameters.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Errors and Warnings";
            // 
            // textBoxErrorsAndWarnings
            // 
            this.textBoxErrorsAndWarnings.Location = new System.Drawing.Point(578, 534);
            this.textBoxErrorsAndWarnings.Multiline = true;
            this.textBoxErrorsAndWarnings.Name = "textBoxErrorsAndWarnings";
            this.textBoxErrorsAndWarnings.Size = new System.Drawing.Size(530, 102);
            this.textBoxErrorsAndWarnings.TabIndex = 5;
            this.textBoxErrorsAndWarnings.WordWrap = false;
            // 
            // comboBoxDatabaseInterface
            // 
            this.comboBoxDatabaseInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabaseInterface.FormattingEnabled = true;
            this.comboBoxDatabaseInterface.Items.AddRange(new object[] {
            "NONE",
            "MSSQL"});
            this.comboBoxDatabaseInterface.Location = new System.Drawing.Point(13, 77);
            this.comboBoxDatabaseInterface.Name = "comboBoxDatabaseInterface";
            this.comboBoxDatabaseInterface.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDatabaseInterface.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Template";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database Interface";
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(166, 75);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(109, 23);
            this.buttonTestConnection.TabIndex = 10;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // buttonSaveToDisk
            // 
            this.buttonSaveToDisk.Location = new System.Drawing.Point(1006, 283);
            this.buttonSaveToDisk.Name = "buttonSaveToDisk";
            this.buttonSaveToDisk.Size = new System.Drawing.Size(99, 23);
            this.buttonSaveToDisk.TabIndex = 11;
            this.buttonSaveToDisk.Text = "Save to Disk";
            this.buttonSaveToDisk.UseVisualStyleBackColor = true;
            this.buttonSaveToDisk.Click += new System.EventHandler(this.buttonSaveToDisk_Click);
            // 
            // labelFilenamePlaceHolder
            // 
            this.labelFilenamePlaceHolder.AutoSize = true;
            this.labelFilenamePlaceHolder.Location = new System.Drawing.Point(575, 431);
            this.labelFilenamePlaceHolder.Name = "labelFilenamePlaceHolder";
            this.labelFilenamePlaceHolder.Size = new System.Drawing.Size(49, 13);
            this.labelFilenamePlaceHolder.TabIndex = 12;
            this.labelFilenamePlaceHolder.Text = "Filename";
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(578, 448);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(526, 20);
            this.textBoxFilename.TabIndex = 13;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(578, 260);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(526, 168);
            this.textBoxOutput.TabIndex = 14;
            this.textBoxOutput.Text = "";
            // 
            // buttonViewTemplate
            // 
            this.buttonViewTemplate.Location = new System.Drawing.Point(411, 31);
            this.buttonViewTemplate.Name = "buttonViewTemplate";
            this.buttonViewTemplate.Size = new System.Drawing.Size(106, 23);
            this.buttonViewTemplate.TabIndex = 15;
            this.buttonViewTemplate.Text = "View Template";
            this.buttonViewTemplate.UseVisualStyleBackColor = true;
            this.buttonViewTemplate.Click += new System.EventHandler(this.buttonViewTemplate_Click);
            // 
            // checkBoxAllTables
            // 
            this.checkBoxAllTables.AutoSize = true;
            this.checkBoxAllTables.Location = new System.Drawing.Point(305, 80);
            this.checkBoxAllTables.Name = "checkBoxAllTables";
            this.checkBoxAllTables.Size = new System.Drawing.Size(72, 17);
            this.checkBoxAllTables.TabIndex = 16;
            this.checkBoxAllTables.Text = "All Tables";
            this.checkBoxAllTables.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveToDisk
            // 
            this.checkBoxSaveToDisk.AutoSize = true;
            this.checkBoxSaveToDisk.Location = new System.Drawing.Point(305, 103);
            this.checkBoxSaveToDisk.Name = "checkBoxSaveToDisk";
            this.checkBoxSaveToDisk.Size = new System.Drawing.Size(87, 17);
            this.checkBoxSaveToDisk.TabIndex = 17;
            this.checkBoxSaveToDisk.Text = "Save to Disk";
            this.checkBoxSaveToDisk.UseVisualStyleBackColor = true;
            // 
            // linkLabelOutputDirectory
            // 
            this.linkLabelOutputDirectory.AutoSize = true;
            this.linkLabelOutputDirectory.Location = new System.Drawing.Point(476, 68);
            this.linkLabelOutputDirectory.Name = "linkLabelOutputDirectory";
            this.linkLabelOutputDirectory.Size = new System.Drawing.Size(84, 13);
            this.linkLabelOutputDirectory.TabIndex = 18;
            this.linkLabelOutputDirectory.TabStop = true;
            this.linkLabelOutputDirectory.Text = "Output Directory";
            this.linkLabelOutputDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOutputDirectory_LinkClicked);
            this.linkLabelOutputDirectory.MouseHover += new System.EventHandler(this.linkLabelOutputDirectory_MouseHover);
            // 
            // toolTipOutputDirectory
            // 
            this.toolTipOutputDirectory.IsBalloon = true;
            this.toolTipOutputDirectory.ShowAlways = true;
            this.toolTipOutputDirectory.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTipOutputDirectory_Draw);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(12, 60);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProject.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxTemplate);
            this.panel1.Controls.Add(this.comboBoxDatabaseInterface);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBoxSaveToDisk);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBoxAllTables);
            this.panel1.Controls.Add(this.buttonTestConnection);
            this.panel1.Controls.Add(this.buttonViewTemplate);
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 149);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.linkLabelOutputDirectory);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.labelFilenamePlaceHolder);
            this.Controls.Add(this.buttonSaveToDisk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxErrorsAndWarnings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.buttonProcess);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCanvas.ResumeLayout(false);
            this.panelCanvas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.ComboBox comboBoxTemplate;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxErrorsAndWarnings;
        private System.Windows.Forms.ComboBox comboBoxDatabaseInterface;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.Button buttonSaveToDisk;
        private System.Windows.Forms.Label labelFilenamePlaceHolder;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Button buttonViewTemplate;
        private System.Windows.Forms.CheckBox checkBoxAllTables;
        private System.Windows.Forms.CheckBox checkBoxSaveToDisk;
        private System.Windows.Forms.LinkLabel linkLabelOutputDirectory;
        private System.Windows.Forms.ToolTip toolTipOutputDirectory;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Panel panel1;
    }
}

