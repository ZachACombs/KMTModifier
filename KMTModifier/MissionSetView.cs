using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMT;

namespace KMTModifier
{
    public partial class MissionSetView : UserControl
    {
        public delegate void SelectionChangedEventHandler(object sender, SelectionChangedEventArgs e);
        public event SelectionChangedEventHandler OnSelectionChanged;
        private void SelectionChanged(KmtEntry entry)
        {
            SelectionChangedEventArgs args = new SelectionChangedEventArgs(entry);
            OnSelectionChanged(this, args);
        }

        Dictionary<TreeNode, KmtEntry> nodemission = new Dictionary<TreeNode, KmtEntry>();
        
        KmtEntry cloneentry(KmtEntry entry)
        {
            KmtEntry newentry = new KmtEntry();
            newentry.CameraMode = entry.CameraMode;
            newentry.CannonFlag = entry.CannonFlag;
            newentry.Character = entry.Character;
            newentry.ControllerRestriction = entry.ControllerRestriction;
            newentry.Course = entry.Course;
            newentry.EngineClass = entry.EngineClass;
            newentry.GameMode = entry.GameMode;
            newentry.Minimap = entry.Minimap;
            newentry.MissionRunFile = entry.MissionRunFile;
            newentry.Score = entry.Score;
            newentry.TimeLimit = entry.TimeLimit;
            newentry.Vehicle = entry.Vehicle;
            for (int m = 0; m < entry.CPUs.Count; m += 1)
            {
                KmtCPUEntry cpu = entry.CPUs[m];
                KmtCPUEntry newcpu = new KmtCPUEntry();
                newcpu.Character = cpu.Character;
                newcpu.Vehicle = cpu.Vehicle;
                newentry.CPUs.Add(cpu);
            }
            return newentry;
        }
        private void clear()
        {
            tv_Missions.Nodes.Clear();
            updatebuttons();
        }
        
        public MissionSetView()
        {
            InitializeComponent();
        }

        public void LoadKmt(Kmt kmt)
        {
            clear();
            for (int n = 0; n < kmt.Entries.Count; n += 1)
            {
                KmtEntry entry = kmt.Entries[n];
                KmtEntry newentry = cloneentry(entry);
                int section_index = n / 8;
                int mission_index = n % 8;
                TreeNode mission = new TreeNode(String.Format(
                    "{0} - {1}"
                    , section_index + 1, mission_index + 1));
                nodemission.Add(mission, newentry);
                tv_Missions.Nodes.Add(mission);
            }
            updatebuttons();
        }
        public KmtEntryList Missions()
        {
            KmtEntryList newlist = new KmtEntryList();
            for (int n = 0; n < tv_Missions.Nodes.Count; n += 1)
            {
                newlist.Add(nodemission[tv_Missions.Nodes[n]]);
            }
            return newlist;
        }
        public void Clear()
        {
            clear();
        }

        void starttimer()
        {
            t_NodeText.Enabled = true;
            t_NodeText.Stop();
            t_NodeText.Start();
        }
        void mission_add()
        {
            KmtEntry newentry = new KmtEntry();
            int section_index = tv_Missions.Nodes.Count / 8;
            int mission_index = tv_Missions.Nodes.Count % 8;
            TreeNode mission = new TreeNode(String.Format(
                "{0} - {1}"
                , section_index + 1, mission_index + 1));
            nodemission.Add(mission, newentry);
            tv_Missions.Nodes.Add(mission);
            updatebuttons();
            tv_Missions.SelectedNode = mission;
        }
        void mission_remove()
        {
            TreeNode selnode = tv_Missions.SelectedNode;
            tv_Missions.SelectedNode = null;
            tv_Missions.Nodes.Remove(selnode);
            nodemission.Remove(selnode);
            starttimer();
            updatebuttons();
            if (tv_Missions.SelectedNode != null)
            {
                SelectionChanged(nodemission[tv_Missions.SelectedNode]);
            }
            else
            {
                SelectionChanged(null);
            }
        }
        void mission_move(bool movedown)
        {
            int oldindex = tv_Missions.SelectedNode.Index;
            int newindex;
            if (movedown) newindex = oldindex + 1;
            else newindex = oldindex - 1;
            TreeNode oldnode = tv_Missions.Nodes[oldindex];
            TreeNode newnode = tv_Missions.Nodes[newindex];
            string curtext = oldnode.Text;
            string swptext = newnode.Text;
            KmtEntry curentry = nodemission[oldnode];
            KmtEntry swpentry = nodemission[newnode];
            newnode.Text = curtext;
            oldnode.Text = swptext;
            nodemission[newnode] = curentry;
            nodemission[oldnode] = swpentry;
            tv_Missions.SelectedNode = newnode;
            starttimer();
            updatebuttons();
        }
        void updatebuttons()
        {
            if (tv_Missions.SelectedNode != null)
            {
                int index = tv_Missions.SelectedNode.Index;
                b_m_Up.Enabled = (index > 0);
                b_m_Down.Enabled = (index < (tv_Missions.Nodes.Count - 1));
                b_m_Remove.Enabled = true;
            }
            else
            {
                b_m_Up.Enabled = false;
                b_m_Down.Enabled = false;
                b_m_Remove.Enabled = false;
            }
        }
        void updatetreenodetexts()
        {
            for (int n = 0; n < tv_Missions.Nodes.Count; n += 1)
            {
                int section_index = n / 8;
                int mission_index = n % 8;
                tv_Missions.Nodes[n].Text = String.Format(
                    "{0} - {1}"
                    , section_index + 1, mission_index + 1);
            }
        }

        private void tv_Missions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectionChanged(nodemission[e.Node]);

            updatebuttons();
        }
        private void b_m_Add_Click(object sender, EventArgs e)
        {
            mission_add();
        }
        private void b_m_Remove_Click(object sender, EventArgs e)
        {
            mission_remove();
        }
        private void b_m_Down_Click(object sender, EventArgs e)
        {
            mission_move(true);
        }
        private void b_m_Up_Click(object sender, EventArgs e)
        {
            mission_move(false);
        }

        private void t_NodeText_Tick(object sender, EventArgs e)
        {
            t_NodeText.Enabled = false;
            updatetreenodetexts();
        }
    }
    public class SelectionChangedEventArgs : EventArgs
    {
        public KmtEntry Entry { get; private set; }

        public SelectionChangedEventArgs(KmtEntry entry)
        {
            Entry = entry;
        }
    }
}
