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
            this.uxListBoxMovies = new System.Windows.Forms.ListBox();
            this.uxLabelEmailAddress = new System.Windows.Forms.Label();
            this.uxTextBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.uxNumericUpDownRentCount = new System.Windows.Forms.NumericUpDown();
            this.uxLabelRentCount = new System.Windows.Forms.Label();
            this.uxButtonRentMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRentCount)).BeginInit();
            this.SuspendLayout();
            // 
            // uxListBoxMovies
            // 
            this.uxListBoxMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxListBoxMovies.Enabled = false;
            this.uxListBoxMovies.FormattingEnabled = true;
            this.uxListBoxMovies.HorizontalScrollbar = true;
            this.uxListBoxMovies.Location = new System.Drawing.Point(4, 48);
            this.uxListBoxMovies.MultiColumn = true;
            this.uxListBoxMovies.Name = "uxListBoxMovies";
            this.uxListBoxMovies.Size = new System.Drawing.Size(577, 433);
            this.uxListBoxMovies.TabIndex = 0;
            this.uxListBoxMovies.SelectedIndexChanged += new System.EventHandler(this.uxListBoxMovies_SelectedIndexChanged);
            // 
            // uxLabelEmailAddress
            // 
            this.uxLabelEmailAddress.AutoSize = true;
            this.uxLabelEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelEmailAddress.ForeColor = System.Drawing.Color.White;
            this.uxLabelEmailAddress.Location = new System.Drawing.Point(4, 15);
            this.uxLabelEmailAddress.Name = "uxLabelEmailAddress";
            this.uxLabelEmailAddress.Size = new System.Drawing.Size(129, 20);
            this.uxLabelEmailAddress.TabIndex = 1;
            this.uxLabelEmailAddress.Text = "Email Address:";
            // 
            // uxTextBoxEmailAddress
            // 
            this.uxTextBoxEmailAddress.Location = new System.Drawing.Point(140, 15);
            this.uxTextBoxEmailAddress.Name = "uxTextBoxEmailAddress";
            this.uxTextBoxEmailAddress.Size = new System.Drawing.Size(429, 20);
            this.uxTextBoxEmailAddress.TabIndex = 2;
            this.uxTextBoxEmailAddress.TextChanged += new System.EventHandler(this.uxTextBoxTextChanged);
            // 
            // uxNumericUpDownRentCount
            // 
            this.uxNumericUpDownRentCount.Enabled = false;
            this.uxNumericUpDownRentCount.Location = new System.Drawing.Point(170, 530);
            this.uxNumericUpDownRentCount.Name = "uxNumericUpDownRentCount";
            this.uxNumericUpDownRentCount.Size = new System.Drawing.Size(120, 20);
            this.uxNumericUpDownRentCount.TabIndex = 3;
            this.uxNumericUpDownRentCount.ValueChanged += new System.EventHandler(this.uxNumericUpDownRentCount_ValueChanged);
            // 
            // uxLabelRentCount
            // 
            this.uxLabelRentCount.AutoSize = true;
            this.uxLabelRentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelRentCount.ForeColor = System.Drawing.Color.White;
            this.uxLabelRentCount.Location = new System.Drawing.Point(6, 529);
            this.uxLabelRentCount.Name = "uxLabelRentCount";
            this.uxLabelRentCount.Size = new System.Drawing.Size(157, 20);
            this.uxLabelRentCount.TabIndex = 4;
            this.uxLabelRentCount.Text = "Number of Copies:";
            // 
            // uxButtonRentMovie
            // 
            this.uxButtonRentMovie.Enabled = false;
            this.uxButtonRentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonRentMovie.Location = new System.Drawing.Point(368, 524);
            this.uxButtonRentMovie.Name = "uxButtonRentMovie";
            this.uxButtonRentMovie.Size = new System.Drawing.Size(154, 31);
            this.uxButtonRentMovie.TabIndex = 5;
            this.uxButtonRentMovie.Text = "Rent Movie(s)";
            this.uxButtonRentMovie.UseVisualStyleBackColor = true;
            this.uxButtonRentMovie.Click += new System.EventHandler(this.uxButtonRentMovie_Click);
            // 
            // RentMovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.uxButtonRentMovie);
            this.Controls.Add(this.uxLabelRentCount);
            this.Controls.Add(this.uxNumericUpDownRentCount);
            this.Controls.Add(this.uxTextBoxEmailAddress);
            this.Controls.Add(this.uxLabelEmailAddress);
            this.Controls.Add(this.uxListBoxMovies);
            this.Name = "RentMovieWindow";
            this.Size = new System.Drawing.Size(584, 561);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownRentCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxListBoxMovies;
        private System.Windows.Forms.Label uxLabelEmailAddress;
        private System.Windows.Forms.TextBox uxTextBoxEmailAddress;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownRentCount;
        private System.Windows.Forms.Label uxLabelRentCount;
        private System.Windows.Forms.Button uxButtonRentMovie;
    }
}
