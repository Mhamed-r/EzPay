namespace EzPay
{
    partial class Registration
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            btn_close = new Button();
            label7 = new Label();
            label1 = new Label();
            txt_username = new TextBox();
            cb_show = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            txt_password = new TextBox();
            txt_email = new TextBox();
            label2 = new Label();
            txt_confirmpass = new TextBox();
            txt_phone = new TextBox();
            label5 = new Label();
            btn_back = new Button();
            label9 = new Label();
            btn_register = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_clear = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Dock = DockStyle.Left;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(0, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.BorderRadius = 10;
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(585, 645);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.White;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.Red;
            btn_close.Location = new Point(919, -4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(42, 41);
            btn_close.TabIndex = 25;
            btn_close.Text = "✗";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(136, 198, 150);
            label7.Location = new Point(660, 7);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(200, 46);
            label7.TabIndex = 24;
            label7.Text = "Get Started";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(639, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 23;
            label1.Text = "UserName";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(639, 84);
            txt_username.Margin = new Padding(4, 3, 4, 3);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(279, 41);
            txt_username.TabIndex = 22;
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.Cursor = Cursors.Hand;
            cb_show.FlatStyle = FlatStyle.Flat;
            cb_show.Location = new Point(794, 407);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(124, 24);
            cb_show.TabIndex = 30;
            cb_show.Text = "ShowPassword";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(639, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 29;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(639, 266);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(230, 231, 233);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("MS UI Gothic", 13.8F);
            txt_password.Location = new Point(639, 292);
            txt_password.Margin = new Padding(4, 3, 4, 3);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(279, 41);
            txt_password.TabIndex = 27;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.FromArgb(230, 231, 233);
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("MS UI Gothic", 13.8F);
            txt_email.Location = new Point(639, 157);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(279, 41);
            txt_email.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(639, 337);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 32;
            label2.Text = "Confirm Password";
            // 
            // txt_confirmpass
            // 
            txt_confirmpass.BackColor = Color.FromArgb(230, 231, 233);
            txt_confirmpass.BorderStyle = BorderStyle.None;
            txt_confirmpass.Font = new Font("MS UI Gothic", 13.8F);
            txt_confirmpass.Location = new Point(639, 360);
            txt_confirmpass.Margin = new Padding(4, 3, 4, 3);
            txt_confirmpass.Multiline = true;
            txt_confirmpass.Name = "txt_confirmpass";
            txt_confirmpass.PasswordChar = '*';
            txt_confirmpass.Size = new Size(279, 41);
            txt_confirmpass.TabIndex = 31;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.FromArgb(230, 231, 233);
            txt_phone.BorderStyle = BorderStyle.None;
            txt_phone.Font = new Font("MS UI Gothic", 13.8F);
            txt_phone.Location = new Point(639, 224);
            txt_phone.Margin = new Padding(4, 3, 4, 3);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(279, 41);
            txt_phone.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(638, 201);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 35;
            label5.Text = "Phone Number";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.FromArgb(61, 162, 166);
            btn_back.Location = new Point(670, 592);
            btn_back.Margin = new Padding(4, 3, 4, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(221, 47);
            btn_back.TabIndex = 39;
            btn_back.Text = "Back To LOGIN";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(164, 165, 196);
            label9.Location = new Point(680, 566);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 20);
            label9.TabIndex = 38;
            label9.Text = "Already Have an Account";
            // 
            // btn_register
            // 
            btn_register.BorderRadius = 9;
            btn_register.CustomizableEdges = customizableEdges3;
            btn_register.DisabledState.BorderColor = Color.DarkGray;
            btn_register.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_register.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_register.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_register.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_register.FillColor = Color.FromArgb(205, 231, 135);
            btn_register.FillColor2 = Color.FromArgb(76, 169, 163);
            btn_register.Font = new Font("Segoe UI", 9F);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(670, 443);
            btn_register.Name = "btn_register";
            btn_register.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_register.Size = new Size(221, 47);
            btn_register.TabIndex = 40;
            btn_register.Text = "REGISTER";
            btn_register.Click += btn_register_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.BorderColor = Color.FromArgb(61, 162, 166);
            btn_clear.BorderRadius = 9;
            btn_clear.BorderThickness = 1;
            btn_clear.CustomizableEdges = customizableEdges5;
            btn_clear.DisabledState.BorderColor = Color.DarkGray;
            btn_clear.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_clear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_clear.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_clear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_clear.FillColor = Color.White;
            btn_clear.FillColor2 = Color.White;
            btn_clear.Font = new Font("Segoe UI", 9F);
            btn_clear.ForeColor = Color.FromArgb(92, 177, 159);
            btn_clear.Location = new Point(670, 496);
            btn_clear.Name = "btn_clear";
            btn_clear.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_clear.Size = new Size(221, 47);
            btn_clear.TabIndex = 41;
            btn_clear.Text = "CLEAR";
            btn_clear.Click += btn_clear_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(956, 645);
            Controls.Add(btn_clear);
            Controls.Add(btn_register);
            Controls.Add(btn_back);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(txt_phone);
            Controls.Add(label2);
            Controls.Add(txt_confirmpass);
            Controls.Add(cb_show);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(btn_close);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Controls.Add(guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Button btn_close;
        private Label label7;
        private Label label1;
        private TextBox txt_username;
        private CheckBox cb_show;
        private Label label4;
        private Label label3;
        private TextBox txt_password;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_confirmpass;
        private TextBox txt_phone;
        private Label label5;
        private Button btn_back;
        private Label label9;
        private Guna.UI2.WinForms.Guna2GradientButton btn_register;
        private Guna.UI2.WinForms.Guna2GradientButton btn_clear;
    }
}