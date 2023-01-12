namespace CompressFile
{
    partial class Authorisation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorisation_Form));
            this.Button_Confirm = new yt_DesignUI.yt_Button();
            this.Pass_Toggle_Switch = new yt_DesignUI.EgoldsToggleSwitch();
            this.Login_input = new yt_DesignUI.EgoldsGoogleTextBox();
            this.Password_input = new yt_DesignUI.EgoldsGoogleTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Registration_label = new System.Windows.Forms.LinkLabel();
            this.error_register = new System.Windows.Forms.Label();
            this.Clip_box = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clip_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.Button_Confirm.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.Button_Confirm.BackColorGradientEnabled = true;
            this.Button_Confirm.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Button_Confirm.BorderColor = System.Drawing.Color.Tomato;
            this.Button_Confirm.BorderColorEnabled = false;
            this.Button_Confirm.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.Button_Confirm.BorderColorOnHoverEnabled = false;
            this.Button_Confirm.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Confirm.ForeColor = System.Drawing.Color.White;
            this.Button_Confirm.Location = new System.Drawing.Point(39, 293);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.RippleColor = System.Drawing.Color.Black;
            this.Button_Confirm.RoundingEnable = true;
            this.Button_Confirm.Size = new System.Drawing.Size(200, 50);
            this.Button_Confirm.TabIndex = 0;
            this.Button_Confirm.Text = "Sign In";
            this.Button_Confirm.TextHover = null;
            this.Button_Confirm.UseDownPressEffectOnClick = true;
            this.Button_Confirm.UseRippleEffect = true;
            this.Button_Confirm.UseVisualStyleBackColor = false;
            this.Button_Confirm.UseZoomEffectOnHover = false;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Pass_Toggle_Switch
            // 
            this.Pass_Toggle_Switch.BackColor = System.Drawing.Color.White;
            this.Pass_Toggle_Switch.BackColorOFF = System.Drawing.Color.Gray;
            this.Pass_Toggle_Switch.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.Pass_Toggle_Switch.Checked = false;
            this.Pass_Toggle_Switch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pass_Toggle_Switch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pass_Toggle_Switch.Location = new System.Drawing.Point(88, 243);
            this.Pass_Toggle_Switch.Name = "Pass_Toggle_Switch";
            this.Pass_Toggle_Switch.Size = new System.Drawing.Size(151, 15);
            this.Pass_Toggle_Switch.TabIndex = 4;
            this.Pass_Toggle_Switch.Text = "Show password";
            this.Pass_Toggle_Switch.TextOnChecked = "";
            this.Pass_Toggle_Switch.CheckedChanged += new yt_DesignUI.EgoldsToggleSwitch.OnCheckedChangedHandler(this.Pass_Toggle_Switch_CheckedChanged);
            // 
            // Login_input
            // 
            this.Login_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.Login_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_input.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Login_input.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_input.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(113)))), ((int)(((byte)(237)))));
            this.Login_input.Location = new System.Drawing.Point(39, 135);
            this.Login_input.Name = "Login_input";
            this.Login_input.SelectionStart = 0;
            this.Login_input.Size = new System.Drawing.Size(200, 42);
            this.Login_input.TabIndex = 2;
            this.Login_input.TextInput = "";
            this.Login_input.TextPreview = "Input login";
            this.Login_input.UseSystemPasswordChar = false;
            this.Login_input.Enter += new System.EventHandler(this.Login_input_Enter);
            // 
            // Password_input
            // 
            this.Password_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.Password_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Password_input.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Password_input.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_input.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(113)))), ((int)(((byte)(237)))));
            this.Password_input.Location = new System.Drawing.Point(39, 195);
            this.Password_input.Name = "Password_input";
            this.Password_input.SelectionStart = 0;
            this.Password_input.Size = new System.Drawing.Size(200, 42);
            this.Password_input.TabIndex = 3;
            this.Password_input.TextInput = "";
            this.Password_input.TextPreview = "Input password";
            this.Password_input.UseSystemPasswordChar = true;
            this.Password_input.Enter += new System.EventHandler(this.Password_input_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.Registration_label);
            this.panel1.Controls.Add(this.error_register);
            this.panel1.Controls.Add(this.Clip_box);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Button_Confirm);
            this.panel1.Controls.Add(this.Pass_Toggle_Switch);
            this.panel1.Controls.Add(this.Login_input);
            this.panel1.Controls.Add(this.Password_input);
            this.panel1.Location = new System.Drawing.Point(133, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 389);
            this.panel1.TabIndex = 5;
            // 
            // Registration_label
            // 
            this.Registration_label.AutoSize = true;
            this.Registration_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.Registration_label.Location = new System.Drawing.Point(102, 362);
            this.Registration_label.Name = "Registration_label";
            this.Registration_label.Size = new System.Drawing.Size(70, 15);
            this.Registration_label.TabIndex = 8;
            this.Registration_label.TabStop = true;
            this.Registration_label.Text = "Registration";
            this.Registration_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registration_label_LinkClicked);
            // 
            // error_register
            // 
            this.error_register.AutoSize = true;
            this.error_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_register.Location = new System.Drawing.Point(56, 275);
            this.error_register.Name = "error_register";
            this.error_register.Size = new System.Drawing.Size(0, 15);
            this.error_register.TabIndex = 7;
            // 
            // Clip_box
            // 
            this.Clip_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clip_box.Image = ((System.Drawing.Image)(resources.GetObject("Clip_box.Image")));
            this.Clip_box.Location = new System.Drawing.Point(245, 205);
            this.Clip_box.Name = "Clip_box";
            this.Clip_box.Size = new System.Drawing.Size(34, 32);
            this.Clip_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Clip_box.TabIndex = 6;
            this.Clip_box.TabStop = false;
            this.Clip_box.Click += new System.EventHandler(this.Clip_box_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Authorisation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(553, 501);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Authorisation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_form_FormClosed);
            this.Load += new System.EventHandler(this.Registration_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clip_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private yt_DesignUI.yt_Button Button_Confirm;
        private yt_DesignUI.EgoldsToggleSwitch Pass_Toggle_Switch;
        private yt_DesignUI.EgoldsGoogleTextBox Login_input;
        private yt_DesignUI.EgoldsGoogleTextBox Password_input;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox Clip_box;
        private Label error_register;
        private LinkLabel Registration_label;
    }
}