using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace ReflectorKG
{
    partial class FormParent
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

        /*
            Main Form > Rectangle
        */

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen clr_border = new Pen( Color.FromArgb( 75, 75, 75 ) );
            e.Graphics.DrawRectangle( clr_border, 0, 0, Width - 1, Height - 1 );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParent));
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.serialTextbox = new System.Windows.Forms.TextBox();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.requestTextbox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.responseTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Response_Save = new System.Windows.Forms.Button();
            this.btn_Request_Load = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Response_Copy = new System.Windows.Forms.Button();
            this.btn_Request_Paste = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEditions = new System.Windows.Forms.ComboBox();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuTop.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.Location = new System.Drawing.Point(731, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(13, 32);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.Text = "―";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBtn.Click += new System.EventHandler(this.btn_Window_Minimize_Click);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.btn_Window_Minimize_MouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.btn_Window_Minimize_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(756, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 32);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.btn_Window_Close_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.btn_Window_Close_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.btn_Window_Close_MouseLeave);
            // 
            // serialTextbox
            // 
            this.serialTextbox.BackColor = System.Drawing.Color.White;
            this.serialTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serialTextbox.CausesValidation = false;
            this.serialTextbox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.serialTextbox.Location = new System.Drawing.Point(24, 142);
            this.serialTextbox.MaxLength = 100;
            this.serialTextbox.Name = "serialTextbox";
            this.serialTextbox.ReadOnly = true;
            this.serialTextbox.Size = new System.Drawing.Size(546, 29);
            this.serialTextbox.TabIndex = 2;
            this.serialTextbox.WordWrap = false;
            this.serialTextbox.TextChanged += new System.EventHandler(this.txt_Serial_TextChanged);
            // 
            // txtUsers
            // 
            this.txtUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsers.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtUsers.Location = new System.Drawing.Point(576, 142);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtUsers.MaxLength = 2;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(58, 29);
            this.txtUsers.TabIndex = 13;
            this.txtUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsers.WordWrap = false;
            this.txtUsers.TextChanged += new System.EventHandler(this.txt_Users_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(103)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(24, 177);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(111, 29);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // requestTextbox
            // 
            this.requestTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.requestTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTextbox.ForeColor = System.Drawing.Color.White;
            this.requestTextbox.Location = new System.Drawing.Point(20, 44);
            this.requestTextbox.Name = "requestTextbox";
            this.requestTextbox.Size = new System.Drawing.Size(338, 161);
            this.requestTextbox.TabIndex = 4;
            this.requestTextbox.Text = "";
            this.requestTextbox.TextChanged += new System.EventHandler(this.txt_Request_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(100)))));
            this.titleLabel.Location = new System.Drawing.Point(19, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(325, 30);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = ".NET Reflector License Generator";
            this.titleLabel.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(20, 88);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(151, 21);
            this.serialLabel.TabIndex = 6;
            this.serialLabel.Text = "Generated serial key";
            this.serialLabel.Click += new System.EventHandler(this.lbl_Serial_Sub_Click);
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.requestLabel.Location = new System.Drawing.Point(16, 15);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.requestLabel.Size = new System.Drawing.Size(139, 21);
            this.requestLabel.TabIndex = 7;
            this.requestLabel.Text = "Activation Request";
            this.requestLabel.Click += new System.EventHandler(this.lbl_Reqest_Click);
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(394, 15);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(153, 21);
            this.responseLabel.TabIndex = 9;
            this.responseLabel.Text = "Generated Response";
            this.responseLabel.Click += new System.EventHandler(this.lbl_Response_Click);
            // 
            // responseTextbox
            // 
            this.responseTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.responseTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.responseTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTextbox.ForeColor = System.Drawing.Color.White;
            this.responseTextbox.Location = new System.Drawing.Point(398, 44);
            this.responseTextbox.Name = "responseTextbox";
            this.responseTextbox.ReadOnly = true;
            this.responseTextbox.Size = new System.Drawing.Size(338, 161);
            this.responseTextbox.TabIndex = 8;
            this.responseTextbox.Text = "";
            this.responseTextbox.TextChanged += new System.EventHandler(this.txt_Response_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click the \"Generate\" button below to create a serial number.";
            this.label1.Click += new System.EventHandler(this.lbl_Serial_Body_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(21, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Paste serial number in .NET Reflector and select \"Activate Manually\".";
            this.label2.Click += new System.EventHandler(this.lbl_ClickToGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btn_Response_Save);
            this.panel1.Controls.Add(this.btn_Request_Load);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Response_Copy);
            this.panel1.Controls.Add(this.btn_Request_Paste);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.requestLabel);
            this.panel1.Controls.Add(this.responseLabel);
            this.panel1.Controls.Add(this.responseTextbox);
            this.panel1.Controls.Add(this.requestTextbox);
            this.panel1.Location = new System.Drawing.Point(24, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 274);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBox_Paint);
            // 
            // btn_Response_Save
            // 
            this.btn_Response_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(103)))));
            this.btn_Response_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Response_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Response_Save.FlatAppearance.BorderSize = 0;
            this.btn_Response_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Response_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Response_Save.Location = new System.Drawing.Point(689, 219);
            this.btn_Response_Save.Name = "btn_Response_Save";
            this.btn_Response_Save.Size = new System.Drawing.Size(47, 26);
            this.btn_Response_Save.TabIndex = 24;
            this.btn_Response_Save.Text = "Save";
            this.btn_Response_Save.UseVisualStyleBackColor = false;
            this.btn_Response_Save.Click += new System.EventHandler(this.btn_Response_Save_Click);
            // 
            // btn_Request_Load
            // 
            this.btn_Request_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(103)))));
            this.btn_Request_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Request_Load.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Request_Load.FlatAppearance.BorderSize = 0;
            this.btn_Request_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Request_Load.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Request_Load.Location = new System.Drawing.Point(311, 219);
            this.btn_Request_Load.Name = "btn_Request_Load";
            this.btn_Request_Load.Size = new System.Drawing.Size(47, 26);
            this.btn_Request_Load.TabIndex = 23;
            this.btn_Request_Load.Text = "Load";
            this.btn_Request_Load.UseVisualStyleBackColor = false;
            this.btn_Request_Load.Click += new System.EventHandler(this.btn_Request_Load_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Response_Copy
            // 
            this.btn_Response_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(103)))));
            this.btn_Response_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Response_Copy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Response_Copy.FlatAppearance.BorderSize = 0;
            this.btn_Response_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Response_Copy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Response_Copy.Location = new System.Drawing.Point(617, 219);
            this.btn_Response_Copy.Name = "btn_Response_Copy";
            this.btn_Response_Copy.Size = new System.Drawing.Size(66, 26);
            this.btn_Response_Copy.TabIndex = 21;
            this.btn_Response_Copy.Text = "Copy";
            this.btn_Response_Copy.UseVisualStyleBackColor = false;
            this.btn_Response_Copy.Click += new System.EventHandler(this.btn_Response_Copy_Click);
            // 
            // btn_Request_Paste
            // 
            this.btn_Request_Paste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(103)))));
            this.btn_Request_Paste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Request_Paste.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Request_Paste.FlatAppearance.BorderSize = 0;
            this.btn_Request_Paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Request_Paste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Request_Paste.Location = new System.Drawing.Point(239, 219);
            this.btn_Request_Paste.Name = "btn_Request_Paste";
            this.btn_Request_Paste.Size = new System.Drawing.Size(66, 26);
            this.btn_Request_Paste.TabIndex = 20;
            this.btn_Request_Paste.Text = "Paste";
            this.btn_Request_Paste.UseVisualStyleBackColor = false;
            this.btn_Request_Paste.Click += new System.EventHandler(this.btn_Request_Paste_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.Location = new System.Drawing.Point(395, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 43);
            this.label4.TabIndex = 13;
            this.label4.Text = "Copy and paste the Response above back into .NET Reflector on right side.";
            this.label4.Click += new System.EventHandler(this.lbl_Response_Sub_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.Location = new System.Drawing.Point(20, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "In .NET Reflector, copy the contents in the left box, and paste above.";
            this.label3.Click += new System.EventHandler(this.lbl_Request_Sub_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.Location = new System.Drawing.Point(576, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Users";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.lbl_Users_Click);
            // 
            // cboEditions
            // 
            this.cboEditions.DropDownHeight = 100;
            this.cboEditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEditions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboEditions.IntegralHeight = false;
            this.cboEditions.ItemHeight = 21;
            this.cboEditions.Location = new System.Drawing.Point(641, 142);
            this.cboEditions.Name = "cboEditions";
            this.cboEditions.Size = new System.Drawing.Size(139, 29);
            this.cboEditions.TabIndex = 15;
            this.cboEditions.SelectedIndexChanged += new System.EventHandler(this.cbo_Editions_SelectedIndexChanged);
            // 
            // mnuTop
            // 
            this.mnuTop.AutoSize = false;
            this.mnuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mnuTop.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuTop.GripMargin = new System.Windows.Forms.Padding(12, 2, 0, 2);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(1, 46);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuTop.Size = new System.Drawing.Size(798, 32);
            this.mnuTop.TabIndex = 16;
            this.mnuTop.Text = "menuStrip1";
            this.mnuTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuTop_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 28);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ForeColor = System.Drawing.Color.Red;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(1, 556);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(798, 28);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.LinkVisited = true;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(103)))));
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(141, 177);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(111, 29);
            this.btnCopy.TabIndex = 18;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.Location = new System.Drawing.Point(641, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Edition";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.lbl_Editions_Click);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.cboEditions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.serialTextbox);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.FormParent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimizeBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.TextBox serialTextbox;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox requestTextbox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.RichTextBox responseTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEditions;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label6;
        private Button btn_Response_Copy;
        private Button btn_Request_Paste;
        private PictureBox pictureBox1;
        private Button btn_Request_Load;
        private Button btn_Response_Save;
    }
}

