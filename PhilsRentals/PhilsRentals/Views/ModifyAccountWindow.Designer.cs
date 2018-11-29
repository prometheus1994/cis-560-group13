﻿namespace PhilsRentals.Views
{
    partial class ModifyAccountWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxModifyAccountWindowLabel = new System.Windows.Forms.Label();
            this.uxLabelEmail = new System.Windows.Forms.Label();
            this.uxButtonUpdateInfo = new System.Windows.Forms.Button();
            this.uxLabelPhoneNumber = new System.Windows.Forms.Label();
            this.uxLabelLastName = new System.Windows.Forms.Label();
            this.uxTextBoxNewEmail = new System.Windows.Forms.TextBox();
            this.uxTextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.uxTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.uxLabelFirstName = new System.Windows.Forms.Label();
            this.uxTextBoxLastName = new System.Windows.Forms.TextBox();
            this.uxLabelSearchEmail = new System.Windows.Forms.Label();
            this.uxTextBoxSearchEmail = new System.Windows.Forms.TextBox();
            this.uxButtonSearchEmail = new System.Windows.Forms.Button();
            this.uxLabelModififyInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxModifyAccountWindowLabel
            // 
            this.uxModifyAccountWindowLabel.BackColor = System.Drawing.Color.Purple;
            this.uxModifyAccountWindowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxModifyAccountWindowLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxModifyAccountWindowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxModifyAccountWindowLabel.ForeColor = System.Drawing.Color.White;
            this.uxModifyAccountWindowLabel.Location = new System.Drawing.Point(0, 0);
            this.uxModifyAccountWindowLabel.Name = "uxModifyAccountWindowLabel";
            this.uxModifyAccountWindowLabel.Size = new System.Drawing.Size(584, 50);
            this.uxModifyAccountWindowLabel.TabIndex = 0;
            this.uxModifyAccountWindowLabel.Text = "Modify Account";
            this.uxModifyAccountWindowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxLabelEmail
            // 
            this.uxLabelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelEmail.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelEmail.Location = new System.Drawing.Point(208, 320);
            this.uxLabelEmail.Name = "uxLabelEmail";
            this.uxLabelEmail.Size = new System.Drawing.Size(150, 30);
            this.uxLabelEmail.TabIndex = 0;
            this.uxLabelEmail.Text = "Email:";
            this.uxLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxButtonUpdateInfo
            // 
            this.uxButtonUpdateInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonUpdateInfo.Enabled = false;
            this.uxButtonUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxButtonUpdateInfo.Location = new System.Drawing.Point(364, 482);
            this.uxButtonUpdateInfo.Name = "uxButtonUpdateInfo";
            this.uxButtonUpdateInfo.Size = new System.Drawing.Size(200, 40);
            this.uxButtonUpdateInfo.TabIndex = 1;
            this.uxButtonUpdateInfo.Text = "Update";
            this.uxButtonUpdateInfo.UseVisualStyleBackColor = true;
            this.uxButtonUpdateInfo.Click += new System.EventHandler(this.uxButtonUpdateInfo_Click);
            // 
            // uxLabelPhoneNumber
            // 
            this.uxLabelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelPhoneNumber.Location = new System.Drawing.Point(208, 361);
            this.uxLabelPhoneNumber.Name = "uxLabelPhoneNumber";
            this.uxLabelPhoneNumber.Size = new System.Drawing.Size(150, 30);
            this.uxLabelPhoneNumber.TabIndex = 2;
            this.uxLabelPhoneNumber.Text = "Phone:";
            this.uxLabelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxLabelLastName
            // 
            this.uxLabelLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelLastName.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelLastName.Location = new System.Drawing.Point(208, 443);
            this.uxLabelLastName.Name = "uxLabelLastName";
            this.uxLabelLastName.Size = new System.Drawing.Size(150, 30);
            this.uxLabelLastName.TabIndex = 3;
            this.uxLabelLastName.Text = "Last Name:";
            this.uxLabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxTextBoxNewEmail
            // 
            this.uxTextBoxNewEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxNewEmail.Enabled = false;
            this.uxTextBoxNewEmail.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxTextBoxNewEmail.Location = new System.Drawing.Point(364, 317);
            this.uxTextBoxNewEmail.MaxLength = 150;
            this.uxTextBoxNewEmail.Name = "uxTextBoxNewEmail";
            this.uxTextBoxNewEmail.Size = new System.Drawing.Size(200, 36);
            this.uxTextBoxNewEmail.TabIndex = 4;
            this.uxTextBoxNewEmail.Tag = "Current email";
            this.uxTextBoxNewEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxTextBoxNewEmail.TextChanged += new System.EventHandler(this.uxTextBoxTextChanged);
            // 
            // uxTextBoxPhoneNumber
            // 
            this.uxTextBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxPhoneNumber.Enabled = false;
            this.uxTextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxTextBoxPhoneNumber.Location = new System.Drawing.Point(364, 440);
            this.uxTextBoxPhoneNumber.MaxLength = 10;
            this.uxTextBoxPhoneNumber.Name = "uxTextBoxPhoneNumber";
            this.uxTextBoxPhoneNumber.Size = new System.Drawing.Size(200, 36);
            this.uxTextBoxPhoneNumber.TabIndex = 5;
            this.uxTextBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxTextBoxPhoneNumber.TextChanged += new System.EventHandler(this.uxTextBoxTextChanged);
            // 
            // uxTextBoxFirstName
            // 
            this.uxTextBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxFirstName.Enabled = false;
            this.uxTextBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxTextBoxFirstName.Location = new System.Drawing.Point(364, 399);
            this.uxTextBoxFirstName.MaxLength = 150;
            this.uxTextBoxFirstName.Name = "uxTextBoxFirstName";
            this.uxTextBoxFirstName.Size = new System.Drawing.Size(200, 36);
            this.uxTextBoxFirstName.TabIndex = 6;
            this.uxTextBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxTextBoxFirstName.TextChanged += new System.EventHandler(this.uxTextBoxTextChanged);
            // 
            // uxLabelFirstName
            // 
            this.uxLabelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelFirstName.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelFirstName.Location = new System.Drawing.Point(208, 402);
            this.uxLabelFirstName.Name = "uxLabelFirstName";
            this.uxLabelFirstName.Size = new System.Drawing.Size(150, 30);
            this.uxLabelFirstName.TabIndex = 7;
            this.uxLabelFirstName.Text = "First Name:";
            this.uxLabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxTextBoxLastName
            // 
            this.uxTextBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxLastName.Enabled = false;
            this.uxTextBoxLastName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxTextBoxLastName.Location = new System.Drawing.Point(364, 358);
            this.uxTextBoxLastName.MaxLength = 150;
            this.uxTextBoxLastName.Name = "uxTextBoxLastName";
            this.uxTextBoxLastName.Size = new System.Drawing.Size(200, 36);
            this.uxTextBoxLastName.TabIndex = 8;
            this.uxTextBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxTextBoxLastName.TextChanged += new System.EventHandler(this.uxTextBoxTextChanged);
            // 
            // uxLabelSearchEmail
            // 
            this.uxLabelSearchEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelSearchEmail.AutoSize = true;
            this.uxLabelSearchEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelSearchEmail.Location = new System.Drawing.Point(21, 135);
            this.uxLabelSearchEmail.Name = "uxLabelSearchEmail";
            this.uxLabelSearchEmail.Size = new System.Drawing.Size(391, 32);
            this.uxLabelSearchEmail.TabIndex = 9;
            this.uxLabelSearchEmail.Text = "Enter the customers current email:";
            // 
            // uxTextBoxSearchEmail
            // 
            this.uxTextBoxSearchEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxSearchEmail.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxTextBoxSearchEmail.Location = new System.Drawing.Point(364, 170);
            this.uxTextBoxSearchEmail.MaxLength = 150;
            this.uxTextBoxSearchEmail.Name = "uxTextBoxSearchEmail";
            this.uxTextBoxSearchEmail.Size = new System.Drawing.Size(200, 36);
            this.uxTextBoxSearchEmail.TabIndex = 10;
            this.uxTextBoxSearchEmail.Text = "\r\n";
            this.uxTextBoxSearchEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxTextBoxSearchEmail.TextChanged += new System.EventHandler(this.uxTextBoxTextChanged);
            // 
            // uxButtonSearchEmail
            // 
            this.uxButtonSearchEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonSearchEmail.Enabled = false;
            this.uxButtonSearchEmail.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxButtonSearchEmail.Location = new System.Drawing.Point(364, 211);
            this.uxButtonSearchEmail.Name = "uxButtonSearchEmail";
            this.uxButtonSearchEmail.Size = new System.Drawing.Size(200, 40);
            this.uxButtonSearchEmail.TabIndex = 11;
            this.uxButtonSearchEmail.Text = "Search";
            this.uxButtonSearchEmail.UseVisualStyleBackColor = true;
            this.uxButtonSearchEmail.Click += new System.EventHandler(this.uxButtonSearchEmail_Click);
            // 
            // uxLabelModififyInstruction
            // 
            this.uxLabelModififyInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelModififyInstruction.AutoSize = true;
            this.uxLabelModififyInstruction.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelModififyInstruction.Location = new System.Drawing.Point(21, 277);
            this.uxLabelModififyInstruction.Name = "uxLabelModififyInstruction";
            this.uxLabelModififyInstruction.Size = new System.Drawing.Size(400, 32);
            this.uxLabelModififyInstruction.TabIndex = 12;
            this.uxLabelModififyInstruction.Text = "Modify the customers account info:";
            // 
            // ModifyAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxLabelModififyInstruction);
            this.Controls.Add(this.uxButtonSearchEmail);
            this.Controls.Add(this.uxTextBoxSearchEmail);
            this.Controls.Add(this.uxLabelSearchEmail);
            this.Controls.Add(this.uxTextBoxLastName);
            this.Controls.Add(this.uxLabelFirstName);
            this.Controls.Add(this.uxTextBoxFirstName);
            this.Controls.Add(this.uxTextBoxPhoneNumber);
            this.Controls.Add(this.uxTextBoxNewEmail);
            this.Controls.Add(this.uxLabelLastName);
            this.Controls.Add(this.uxLabelPhoneNumber);
            this.Controls.Add(this.uxButtonUpdateInfo);
            this.Controls.Add(this.uxLabelEmail);
            this.Controls.Add(this.uxModifyAccountWindowLabel);
            this.Name = "ModifyAccountWindow";
            this.Size = new System.Drawing.Size(584, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxModifyAccountWindowLabel;
        private System.Windows.Forms.Label uxLabelEmail;
        private System.Windows.Forms.Button uxButtonUpdateInfo;
        private System.Windows.Forms.Label uxLabelPhoneNumber;
        private System.Windows.Forms.Label uxLabelLastName;
        private System.Windows.Forms.TextBox uxTextBoxNewEmail;
        private System.Windows.Forms.TextBox uxTextBoxPhoneNumber;
        private System.Windows.Forms.TextBox uxTextBoxFirstName;
        private System.Windows.Forms.Label uxLabelFirstName;
        private System.Windows.Forms.TextBox uxTextBoxLastName;
        private System.Windows.Forms.Label uxLabelSearchEmail;
        private System.Windows.Forms.TextBox uxTextBoxSearchEmail;
        private System.Windows.Forms.Button uxButtonSearchEmail;
        private System.Windows.Forms.Label uxLabelModififyInstruction;
    }
}
