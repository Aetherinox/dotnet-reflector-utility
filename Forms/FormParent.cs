using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace ReflectorKG
{

    public partial class FormParent : Form
    {
        private Serial Serial       = new Serial( );
        private Response Response   = new Response( );

        /*
            Frame > Parent
        */

        public FormParent( )
        {
            InitializeComponent( );
            this.statusStrip.Renderer       = new StatusBar_Renderer( );
        }


        /*
            Frame > Parent > Load
        */

        private void FormParent_Load( object sender, EventArgs e )
        {
            mnuTop.Renderer                 = new ToolStripProfessionalRenderer( new mnuTop_ColorTable( ) );
            toolStripStatusLabel1.Text      = string.Format( "Press Generate to create serial number ..." );
            statusStrip.Refresh( );

            /*
                combo > editions > populate
            */

           string[] lst_editions = ConfigurationManager.AppSettings["editions_list"].Split(',');

            for (int i = 0; i < lst_editions.Length; i++)
            {
                cboEditions.Items.Add(lst_editions[i]);
            }

            /*
                combo > editions > default
            */

            string v_def_edition = ConfigurationManager.AppSettings["edition_default"];
            cboEditions.SelectedIndex = cboEditions.FindStringExact(v_def_edition);

            /*
                users > default
            */

            string def_users = ConfigurationManager.AppSettings["users_min_default"];
            txtUsers.Text = def_users;
        }

        /*
            Window > Button > Minimize > Click
        */

        private void btn_Window_Minimize_Click( object sender, EventArgs e )
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
            Window > Button > Minimize > Mouse Enter
        */

        private void btn_Window_Minimize_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.ForeColor = Color.FromArgb(222, 31, 100);
        }

        /*
            Window > Button > Minimize > Mouse Leave
        */

        private void btn_Window_Minimize_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        /*
            Window > Button > Close > Click
        */

        private void btn_Window_Close_Click( object sender, EventArgs e )
        {
            Application.Exit( );
        }

        /*
            Window > Button > Close > Mouse Enter
        */

        private void btn_Window_Close_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.FromArgb(222, 31, 100);
        }

        /*
            Window > Button > Close > Mouse Leave
        */

        private void btn_Window_Close_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        /*
            button > Generate > OnClick
        */

        private void btn_Generate_Click( object sender, EventArgs e )
        {
            string usersInput               = txtUsers.Text;
            serialTextbox.Text              = Serial.Generate( );
            toolStripStatusLabel1.Text      = string.Format( "Serial number generated. Paste into .NET Reflector app." );
            statusStrip.Refresh( );

            Debug.WriteLine( usersInput );
        }

        /*
            Main Form > Mouse Down
            deals with moving form around on screen
        */

        private bool mouseDown;
        private Point lastLocation;

        private void MainForm_MouseDown( object sender, MouseEventArgs e )
        {
            mouseDown       = true;
            lastLocation    = e.Location;
        }

        /*
            Main Form > Mouse Up
            deals with moving form around on screen
        */

        private void MainForm_MouseUp( object sender, MouseEventArgs e )
        {
            mouseDown = false;
        }

        /*
            Main Form > Mouse Move
            deals with moving form around on screen
        */

        private void MainForm_MouseMove( object sender, MouseEventArgs e )
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    ( this.Location.X - lastLocation.X ) + e.X, ( this.Location.Y - lastLocation.Y ) + e.Y );

                this.Update( );
            }
        }

        /*
            Label > Window Title
        */

        private void lbl_Title_Click( object sender, EventArgs e )
        {

        }

        /*
            Label > Users
        */

        private void lbl_Users_Click( object sender, EventArgs e )
        {
            
        }

        /*
            Top Menu > File > Exit
        */

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit( );
        }

        /*
            Top Menu > Help > About
        */

        private void aboutToolStripMenuItem1_Click( object sender, EventArgs e )
        {
            FormAbout to = new FormAbout( );
            to.TopMost = true;
            to.Show( );
        }

        /*
            Top Menu > Click Item
        */

        private void mnuTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Debug.WriteLine("Clicked");
        }

        /*
            Status Bar > Color Table
        */

        public class ClrTable : ProfessionalColorTable
        {
            public override Color StatusStripGradientBegin => Color.FromArgb( 35, 35, 35 );
            public override Color StatusStripGradientEnd => Color.FromArgb( 35, 35, 35 );
        }

        /*
            Status Bar > Renderer
            Override colors
        */

        public class StatusBar_Renderer : ToolStripProfessionalRenderer
        {
            public StatusBar_Renderer( ) : base( new ClrTable() ) { }

            protected override void OnRenderToolStripBorder( ToolStripRenderEventArgs e )
            {
                if (!( e.ToolStrip is StatusStrip ) ) base.OnRenderToolStripBorder( e );
            }
        }

        /*
            Top Menu > Override Render Colors
        */

        public class mnuTop_ColorTable : ProfessionalColorTable
        {

            /*
                Gets the starting color of the gradient used when 
                a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
            */

            public override Color MenuItemPressedGradientBegin => Color.FromArgb( 55, 55, 55 );

            /*
                Gets the end color of the gradient used when a top-level
                System.Windows.Forms.ToolStripMenuItem is pressed.
            */

            public override Color MenuItemPressedGradientEnd => Color.FromArgb( 55, 55, 55 );

            /*
                Gets the border color to use with a 
                System.Windows.Forms.ToolStripMenuItem.
            */

            public override Color MenuItemBorder => Color.FromArgb( 0, 45, 45, 45 );

            /*
                Gets the starting color of the gradient used when the 
                System.Windows.Forms.ToolStripMenuItem is selected.
            */

            public override Color MenuItemSelectedGradientBegin => Color.FromArgb( 222, 31, 103 );

            /*
                Gets the end color of the gradient used when the 
                System.Windows.Forms.ToolStripMenuItem is selected.
            */

            public override Color MenuItemSelectedGradientEnd => Color.FromArgb( 222, 31, 103 );

            /*
                Gets the solid background color of the 
                System.Windows.Forms.ToolStripDropDown.
            */

            public override Color ToolStripDropDownBackground => Color.FromArgb( 40, 40, 40 );

            /*
                Top Menu > Image > Start Gradient Color
            */

            public override Color ImageMarginGradientBegin => Color.FromArgb(222, 31, 103);

            /*
                Top Menu > Image > Middle Gradient Color
            */

            public override Color ImageMarginGradientMiddle => Color.FromArgb(222, 31, 103);

            /*
                Top Menu > Image > End Gradient Color
            */

            public override Color ImageMarginGradientEnd => Color.FromArgb(222, 31, 103);

            /*
                Top Menu > Shadow Effect
            */

            public override Color SeparatorDark => Color.FromArgb(0, 45, 45, 45);

            /*
                Top Menu > Border Color
            */

            public override Color MenuBorder => Color.FromArgb(0, 45, 45, 45);

            /*
                 Top Menu > Item Hover BG Color
             */

            public override Color MenuItemSelected => Color.FromArgb(222, 31, 103);

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /*
            Button > Copy generated serial number
        */

        private void btn_Copy_Click( object sender, EventArgs e )
        {
            if ( string.IsNullOrEmpty( serialTextbox.Text ) )
            {
                toolStripStatusLabel1.Text      = string.Format( "Generate serial number first" );
                statusStrip.Refresh( );
            }
            else
            {
                Clipboard.SetText( serialTextbox.Text );

                toolStripStatusLabel1.Text      = string.Format( "Serial number copied. Paste in Reflector app." );
                statusStrip.Refresh( );
            }
        }

        /*
            Label > Body
                "Click Generate button and copy the serial number below, and paste into .NET Reflector."
        */

        private void lbl_ClickToGenerate_Click( object sender, EventArgs e )
        {

        }

        /*
            Label > Sub Header
                "Generated serial key"
        */

        private void lbl_Serial_Sub_Click( object sender, EventArgs e )
        {

        }

        /*
            Label > Body
                "Click the "Generate" button below to create a number number."
        */

        private void lbl_Serial_Body_Click( object sender, EventArgs e )
        {

        }

        /*
            Group box for activation + generated response boxes

            paint custom borders because default borders looks like shit
        */

        private void grpBox_Paint(object sender, PaintEventArgs e)
        {

            // border color
            Pen p = new Pen(Color.FromArgb(75, 75, 75));

            // left
            e.Graphics.DrawLine(p, 0, 1, 0, e.ClipRectangle.Height - 1);

            // top
            e.Graphics.DrawLine(p, 1, 1, e.ClipRectangle.Width - 1, 1);

            // right
            e.Graphics.DrawLine(p, e.ClipRectangle.Width - 1, 1, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);

            // bottom
            e.Graphics.DrawLine(p, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 0, e.ClipRectangle.Height - 1);
        }

        /*
            Section Label > Generated Response
        */

        private void lbl_Response_Click(object sender, EventArgs e)
        {

        }

        /*
            Text Box > Generated Response
        */

        private void txt_Response_TextChanged(object sender, EventArgs e)
        {

        }

        /*
            Label > Generated Response
        */

        private void lbl_Response_Sub_Click(object sender, EventArgs e)
        {

        }

        /*
            Label > Activation Request
        */

        private void lbl_Request_Sub_Click(object sender, EventArgs e)
        {

        }

        /*
            Section Label > Activation Request
        */

        private void lbl_Reqest_Click(object sender, EventArgs e)
        {

        }

        /*
            Text Box > Activation Response
        */

        private void txt_Request_TextChanged(object sender, EventArgs e)
        {
            string text = requestTextbox.Text;
            if ( string.IsNullOrEmpty( text ) )
            {
                requestTextbox.Text = "";
                return;
            }

            try
            {
                string sel_edition      = cboEditions.Text;
                string sel_users        = txtUsers.Text;
                responseTextbox.Text    = Response.Generate( text, sel_users, sel_edition);
            }
            catch (Exception ex)
            {
                responseTextbox.Text = "";
                MessageBox.Show("This does not appear to be valid: Text must start and end with <activationrequest>Valid XML</activationrequest> \n\n" + ex.Message, "Invalid paste provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
            Text Box > Serial > OnTextChanged
        */

        private void txt_Serial_TextChanged(object sender, EventArgs e)
        {

        }

        /*
            Text Box > Users > OnTextChanged

            specifies how many users a license is valid for.
            Not super important, but we'll do it anyway.
        */

        private void txt_Users_TextChanged(object sender, EventArgs e)
        {
            int i_min_users = Int32.Parse(ConfigurationManager.AppSettings["users_min_default"]);
            int i_max_users = Int32.Parse(ConfigurationManager.AppSettings["users_max_default"]);

            // limit input to numbers only
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUsers.Text, "[^1-9]"))
            {
                MessageBox.Show("Numbers are 1, 2, 3, - " + i_max_users.ToString( ), "Not a valid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsers.Text = i_min_users.ToString();
            }

            else
            {
                if(!string.IsNullOrEmpty(txtUsers.Text.ToString()))
                {
                    if (Convert.ToInt32(txtUsers.Text) > i_max_users || Convert.ToInt32(txtUsers.Text) < i_min_users)
                    {
                        MessageBox.Show("Must be between " + i_min_users + " and " + i_max_users, "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsers.Text = i_min_users.ToString();
                    }
                }
            }
        }

        /*
            Label > Editions
        */

        private void lbl_Editions_Click(object sender, EventArgs e)
        {

        }

        /*
            Dropdown > Editions
        */

        private void cbo_Editions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
            Button > Paste Request into Textbox
        */

        private void btn_Request_Paste_Click(object sender, EventArgs e)
        {
            requestTextbox.Text = Clipboard.GetText();
        }

        /*
            Button > Copy Response from Textbox
        */

        private void btn_Response_Copy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(responseTextbox.Text))
            {
                toolStripStatusLabel1.Text = string.Format("Cannot paste an empty clipboard");
                MessageBox.Show("Nothing to copy. Go back to .NET Reflector and copy the text in the left-side box, then paste it into the left side box of this tool.", "Invalid Activation Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusStrip.Refresh();
            }
            else
            {
                Clipboard.SetText(responseTextbox.Text);

                toolStripStatusLabel1.Text = string.Format("Response copied. Go back to .NET Reflector and paste what you copied into the right-side box.");
                statusStrip.Refresh();
            }
        }

        /*
            Button > Activation Request > Load File
        */

        private void btn_Request_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open text file";
            dlg.InitialDirectory = @"c:\";

            dlg.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = File.OpenText(dlg.FileName);

                string s = sr.ReadLine();
                StringBuilder sb = new StringBuilder();
                while (s != null)
                {
                    sb.Append(s);
                    s = sr.ReadLine();
                }
                sr.Close();
                requestTextbox.Text = sb.ToString();

                toolStripStatusLabel1.Text = string.Format("Loaded Activation Request from " + dlg.FileName);
                statusStrip.Refresh();
            }
        }

        /*
            Button > Generated Response > Save File
        */

        private void btn_Response_Save_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(requestTextbox.Text))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = "activator";
                dlg.Title = "Save Generated Response";
                dlg.CheckPathExists = true;
                dlg.InitialDirectory = @"c:\";
                dlg.DefaultExt = "txt";
                dlg.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(dlg.FileName))
                    {
                        foreach (string line in requestTextbox.Lines)
                        {
                            sw.WriteLine(line);
                        }

                        MessageBox.Show("Successfully saved Generated Response to file. Load it into .NET Reflector in the right side box.", "Generated Response Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        string file_path = dlg.FileName;
                        toolStripStatusLabel1.Text = string.Format("Saved generation response " + file_path);
                        statusStrip.Refresh();

                    }
                }
            }
            else
            {
                MessageBox.Show("Can't save an empty Generated Response.\n\nCreate a valid Activation Request in order to get a Generated Response.", "No Generated Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
