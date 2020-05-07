namespace KMTModifier
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.currentMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_EntryClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MissionModeClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MissionModeClipboard_PAL = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MissionModeClipboard_NTSCU = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MissionModeClipboard_NTSCJ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MissionModeClipboard_NTSCK = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ExportGCTCode = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ExportGCTCode_PAL = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ExportGCTCode_NTSCU = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ExportGCTCode_NTSCJ = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ExportGCTCode_NTSCK = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help_AboutKMTModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.flp_Mission = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.me_Program = new KMTModifier.MissionEditor();
            this.msv_Program = new KMTModifier.MissionSetView();
            this.menuStrip1.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            this.flp_Mission.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.currentMissionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File_New,
            this.menu_File_Open,
            this.menu_File_Save,
            this.menu_File_SaveAs,
            this.menu_File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_File_New
            // 
            this.menu_File_New.Name = "menu_File_New";
            this.menu_File_New.Size = new System.Drawing.Size(114, 22);
            this.menu_File_New.Text = "New";
            this.menu_File_New.Click += new System.EventHandler(this.menu_File_New_Click);
            // 
            // menu_File_Open
            // 
            this.menu_File_Open.Name = "menu_File_Open";
            this.menu_File_Open.Size = new System.Drawing.Size(114, 22);
            this.menu_File_Open.Text = "Open";
            this.menu_File_Open.Click += new System.EventHandler(this.menu_File_Open_Click);
            // 
            // menu_File_Save
            // 
            this.menu_File_Save.Name = "menu_File_Save";
            this.menu_File_Save.Size = new System.Drawing.Size(114, 22);
            this.menu_File_Save.Text = "Save";
            this.menu_File_Save.Click += new System.EventHandler(this.menu_File_Save_Click);
            // 
            // menu_File_SaveAs
            // 
            this.menu_File_SaveAs.Name = "menu_File_SaveAs";
            this.menu_File_SaveAs.Size = new System.Drawing.Size(114, 22);
            this.menu_File_SaveAs.Text = "Save As";
            this.menu_File_SaveAs.Click += new System.EventHandler(this.menu_File_SaveAs_Click);
            // 
            // menu_File_Exit
            // 
            this.menu_File_Exit.Name = "menu_File_Exit";
            this.menu_File_Exit.Size = new System.Drawing.Size(114, 22);
            this.menu_File_Exit.Text = "Exit";
            this.menu_File_Exit.Click += new System.EventHandler(this.menu_File_Exit_Click);
            // 
            // currentMissionToolStripMenuItem
            // 
            this.currentMissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_EntryClipboard,
            this.menu_MissionModeClipboard,
            this.menu_ExportGCTCode});
            this.currentMissionToolStripMenuItem.Enabled = false;
            this.currentMissionToolStripMenuItem.Name = "currentMissionToolStripMenuItem";
            this.currentMissionToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.currentMissionToolStripMenuItem.Text = "Current Mission";
            // 
            // menu_EntryClipboard
            // 
            this.menu_EntryClipboard.Name = "menu_EntryClipboard";
            this.menu_EntryClipboard.Size = new System.Drawing.Size(375, 22);
            this.menu_EntryClipboard.Text = "Copy Mission Code To Clipboard";
            this.menu_EntryClipboard.Click += new System.EventHandler(this.menu_EntryClipboard_Click);
            // 
            // menu_MissionModeClipboard
            // 
            this.menu_MissionModeClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_MissionModeClipboard_PAL,
            this.menu_MissionModeClipboard_NTSCU,
            this.menu_MissionModeClipboard_NTSCJ,
            this.menu_MissionModeClipboard_NTSCK});
            this.menu_MissionModeClipboard.Name = "menu_MissionModeClipboard";
            this.menu_MissionModeClipboard.Size = new System.Drawing.Size(375, 22);
            this.menu_MissionModeClipboard.Text = "Copy Mission As Mission Mode Cheat Code To Clipboard";
            // 
            // menu_MissionModeClipboard_PAL
            // 
            this.menu_MissionModeClipboard_PAL.Name = "menu_MissionModeClipboard_PAL";
            this.menu_MissionModeClipboard_PAL.Size = new System.Drawing.Size(116, 22);
            this.menu_MissionModeClipboard_PAL.Text = "PAL";
            this.menu_MissionModeClipboard_PAL.Click += new System.EventHandler(this.menu_MissionModeClipboard_PAL_Click);
            // 
            // menu_MissionModeClipboard_NTSCU
            // 
            this.menu_MissionModeClipboard_NTSCU.Name = "menu_MissionModeClipboard_NTSCU";
            this.menu_MissionModeClipboard_NTSCU.Size = new System.Drawing.Size(116, 22);
            this.menu_MissionModeClipboard_NTSCU.Text = "NTSC-U";
            this.menu_MissionModeClipboard_NTSCU.Click += new System.EventHandler(this.menu_MissionModeClipboard_NTSCU_Click);
            // 
            // menu_MissionModeClipboard_NTSCJ
            // 
            this.menu_MissionModeClipboard_NTSCJ.Name = "menu_MissionModeClipboard_NTSCJ";
            this.menu_MissionModeClipboard_NTSCJ.Size = new System.Drawing.Size(116, 22);
            this.menu_MissionModeClipboard_NTSCJ.Text = "NTSC-J";
            this.menu_MissionModeClipboard_NTSCJ.Click += new System.EventHandler(this.menu_MissionModeClipboard_NTSCJ_Click);
            // 
            // menu_MissionModeClipboard_NTSCK
            // 
            this.menu_MissionModeClipboard_NTSCK.Name = "menu_MissionModeClipboard_NTSCK";
            this.menu_MissionModeClipboard_NTSCK.Size = new System.Drawing.Size(116, 22);
            this.menu_MissionModeClipboard_NTSCK.Text = "NTSC-K";
            this.menu_MissionModeClipboard_NTSCK.Click += new System.EventHandler(this.menu_MissionModeClipboard_NTSCK_Click);
            // 
            // menu_ExportGCTCode
            // 
            this.menu_ExportGCTCode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ExportGCTCode_PAL,
            this.menu_ExportGCTCode_NTSCU,
            this.menu_ExportGCTCode_NTSCJ,
            this.menu_ExportGCTCode_NTSCK});
            this.menu_ExportGCTCode.Name = "menu_ExportGCTCode";
            this.menu_ExportGCTCode.Size = new System.Drawing.Size(375, 22);
            this.menu_ExportGCTCode.Text = "Export As GCT Code";
            // 
            // menu_ExportGCTCode_PAL
            // 
            this.menu_ExportGCTCode_PAL.Name = "menu_ExportGCTCode_PAL";
            this.menu_ExportGCTCode_PAL.Size = new System.Drawing.Size(116, 22);
            this.menu_ExportGCTCode_PAL.Text = "PAL";
            this.menu_ExportGCTCode_PAL.Click += new System.EventHandler(this.menu_ExportGCTCode_PAL_Click);
            // 
            // menu_ExportGCTCode_NTSCU
            // 
            this.menu_ExportGCTCode_NTSCU.Name = "menu_ExportGCTCode_NTSCU";
            this.menu_ExportGCTCode_NTSCU.Size = new System.Drawing.Size(116, 22);
            this.menu_ExportGCTCode_NTSCU.Text = "NTSC-U";
            this.menu_ExportGCTCode_NTSCU.Click += new System.EventHandler(this.menu_ExportGCTCode_NTSCU_Click);
            // 
            // menu_ExportGCTCode_NTSCJ
            // 
            this.menu_ExportGCTCode_NTSCJ.Name = "menu_ExportGCTCode_NTSCJ";
            this.menu_ExportGCTCode_NTSCJ.Size = new System.Drawing.Size(116, 22);
            this.menu_ExportGCTCode_NTSCJ.Text = "NTSC-J";
            this.menu_ExportGCTCode_NTSCJ.Click += new System.EventHandler(this.menu_ExportGCTCode_NTSCJ_Click);
            // 
            // menu_ExportGCTCode_NTSCK
            // 
            this.menu_ExportGCTCode_NTSCK.Name = "menu_ExportGCTCode_NTSCK";
            this.menu_ExportGCTCode_NTSCK.Size = new System.Drawing.Size(116, 22);
            this.menu_ExportGCTCode_NTSCK.Text = "NTSC-K";
            this.menu_ExportGCTCode_NTSCK.Click += new System.EventHandler(this.menu_ExportGCTCode_NTSCK_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Help_AboutKMTModifier});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menu_Help_AboutKMTModifier
            // 
            this.menu_Help_AboutKMTModifier.Name = "menu_Help_AboutKMTModifier";
            this.menu_Help_AboutKMTModifier.Size = new System.Drawing.Size(182, 22);
            this.menu_Help_AboutKMTModifier.Text = "About KMT Modifier";
            this.menu_Help_AboutKMTModifier.Click += new System.EventHandler(this.menu_Help_AboutKMTModifier_Click);
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.Controls.Add(this.flp_Mission, 1, 0);
            this.tlp_Main.Controls.Add(this.msv_Program, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 24);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(484, 337);
            this.tlp_Main.TabIndex = 16;
            // 
            // flp_Mission
            // 
            this.flp_Mission.AutoScroll = true;
            this.flp_Mission.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Mission.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flp_Mission.Controls.Add(this.panel1);
            this.flp_Mission.Controls.Add(this.me_Program);
            this.flp_Mission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Mission.Location = new System.Drawing.Point(203, 3);
            this.flp_Mission.MinimumSize = new System.Drawing.Size(128, 256);
            this.flp_Mission.Name = "flp_Mission";
            this.flp_Mission.Size = new System.Drawing.Size(278, 331);
            this.flp_Mission.TabIndex = 1;
            this.flp_Mission.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // me_Program
            // 
            this.me_Program.AutoSize = true;
            this.me_Program.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.me_Program.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.me_Program.Enabled = false;
            this.me_Program.Location = new System.Drawing.Point(9, 3);
            this.me_Program.Name = "me_Program";
            this.me_Program.Size = new System.Drawing.Size(614, 326);
            this.me_Program.TabIndex = 0;
            // 
            // msv_Program
            // 
            this.msv_Program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msv_Program.Location = new System.Drawing.Point(3, 3);
            this.msv_Program.Name = "msv_Program";
            this.msv_Program.Size = new System.Drawing.Size(194, 331);
            this.msv_Program.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form_Main";
            this.Text = "KMT Modifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlp_Main.ResumeLayout(false);
            this.flp_Mission.ResumeLayout(false);
            this.flp_Mission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.FlowLayoutPanel flp_Mission;
        private System.Windows.Forms.ToolStripMenuItem menu_File_New;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem menu_File_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem currentMissionToolStripMenuItem;
        private MissionEditor me_Program;
        private MissionSetView msv_Program;
        private System.Windows.Forms.ToolStripMenuItem menu_EntryClipboard;
        private System.Windows.Forms.ToolStripMenuItem menu_MissionModeClipboard;
        private System.Windows.Forms.ToolStripMenuItem menu_MissionModeClipboard_PAL;
        private System.Windows.Forms.ToolStripMenuItem menu_MissionModeClipboard_NTSCU;
        private System.Windows.Forms.ToolStripMenuItem menu_MissionModeClipboard_NTSCJ;
        private System.Windows.Forms.ToolStripMenuItem menu_ExportGCTCode;
        private System.Windows.Forms.ToolStripMenuItem menu_ExportGCTCode_PAL;
        private System.Windows.Forms.ToolStripMenuItem menu_ExportGCTCode_NTSCU;
        private System.Windows.Forms.ToolStripMenuItem menu_ExportGCTCode_NTSCJ;
        private System.Windows.Forms.ToolStripMenuItem menu_MissionModeClipboard_NTSCK;
        private System.Windows.Forms.ToolStripMenuItem menu_ExportGCTCode_NTSCK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Help_AboutKMTModifier;
    }
}