namespace baitaplon
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.panel_pageHolder = new System.Windows.Forms.Panel();
            this.Gpanel_slideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.label_sign = new System.Windows.Forms.Label();
            this.spBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.nccBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gImage_SignIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label_tittlePage = new System.Windows.Forms.Label();
            this.panel_tittle = new System.Windows.Forms.Panel();
            this.Gpanel_slideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gImage_SignIcon)).BeginInit();
            this.panel_tittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.transition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation3;
            this.transition.Interval = 1000;
            // 
            // panel_pageHolder
            // 
            this.panel_pageHolder.AutoScroll = true;
            this.panel_pageHolder.BackColor = System.Drawing.Color.Silver;
            this.transition.SetDecoration(this.panel_pageHolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel_pageHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pageHolder.Location = new System.Drawing.Point(180, 57);
            this.panel_pageHolder.Name = "panel_pageHolder";
            this.panel_pageHolder.Size = new System.Drawing.Size(749, 442);
            this.panel_pageHolder.TabIndex = 2;
            // 
            // Gpanel_slideBar
            // 
            this.Gpanel_slideBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Gpanel_slideBar.Controls.Add(this.label_sign);
            this.Gpanel_slideBar.Controls.Add(this.spBtn);
            this.Gpanel_slideBar.Controls.Add(this.nccBtn);
            this.Gpanel_slideBar.Controls.Add(this.gImage_SignIcon);
            this.transition.SetDecoration(this.Gpanel_slideBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Gpanel_slideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Gpanel_slideBar.Location = new System.Drawing.Point(0, 0);
            this.Gpanel_slideBar.Name = "Gpanel_slideBar";
            this.Gpanel_slideBar.Size = new System.Drawing.Size(180, 499);
            this.Gpanel_slideBar.TabIndex = 4;
            this.Gpanel_slideBar.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.Gpanel_slideBar.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // label_sign
            // 
            this.label_sign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sign.AutoSize = true;
            this.transition.SetDecoration(this.label_sign, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_sign.Location = new System.Drawing.Point(12, 465);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(130, 16);
            this.label_sign.TabIndex = 3;
            this.label_sign.Text = "#develop_by_giatoc";
            // 
            // spBtn
            // 
            this.spBtn.Animated = true;
            this.spBtn.BackColor = System.Drawing.Color.Transparent;
            this.spBtn.BorderColor = System.Drawing.Color.DimGray;
            this.transition.SetDecoration(this.spBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.spBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.spBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.spBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.spBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.spBtn.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.spBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.spBtn.ForeColor = System.Drawing.Color.White;
            this.spBtn.Location = new System.Drawing.Point(0, 235);
            this.spBtn.Name = "spBtn";
            this.spBtn.Size = new System.Drawing.Size(178, 55);
            this.spBtn.TabIndex = 2;
            this.spBtn.Text = "SẢN PHẨM";
            this.spBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spBtn.UseTransparentBackground = true;
            this.spBtn.Click += new System.EventHandler(this.spBtn_Click_1);
            this.spBtn.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.spBtn.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // nccBtn
            // 
            this.nccBtn.Animated = true;
            this.nccBtn.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.nccBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nccBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nccBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nccBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nccBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nccBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nccBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nccBtn.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.nccBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nccBtn.ForeColor = System.Drawing.Color.White;
            this.nccBtn.Location = new System.Drawing.Point(0, 178);
            this.nccBtn.Name = "nccBtn";
            this.nccBtn.Size = new System.Drawing.Size(178, 52);
            this.nccBtn.TabIndex = 1;
            this.nccBtn.Text = "NHÀ CUNG CẤP";
            this.nccBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nccBtn.UseTransparentBackground = true;
            this.nccBtn.Click += new System.EventHandler(this.nccBtn_Click);
            this.nccBtn.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.nccBtn.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // gImage_SignIcon
            // 
            this.transition.SetDecoration(this.gImage_SignIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gImage_SignIcon.Image = ((System.Drawing.Image)(resources.GetObject("gImage_SignIcon.Image")));
            this.gImage_SignIcon.ImageRotate = 0F;
            this.gImage_SignIcon.Location = new System.Drawing.Point(27, 28);
            this.gImage_SignIcon.Name = "gImage_SignIcon";
            this.gImage_SignIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gImage_SignIcon.Size = new System.Drawing.Size(132, 125);
            this.gImage_SignIcon.TabIndex = 0;
            this.gImage_SignIcon.TabStop = false;
            this.gImage_SignIcon.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.gImage_SignIcon.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // label_tittlePage
            // 
            this.label_tittlePage.AutoSize = true;
            this.transition.SetDecoration(this.label_tittlePage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_tittlePage.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tittlePage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_tittlePage.Location = new System.Drawing.Point(11, 15);
            this.label_tittlePage.Name = "label_tittlePage";
            this.label_tittlePage.Size = new System.Drawing.Size(175, 31);
            this.label_tittlePage.TabIndex = 0;
            this.label_tittlePage.Text = "NHÀ CUNG CẤP";
            // 
            // panel_tittle
            // 
            this.panel_tittle.AllowDrop = true;
            this.panel_tittle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_tittle.Controls.Add(this.label_tittlePage);
            this.transition.SetDecoration(this.panel_tittle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel_tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tittle.Location = new System.Drawing.Point(180, 0);
            this.panel_tittle.Name = "panel_tittle";
            this.panel_tittle.Size = new System.Drawing.Size(749, 57);
            this.panel_tittle.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(929, 499);
            this.Controls.Add(this.panel_pageHolder);
            this.Controls.Add(this.panel_tittle);
            this.Controls.Add(this.Gpanel_slideBar);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gpanel_slideBar.ResumeLayout(false);
            this.Gpanel_slideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gImage_SignIcon)).EndInit();
            this.panel_tittle.ResumeLayout(false);
            this.panel_tittle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pageHolder;
        private Guna.UI2.WinForms.Guna2Panel Gpanel_slideBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gImage_SignIcon;
        private Guna.UI2.WinForms.Guna2GradientButton spBtn;
        private Guna.UI2.WinForms.Guna2GradientButton nccBtn;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private System.Windows.Forms.Label label_tittlePage;
        private System.Windows.Forms.Panel panel_tittle;
        private System.Windows.Forms.Label label_sign;
    }
}
