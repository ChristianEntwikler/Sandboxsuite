using System;
using System.Drawing.Printing;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Sandbox_202138471
{
    public partial class Sandbox : Form
    {
        
        public Sandbox()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileCmd_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePathTxt.Text = folderBrowserDialog1.SelectedPath;
                    Environment.SpecialFolder root = folderBrowserDialog1.RootFolder;
                    pgmProcesslbl.Text = "Application path changed";
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void clearCmd_Click(object sender, EventArgs e)
        {
            argsTxt.Text = "";
        }

        private void checkCmd_Click(object sender, EventArgs e)
        {
            runProcess();
        }

        private void entryPointCmd_Click(object sender, EventArgs e)
        {
            entryPointtxt.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runProcess();
        }

        private void runProcess()
        {
            try
            { 
            if (filePathTxt.Text == "")
            {
                MessageBox.Show("Application path is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (classPathTxt.Text == "")
            {
                MessageBox.Show("Application class package / path is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] parameters = argsTxt.Text.Split(',');

                //Setting the permissions for the AppDomain.

                PermissionSet permSet = new PermissionSet(PermissionState.None);

                if (readCkb.Checked == true)
                {
                    EnvironmentPermission evr = new EnvironmentPermission(EnvironmentPermissionAccess.Read, "USERNAME");
                    permSet.AddPermission(evr);
                    try
                    {
                        permSet.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //"Adding permission to read environment variable COMPUTERNAME.";
                    EnvironmentPermission evr2 = new EnvironmentPermission(EnvironmentPermissionAccess.Read, "COMPUTERNAME");
                    permSet.AddPermission(evr2);

                    // Demand the permissions in the set.
                    try
                    {
                        evr2.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (executeCkb.Checked == true)
            {
                permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
                    permSet.Demand();
                }
            if (uiPermitCkb.Checked == true)
            {
                permSet.AddPermission(new UIPermission(PermissionState.Unrestricted));
                    permSet.Demand();
                }
            
            if (fileReadCkb.Checked == true)
            {
                    FileIOPermission fileReada = new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, fileReadTxt.Text);
                    try
                    {
                        fileReada.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    permSet.AddPermission(fileReada);
                }
            if (fileWriteCkb.Checked == true)
            {
                    FileIOPermission fileWrita = new FileIOPermission(FileIOPermissionAccess.Read, fileReadTxt.Text);
                fileWrita.AddPathList(FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, fileReadTxt.Text);
                permSet.AddPermission(fileWrita);
                    try
                    {
                        fileWrita.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
            }
            if (fileAppendCkb.Checked == true)
            {
                    FileIOPermission fileWrita = new FileIOPermission(FileIOPermissionAccess.Read, filePathTxt.Text);
                fileWrita.AddPathList(FileIOPermissionAccess.Append | FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, filePathTxt.Text);
                permSet.AddPermission(fileWrita);
                    try
                    {
                        fileWrita.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
            }
            if (fileDialogOpenCkb.Checked == true)
            {
                    permSet.AddPermission(new FileDialogPermission(FileDialogPermissionAccess.Open));
                    //Demanding permission to open a file
                    try
                    {
                        permSet.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            if (fileDialogSaveCkb.Checked == true)
            {
                    //Adding permission to save a file from a file dialog box
                    permSet.AddPermission(new FileDialogPermission(FileDialogPermissionAccess.Save));
                    
                    //Demanding permission to open and save a file
                    try
                    {
                        permSet.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (webCkb.Checked == true)
                {
                    // Create a WebPermission  instance.
                    WebPermission webPermission = new WebPermission(PermissionState.Unrestricted);

                    // Check for permission.
                    try
                    {
                        webPermission.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    permSet.AddPermission(webPermission);
                }
                if (webBrowserCkb.Checked == true)
                {
                    // Create a WebBrowserPermission  instance.
                    WebBrowserPermission webPermission = new WebBrowserPermission(PermissionState.Unrestricted);

                    // Check for permission.
                    try
                    {
                        webPermission.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    permSet.AddPermission(webPermission);
                }

                if (socketCkb.Checked == true)
            {
                    SocketPermission mySocketPermission = new SocketPermission(PermissionState.Unrestricted);
                    permSet.AddPermission(mySocketPermission);

                }

            if (dnsCkb.Checked == true)
            {
                    // Create a DnsPermission instance.
                    DnsPermission dnsPermission = new DnsPermission(PermissionState.Unrestricted);

                    // Check for permission.
                    try
                    {
                        dnsPermission.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    permSet.AddPermission(dnsPermission);
                }

            if (printCkb.Checked == true)
            {
                    // Create a PrintingPermission instance.
                    PrintingPermission printPermission = new PrintingPermission(PermissionState.Unrestricted);

                    // Check for permission.
                    try
                    {
                        printPermission.Demand();
                    }
                    catch (SecurityException s)
                    {
                        MessageBox.Show(s.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    permSet.AddPermission(printPermission);
                }
                
                

                new Program().createAppDomain(permSet, filePathTxt.Text, classPathTxt.Text, entryPointtxt.Text, parameters);

            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            hlp.ShowDialog();
        }

        private void classPathCmd_Click(object sender, EventArgs e)
        {
            classPathTxt.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgmProcesslbl.Text = "No program selected yet";
            filePathTxt.Text = "";
            classPathTxt.Text = "";
            entryPointtxt.Text = "";
            argsTxt.Text = "";
            fileReadTxt.Text = "";
        }

        private void fileReadClearCmd_Click(object sender, EventArgs e)
        {
            fileReadTxt.Text = "";
        }

        private void Sandbox_Load(object sender, EventArgs e)
        {

        }

        private void filePathTxt_TextChanged(object sender, EventArgs e)
        {
            if(filePathTxt.Text == "")
            {
                pgmProcesslbl.Text = "No program selected yet";
            }
            else
            {
                pgmProcesslbl.Text = "Application path changed";
            }
        }
    }
}
