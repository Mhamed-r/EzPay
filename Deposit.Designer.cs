namespace EzPay
{
    partial class Deposit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel_creditcard = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            nud_amount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btn_cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_addcard = new Guna.UI2.WinForms.Guna2GradientButton();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)nud_amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_creditcard
            // 
            panel_creditcard.BackColor = Color.Transparent;
            panel_creditcard.BorderRadius = 25;
            panel_creditcard.CustomizableEdges = customizableEdges1;
            panel_creditcard.Location = new Point(35, 357);
            panel_creditcard.Name = "panel_creditcard";
            panel_creditcard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panel_creditcard.Size = new Size(413, 221);
            panel_creditcard.TabIndex = 86;
            // 
            // nud_amount
            // 
            nud_amount.BackColor = Color.Transparent;
            nud_amount.BorderRadius = 8;
            nud_amount.CustomizableEdges = customizableEdges3;
            nud_amount.DecimalPlaces = 2;
            nud_amount.Font = new Font("Segoe UI", 9F);
            nud_amount.Location = new Point(135, 243);
            nud_amount.Margin = new Padding(3, 4, 3, 4);
            nud_amount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_amount.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_amount.Name = "nud_amount";
            nud_amount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            nud_amount.Size = new Size(139, 38);
            nud_amount.TabIndex = 85;
            nud_amount.UpDownButtonFillColor = Color.FromArgb(40, 89, 255);
            nud_amount.UpDownButtonForeColor = Color.Black;
            nud_amount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.BorderColor = Color.FromArgb(213, 218, 223);
            btn_cancel.BorderRadius = 9;
            btn_cancel.BorderThickness = 1;
            btn_cancel.CustomizableEdges = customizableEdges5;
            btn_cancel.DisabledState.BorderColor = Color.DarkGray;
            btn_cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_cancel.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_cancel.FillColor = Color.White;
            btn_cancel.FillColor2 = Color.White;
            btn_cancel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btn_cancel.ForeColor = Color.Black;
            btn_cancel.HoverState.BorderColor = Color.White;
            btn_cancel.HoverState.FillColor = Color.Red;
            btn_cancel.HoverState.FillColor2 = Color.Red;
            btn_cancel.HoverState.ForeColor = Color.White;
            btn_cancel.Location = new Point(52, 625);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_cancel.Size = new Size(193, 50);
            btn_cancel.TabIndex = 84;
            btn_cancel.Text = "Cancel";
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_addcard
            // 
            btn_addcard.BackColor = Color.Transparent;
            btn_addcard.BorderRadius = 9;
            btn_addcard.CustomizableEdges = customizableEdges7;
            btn_addcard.DisabledState.BorderColor = Color.DarkGray;
            btn_addcard.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_addcard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_addcard.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_addcard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_addcard.FillColor = Color.FromArgb(40, 89, 255);
            btn_addcard.FillColor2 = Color.FromArgb(40, 89, 255);
            btn_addcard.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btn_addcard.ForeColor = Color.White;
            btn_addcard.Location = new Point(294, 625);
            btn_addcard.Name = "btn_addcard";
            btn_addcard.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_addcard.Size = new Size(193, 50);
            btn_addcard.TabIndex = 83;
            btn_addcard.Text = "Continue";
            btn_addcard.Click += btn_addcard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 315);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 82;
            label1.Text = "Payment Method:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 250);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 81;
            label2.Text = "Amount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 17);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 80;
            label8.Text = "Add Money";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges9;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(72, 32);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2PictureBox1.Size = new Size(376, 186);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 68;
            guna2PictureBox1.TabStop = false;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(523, 701);
            Controls.Add(panel_creditcard);
            Controls.Add(nud_amount);
            Controls.Add(btn_cancel);
            Controls.Add(btn_addcard);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)nud_amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_creditcard;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_amount;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cancel;
        private Guna.UI2.WinForms.Guna2GradientButton btn_addcard;
        private Label label1;
        private Label label2;
        private Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}