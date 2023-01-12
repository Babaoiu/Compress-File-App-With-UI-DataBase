namespace CompressFile
{
    partial class Welcome_folder
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
            this.Welcome_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome_text
            // 
            this.Welcome_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Welcome_text.Font = new System.Drawing.Font("SimSun-ExtB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Welcome_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(97)))));
            this.Welcome_text.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Welcome_text.Location = new System.Drawing.Point(212, 358);
            this.Welcome_text.Name = "Welcome_text";
            this.Welcome_text.Size = new System.Drawing.Size(469, 50);
            this.Welcome_text.TabIndex = 0;
            this.Welcome_text.Text = "label1";
            this.Welcome_text.Click += new System.EventHandler(this.Welcome_text_Click);
            // 
            // Welcome_folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.Welcome_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Welcome_folder";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_folder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Welcome_text;
    }
}