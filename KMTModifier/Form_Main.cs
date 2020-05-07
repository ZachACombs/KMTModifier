using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using KMT;

namespace KMTModifier
{
    public partial class Form_Main : Form
    {
        public Form_Main(StringValue filename)
        {
            InitializeComponent();

            msv_Program.OnSelectionChanged +=
                new MissionSetView.SelectionChangedEventHandler(
                    msv_Program_SelectionChanged
                    );
            
            if (filename != null)
            {
                TryToOpen(filename.Value);
            }
            
            UpdateFormText();
        }

        private void msv_Program_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Entry != null)
            {
                me_Program.Enabled = true;
                currentMissionToolStripMenuItem.Enabled = true;
                me_Program.DisplayMission(e.Entry);
            }
            else
            {
                me_Program.Enabled = false;
                currentMissionToolStripMenuItem.Enabled = false;
            }
        }

        Kmt openkmt = null; /*Used to detect if the user makes any changes to the file.
            Changes when the user creates, opens, or saves a file.*/
        const string untitledtext = "Untitled";
        StringValue openfname = null;
        string untitledorfilename(bool justfilename)
        {
            if (openfname == null)
            {
                return untitledtext;
            }
            else
            {
                if (justfilename)
                {
                    return Path.GetFileName(openfname.Value);
                }
                else
                {
                    return "\"" + openfname.Value + "\"";
                }
            }
        }
        void UpdateFormText()
        {
            Text = String.Format(
                    "{0} - KMT Modifier"
                    , untitledorfilename(true));
        }
        bool usermadechanges()
        {
            KmtEntryList entrylist = msv_Program.Missions();

            if (openkmt == null)
            {
                return (entrylist.Count > 0);
            }

            if (entrylist.Count != openkmt.Entries.Count)
            {
                return true;
            }

            for (int n = 0; n < entrylist.Count; n += 1)
            {
                KmtEntry newentry = entrylist[n];
                KmtEntry oldentry = openkmt.Entries[n];
                if (
                    newentry.CameraMode != oldentry.CameraMode |
                    newentry.CannonFlag != oldentry.CannonFlag |
                    newentry.Character != oldentry.Character |
                    newentry.ControllerRestriction != oldentry.ControllerRestriction |
                    newentry.Course != oldentry.Course |
                    newentry.EngineClass != oldentry.EngineClass |
                    newentry.GameMode != oldentry.GameMode |
                    newentry.Minimap != oldentry.Minimap |
                    newentry.MissionRunFile != oldentry.MissionRunFile |
                    newentry.Score != oldentry.Score |
                    newentry.TimeLimit != oldentry.TimeLimit |
                    newentry.Vehicle != oldentry.Vehicle
                    )
                {
                    return true;
                }
                
                if (newentry.CPUs.Count != oldentry.CPUs.Count)
                {
                    return true;
                }

                for (int m = 0; m < newentry.CPUs.Count; m += 1)
                {
                    KmtCPUEntry newcpu = newentry.CPUs[m];
                    KmtCPUEntry oldcpu = newentry.CPUs[m];
                    if (newcpu.Character != oldcpu.Character | 
                        newcpu.Vehicle != oldcpu.Vehicle)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        void ResetData()
        {
            msv_Program.Clear();
            openfname = null;
            openkmt = null;
        }
        bool TryToOpen(string path)
        {
            const string errorheader = "Could not open file";
            if (!File.Exists(path))
            {
                Error.Show(
                    "\"{0}\" does not exist"
                    , errorheader, path);
                return false;
            }
            else
            {
                try
                {
                    Kmt kmt = new Kmt();
                    kmt.Load(path);
                    ResetData();
                    msv_Program.LoadKmt(kmt);

                    openkmt = kmt;
                    openfname = new StringValue(path);
                }
                catch (Exception ex)
                {
                    Error.Show(ex.Message, errorheader);
                    return false;
                }
            }
            return true;
        }
        DialogResult AllowUserChanceToSaveIfChanged()
        {
            DialogResult result = DialogResult.None;
            if (usermadechanges())
            {
                result = MessageBox.Show(String.Format(
                    "Save changes to {0}"
                    , untitledorfilename(false)),
                    "Save Changes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    File_Save(false);
                }
            }

            return result;
        }
        void File_New()
        {
            ResetData();
        }
        void File_Open()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "KMT File|*.kmt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TryToOpen(dialog.FileName);
            }
        }
        void File_Save(bool forcesaveas)
        {
            bool fileisfound()
            {
                bool filefound = false;
                if (openfname != null)
                {
                    if (File.Exists(openfname.Value))
                    {
                        filefound = true;
                    }
                }
                return filefound;
            }
            bool SaveIt()
            {
                string savefilename;
                if (forcesaveas | (!fileisfound()))
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "KMT File|*.kmt";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        savefilename = dialog.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    savefilename = openfname.Value;
                }
                Kmt kmt = new Kmt();
                kmt.Entries = msv_Program.Missions();
                kmt.Save(savefilename);
                openfname = new StringValue(savefilename);
                openkmt = kmt;

                return true;
            }
            SaveIt();
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AllowUserChanceToSaveIfChanged() == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        
        private void menu_File_New_Click(object sender, EventArgs e)
        {
            if (AllowUserChanceToSaveIfChanged() != DialogResult.Cancel)
            {
                ResetData();
                UpdateFormText();
                me_Program.Enabled = false;
            }
        }
        private void menu_File_Open_Click(object sender, EventArgs e)
        {
            if (AllowUserChanceToSaveIfChanged() != DialogResult.Cancel)
            {
                File_Open();
                UpdateFormText();
                me_Program.Enabled = false;
            }
        }
        private void menu_File_Save_Click(object sender, EventArgs e)
        {
            File_Save(false);
            UpdateFormText();
        }
        private void menu_File_SaveAs_Click(object sender, EventArgs e)
        {
            File_Save(true);
            UpdateFormText();
        }
        private void menu_File_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_EntryClipboard_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.CopyEntryToClipboard(me_Program.CurrentMission);
        }

        private void menu_MissionModeClipboard_PAL_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.CopyCheatCodeToClipboard(me_Program.CurrentMission, 0);
        }
        private void menu_MissionModeClipboard_NTSCU_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.CopyCheatCodeToClipboard(me_Program.CurrentMission, 1);
        }
        private void menu_MissionModeClipboard_NTSCJ_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.CopyCheatCodeToClipboard(me_Program.CurrentMission, 2);
        }
        private void menu_MissionModeClipboard_NTSCK_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.CopyCheatCodeToClipboard(me_Program.CurrentMission, 3);
        }

        private void menu_ExportGCTCode_PAL_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.ExportGCTCode(me_Program.CurrentMission, 0);
        }
        private void menu_ExportGCTCode_NTSCU_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.ExportGCTCode(me_Program.CurrentMission, 1);
        }
        private void menu_ExportGCTCode_NTSCJ_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.ExportGCTCode(me_Program.CurrentMission, 2);
        }
        private void menu_ExportGCTCode_NTSCK_Click(object sender, EventArgs e)
        {
            CurrentMissionOption.ExportGCTCode(me_Program.CurrentMission, 3);
        }

        private void menu_Help_AboutKMTModifier_Click(object sender, EventArgs e)
        {
            (new Form_About()).ShowDialog();
        }
    }
}
