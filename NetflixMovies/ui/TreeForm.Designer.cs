
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.DimGray;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(787, 395);
            this.Show.Margin = new System.Windows.Forms.Padding(2);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(113, 37);
            this.Show.TabIndex = 0;
            this.Show.Text = "PREDECIR";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Implementation
            // 
            this.Implementation.AutoSize = true;
            this.Implementation.BackColor = System.Drawing.Color.DimGray;
            this.Implementation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Implementation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Implementation.ForeColor = System.Drawing.Color.Black;
            this.Implementation.Location = new System.Drawing.Point(787, 124);
            this.Implementation.Margin = new System.Windows.Forms.Padding(2);
            this.Implementation.Name = "Implementation";
            this.Implementation.Size = new System.Drawing.Size(147, 24);
            this.Implementation.TabIndex = 1;
            this.Implementation.TabStop = true;
            this.Implementation.Text = "IMPLEMTACIÓN";
            this.Implementation.UseVisualStyleBackColor = false;
            // 
            // library
            // 
            this.library.AutoSize = true;
            this.library.BackColor = System.Drawing.Color.DimGray;
            this.library.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.library.Location = new System.Drawing.Point(787, 153);
            this.library.Margin = new System.Windows.Forms.Padding(2);
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(103, 24);
            this.library.TabIndex = 2;
            this.library.TabStop = true;
            this.library.Text = "LIBRERÍA";
            this.library.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(81, 102);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(692, 331);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Algerian", 31.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "VISUALIZACIÓN ÁRBOL DE DECISIÓN";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(142, 142);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 263);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetflixMovies.Properties.Resources.tecnologia_inteligencia_artificial;
            this.ClientSize = new System.Drawing.Size(935, 470);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.library);
            this.Controls.Add(this.Implementation);
            this.Controls.Add(this.Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TreeView treeView1;
    }
}