namespace COMP1004_W2017_MovieBonanza
{
    partial class SelectionForm
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
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 16;
            this.MovieListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I Am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieListBox.Location = new System.Drawing.Point(45, 97);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(199, 468);
            this.MovieListBox.Sorted = true;
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(42, 62);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(115, 17);
            this.ListLabel.TabIndex = 1;
            this.ListLabel.Text = "Movie Selection: ";
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionLabel.Location = new System.Drawing.Point(41, 13);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(480, 25);
            this.SelectionLabel.TabIndex = 2;
            this.SelectionLabel.Text = "Please choose a movie from our selection below.";
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.CostLabel);
            this.SelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectionGroupBox.Controls.Add(this.TitleLabel);
            this.SelectionGroupBox.Controls.Add(this.CostTextBox);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionGroupBox.Location = new System.Drawing.Point(275, 97);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(512, 340);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(403, 155);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 17);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(247, 156);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(73, 17);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(244, 86);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(40, 17);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(400, 178);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(97, 22);
            this.CostTextBox.TabIndex = 3;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(244, 179);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(140, 22);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(244, 109);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(253, 22);
            this.TitleTextBox.TabIndex = 1;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(7, 22);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(220, 277);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(728, 544);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(94, 34);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 615);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.MovieListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.Text = "Movie Bonanza - Streaming Service";
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}