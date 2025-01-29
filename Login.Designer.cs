namespace EzPay
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_close = new Button();
            btn_back = new Button();
            label9 = new Label();
            cb_show = new CheckBox();
            txt_password = new TextBox();
            label1 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            btn_login = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.White;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.Red;
            btn_close.Location = new Point(408, -2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(27, 47);
            btn_close.TabIndex = 21;
            btn_close.Text = "✗";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btn_back.ForeColor = Color.FromArgb(61, 162, 166);
            btn_back.Location = new Point(106, 621);
            btn_back.Margin = new Padding(4, 3, 4, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(221, 47);
            btn_back.TabIndex = 48;
            btn_back.Text = "Create Account";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(164, 165, 196);
            label9.Location = new Point(137, 595);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(158, 20);
            label9.TabIndex = 47;
            label9.Text = "Dont Have an Account";
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.Cursor = Cursors.Hand;
            cb_show.FlatStyle = FlatStyle.Flat;
            cb_show.Location = new Point(251, 492);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(124, 24);
            cb_show.TabIndex = 46;
            cb_show.Text = "ShowPassword";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(230, 231, 233);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("MS UI Gothic", 13.8F);
            txt_password.Location = new Point(87, 443);
            txt_password.Margin = new Padding(4, 3, 4, 3);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(279, 41);
            txt_password.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(164, 165, 196);
            label1.Location = new Point(87, 325);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 43;
            label1.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.FromArgb(230, 231, 233);
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(87, 351);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(279, 41);
            txt_email.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(164, 165, 196);
            label3.Location = new Point(87, 417);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 51;
            label3.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BorderRadius = 9;
            btn_login.CustomizableEdges = customizableEdges1;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.FillColor = Color.FromArgb(205, 231, 135);
            btn_login.FillColor2 = Color.FromArgb(76, 169, 163);
            btn_login.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(106, 533);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_login.Size = new Size(221, 47);
            btn_login.TabIndex = 52;
            btn_login.Text = "LOGIN";
            btn_login.Click += btn_login_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-4, -2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(439, 315);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 53;
            guna2PictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(435, 687);
            Controls.Add(btn_close);
            Controls.Add(guna2PictureBox1);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(btn_back);
            Controls.Add(label9);
            Controls.Add(cb_show);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_email);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_registration;
        private Button btn_close;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_clear;
        private Guna.UI2.WinForms.Guna2GradientButton btn_login;
        private Button btn_back;
        private Label label9;
        private CheckBox cb_show;
        private TextBox txt_password;
        private Label label1;
        private TextBox txt_email;
        private Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

        //private Guna.UI2.WinForms.Guna2GradientButton btn_login;
        //private Guna.UI2.WinForms.Guna2GradientButton btn_registration;
    }
}