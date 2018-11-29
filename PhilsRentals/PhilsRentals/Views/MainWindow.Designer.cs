namespace PhilsRentals
{
    partial class MainWindow
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
            this.uxPanelCreateAccount = new System.Windows.Forms.Panel();
            this.uxButtonCreateAccount = new System.Windows.Forms.Button();
            this.uxPanelMenu = new System.Windows.Forms.Panel();
            this.uxPanelBrowseMovie = new System.Windows.Forms.Panel();
            this.uxButtonBrowseMovie = new System.Windows.Forms.Button();
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.uxPanelAddMovie = new System.Windows.Forms.Panel();
            this.uxButtonAddMovie = new System.Windows.Forms.Button();
            this.uxPanelDeleteAccount = new System.Windows.Forms.Panel();
            this.uxButtonDeleteAccount = new System.Windows.Forms.Button();
            this.uxPanelModifyAccount = new System.Windows.Forms.Panel();
            this.uxButtonModifyAccount = new System.Windows.Forms.Button();
            this.uxPanelRentMovie = new System.Windows.Forms.Panel();
            this.uxButtonRentMovie = new System.Windows.Forms.Button();
            this.uxPanelMain = new System.Windows.Forms.Panel();
            this.uxPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPanelCreateAccount
            // 
            this.uxPanelCreateAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.uxPanelCreateAccount.Location = new System.Drawing.Point(0, 105);
            this.uxPanelCreateAccount.Name = "uxPanelCreateAccount";
            this.uxPanelCreateAccount.Size = new System.Drawing.Size(5, 35);
            this.uxPanelCreateAccount.TabIndex = 1;
            // 
            // uxButtonCreateAccount
            // 
            this.uxButtonCreateAccount.FlatAppearance.BorderSize = 0;
            this.uxButtonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonCreateAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonCreateAccount.Location = new System.Drawing.Point(0, 105);
            this.uxButtonCreateAccount.Name = "uxButtonCreateAccount";
            this.uxButtonCreateAccount.Size = new System.Drawing.Size(200, 35);
            this.uxButtonCreateAccount.TabIndex = 0;
            this.uxButtonCreateAccount.Text = "Create Account";
            this.uxButtonCreateAccount.UseVisualStyleBackColor = true;
            this.uxButtonCreateAccount.Click += new System.EventHandler(this.uxMenuHandler);
            // 
            // uxPanelMenu
            // 
            this.uxPanelMenu.BackColor = System.Drawing.Color.Navy;
            this.uxPanelMenu.Controls.Add(this.uxPanelBrowseMovie);
            this.uxPanelMenu.Controls.Add(this.uxButtonBrowseMovie);
            this.uxPanelMenu.Controls.Add(this.uxLabelTitle);
            this.uxPanelMenu.Controls.Add(this.uxPanelAddMovie);
            this.uxPanelMenu.Controls.Add(this.uxButtonAddMovie);
            this.uxPanelMenu.Controls.Add(this.uxPanelDeleteAccount);
            this.uxPanelMenu.Controls.Add(this.uxButtonDeleteAccount);
            this.uxPanelMenu.Controls.Add(this.uxPanelModifyAccount);
            this.uxPanelMenu.Controls.Add(this.uxButtonModifyAccount);
            this.uxPanelMenu.Controls.Add(this.uxPanelRentMovie);
            this.uxPanelMenu.Controls.Add(this.uxButtonRentMovie);
            this.uxPanelMenu.Controls.Add(this.uxPanelCreateAccount);
            this.uxPanelMenu.Controls.Add(this.uxButtonCreateAccount);
            this.uxPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.uxPanelMenu.ForeColor = System.Drawing.Color.Orange;
            this.uxPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.uxPanelMenu.Name = "uxPanelMenu";
            this.uxPanelMenu.Size = new System.Drawing.Size(200, 561);
            this.uxPanelMenu.TabIndex = 5;
            // 
            // uxPanelBrowseMovie
            // 
            this.uxPanelBrowseMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.uxPanelBrowseMovie.Location = new System.Drawing.Point(0, 35);
            this.uxPanelBrowseMovie.Name = "uxPanelBrowseMovie";
            this.uxPanelBrowseMovie.Size = new System.Drawing.Size(5, 35);
            this.uxPanelBrowseMovie.TabIndex = 14;
            // 
            // uxButtonBrowseMovie
            // 
            this.uxButtonBrowseMovie.FlatAppearance.BorderSize = 0;
            this.uxButtonBrowseMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonBrowseMovie.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonBrowseMovie.Location = new System.Drawing.Point(0, 35);
            this.uxButtonBrowseMovie.Name = "uxButtonBrowseMovie";
            this.uxButtonBrowseMovie.Size = new System.Drawing.Size(200, 35);
            this.uxButtonBrowseMovie.TabIndex = 13;
            this.uxButtonBrowseMovie.Text = "Browse Movies";
            this.uxButtonBrowseMovie.UseVisualStyleBackColor = true;
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.AutoSize = true;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelTitle.Location = new System.Drawing.Point(31, 2);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(137, 30);
            this.uxLabelTitle.TabIndex = 12;
            this.uxLabelTitle.Text = "Phils Rentals";
            // 
            // uxPanelAddMovie
            // 
            this.uxPanelAddMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.uxPanelAddMovie.Location = new System.Drawing.Point(0, 210);
            this.uxPanelAddMovie.Name = "uxPanelAddMovie";
            this.uxPanelAddMovie.Size = new System.Drawing.Size(5, 35);
            this.uxPanelAddMovie.TabIndex = 11;
            // 
            // uxButtonAddMovie
            // 
            this.uxButtonAddMovie.FlatAppearance.BorderSize = 0;
            this.uxButtonAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonAddMovie.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonAddMovie.Location = new System.Drawing.Point(0, 210);
            this.uxButtonAddMovie.Name = "uxButtonAddMovie";
            this.uxButtonAddMovie.Size = new System.Drawing.Size(200, 35);
            this.uxButtonAddMovie.TabIndex = 10;
            this.uxButtonAddMovie.Text = "Add Movie";
            this.uxButtonAddMovie.UseVisualStyleBackColor = true;
            this.uxButtonAddMovie.Click += new System.EventHandler(this.uxMenuHandler);
            // 
            // uxPanelDeleteAccount
            // 
            this.uxPanelDeleteAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.uxPanelDeleteAccount.Location = new System.Drawing.Point(0, 175);
            this.uxPanelDeleteAccount.Name = "uxPanelDeleteAccount";
            this.uxPanelDeleteAccount.Size = new System.Drawing.Size(5, 35);
            this.uxPanelDeleteAccount.TabIndex = 9;
            // 
            // uxButtonDeleteAccount
            // 
            this.uxButtonDeleteAccount.FlatAppearance.BorderSize = 0;
            this.uxButtonDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonDeleteAccount.Location = new System.Drawing.Point(0, 175);
            this.uxButtonDeleteAccount.Name = "uxButtonDeleteAccount";
            this.uxButtonDeleteAccount.Size = new System.Drawing.Size(200, 35);
            this.uxButtonDeleteAccount.TabIndex = 8;
            this.uxButtonDeleteAccount.Text = "Delete Account";
            this.uxButtonDeleteAccount.UseVisualStyleBackColor = true;
            this.uxButtonDeleteAccount.Click += new System.EventHandler(this.uxMenuHandler);
            // 
            // uxPanelModifyAccount
            // 
            this.uxPanelModifyAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.uxPanelModifyAccount.Location = new System.Drawing.Point(0, 140);
            this.uxPanelModifyAccount.Name = "uxPanelModifyAccount";
            this.uxPanelModifyAccount.Size = new System.Drawing.Size(5, 35);
            this.uxPanelModifyAccount.TabIndex = 7;
            // 
            // uxButtonModifyAccount
            // 
            this.uxButtonModifyAccount.FlatAppearance.BorderSize = 0;
            this.uxButtonModifyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonModifyAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonModifyAccount.Location = new System.Drawing.Point(0, 140);
            this.uxButtonModifyAccount.Name = "uxButtonModifyAccount";
            this.uxButtonModifyAccount.Size = new System.Drawing.Size(200, 35);
            this.uxButtonModifyAccount.TabIndex = 6;
            this.uxButtonModifyAccount.Text = "Modify Account";
            this.uxButtonModifyAccount.UseVisualStyleBackColor = true;
            this.uxButtonModifyAccount.Click += new System.EventHandler(this.uxMenuHandler);
            // 
            // uxPanelRentMovie
            // 
            this.uxPanelRentMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.uxPanelRentMovie.Location = new System.Drawing.Point(0, 70);
            this.uxPanelRentMovie.Name = "uxPanelRentMovie";
            this.uxPanelRentMovie.Size = new System.Drawing.Size(5, 35);
            this.uxPanelRentMovie.TabIndex = 5;
            // 
            // uxButtonRentMovie
            // 
            this.uxButtonRentMovie.FlatAppearance.BorderSize = 0;
            this.uxButtonRentMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonRentMovie.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonRentMovie.Location = new System.Drawing.Point(0, 70);
            this.uxButtonRentMovie.Name = "uxButtonRentMovie";
            this.uxButtonRentMovie.Size = new System.Drawing.Size(200, 35);
            this.uxButtonRentMovie.TabIndex = 4;
            this.uxButtonRentMovie.Text = "Rent Movies";
            this.uxButtonRentMovie.UseVisualStyleBackColor = true;
            this.uxButtonRentMovie.Click += new System.EventHandler(this.uxMenuHandler);
            // 
            // uxPanelMain
            // 
            this.uxPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPanelMain.Location = new System.Drawing.Point(200, 0);
            this.uxPanelMain.Name = "uxPanelMain";
            this.uxPanelMain.Size = new System.Drawing.Size(584, 561);
            this.uxPanelMain.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.uxPanelMain);
            this.Controls.Add(this.uxPanelMenu);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "Phils Rentals";
            this.uxPanelMenu.ResumeLayout(false);
            this.uxPanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel uxPanelCreateAccount;
        private System.Windows.Forms.Button uxButtonCreateAccount;
        private System.Windows.Forms.Panel uxPanelMenu;
        private System.Windows.Forms.Panel uxPanelRentMovie;
        private System.Windows.Forms.Button uxButtonRentMovie;
        private System.Windows.Forms.Panel uxPanelAddMovie;
        private System.Windows.Forms.Button uxButtonAddMovie;
        private System.Windows.Forms.Panel uxPanelDeleteAccount;
        private System.Windows.Forms.Button uxButtonDeleteAccount;
        private System.Windows.Forms.Panel uxPanelModifyAccount;
        private System.Windows.Forms.Button uxButtonModifyAccount;
        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.Panel uxPanelMain;
        private System.Windows.Forms.Panel uxPanelBrowseMovie;
        private System.Windows.Forms.Button uxButtonBrowseMovie;
    }
}

