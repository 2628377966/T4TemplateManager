﻿namespace Codenesium.TemplateGenerator.Forms
{
    partial class ParameterPrompt
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
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxValue = new MetroFramework.Controls.MetroTextBox();
            this.buttonSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(24, 61);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(35, 13);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "label1";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Lines = new string[0];
            this.textBoxValue.Location = new System.Drawing.Point(27, 77);
            this.textBoxValue.MaxLength = 32767;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.PasswordChar = '\0';
            this.textBoxValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxValue.SelectedText = "";
            this.textBoxValue.Size = new System.Drawing.Size(208, 23);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.UseSelectable = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(160, 124);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseSelectable = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ParameterPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelKey);
            this.Name = "ParameterPrompt";
            this.Text = "ParameterPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private MetroFramework.Controls.MetroTextBox textBoxValue;
        private MetroFramework.Controls.MetroButton buttonSave;
    }
}