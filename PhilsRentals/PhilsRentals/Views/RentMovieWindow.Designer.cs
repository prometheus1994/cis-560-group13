namespace PhilsRentals.Views
{
    partial class RentMovieWindow
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
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.uxButtonRentMovie = new System.Windows.Forms.Button();
            this.uxLabelRentCount = new System.Windows.Forms.Label();
            this.uxNumericUpDownRentCount = new System.Windows.Forms.NumericUpDown();
            this.uxListBoxMovies = new System.Windows.Forms.ListBox();
            this.uxTextBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.uxLabelMovieTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRentCount)).BeginInit();
            this.SuspendLayout();
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
            this.uxLabelTitle.TabIndex = 13;
            this.uxLabelTitle.Text = "Rent Movie";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxButtonRentMovie
            // 
            this.uxButtonRentMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonRentMovie.Enabled = false;
            this.uxButtonRentMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.uxButtonRentMovie.Location = new System.Drawing.Point(422, 526);
            this.uxButtonRentMovie.Name = "uxButtonRentMovie";
            this.uxButtonRentMovie.Size = new System.Drawing.Size(154, 31);
            this.uxButtonRentMovie.TabIndex = 12;
            this.uxButtonRentMovie.Text = "Rent Movie(s)";
            this.uxButtonRentMovie.UseVisualStyleBackColor = true;
            this.uxButtonRentMovie.Click += new System.EventHandler(this.uxButtonRentMovie_Click);
            // 
            // uxLabelRentCount
            // 
            this.uxLabelRentCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelRentCount.AutoSize = true;
            this.uxLabelRentCount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelRentCount.ForeColor = System.Drawing.Color.Black;
            this.uxLabelRentCount.Location = new System.Drawing.Point(6, 531);
            this.uxLabelRentCount.Name = "uxLabelRentCount";
            this.uxLabelRentCount.Size = new System.Drawing.Size(152, 21);
            this.uxLabelRentCount.TabIndex = 11;
            this.uxLabelRentCount.Text = "Number of Copies:";
            // 
            // uxNumericUpDownRentCount
            // 
            this.uxNumericUpDownRentCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownRentCount.Enabled = false;
            this.uxNumericUpDownRentCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumericUpDownRentCount.Location = new System.Drawing.Point(170, 529);
            this.uxNumericUpDownRentCount.Name = "uxNumericUpDownRentCount";
            this.uxNumericUpDownRentCount.Size = new System.Drawing.Size(120, 25);
            this.uxNumericUpDownRentCount.TabIndex = 10;
            this.uxNumericUpDownRentCount.ValueChanged += new System.EventHandler(this.uxNumericUpDownRentCount_ValueChanged);
            // 
            // uxListBoxMovies
            // 
            this.uxListBoxMovies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxListBoxMovies.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uxListBoxMovies.Enabled = false;
            this.uxListBoxMovies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxListBoxMovies.ForeColor = System.Drawing.Color.White;
            this.uxListBoxMovies.FormattingEnabled = true;
            this.uxListBoxMovies.HorizontalScrollbar = true;
            this.uxListBoxMovies.ItemHeight = 17;
            this.uxListBoxMovies.Location = new System.Drawing.Point(4, 124);
            this.uxListBoxMovies.MultiColumn = true;
            this.uxListBoxMovies.Name = "uxListBoxMovies";
            this.uxListBoxMovies.Size = new System.Drawing.Size(577, 395);
            this.uxListBoxMovies.TabIndex = 7;
            this.uxListBoxMovies.SelectedIndexChanged += new System.EventHandler(this.uxListBoxMovies_SelectedIndexChanged);
            this.uxListBoxMovies.DoubleClick += new System.EventHandler(this.uxListBoxMovies_DoubleClick);
            // 
            // uxTextBoxMovieTitle
            // 
            this.uxTextBoxMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxMovieTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uxTextBoxMovieTitle.Location = new System.Drawing.Point(141, 55);
            this.uxTextBoxMovieTitle.Name = "uxTextBoxMovieTitle";
            this.uxTextBoxMovieTitle.Size = new System.Drawing.Size(429, 29);
            this.uxTextBoxMovieTitle.TabIndex = 15;
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(11, 59);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(100, 21);
            this.uxLabelMovieTitle.TabIndex = 14;
            this.uxLabelMovieTitle.Text = "Movie Title:";
            // 
            // RentMovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxTextBoxMovieTitle);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Controls.Add(this.uxLabelTitle);
            this.Controls.Add(this.uxButtonRentMovie);
            this.Controls.Add(this.uxLabelRentCount);
            this.Controls.Add(this.uxNumericUpDownRentCount);
            this.Controls.Add(this.uxListBoxMovies);
            this.Name = "RentMovieWindow";
            this.Size = new System.Drawing.Size(584, 561);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRentCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.Button uxButtonRentMovie;
        private System.Windows.Forms.Label uxLabelRentCount;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownRentCount;
        private System.Windows.Forms.ListBox uxListBoxMovies;
        private System.Windows.Forms.TextBox uxTextBoxMovieTitle;
        private System.Windows.Forms.Label uxLabelMovieTitle;
    }
}
