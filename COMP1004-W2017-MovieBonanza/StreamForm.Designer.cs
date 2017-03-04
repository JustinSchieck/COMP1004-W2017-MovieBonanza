namespace COMP1004_W2017_MovieBonanza
{
    partial class StreamForm
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
            this.CostLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(79, 83);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(276, 17);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Your credit card will be charged [X Dollars]";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(98, 113);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(226, 17);
            this.MovieLabel.TabIndex = 1;
            this.MovieLabel.Text = "[Movie] will begin streaming shortly";
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.AutoSize = true;
            this.ThanksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanksLabel.Location = new System.Drawing.Point(-1, 44);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(438, 29);
            this.ThanksLabel.TabIndex = 2;
            this.ThanksLabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // StreamFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 187);
            this.Controls.Add(this.ThanksLabel);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.CostLabel);
            this.Name = "StreamFrom";
            this.Text = "Your Stream is about to Start!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Label ThanksLabel;
    }
}