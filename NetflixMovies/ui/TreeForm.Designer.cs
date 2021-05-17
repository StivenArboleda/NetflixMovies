
namespace NetflixMovies.ui
{
    partial class TreeForm
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
            this.Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(972, 472);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(151, 46);
            this.Show.TabIndex = 0;
            this.Show.Text = "button1";
            this.Show.UseVisualStyleBackColor = true;
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 579);
            this.Controls.Add(this.Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Show;
    }
}