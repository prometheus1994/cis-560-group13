namespace PhilsRentals.Views
{
    partial class BrowseMovieWindow
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
            this.uxLabelMovieTitle = new System.Windows.Forms.Label();
            this.uxTextBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.uxListBoxMovies = new System.Windows.Forms.ListBox();
            this.uxButtonGetMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(3, 57);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(100, 21);
            this.uxLabelMovieTitle.TabIndex = 1;
            this.uxLabelMovieTitle.Text = "Movie Title:";
            // 
            // uxTextBoxMovieTitle
            // 
            this.uxTextBoxMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxMovieTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxMovieTitle.Location = new System.Drawing.Point(109, 53);
            this.uxTextBoxMovieTitle.Name = "uxTextBoxMovieTitle";
            this.uxTextBoxMovieTitle.Size = new System.Drawing.Size(429, 29);
            this.uxTextBoxMovieTitle.TabIndex = 2;
            this.uxTextBoxMovieTitle.TextChanged += new System.EventHandler(this.uxTextBoxTextChanged);
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.Purple;
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(584, 50);
            this.uxLabelTitle.TabIndex = 6;
            this.uxLabelTitle.Text = "Browse Movie";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxListBoxMovies
            // 
            this.uxListBoxMovies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxListBoxMovies.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uxListBoxMovies.Enabled = false;
            this.uxListBoxMovies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.uxListBoxMovies.ForeColor = System.Drawing.Color.White;
            this.uxListBoxMovies.FormattingEnabled = true;
            this.uxListBoxMovies.HorizontalScrollbar = true;
            this.uxListBoxMovies.ItemHeight = 17;
            this.uxListBoxMovies.Location = new System.Drawing.Point(3, 125);
            this.uxListBoxMovies.MultiColumn = true;
            this.uxListBoxMovies.Name = "uxListBoxMovies";
            this.uxListBoxMovies.Size = new System.Drawing.Size(577, 429);
            this.uxListBoxMovies.TabIndex = 8;
            this.uxListBoxMovies.DoubleClick += new System.EventHandler(this.uxListBoxMovies_DoubleClick);
            // 
            // uxButtonGetMovie
            // 
            this.uxButtonGetMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonGetMovie.Enabled = false;
            this.uxButtonGetMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.uxButtonGetMovie.Location = new System.Drawing.Point(204, 88);
            this.uxButtonGetMovie.Name = "uxButtonGetMovie";
            this.uxButtonGetMovie.Size = new System.Drawing.Size(154, 31);
            this.uxButtonGetMovie.TabIndex = 13;
            this.uxButtonGetMovie.Text = "Get Movie(s)";
            this.uxButtonGetMovie.UseVisualStyleBackColor = true;
            this.uxButtonGetMovie.Click += new System.EventHandler(this.uxButtonGetMovie_Click);
            // 
            // BrowseMovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxButtonGetMovie);
            this.Controls.Add(this.uxListBoxMovies);
            this.Controls.Add(this.uxLabelTitle);
            this.Controls.Add(this.uxTextBoxMovieTitle);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Name = "BrowseMovieWindow";
            this.Size = new System.Drawing.Size(584, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxLabelMovieTitle;
        private System.Windows.Forms.TextBox uxTextBoxMovieTitle;
        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.ListBox uxListBoxMovies;
        private System.Windows.Forms.Button uxButtonGetMovie;
    }
}
