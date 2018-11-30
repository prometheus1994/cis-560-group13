namespace PhilsRentals.Views
{
    partial class ReturnMovieWindow
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
            this.uxLabelReturnMovieWindow = new System.Windows.Forms.Label();
            this.uxButtonReturnMovie = new System.Windows.Forms.Button();
            this.uxLabelCustomer = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // uxLabelReturnMovieWindow
            // 
            this.uxLabelReturnMovieWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLabelReturnMovieWindow.BackColor = System.Drawing.Color.Purple;
            this.uxLabelReturnMovieWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelReturnMovieWindow.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelReturnMovieWindow.ForeColor = System.Drawing.Color.White;
            this.uxLabelReturnMovieWindow.Location = new System.Drawing.Point(0, 0);
            this.uxLabelReturnMovieWindow.Name = "uxLabelReturnMovieWindow";
            this.uxLabelReturnMovieWindow.Size = new System.Drawing.Size(584, 50);
            this.uxLabelReturnMovieWindow.TabIndex = 0;
            this.uxLabelReturnMovieWindow.Text = "Return Movie";
            this.uxLabelReturnMovieWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxButtonReturnMovie
            // 
            this.uxButtonReturnMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonReturnMovie.Enabled = false;
            this.uxButtonReturnMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.uxButtonReturnMovie.Location = new System.Drawing.Point(215, 518);
            this.uxButtonReturnMovie.Name = "uxButtonReturnMovie";
            this.uxButtonReturnMovie.Size = new System.Drawing.Size(154, 31);
            this.uxButtonReturnMovie.TabIndex = 13;
            this.uxButtonReturnMovie.Text = "Return Movie(s)";
            this.uxButtonReturnMovie.UseVisualStyleBackColor = true;
            this.uxButtonReturnMovie.Click += new System.EventHandler(this.uxButtonReturnMovie_Click);
            // 
            // uxLabelCustomer
            // 
            this.uxLabelCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxLabelCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.uxLabelCustomer.Location = new System.Drawing.Point(154, 73);
            this.uxLabelCustomer.Name = "uxLabelCustomer";
            this.uxLabelCustomer.Size = new System.Drawing.Size(277, 23);
            this.uxLabelCustomer.TabIndex = 14;
            this.uxLabelCustomer.Text = "\"Will Display Customer Name\" + \"Rentals\"";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 120);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(577, 384);
            this.checkedListBox1.TabIndex = 15;
            // 
            // ReturnMovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.uxLabelCustomer);
            this.Controls.Add(this.uxButtonReturnMovie);
            this.Controls.Add(this.uxLabelReturnMovieWindow);
            this.Name = "ReturnMovieWindow";
            this.Size = new System.Drawing.Size(584, 561);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uxLabelReturnMovieWindow;
        private System.Windows.Forms.Button uxButtonReturnMovie;
        private System.Windows.Forms.Label uxLabelCustomer;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
