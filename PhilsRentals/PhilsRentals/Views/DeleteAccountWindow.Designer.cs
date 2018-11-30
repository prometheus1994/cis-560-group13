namespace PhilsRentals.Views
{
    partial class DeleteAccountWindow
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
            this.uxLabelCreateAccount = new System.Windows.Forms.Label();
            this.uxLabelEmail = new System.Windows.Forms.Label();
            this.uxTextboxEmail = new System.Windows.Forms.TextBox();
            this.uxButtonAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLabelCreateAccount
            // 
            this.uxLabelCreateAccount.BackColor = System.Drawing.Color.Purple;
            this.uxLabelCreateAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelCreateAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelCreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelCreateAccount.ForeColor = System.Drawing.Color.White;
            this.uxLabelCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.uxLabelCreateAccount.Name = "uxLabelCreateAccount";
            this.uxLabelCreateAccount.Size = new System.Drawing.Size(779, 62);
            this.uxLabelCreateAccount.TabIndex = 6;
            this.uxLabelCreateAccount.Text = "Create Account";
            this.uxLabelCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxLabelEmail
            // 
            this.uxLabelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelEmail.AutoSize = true;
            this.uxLabelEmail.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelEmail.Location = new System.Drawing.Point(52, 154);
            this.uxLabelEmail.Name = "uxLabelEmail";
            this.uxLabelEmail.Size = new System.Drawing.Size(116, 46);
            this.uxLabelEmail.TabIndex = 8;
            this.uxLabelEmail.Text = "Email:";
            // 
            // uxTextboxEmail
            // 
            this.uxTextboxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextboxEmail.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.uxTextboxEmail.Location = new System.Drawing.Point(185, 151);
            this.uxTextboxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxTextboxEmail.Name = "uxTextboxEmail";
            this.uxTextboxEmail.Size = new System.Drawing.Size(546, 52);
            this.uxTextboxEmail.TabIndex = 9;
            this.uxTextboxEmail.TextChanged += new System.EventHandler(this.uxTextboxEmail_TextChanged);
            // 
            // uxButtonAccept
            // 
            this.uxButtonAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonAccept.Enabled = false;
            this.uxButtonAccept.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.uxButtonAccept.Location = new System.Drawing.Point(246, 446);
            this.uxButtonAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxButtonAccept.Name = "uxButtonAccept";
            this.uxButtonAccept.Size = new System.Drawing.Size(267, 62);
            this.uxButtonAccept.TabIndex = 10;
            this.uxButtonAccept.Text = "Accept";
            this.uxButtonAccept.UseVisualStyleBackColor = true;
            this.uxButtonAccept.Click += new System.EventHandler(this.uxButtonAccept_Click);
            // 
            // DeleteAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxButtonAccept);
            this.Controls.Add(this.uxTextboxEmail);
            this.Controls.Add(this.uxLabelEmail);
            this.Controls.Add(this.uxLabelCreateAccount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteAccountWindow";
            this.Size = new System.Drawing.Size(779, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelCreateAccount;
        private System.Windows.Forms.Label uxLabelEmail;
        private System.Windows.Forms.TextBox uxTextboxEmail;
        private System.Windows.Forms.Button uxButtonAccept;
    }
}
