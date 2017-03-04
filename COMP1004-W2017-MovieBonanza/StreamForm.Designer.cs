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
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CostLabel
            // 
            this.CostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostLabel.Location = new System.Drawing.Point(0, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(479, 141);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Your credit card will be charged [X Dollars]";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThanksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanksLabel.Location = new System.Drawing.Point(0, 0);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(479, 29);
            this.ThanksLabel.TabIndex = 2;
            this.ThanksLabel.Text = "Thank you for choosing Movie Bonanza!";
            this.ThanksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(193, 106);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(74, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this._OkButton_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 141);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ThanksLabel);
            this.Controls.Add(this.CostLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Stream is about to Start!";
            this.Load += new System.EventHandler(this._StreamForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ThanksLabel;
        private System.Windows.Forms.Button OkButton;
    }
}