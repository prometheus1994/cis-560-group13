namespace PhilsRentals.Views
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
            this.uxModifyAccountWindowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxModifyAccountWindowLabel.BackColor = System.Drawing.Color.Navy;
            this.uxModifyAccountWindowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxModifyAccountWindowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxModifyAccountWindowLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxModifyAccountWindowLabel.Location = new System.Drawing.Point(14, 20);
            this.uxModifyAccountWindowLabel.Name = "uxModifyAccountWindowLabel";
            this.uxModifyAccountWindowLabel.Size = new System.Drawing.Size(553, 47);
            this.uxModifyAccountWindowLabel.TabIndex = 0;
            this.uxModifyAccountWindowLabel.Text = "Modify Account";
            this.uxModifyAccountWindowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxLabelEmail
            // 
            this.uxLabelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxLabelEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelEmail.Location = new System.Drawing.Point(211, 284);
            this.uxLabelEmail.Name = "uxLabelEmail";
            this.uxLabelEmail.Size = new System.Drawing.Size(150, 30);
            this.uxLabelEmail.TabIndex = 0;
            this.uxLabelEmail.Text = "Email:";
            this.uxLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxButtonUpdateInfo
            // 
            this.uxButtonUpdateInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxButtonUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxButtonUpdateInfo.Location = new System.Drawing.Point(367, 443);
            this.uxButtonUpdateInfo.Name = "uxButtonUpdateInfo";
            this.uxButtonUpdateInfo.Size = new System.Drawing.Size(200, 40);
            this.uxButtonUpdateInfo.TabIndex = 1;
            this.uxButtonUpdateInfo.Text = "Update";
            this.uxButtonUpdateInfo.UseVisualStyleBackColor = true;
            this.uxButtonUpdateInfo.Click += new System.EventHandler(this.uxButtonUpdateInfo_Click);
            // 
            // uxLabelPhoneNumber
            // 
            this.uxLabelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxLabelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelPhoneNumber.Location = new System.Drawing.Point(211, 325);
            this.uxLabelPhoneNumber.Name = "uxLabelPhoneNumber";
            this.uxLabelPhoneNumber.Size = new System.Drawing.Size(150, 30);
            this.uxLabelPhoneNumber.TabIndex = 2;
            this.uxLabelPhoneNumber.Text = "Phone: ";
            this.uxLabelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxLabelLastName
            // 
            this.uxLabelLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxLabelLastName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelLastName.Location = new System.Drawing.Point(211, 407);
            this.uxLabelLastName.Name = "uxLabelLastName";
            this.uxLabelLastName.Size = new System.Drawing.Size(150, 30);
            this.uxLabelLastName.TabIndex = 3;
            this.uxLabelLastName.Text = "Last Name:";
            this.uxLabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxTextBoxNewEmail
            // 
            this.uxTextBoxNewEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxTextBoxNewEmail.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.uxTextBoxNewEmail.Location = new System.Drawing.Point(367, 278);
            this.uxTextBoxNewEmail.MaxLength = 150;
            this.uxTextBoxNewEmail.Name = "uxTextBoxNewEmail";
            this.uxTextBoxNewEmail.Size = new System.Drawing.Size(200, 36);
            this.uxTextBoxNewEmail.TabIndex = 4;
            this.uxTextBoxNewEmail.Tag = "Current email";
            this.uxTextBoxNewEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxTextBoxPhoneNumber
            // 
            this.uxTextBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxTextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxPhoneNumber.Location = new System.Drawing.Point(367, 402);
            this.uxTextBoxPhoneNumber.MaxLength = 10;
            this.uxTextBoxPhoneNumber.Name = "uxTextBoxPhoneNumber";
            this.uxTextBoxPhoneNumber.Size = new System.Drawing.Size(200, 35);
            this.uxTextBoxPhoneNumber.TabIndex = 5;
            this.uxTextBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxTextBoxFirstName
            // 
            this.uxTextBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxTextBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxFirstName.Location = new System.Drawing.Point(367, 361);
            this.uxTextBoxFirstName.MaxLength = 150;
            this.uxTextBoxFirstName.Name = "uxTextBoxFirstName";
            this.uxTextBoxFirstName.Size = new System.Drawing.Size(200, 35);
            this.uxTextBoxFirstName.TabIndex = 6;
            this.uxTextBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxLabelFirstName
            // 
            this.uxLabelFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxLabelFirstName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLabelFirstName.Location = new System.Drawing.Point(211, 366);
            this.uxLabelFirstName.Name = "uxLabelFirstName";
            this.uxLabelFirstName.Size = new System.Drawing.Size(150, 30);
            this.uxLabelFirstName.TabIndex = 7;
            this.uxLabelFirstName.Text = "First Name:";
            this.uxLabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxTextBoxLastName
            // 
            this.uxTextBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxTextBoxLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxLastName.Location = new System.Drawing.Point(367, 320);
            this.uxTextBoxLastName.MaxLength = 150;
            this.uxTextBoxLastName.Name = "uxTextBoxLastName";
            this.uxTextBoxLastName.Size = new System.Drawing.Size(200, 35);
            this.uxTextBoxLastName.TabIndex = 8;
            this.uxTextBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxLabelSearchEmail
            // 
            this.uxLabelSearchEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxLabelSearchEmail.AutoSize = true;
            this.uxLabelSearchEmail.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.uxLabelSearchEmail.Location = new System.Drawing.Point(24, 96);
            this.uxLabelSearchEmail.Name = "uxLabelSearchEmail";
            this.uxLabelSearchEmail.Size = new System.Drawing.Size(381, 32);
            this.uxLabelSearchEmail.TabIndex = 9;
            this.uxLabelSearchEmail.Text = "Enter the customers current email:";
            // 
            // uxTextBoxSearchEmail
            // 
            this.uxTextBoxSearchEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxTextBoxSearchEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxSearchEmail.Location = new System.Drawing.Point(367, 131);
            this.uxTextBoxSearchEmail.MaxLength = 150;
            this.uxTextBoxSearchEmail.Name = "uxTextBoxSearchEmail";
            this.uxTextBoxSearchEmail.Size = new System.Drawing.Size(200, 35);
            this.uxTextBoxSearchEmail.TabIndex = 10;
            this.uxTextBoxSearchEmail.Text = "\r\n";
            this.uxTextBoxSearchEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxButtonSearchEmail
            // 
            this.uxButtonSearchEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxButtonSearchEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonSearchEmail.Location = new System.Drawing.Point(367, 172);
            this.uxButtonSearchEmail.Name = "uxButtonSearchEmail";
            this.uxButtonSearchEmail.Size = new System.Drawing.Size(200, 40);
            this.uxButtonSearchEmail.TabIndex = 11;
            this.uxButtonSearchEmail.Text = "Search";
            this.uxButtonSearchEmail.UseVisualStyleBackColor = true;
            // 
            // uxLabelModififyInstruction
            // 
            this.uxLabelModififyInstruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxLabelModififyInstruction.AutoSize = true;
            this.uxLabelModififyInstruction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelModififyInstruction.Location = new System.Drawing.Point(24, 238);
            this.uxLabelModififyInstruction.Name = "uxLabelModififyInstruction";
            this.uxLabelModififyInstruction.Size = new System.Drawing.Size(394, 32);
            this.uxLabelModififyInstruction.TabIndex = 12;
            this.uxLabelModififyInstruction.Text = "Modify the customers account info:";
            // 
            // uxModifyAccountLabel
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
            this.Name = "uxModifyAccountLabel";
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
