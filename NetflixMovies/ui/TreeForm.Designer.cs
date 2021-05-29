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
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.comboCast = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.DimGray;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(1020, 486);
            this.Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(151, 46);
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
            this.Implementation.Location = new System.Drawing.Point(1020, 357);
            this.Implementation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Implementation.Name = "Implementation";
            this.Implementation.Size = new System.Drawing.Size(213, 29);
            this.Implementation.TabIndex = 1;
            this.Implementation.TabStop = true;
            this.Implementation.Text = "IMPLEMENTACIÓN";
            this.Implementation.UseVisualStyleBackColor = false;
            // 
            // library
            // 
            this.library.AutoSize = true;
            this.library.BackColor = System.Drawing.Color.DimGray;
            this.library.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.library.Location = new System.Drawing.Point(1020, 410);
            this.library.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(120, 29);
            this.library.TabIndex = 2;
            this.library.TabStop = true;
            this.library.Text = "LIBRERÍA";
            this.library.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 126);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1001, 406);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Algerian", 31.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "VISUALIZACIÓN ÁRBOL DE DECISIÓN";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(29, 143);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(451, 374);
            this.treeView1.TabIndex = 5;
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(1020, 158);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(201, 28);
            this.comboGender.TabIndex = 6;
            // 
            // comboCast
            // 
            this.comboCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCast.FormattingEnabled = true;
            this.comboCast.Location = new System.Drawing.Point(1020, 211);
            this.comboCast.Margin = new System.Windows.Forms.Padding(4);
            this.comboCast.Name = "comboCast";
            this.comboCast.Size = new System.Drawing.Size(201, 28);
            this.comboCast.TabIndex = 7;
            // 
            // comboYear
            // 
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(1020, 272);
            this.comboYear.Margin = new System.Windows.Forms.Padding(4);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(201, 28);
            this.comboYear.TabIndex = 8;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(516, 143);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(463, 374);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetflixMovies.Properties.Resources.tree;
            this.ClientSize = new System.Drawing.Size(1247, 578);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboCast);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.library);
            this.Controls.Add(this.Implementation);
            this.Controls.Add(this.Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ComboBox comboCast;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}