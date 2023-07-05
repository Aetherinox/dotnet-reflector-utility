using System.Drawing;
using System.Windows.Forms;

namespace ReflectorKG
{
    partial class FormAbout
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
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen clr_border = new Pen(Color.FromArgb(75, 75, 75));
            e.Graphics.DrawRectangle(clr_border, 0, 0, Width - 1, Height - 1);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.closeBtn = new System.Windows.Forms.Label();
            this.txt_Version = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lbl_Edu = new System.Windows.Forms.Label();
            this.lbl_TPBLink = new System.Windows.Forms.LinkLabel();
            this.lnk_Github = new System.Windows.Forms.LinkLabel();
            this.txt_Terms = new ReflectorKG.AetherxTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(482, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 22);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.btn_Window_Close_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.btn_Window_Close_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.btn_Window_Close_MouseLeave);
            // 
            // txt_Version
            // 
            this.txt_Version.AutoSize = true;
            this.txt_Version.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Version.ForeColor = System.Drawing.Color.White;
            this.txt_Version.Location = new System.Drawing.Point(126, 41);
            this.txt_Version.Name = "txt_Version";
            this.txt_Version.Size = new System.Drawing.Size(38, 15);
            this.txt_Version.TabIndex = 4;
            this.txt_Version.Text = "label1";
            this.txt_Version.Click += new System.EventHandler(this.lbl_Serial_Click);
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(100)))));
            this.lbl_Product.Location = new System.Drawing.Point(123, 9);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(78, 32);
            this.lbl_Product.TabIndex = 5;
            this.lbl_Product.Text = "label1";
            this.lbl_Product.Click += new System.EventHandler(this.lbl_Product_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(15, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(100, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.mat_Logo_Click);
            // 
            // lbl_Edu
            // 
            this.lbl_Edu.AutoSize = true;
            this.lbl_Edu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Edu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lbl_Edu.Location = new System.Drawing.Point(126, 81);
            this.lbl_Edu.Name = "lbl_Edu";
            this.lbl_Edu.Size = new System.Drawing.Size(309, 15);
            this.lbl_Edu.TabIndex = 8;
            this.lbl_Edu.Text = "Educational purposes only. No ads, no music, no bullshit.";
            // 
            // lbl_TPBLink
            // 
            this.lbl_TPBLink.AutoSize = true;
            this.lbl_TPBLink.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_TPBLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_TPBLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_TPBLink.Location = new System.Drawing.Point(125, 96);
            this.lbl_TPBLink.Name = "lbl_TPBLink";
            this.lbl_TPBLink.Size = new System.Drawing.Size(74, 19);
            this.lbl_TPBLink.TabIndex = 10;
            this.lbl_TPBLink.TabStop = true;
            this.lbl_TPBLink.Text = "TPB Profile";
            this.lbl_TPBLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLink_TPB_LinkClicked_1);
            // 
            // lnk_Github
            // 
            this.lnk_Github.AutoSize = true;
            this.lnk_Github.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnk_Github.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_Github.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lnk_Github.Location = new System.Drawing.Point(205, 96);
            this.lnk_Github.Name = "lnk_Github";
            this.lnk_Github.Size = new System.Drawing.Size(86, 19);
            this.lnk_Github.TabIndex = 14;
            this.lnk_Github.TabStop = true;
            this.lnk_Github.Text = "Github Repo";
            this.lnk_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Github_LinkClicked);
            // 
            // txt_Terms
            // 
            this.txt_Terms.AutoScroll = true;
            this.txt_Terms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Terms.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Terms.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Terms.BorderSize = 1;
            this.txt_Terms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Terms.ForeColor = System.Drawing.Color.White;
            this.txt_Terms.Location = new System.Drawing.Point(15, 128);
            this.txt_Terms.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Terms.Multiline = true;
            this.txt_Terms.Name = "txt_Terms";
            this.txt_Terms.Padding = new System.Windows.Forms.Padding(6);
            this.txt_Terms.PasswordChar = false;
            this.txt_Terms.ReadOnly = true;
            this.txt_Terms.Size = new System.Drawing.Size(488, 257);
            this.txt_Terms.TabIndex = 14;
            this.txt_Terms.UnderlineStyle = false;
            this.txt_Terms.Value = "";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(516, 399);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Terms);
            this.Controls.Add(this.lnk_Github);
            this.Controls.Add(this.lbl_TPBLink);
            this.Controls.Add(this.lbl_Edu);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.txt_Version);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeBtn;
        private Label txt_Version;
        private Label lbl_Product;
        private PictureBox imgLogo;
        private Label lbl_Edu;
        private LinkLabel lbl_TPBLink;
        private ReflectorKG.AetherxTextBox txt_Terms;
        private LinkLabel lnk_Github;
    }
}