
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
            this.Implementation = new System.Windows.Forms.RadioButton();
            this.library = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(1049, 486);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(151, 46);
            this.Show.TabIndex = 0;
            this.Show.Text = "PREDECIR";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Implementation
            // 
            this.Implementation.AutoSize = true;
            this.Implementation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Implementation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Implementation.Location = new System.Drawing.Point(1049, 126);
            this.Implementation.Name = "Implementation";
            this.Implementation.Size = new System.Drawing.Size(186, 29);
            this.Implementation.TabIndex = 1;
            this.Implementation.TabStop = true;
            this.Implementation.Text = "IMPLEMTACIÓN";
            this.Implementation.UseVisualStyleBackColor = true;
            // 
            // library
            // 
            this.library.AutoSize = true;
            this.library.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.library.Location = new System.Drawing.Point(1049, 161);
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(120, 29);
            this.library.TabIndex = 2;
            this.library.TabStop = true;
            this.library.Text = "LIBRERÍA";
            this.library.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(108, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(922, 406);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 31.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(902, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "VISUALIZACIÓN ÁRBOL DE DECISIÓN";
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.library);
            this.Controls.Add(this.Implementation);
            this.Controls.Add(this.Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.RadioButton Implementation;
        private System.Windows.Forms.RadioButton library;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}