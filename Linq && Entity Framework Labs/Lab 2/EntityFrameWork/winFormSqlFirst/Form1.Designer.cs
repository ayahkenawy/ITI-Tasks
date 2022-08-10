namespace winFormSqlFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesView)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesView
            // 
            this.MoviesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesView.Location = new System.Drawing.Point(0, 0);
            this.MoviesView.Name = "MoviesView";
            this.MoviesView.RowHeadersWidth = 51;
            this.MoviesView.Size = new System.Drawing.Size(800, 450);
            this.MoviesView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoviesView);
            this.Name = "Form1";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.MoviesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MoviesView;
    }
}
