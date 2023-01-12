namespace CompressFile
{
    partial class Registration_Form
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
            this.Button_confirm = new yt_DesignUI.yt_Button();
            this.Login_textBox = new yt_DesignUI.EgoldsGoogleTextBox();
            this.Password_textBox = new yt_DesignUI.EgoldsGoogleTextBox();
            this.Sign_In_label = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_confirm
            // 
            this.Button_confirm.BackColor = System.Drawing.Color.Transparent;
            this.Button_confirm.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.Button_confirm.BackColorGradientEnabled = true;
            this.Button_confirm.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Button_confirm.BorderColor = System.Drawing.Color.Tomato;
            this.Button_confirm.BorderColorEnabled = false;
            this.Button_confirm.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.Button_confirm.BorderColorOnHoverEnabled = false;
            this.Button_confirm.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_confirm.ForeColor = System.Drawing.Color.White;
            this.Button_confirm.Location = new System.Drawing.Point(55, 272);
            this.Button_confirm.Name = "Button_confirm";
            this.Button_confirm.RippleColor = System.Drawing.Color.Black;
            this.Button_confirm.RoundingEnable = true;
            this.Button_confirm.Size = new System.Drawing.Size(188, 52);
            this.Button_confirm.TabIndex = 0;
            this.Button_confirm.Text = "Log In";
            this.Button_confirm.TextHover = null;
            this.Button_confirm.UseDownPressEffectOnClick = false;
            this.Button_confirm.UseRippleEffect = true;
            this.Button_confirm.UseVisualStyleBackColor = false;
            this.Button_confirm.UseZoomEffectOnHover = false;
            this.Button_confirm.Click += new System.EventHandler(this.Button_confirm_Click);
            // 
            // Login_textBox
            // 
            this.Login_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.Login_textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_textBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Login_textBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_textBox.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_textBox.Location = new System.Drawing.Point(76, 107);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.SelectionStart = 0;
            this.Login_textBox.Size = new System.Drawing.Size(150, 40);
            this.Login_textBox.TabIndex = 1;
            this.Login_textBox.TextInput = "";
            this.Login_textBox.TextPreview = "Login";
            this.Login_textBox.UseSystemPasswordChar = false;
            // 
            // Password_textBox
            // 
            this.Password_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.Password_textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Password_textBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Password_textBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_textBox.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Password_textBox.Location = new System.Drawing.Point(76, 211);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.SelectionStart = 0;
            this.Password_textBox.Size = new System.Drawing.Size(150, 40);
            this.Password_textBox.TabIndex = 2;
            this.Password_textBox.TextInput = "";
            this.Password_textBox.TextPreview = "Password";
            this.Password_textBox.UseSystemPasswordChar = false;
            // 
            // Sign_In_label
            // 
            this.Sign_In_label.AutoSize = true;
            this.Sign_In_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.Sign_In_label.Location = new System.Drawing.Point(127, 355);
            this.Sign_In_label.Name = "Sign_In_label";
            this.Sign_In_label.Size = new System.Drawing.Size(43, 15);
            this.Sign_In_label.TabIndex = 3;
            this.Sign_In_label.TabStop = true;
            this.Sign_In_label.Text = "Sign In";
            this.Sign_In_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sign_In_label_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Welcome_label);
            this.panel1.Controls.Add(this.Password_textBox);
            this.panel1.Controls.Add(this.Sign_In_label);
            this.panel1.Controls.Add(this.Login_textBox);
            this.panel1.Controls.Add(this.Button_confirm);
            this.panel1.Location = new System.Drawing.Point(69, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 383);
            this.panel1.TabIndex = 4;
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.Welcome_label.Location = new System.Drawing.Point(25, 25);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(0, 21);
            this.Welcome_label.TabIndex = 4;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(446, 497);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_Form_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private yt_DesignUI.yt_Button Button_confirm;
        private yt_DesignUI.EgoldsGoogleTextBox Login_textBox;
        private yt_DesignUI.EgoldsGoogleTextBox Password_textBox;
        private LinkLabel Sign_In_label;
        private Panel panel1;
        private Label Welcome_label;
    }
}