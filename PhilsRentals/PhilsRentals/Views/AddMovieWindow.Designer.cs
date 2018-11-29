namespace PhilsRentals.Views
{
    partial class AddMovieWindow
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
            this.uxLabelMovieTitle = new System.Windows.Forms.Label();
            this.uxLabelMovieGenre = new System.Windows.Forms.Label();
            this.uxLabelReleaseDate = new System.Windows.Forms.Label();
            this.uxLabelDuration = new System.Windows.Forms.Label();
            this.uxLabelStarRating = new System.Windows.Forms.Label();
            this.uxTextBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.uxButtonAddMovie = new System.Windows.Forms.Button();
            this.uxNumericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.uxNumericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.uxCheckedListBoxMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.uxNumericUpDownRating = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.AutoSize = true;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(210, 19);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(158, 37);
            this.uxLabelTitle.TabIndex = 0;
            this.uxLabelTitle.Text = "Add Movie";
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(32, 92);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(129, 30);
            this.uxLabelMovieTitle.TabIndex = 1;
            this.uxLabelMovieTitle.Text = "Movie Title:";
            // 
            // uxLabelMovieGenre
            // 
            this.uxLabelMovieGenre.AutoSize = true;
            this.uxLabelMovieGenre.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelMovieGenre.ForeColor = System.Drawing.Color.White;
            this.uxLabelMovieGenre.Location = new System.Drawing.Point(32, 149);
            this.uxLabelMovieGenre.Name = "uxLabelMovieGenre";
            this.uxLabelMovieGenre.Size = new System.Drawing.Size(144, 30);
            this.uxLabelMovieGenre.TabIndex = 2;
            this.uxLabelMovieGenre.Text = "Movie Genre:";
            // 
            // uxLabelReleaseDate
            // 
            this.uxLabelReleaseDate.AutoSize = true;
            this.uxLabelReleaseDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelReleaseDate.ForeColor = System.Drawing.Color.White;
            this.uxLabelReleaseDate.Location = new System.Drawing.Point(32, 277);
            this.uxLabelReleaseDate.Name = "uxLabelReleaseDate";
            this.uxLabelReleaseDate.Size = new System.Drawing.Size(272, 30);
            this.uxLabelReleaseDate.TabIndex = 3;
            this.uxLabelReleaseDate.Text = "Movie Release Date (Year):";
            // 
            // uxLabelDuration
            // 
            this.uxLabelDuration.AutoSize = true;
            this.uxLabelDuration.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelDuration.ForeColor = System.Drawing.Color.White;
            this.uxLabelDuration.Location = new System.Drawing.Point(32, 351);
            this.uxLabelDuration.Name = "uxLabelDuration";
            this.uxLabelDuration.Size = new System.Drawing.Size(275, 30);
            this.uxLabelDuration.TabIndex = 4;
            this.uxLabelDuration.Text = "Movie Duration (Minutes):";
            // 
            // uxLabelStarRating
            // 
            this.uxLabelStarRating.AutoSize = true;
            this.uxLabelStarRating.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxLabelStarRating.ForeColor = System.Drawing.Color.White;
            this.uxLabelStarRating.Location = new System.Drawing.Point(32, 429);
            this.uxLabelStarRating.Name = "uxLabelStarRating";
            this.uxLabelStarRating.Size = new System.Drawing.Size(151, 30);
            this.uxLabelStarRating.TabIndex = 5;
            this.uxLabelStarRating.Text = "Movie Rating:";
            // 
            // uxTextBoxMovieTitle
            // 
            this.uxTextBoxMovieTitle.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.uxTextBoxMovieTitle.Location = new System.Drawing.Point(167, 90);
            this.uxTextBoxMovieTitle.Multiline = true;
            this.uxTextBoxMovieTitle.Name = "uxTextBoxMovieTitle";
            this.uxTextBoxMovieTitle.Size = new System.Drawing.Size(404, 37);
            this.uxTextBoxMovieTitle.TabIndex = 6;
            // 
            // uxButtonAddMovie
            // 
            this.uxButtonAddMovie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.uxButtonAddMovie.Location = new System.Drawing.Point(191, 499);
            this.uxButtonAddMovie.Name = "uxButtonAddMovie";
            this.uxButtonAddMovie.Size = new System.Drawing.Size(177, 37);
            this.uxButtonAddMovie.TabIndex = 12;
            this.uxButtonAddMovie.Text = "Add Movie";
            this.uxButtonAddMovie.UseVisualStyleBackColor = true;
            this.uxButtonAddMovie.Click += new System.EventHandler(this.uxButtonAddMovie_Click);
            // 
            // uxNumericUpDownYear
            // 
            this.uxNumericUpDownYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxNumericUpDownYear.Location = new System.Drawing.Point(303, 279);
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
            this.uxNumericUpDownYear.Size = new System.Drawing.Size(120, 30);
            this.uxNumericUpDownYear.TabIndex = 13;
            this.uxNumericUpDownYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // uxNumericUpDownDuration
            // 
            this.uxNumericUpDownDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxNumericUpDownDuration.Location = new System.Drawing.Point(313, 351);
            this.uxNumericUpDownDuration.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.uxNumericUpDownDuration.Name = "uxNumericUpDownDuration";
            this.uxNumericUpDownDuration.Size = new System.Drawing.Size(120, 30);
            this.uxNumericUpDownDuration.TabIndex = 14;
            // 
            // uxCheckedListBoxMovieGenre
            // 
            this.uxCheckedListBoxMovieGenre.CheckOnClick = true;
            this.uxCheckedListBoxMovieGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
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
            this.uxCheckedListBoxMovieGenre.Location = new System.Drawing.Point(182, 155);
            this.uxCheckedListBoxMovieGenre.Name = "uxCheckedListBoxMovieGenre";
            this.uxCheckedListBoxMovieGenre.ScrollAlwaysVisible = true;
            this.uxCheckedListBoxMovieGenre.Size = new System.Drawing.Size(186, 104);
            this.uxCheckedListBoxMovieGenre.TabIndex = 15;
            // 
            // uxNumericUpDownRating
            // 
            this.uxNumericUpDownRating.DecimalPlaces = 1;
            this.uxNumericUpDownRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxNumericUpDownRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uxNumericUpDownRating.Location = new System.Drawing.Point(184, 431);
            this.uxNumericUpDownRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uxNumericUpDownRating.Name = "uxNumericUpDownRating";
            this.uxNumericUpDownRating.Size = new System.Drawing.Size(120, 30);
            this.uxNumericUpDownRating.TabIndex = 16;
            // 
            // AddMovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.uxNumericUpDownRating);
            this.Controls.Add(this.uxCheckedListBoxMovieGenre);
            this.Controls.Add(this.uxNumericUpDownDuration);
            this.Controls.Add(this.uxNumericUpDownYear);
            this.Controls.Add(this.uxButtonAddMovie);
            this.Controls.Add(this.uxTextBoxMovieTitle);
            this.Controls.Add(this.uxLabelStarRating);
            this.Controls.Add(this.uxLabelDuration);
            this.Controls.Add(this.uxLabelReleaseDate);
            this.Controls.Add(this.uxLabelMovieGenre);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Controls.Add(this.uxLabelTitle);
            this.Name = "AddMovieWindow";
            this.Size = new System.Drawing.Size(584, 561);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.Label uxLabelMovieTitle;
        private System.Windows.Forms.Label uxLabelMovieGenre;
        private System.Windows.Forms.Label uxLabelReleaseDate;
        private System.Windows.Forms.Label uxLabelDuration;
        private System.Windows.Forms.Label uxLabelStarRating;
        private System.Windows.Forms.TextBox uxTextBoxMovieTitle;
        private System.Windows.Forms.Button uxButtonAddMovie;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownYear;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownDuration;
        private System.Windows.Forms.CheckedListBox uxCheckedListBoxMovieGenre;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownRating;
    }
}
