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
            this.uxMovieTitleLabel = new System.Windows.Forms.Label();
            this.uxMovieGenreLabel = new System.Windows.Forms.Label();
            this.uxReleaseDateLabel = new System.Windows.Forms.Label();
            this.uxDurationLabel = new System.Windows.Forms.Label();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxMovieTitleText = new System.Windows.Forms.TextBox();
            this.uxMovieGenreList = new System.Windows.Forms.ComboBox();
            this.uxReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxParentalRatingList = new System.Windows.Forms.ComboBox();
            this.uxDurationBox = new System.Windows.Forms.ComboBox();
            this.uxAddMovieButton = new System.Windows.Forms.Button();
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
            // uxMovieTitleLabel
            // 
            this.uxMovieTitleLabel.AutoSize = true;
            this.uxMovieTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxMovieTitleLabel.ForeColor = System.Drawing.Color.White;
            this.uxMovieTitleLabel.Location = new System.Drawing.Point(32, 92);
            this.uxMovieTitleLabel.Name = "uxMovieTitleLabel";
            this.uxMovieTitleLabel.Size = new System.Drawing.Size(129, 30);
            this.uxMovieTitleLabel.TabIndex = 1;
            this.uxMovieTitleLabel.Text = "Movie Title:";
            // 
            // uxMovieGenreLabel
            // 
            this.uxMovieGenreLabel.AutoSize = true;
            this.uxMovieGenreLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxMovieGenreLabel.ForeColor = System.Drawing.Color.White;
            this.uxMovieGenreLabel.Location = new System.Drawing.Point(32, 176);
            this.uxMovieGenreLabel.Name = "uxMovieGenreLabel";
            this.uxMovieGenreLabel.Size = new System.Drawing.Size(144, 30);
            this.uxMovieGenreLabel.TabIndex = 2;
            this.uxMovieGenreLabel.Text = "Movie Genre:";
            // 
            // uxReleaseDateLabel
            // 
            this.uxReleaseDateLabel.AutoSize = true;
            this.uxReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxReleaseDateLabel.ForeColor = System.Drawing.Color.White;
            this.uxReleaseDateLabel.Location = new System.Drawing.Point(32, 264);
            this.uxReleaseDateLabel.Name = "uxReleaseDateLabel";
            this.uxReleaseDateLabel.Size = new System.Drawing.Size(209, 30);
            this.uxReleaseDateLabel.TabIndex = 3;
            this.uxReleaseDateLabel.Text = "Movie Release Date:";
            // 
            // uxDurationLabel
            // 
            this.uxDurationLabel.AutoSize = true;
            this.uxDurationLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxDurationLabel.ForeColor = System.Drawing.Color.White;
            this.uxDurationLabel.Location = new System.Drawing.Point(32, 351);
            this.uxDurationLabel.Name = "uxDurationLabel";
            this.uxDurationLabel.Size = new System.Drawing.Size(173, 30);
            this.uxDurationLabel.TabIndex = 4;
            this.uxDurationLabel.Text = "Movie Duration:";
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uxRatingLabel.ForeColor = System.Drawing.Color.White;
            this.uxRatingLabel.Location = new System.Drawing.Point(32, 439);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(237, 30);
            this.uxRatingLabel.TabIndex = 5;
            this.uxRatingLabel.Text = "Movie Parental Rating:";
            // 
            // uxMovieTitleText
            // 
            this.uxMovieTitleText.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.uxMovieTitleText.Location = new System.Drawing.Point(167, 90);
            this.uxMovieTitleText.Multiline = true;
            this.uxMovieTitleText.Name = "uxMovieTitleText";
            this.uxMovieTitleText.Size = new System.Drawing.Size(404, 37);
            this.uxMovieTitleText.TabIndex = 6;
            // 
            // uxMovieGenreList
            // 
            this.uxMovieGenreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxMovieGenreList.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.uxMovieGenreList.FormattingEnabled = true;
            this.uxMovieGenreList.Items.AddRange(new object[] {
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
            this.uxMovieGenreList.Location = new System.Drawing.Point(182, 176);
            this.uxMovieGenreList.Name = "uxMovieGenreList";
            this.uxMovieGenreList.Size = new System.Drawing.Size(241, 39);
            this.uxMovieGenreList.TabIndex = 8;
            // 
            // uxReleaseDatePicker
            // 
            this.uxReleaseDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxReleaseDatePicker.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDatePicker.Location = new System.Drawing.Point(247, 274);
            this.uxReleaseDatePicker.Name = "uxReleaseDatePicker";
            this.uxReleaseDatePicker.Size = new System.Drawing.Size(324, 34);
            this.uxReleaseDatePicker.TabIndex = 9;
            // 
            // uxParentalRatingList
            // 
            this.uxParentalRatingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxParentalRatingList.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.uxParentalRatingList.FormattingEnabled = true;
            this.uxParentalRatingList.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.uxParentalRatingList.Location = new System.Drawing.Point(275, 437);
            this.uxParentalRatingList.Name = "uxParentalRatingList";
            this.uxParentalRatingList.Size = new System.Drawing.Size(241, 39);
            this.uxParentalRatingList.TabIndex = 10;
            // 
            // uxDurationBox
            // 
            this.uxDurationBox.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.uxDurationBox.FormattingEnabled = true;
            this.uxDurationBox.Items.AddRange(new object[] {
            "00:30:00",
            "01:00:00",
            "01:30:00",
            "02:00:00",
            "02:30:00",
            "03:00:00",
            "03:30:00",
            "04:00:00"});
            this.uxDurationBox.Location = new System.Drawing.Point(211, 351);
            this.uxDurationBox.Name = "uxDurationBox";
            this.uxDurationBox.Size = new System.Drawing.Size(241, 39);
            this.uxDurationBox.TabIndex = 11;
            // 
            // uxAddMovieButton
            // 
            this.uxAddMovieButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.uxAddMovieButton.Location = new System.Drawing.Point(191, 499);
            this.uxAddMovieButton.Name = "uxAddMovieButton";
            this.uxAddMovieButton.Size = new System.Drawing.Size(177, 37);
            this.uxAddMovieButton.TabIndex = 12;
            this.uxAddMovieButton.Text = "Add Movie";
            this.uxAddMovieButton.UseVisualStyleBackColor = true;
            // 
            // AddMovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.uxAddMovieButton);
            this.Controls.Add(this.uxDurationBox);
            this.Controls.Add(this.uxParentalRatingList);
            this.Controls.Add(this.uxReleaseDatePicker);
            this.Controls.Add(this.uxMovieGenreList);
            this.Controls.Add(this.uxMovieTitleText);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxDurationLabel);
            this.Controls.Add(this.uxReleaseDateLabel);
            this.Controls.Add(this.uxMovieGenreLabel);
            this.Controls.Add(this.uxMovieTitleLabel);
            this.Controls.Add(this.uxLabelTitle);
            this.Name = "AddMovieWindow";
            this.Size = new System.Drawing.Size(584, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.Label uxMovieTitleLabel;
        private System.Windows.Forms.Label uxMovieGenreLabel;
        private System.Windows.Forms.Label uxReleaseDateLabel;
        private System.Windows.Forms.Label uxDurationLabel;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.TextBox uxMovieTitleText;
        private System.Windows.Forms.ComboBox uxMovieGenreList;
        private System.Windows.Forms.DateTimePicker uxReleaseDatePicker;
        private System.Windows.Forms.ComboBox uxParentalRatingList;
        private System.Windows.Forms.ComboBox uxDurationBox;
        private System.Windows.Forms.Button uxAddMovieButton;
    }
}
