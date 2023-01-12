namespace CompressFile
{
    partial class Bababoiu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bababoiu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OpenDialog_label = new System.Windows.Forms.LinkLabel();
            this.CompressedLoad_label = new System.Windows.Forms.LinkLabel();
            this.Compress_Start = new yt_DesignUI.yt_Button();
            this.ProgressCompressing = new System.Windows.Forms.ProgressBar();
            this.error_compressing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // OpenDialog_label
            // 
            this.OpenDialog_label.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(188)))), ((int)(((byte)(245)))));
            this.OpenDialog_label.AutoSize = true;
            this.OpenDialog_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenDialog_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.OpenDialog_label.Location = new System.Drawing.Point(330, 151);
            this.OpenDialog_label.Name = "OpenDialog_label";
            this.OpenDialog_label.Size = new System.Drawing.Size(114, 32);
            this.OpenDialog_label.TabIndex = 3;
            this.OpenDialog_label.TabStop = true;
            this.OpenDialog_label.Text = "Input File";
            this.OpenDialog_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenDialog_label_LinkClicked);
            // 
            // CompressedLoad_label
            // 
            this.CompressedLoad_label.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(188)))), ((int)(((byte)(245)))));
            this.CompressedLoad_label.AutoSize = true;
            this.CompressedLoad_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompressedLoad_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.CompressedLoad_label.Location = new System.Drawing.Point(330, 294);
            this.CompressedLoad_label.Name = "CompressedLoad_label";
            this.CompressedLoad_label.Size = new System.Drawing.Size(134, 32);
            this.CompressedLoad_label.TabIndex = 4;
            this.CompressedLoad_label.TabStop = true;
            this.CompressedLoad_label.Text = "Output File";
            this.CompressedLoad_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CompressedLoad_label_LinkClicked);
            // 
            // Compress_Start
            // 
            this.Compress_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.Compress_Start.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.Compress_Start.BackColorGradientEnabled = true;
            this.Compress_Start.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Compress_Start.BorderColor = System.Drawing.Color.Tomato;
            this.Compress_Start.BorderColorEnabled = false;
            this.Compress_Start.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.Compress_Start.BorderColorOnHoverEnabled = false;
            this.Compress_Start.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Compress_Start.ForeColor = System.Drawing.Color.White;
            this.Compress_Start.Location = new System.Drawing.Point(653, 393);
            this.Compress_Start.Name = "Compress_Start";
            this.Compress_Start.RippleColor = System.Drawing.Color.Black;
            this.Compress_Start.RoundingEnable = true;
            this.Compress_Start.Size = new System.Drawing.Size(135, 45);
            this.Compress_Start.TabIndex = 5;
            this.Compress_Start.Text = "Compress";
            this.Compress_Start.TextHover = null;
            this.Compress_Start.UseDownPressEffectOnClick = true;
            this.Compress_Start.UseRippleEffect = true;
            this.Compress_Start.UseVisualStyleBackColor = false;
            this.Compress_Start.UseZoomEffectOnHover = false;
            this.Compress_Start.Click += new System.EventHandler(this.Compress_Start_Click);
            // 
            // ProgressCompressing
            // 
            this.ProgressCompressing.Location = new System.Drawing.Point(262, 239);
            this.ProgressCompressing.Name = "ProgressCompressing";
            this.ProgressCompressing.Size = new System.Drawing.Size(433, 23);
            this.ProgressCompressing.TabIndex = 6;
            // 
            // error_compressing
            // 
            this.error_compressing.AutoSize = true;
            this.error_compressing.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error_compressing.ForeColor = System.Drawing.Color.Red;
            this.error_compressing.Location = new System.Drawing.Point(262, 380);
            this.error_compressing.Name = "error_compressing";
            this.error_compressing.Size = new System.Drawing.Size(0, 37);
            this.error_compressing.TabIndex = 7;
            // 
            // Bababoiu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error_compressing);
            this.Controls.Add(this.ProgressCompressing);
            this.Controls.Add(this.Compress_Start);
            this.Controls.Add(this.CompressedLoad_label);
            this.Controls.Add(this.OpenDialog_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bababoiu";
            this.Text = "Bababoiu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bababoiu_FormClosed);
            this.Load += new System.EventHandler(this.Bababoiu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel OpenDialog_label;
        private LinkLabel CompressedLoad_label;
        private yt_DesignUI.yt_Button Compress_Start;
        private ProgressBar ProgressCompressing;
        private Label error_compressing;
    }
}