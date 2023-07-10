
using System.Drawing;

namespace Sandbox_202138471
{
    partial class Sandbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sandbox));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.programCallTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.fileReadClearCmd = new System.Windows.Forms.Button();
            this.fileReadTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classPathCmd = new System.Windows.Forms.Button();
            this.classPathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entryPointCmd = new System.Windows.Forms.Button();
            this.entryPointtxt = new System.Windows.Forms.TextBox();
            this.entrypointlbl = new System.Windows.Forms.Label();
            this.checkCmd = new System.Windows.Forms.Button();
            this.fileCmd = new System.Windows.Forms.Button();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.clearCmd = new System.Windows.Forms.Button();
            this.argsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.permissionTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fileDialogSaveCkb = new System.Windows.Forms.CheckBox();
            this.fileDialogOpenCkb = new System.Windows.Forms.CheckBox();
            this.fileAppendCkb = new System.Windows.Forms.CheckBox();
            this.fileWriteCkb = new System.Windows.Forms.CheckBox();
            this.readCkb = new System.Windows.Forms.CheckBox();
            this.fileReadCkb = new System.Windows.Forms.CheckBox();
            this.uiPermitCkb = new System.Windows.Forms.CheckBox();
            this.executeCkb = new System.Windows.Forms.CheckBox();
            this.webBrowserCkb = new System.Windows.Forms.CheckBox();
            this.webCkb = new System.Windows.Forms.CheckBox();
            this.printCkb = new System.Windows.Forms.CheckBox();
            this.dnsCkb = new System.Windows.Forms.CheckBox();
            this.socketCkb = new System.Windows.Forms.CheckBox();
            this.pgmProcesslbl = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.programCallTab.SuspendLayout();
            this.permissionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.helpToolStripMenuItem.Text = "View Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.programCallTab);
            this.tabControl.Controls.Add(this.permissionTab);
            this.tabControl.Location = new System.Drawing.Point(0, 77);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 361);
            this.tabControl.TabIndex = 1;
            // 
            // programCallTab
            // 
            this.programCallTab.Controls.Add(this.label8);
            this.programCallTab.Controls.Add(this.label6);
            this.programCallTab.Controls.Add(this.fileReadClearCmd);
            this.programCallTab.Controls.Add(this.fileReadTxt);
            this.programCallTab.Controls.Add(this.label7);
            this.programCallTab.Controls.Add(this.label5);
            this.programCallTab.Controls.Add(this.label4);
            this.programCallTab.Controls.Add(this.classPathCmd);
            this.programCallTab.Controls.Add(this.classPathTxt);
            this.programCallTab.Controls.Add(this.label1);
            this.programCallTab.Controls.Add(this.entryPointCmd);
            this.programCallTab.Controls.Add(this.entryPointtxt);
            this.programCallTab.Controls.Add(this.entrypointlbl);
            this.programCallTab.Controls.Add(this.checkCmd);
            this.programCallTab.Controls.Add(this.fileCmd);
            this.programCallTab.Controls.Add(this.filePathTxt);
            this.programCallTab.Controls.Add(this.clearCmd);
            this.programCallTab.Controls.Add(this.argsTxt);
            this.programCallTab.Controls.Add(this.label3);
            this.programCallTab.Controls.Add(this.label2);
            this.programCallTab.Location = new System.Drawing.Point(4, 22);
            this.programCallTab.Name = "programCallTab";
            this.programCallTab.Padding = new System.Windows.Forms.Padding(3);
            this.programCallTab.Size = new System.Drawing.Size(792, 335);
            this.programCallTab.TabIndex = 0;
            this.programCallTab.Text = "Program Call";
            this.programCallTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(90, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "File read path";
            // 
            // fileReadClearCmd
            // 
            this.fileReadClearCmd.Location = new System.Drawing.Point(629, 202);
            this.fileReadClearCmd.Name = "fileReadClearCmd";
            this.fileReadClearCmd.Size = new System.Drawing.Size(75, 23);
            this.fileReadClearCmd.TabIndex = 17;
            this.fileReadClearCmd.Text = "Clear";
            this.fileReadClearCmd.UseVisualStyleBackColor = true;
            this.fileReadClearCmd.Click += new System.EventHandler(this.fileReadClearCmd_Click);
            // 
            // fileReadTxt
            // 
            this.fileReadTxt.Location = new System.Drawing.Point(93, 202);
            this.fileReadTxt.Name = "fileReadTxt";
            this.fileReadTxt.Size = new System.Drawing.Size(530, 20);
            this.fileReadTxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "File Path: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(90, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Integers comma delimited E.g. 4,10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(90, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "E.g. Fruit.Apple";
            // 
            // classPathCmd
            // 
            this.classPathCmd.Location = new System.Drawing.Point(629, 63);
            this.classPathCmd.Name = "classPathCmd";
            this.classPathCmd.Size = new System.Drawing.Size(75, 23);
            this.classPathCmd.TabIndex = 12;
            this.classPathCmd.Text = "Clear";
            this.classPathCmd.UseVisualStyleBackColor = true;
            this.classPathCmd.Click += new System.EventHandler(this.classPathCmd_Click);
            // 
            // classPathTxt
            // 
            this.classPathTxt.Location = new System.Drawing.Point(93, 63);
            this.classPathTxt.Name = "classPathTxt";
            this.classPathTxt.Size = new System.Drawing.Size(530, 20);
            this.classPathTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Class Path: ";
            // 
            // entryPointCmd
            // 
            this.entryPointCmd.Location = new System.Drawing.Point(629, 111);
            this.entryPointCmd.Name = "entryPointCmd";
            this.entryPointCmd.Size = new System.Drawing.Size(75, 23);
            this.entryPointCmd.TabIndex = 9;
            this.entryPointCmd.Text = "Clear";
            this.entryPointCmd.UseVisualStyleBackColor = true;
            this.entryPointCmd.Click += new System.EventHandler(this.entryPointCmd_Click);
            // 
            // entryPointtxt
            // 
            this.entryPointtxt.Location = new System.Drawing.Point(93, 111);
            this.entryPointtxt.Name = "entryPointtxt";
            this.entryPointtxt.Size = new System.Drawing.Size(530, 20);
            this.entryPointtxt.TabIndex = 8;
            // 
            // entrypointlbl
            // 
            this.entrypointlbl.AutoSize = true;
            this.entrypointlbl.Location = new System.Drawing.Point(12, 111);
            this.entrypointlbl.Name = "entrypointlbl";
            this.entrypointlbl.Size = new System.Drawing.Size(64, 13);
            this.entrypointlbl.TabIndex = 7;
            this.entrypointlbl.Text = "Entry Point: ";
            // 
            // checkCmd
            // 
            this.checkCmd.Location = new System.Drawing.Point(629, 267);
            this.checkCmd.Name = "checkCmd";
            this.checkCmd.Size = new System.Drawing.Size(75, 23);
            this.checkCmd.TabIndex = 6;
            this.checkCmd.Text = "Run";
            this.checkCmd.UseVisualStyleBackColor = true;
            this.checkCmd.Click += new System.EventHandler(this.checkCmd_Click);
            // 
            // fileCmd
            // 
            this.fileCmd.Location = new System.Drawing.Point(629, 17);
            this.fileCmd.Name = "fileCmd";
            this.fileCmd.Size = new System.Drawing.Size(75, 23);
            this.fileCmd.TabIndex = 5;
            this.fileCmd.Text = "Browse";
            this.fileCmd.UseVisualStyleBackColor = true;
            this.fileCmd.Click += new System.EventHandler(this.fileCmd_Click);
            // 
            // filePathTxt
            // 
            this.filePathTxt.Location = new System.Drawing.Point(93, 17);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(530, 20);
            this.filePathTxt.TabIndex = 4;
            this.filePathTxt.TextChanged += new System.EventHandler(this.filePathTxt_TextChanged);
            // 
            // clearCmd
            // 
            this.clearCmd.Location = new System.Drawing.Point(629, 156);
            this.clearCmd.Name = "clearCmd";
            this.clearCmd.Size = new System.Drawing.Size(75, 23);
            this.clearCmd.TabIndex = 3;
            this.clearCmd.Text = "Clear";
            this.clearCmd.UseVisualStyleBackColor = true;
            this.clearCmd.Click += new System.EventHandler(this.clearCmd_Click);
            // 
            // argsTxt
            // 
            this.argsTxt.Location = new System.Drawing.Point(93, 156);
            this.argsTxt.Name = "argsTxt";
            this.argsTxt.Size = new System.Drawing.Size(530, 20);
            this.argsTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Arguments: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Program Path: ";
            // 
            // permissionTab
            // 
            this.permissionTab.Controls.Add(this.splitContainer1);
            this.permissionTab.Location = new System.Drawing.Point(4, 22);
            this.permissionTab.Name = "permissionTab";
            this.permissionTab.Padding = new System.Windows.Forms.Padding(3);
            this.permissionTab.Size = new System.Drawing.Size(792, 335);
            this.permissionTab.TabIndex = 1;
            this.permissionTab.Text = "Permission";
            this.permissionTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileDialogSaveCkb);
            this.splitContainer1.Panel1.Controls.Add(this.fileDialogOpenCkb);
            this.splitContainer1.Panel1.Controls.Add(this.fileAppendCkb);
            this.splitContainer1.Panel1.Controls.Add(this.fileWriteCkb);
            this.splitContainer1.Panel1.Controls.Add(this.readCkb);
            this.splitContainer1.Panel1.Controls.Add(this.fileReadCkb);
            this.splitContainer1.Panel1.Controls.Add(this.uiPermitCkb);
            this.splitContainer1.Panel1.Controls.Add(this.executeCkb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserCkb);
            this.splitContainer1.Panel2.Controls.Add(this.webCkb);
            this.splitContainer1.Panel2.Controls.Add(this.printCkb);
            this.splitContainer1.Panel2.Controls.Add(this.dnsCkb);
            this.splitContainer1.Panel2.Controls.Add(this.socketCkb);
            this.splitContainer1.Size = new System.Drawing.Size(778, 323);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 5;
            // 
            // fileDialogSaveCkb
            // 
            this.fileDialogSaveCkb.AutoSize = true;
            this.fileDialogSaveCkb.Location = new System.Drawing.Point(19, 290);
            this.fileDialogSaveCkb.Name = "fileDialogSaveCkb";
            this.fileDialogSaveCkb.Size = new System.Drawing.Size(103, 17);
            this.fileDialogSaveCkb.TabIndex = 8;
            this.fileDialogSaveCkb.Text = "File Dialog Save";
            this.fileDialogSaveCkb.UseVisualStyleBackColor = true;
            // 
            // fileDialogOpenCkb
            // 
            this.fileDialogOpenCkb.AutoSize = true;
            this.fileDialogOpenCkb.Location = new System.Drawing.Point(19, 252);
            this.fileDialogOpenCkb.Name = "fileDialogOpenCkb";
            this.fileDialogOpenCkb.Size = new System.Drawing.Size(104, 17);
            this.fileDialogOpenCkb.TabIndex = 7;
            this.fileDialogOpenCkb.Text = "File Dialog Open";
            this.fileDialogOpenCkb.UseVisualStyleBackColor = true;
            // 
            // fileAppendCkb
            // 
            this.fileAppendCkb.AutoSize = true;
            this.fileAppendCkb.Location = new System.Drawing.Point(19, 214);
            this.fileAppendCkb.Name = "fileAppendCkb";
            this.fileAppendCkb.Size = new System.Drawing.Size(82, 17);
            this.fileAppendCkb.TabIndex = 6;
            this.fileAppendCkb.Text = "File Append";
            this.fileAppendCkb.UseVisualStyleBackColor = true;
            // 
            // fileWriteCkb
            // 
            this.fileWriteCkb.AutoSize = true;
            this.fileWriteCkb.Location = new System.Drawing.Point(19, 175);
            this.fileWriteCkb.Name = "fileWriteCkb";
            this.fileWriteCkb.Size = new System.Drawing.Size(70, 17);
            this.fileWriteCkb.TabIndex = 5;
            this.fileWriteCkb.Text = "File Write";
            this.fileWriteCkb.UseVisualStyleBackColor = true;
            // 
            // readCkb
            // 
            this.readCkb.AutoSize = true;
            this.readCkb.Location = new System.Drawing.Point(19, 15);
            this.readCkb.Name = "readCkb";
            this.readCkb.Size = new System.Drawing.Size(114, 17);
            this.readCkb.TabIndex = 0;
            this.readCkb.Text = "Read Environment";
            this.readCkb.UseVisualStyleBackColor = true;
            // 
            // fileReadCkb
            // 
            this.fileReadCkb.AutoSize = true;
            this.fileReadCkb.Location = new System.Drawing.Point(19, 135);
            this.fileReadCkb.Name = "fileReadCkb";
            this.fileReadCkb.Size = new System.Drawing.Size(71, 17);
            this.fileReadCkb.TabIndex = 4;
            this.fileReadCkb.Text = "File Read";
            this.fileReadCkb.UseVisualStyleBackColor = true;
            // 
            // uiPermitCkb
            // 
            this.uiPermitCkb.AutoSize = true;
            this.uiPermitCkb.Location = new System.Drawing.Point(19, 95);
            this.uiPermitCkb.Name = "uiPermitCkb";
            this.uiPermitCkb.Size = new System.Drawing.Size(90, 17);
            this.uiPermitCkb.TabIndex = 3;
            this.uiPermitCkb.Text = "UI Permission";
            this.uiPermitCkb.UseVisualStyleBackColor = true;
            // 
            // executeCkb
            // 
            this.executeCkb.AutoSize = true;
            this.executeCkb.Checked = true;
            this.executeCkb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.executeCkb.Location = new System.Drawing.Point(19, 57);
            this.executeCkb.Name = "executeCkb";
            this.executeCkb.Size = new System.Drawing.Size(65, 17);
            this.executeCkb.TabIndex = 2;
            this.executeCkb.Text = "Execute";
            this.executeCkb.UseVisualStyleBackColor = true;
            // 
            // webBrowserCkb
            // 
            this.webBrowserCkb.AutoSize = true;
            this.webBrowserCkb.Location = new System.Drawing.Point(20, 57);
            this.webBrowserCkb.Name = "webBrowserCkb";
            this.webBrowserCkb.Size = new System.Drawing.Size(90, 17);
            this.webBrowserCkb.TabIndex = 10;
            this.webBrowserCkb.Text = "Web Browser";
            this.webBrowserCkb.UseVisualStyleBackColor = true;
            // 
            // webCkb
            // 
            this.webCkb.AutoSize = true;
            this.webCkb.Location = new System.Drawing.Point(20, 15);
            this.webCkb.Name = "webCkb";
            this.webCkb.Size = new System.Drawing.Size(96, 17);
            this.webCkb.TabIndex = 9;
            this.webCkb.Text = "Web / Internet";
            this.webCkb.UseVisualStyleBackColor = true;
            // 
            // printCkb
            // 
            this.printCkb.AutoSize = true;
            this.printCkb.Location = new System.Drawing.Point(20, 175);
            this.printCkb.Name = "printCkb";
            this.printCkb.Size = new System.Drawing.Size(61, 17);
            this.printCkb.TabIndex = 8;
            this.printCkb.Text = "Printing";
            this.printCkb.UseVisualStyleBackColor = true;
            // 
            // dnsCkb
            // 
            this.dnsCkb.AutoSize = true;
            this.dnsCkb.Location = new System.Drawing.Point(20, 135);
            this.dnsCkb.Name = "dnsCkb";
            this.dnsCkb.Size = new System.Drawing.Size(49, 17);
            this.dnsCkb.TabIndex = 7;
            this.dnsCkb.Text = "DNS";
            this.dnsCkb.UseVisualStyleBackColor = true;
            // 
            // socketCkb
            // 
            this.socketCkb.AutoSize = true;
            this.socketCkb.Location = new System.Drawing.Point(21, 95);
            this.socketCkb.Name = "socketCkb";
            this.socketCkb.Size = new System.Drawing.Size(60, 17);
            this.socketCkb.TabIndex = 6;
            this.socketCkb.Text = "Socket";
            this.socketCkb.UseVisualStyleBackColor = true;
            // 
            // pgmProcesslbl
            // 
            this.pgmProcesslbl.AutoSize = true;
            this.pgmProcesslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgmProcesslbl.Location = new System.Drawing.Point(12, 39);
            this.pgmProcesslbl.Name = "pgmProcesslbl";
            this.pgmProcesslbl.Size = new System.Drawing.Size(216, 24);
            this.pgmProcesslbl.TabIndex = 2;
            this.pgmProcesslbl.Text = "No program selected yet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(90, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Optional. Will be fetched from Assembly if not provided";
            // 
            // Sandbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgmProcesslbl);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sandbox";
            this.Text = "Sandbox";
            this.Load += new System.EventHandler(this.Sandbox_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.programCallTab.ResumeLayout(false);
            this.programCallTab.PerformLayout();
            this.permissionTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage programCallTab;
        private System.Windows.Forms.TabPage permissionTab;
        private System.Windows.Forms.Label pgmProcesslbl;
        private System.Windows.Forms.Button fileCmd;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button clearCmd;
        private System.Windows.Forms.TextBox argsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkCmd;
        private System.Windows.Forms.CheckBox executeCkb;
        private System.Windows.Forms.CheckBox readCkb;
        private System.Windows.Forms.Button entryPointCmd;
        private System.Windows.Forms.TextBox entryPointtxt;
        private System.Windows.Forms.Label entrypointlbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox uiPermitCkb;
        private System.Windows.Forms.CheckBox fileReadCkb;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox fileWriteCkb;
        private System.Windows.Forms.CheckBox fileAppendCkb;
        private System.Windows.Forms.CheckBox fileDialogSaveCkb;
        private System.Windows.Forms.CheckBox fileDialogOpenCkb;
        private System.Windows.Forms.CheckBox dnsCkb;
        private System.Windows.Forms.CheckBox socketCkb;
        private System.Windows.Forms.CheckBox printCkb;
        private System.Windows.Forms.CheckBox webBrowserCkb;
        private System.Windows.Forms.CheckBox webCkb;
        private System.Windows.Forms.Button classPathCmd;
        private System.Windows.Forms.TextBox classPathTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fileReadClearCmd;
        private System.Windows.Forms.TextBox fileReadTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}

