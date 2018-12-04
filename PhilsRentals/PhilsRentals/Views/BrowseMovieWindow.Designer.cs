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
            this.uxCheckedListBoxMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.uxLabelMovieGenre = new System.Windows.Forms.Label();
            this.uxNumericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.uxNumericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.uxNumericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.uxLabelStarRating = new System.Windows.Forms.Label();
            this.uxLabelDuration = new System.Windows.Forms.Label();
            this.uxLabelReleaseDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(13, 63);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(48, 21);
            this.uxLabelMovieTitle.TabIndex = 1;
            this.uxLabelMovieTitle.Text = "Title:";
            // 
            // uxTextBoxMovieTitle
            // 
            this.uxTextBoxMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxMovieTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxMovieTitle.Location = new System.Drawing.Point(97, 60);
            this.uxTextBoxMovieTitle.Name = "uxTextBoxMovieTitle";
            this.uxTextBoxMovieTitle.Size = new System.Drawing.Size(154, 29);
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
            this.uxListBoxMovies.Location = new System.Drawing.Point(3, 244);
            this.uxListBoxMovies.MultiColumn = true;
            this.uxListBoxMovies.Name = "uxListBoxMovies";
            this.uxListBoxMovies.Size = new System.Drawing.Size(577, 310);
            this.uxListBoxMovies.TabIndex = 8;
            this.uxListBoxMovies.DoubleClick += new System.EventHandler(this.uxListBoxMovies_DoubleClick);
            // 
            // uxButtonGetMovie
            // 
            this.uxButtonGetMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonGetMovie.Enabled = false;
            this.uxButtonGetMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.uxButtonGetMovie.Location = new System.Drawing.Point(17, 197);
            this.uxButtonGetMovie.Name = "uxButtonGetMovie";
            this.uxButtonGetMovie.Size = new System.Drawing.Size(154, 31);
            this.uxButtonGetMovie.TabIndex = 13;
            this.uxButtonGetMovie.Text = "Browse";
            this.uxButtonGetMovie.UseVisualStyleBackColor = true;
            this.uxButtonGetMovie.Click += new System.EventHandler(this.uxButtonGetMovie_Click);
            // 
            // uxCheckedListBoxMovieGenre
            // 
            this.uxCheckedListBoxMovieGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxCheckedListBoxMovieGenre.CheckOnClick = true;
            this.uxCheckedListBoxMovieGenre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uxCheckedListBoxMovieGenre.FormattingEnabled = true;
            this.uxCheckedListBoxMovieGenre.Items.AddRange(new object[] {
            "Mystery",
            "Drama",
            "History",
            "Sport",
            "Sci-Fi",
            "Family",
            "Horror",
            "Biography",
            "Crime",
            "Romance",
            "Fantasy",
            "Animation",
            "War",
            "Adventure",
            "Action",
            "Music",
            "Comedy",
            "Documentary",
            "Musical",
            "Thriller",
            "Western"});
            this.uxCheckedListBoxMovieGenre.Location = new System.Drawing.Point(97, 106);
            this.uxCheckedListBoxMovieGenre.Name = "uxCheckedListBoxMovieGenre";
            this.uxCheckedListBoxMovieGenre.ScrollAlwaysVisible = true;
            this.uxCheckedListBoxMovieGenre.Size = new System.Drawing.Size(186, 76);
            this.uxCheckedListBoxMovieGenre.TabIndex = 17;
            // 
            // uxLabelMovieGenre
            // 
            this.uxLabelMovieGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieGenre.AutoSize = true;
            this.uxLabelMovieGenre.BackColor = System.Drawing.Color.White;
            this.uxLabelMovieGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.uxLabelMovieGenre.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieGenre.Location = new System.Drawing.Point(13, 106);
            this.uxLabelMovieGenre.Name = "uxLabelMovieGenre";
            this.uxLabelMovieGenre.Size = new System.Drawing.Size(59, 21);
            this.uxLabelMovieGenre.TabIndex = 16;
            this.uxLabelMovieGenre.Text = "Genre:";
            // 
            // uxNumericUpDownRating
            // 
            this.uxNumericUpDownRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownRating.DecimalPlaces = 1;
            this.uxNumericUpDownRating.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uxNumericUpDownRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uxNumericUpDownRating.Location = new System.Drawing.Point(414, 60);
            this.uxNumericUpDownRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uxNumericUpDownRating.Name = "uxNumericUpDownRating";
            this.uxNumericUpDownRating.Size = new System.Drawing.Size(68, 29);
            this.uxNumericUpDownRating.TabIndex = 23;
            // 
            // uxNumericUpDownDuration
            // 
            this.uxNumericUpDownDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownDuration.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uxNumericUpDownDuration.Location = new System.Drawing.Point(414, 148);
            this.uxNumericUpDownDuration.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.uxNumericUpDownDuration.Name = "uxNumericUpDownDuration";
            this.uxNumericUpDownDuration.Size = new System.Drawing.Size(68, 29);
            this.uxNumericUpDownDuration.TabIndex = 22;
            // 
            // uxNumericUpDownYear
            // 
            this.uxNumericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.uxNumericUpDownYear.Location = new System.Drawing.Point(414, 104);
            this.uxNumericUpDownYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.uxNumericUpDownYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.uxNumericUpDownYear.Name = "uxNumericUpDownYear";
            this.uxNumericUpDownYear.Size = new System.Drawing.Size(68, 29);
            this.uxNumericUpDownYear.TabIndex = 21;
            this.uxNumericUpDownYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // uxLabelStarRating
            // 
            this.uxLabelStarRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelStarRating.AutoSize = true;
            this.uxLabelStarRating.BackColor = System.Drawing.Color.White;
            this.uxLabelStarRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.uxLabelStarRating.ForeColor = System.Drawing.Color.Black;
            this.uxLabelStarRating.Location = new System.Drawing.Point(298, 63);
            this.uxLabelStarRating.Name = "uxLabelStarRating";
            this.uxLabelStarRating.Size = new System.Drawing.Size(64, 21);
            this.uxLabelStarRating.TabIndex = 20;
            this.uxLabelStarRating.Text = "Rating:";
            // 
            // uxLabelDuration
            // 
            this.uxLabelDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelDuration.AutoSize = true;
            this.uxLabelDuration.BackColor = System.Drawing.Color.White;
            this.uxLabelDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.uxLabelDuration.ForeColor = System.Drawing.Color.Black;
            this.uxLabelDuration.Location = new System.Drawing.Point(298, 150);
            this.uxLabelDuration.Name = "uxLabelDuration";
            this.uxLabelDuration.Size = new System.Drawing.Size(82, 21);
            this.uxLabelDuration.TabIndex = 19;
            this.uxLabelDuration.Text = "Duration:";
            // 
            // uxLabelReleaseDate
            // 
            this.uxLabelReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelReleaseDate.AutoSize = true;
            this.uxLabelReleaseDate.BackColor = System.Drawing.Color.White;
            this.uxLabelReleaseDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.uxLabelReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.uxLabelReleaseDate.Location = new System.Drawing.Point(298, 106);
            this.uxLabelReleaseDate.Name = "uxLabelReleaseDate";
            this.uxLabelReleaseDate.Size = new System.Drawing.Size(110, 21);
            this.uxLabelReleaseDate.TabIndex = 18;
            this.uxLabelReleaseDate.Text = "Release Year:";
            // 
            // BrowseMovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxNumericUpDownRating);
            this.Controls.Add(this.uxNumericUpDownDuration);
            this.Controls.Add(this.uxNumericUpDownYear);
            this.Controls.Add(this.uxLabelStarRating);
            this.Controls.Add(this.uxLabelDuration);
            this.Controls.Add(this.uxLabelReleaseDate);
            this.Controls.Add(this.uxCheckedListBoxMovieGenre);
            this.Controls.Add(this.uxLabelMovieGenre);
            this.Controls.Add(this.uxButtonGetMovie);
            this.Controls.Add(this.uxListBoxMovies);
            this.Controls.Add(this.uxLabelTitle);
            this.Controls.Add(this.uxTextBoxMovieTitle);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Name = "BrowseMovieWindow";
            this.Size = new System.Drawing.Size(584, 561);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxLabelMovieTitle;
        private System.Windows.Forms.TextBox uxTextBoxMovieTitle;
        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.ListBox uxListBoxMovies;
        private System.Windows.Forms.Button uxButtonGetMovie;
        private System.Windows.Forms.CheckedListBox uxCheckedListBoxMovieGenre;
        private System.Windows.Forms.Label uxLabelMovieGenre;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownRating;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownDuration;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownYear;
        private System.Windows.Forms.Label uxLabelStarRating;
        private System.Windows.Forms.Label uxLabelDuration;
        private System.Windows.Forms.Label uxLabelReleaseDate;
    }
}
