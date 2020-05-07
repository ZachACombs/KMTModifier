using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMT;

namespace KMTModifier
{
    public partial class Form_CPUs : Form
    {
        DialogResult result = DialogResult.Cancel;

        public KmtCPUEntryList CPUs = new KmtCPUEntryList();

        Dictionary<KmtCharacter, string> dict_character =
            new Dictionary<KmtCharacter, string>();
        Dictionary<KmtVehicle, string> dict_vehicle =
            new Dictionary<KmtVehicle, string>();

        void update_buttons()
        {
            if (dgv_CPUs.SelectedRows.Count > 0)
            {
                menu_Delete.Enabled = true;
            }
            else
            {
                menu_Delete.Enabled = false;
            }
        }
        void update_cpus()
        {
            CPUs.Clear();
            for (int n = 0; n < dgv_CPUs.RowCount; n += 1)
            {
                int ind_char = dict_character.Values.ToList().IndexOf(
                    dgv_CPUs.Rows[n].Cells["Character"].Value.ToString());
                int ind_veh = dict_vehicle.Values.ToList().IndexOf(
                    dgv_CPUs.Rows[n].Cells["Vehicle"].Value.ToString());

                CPUs.Add(new KmtCPUEntry(
                    dict_character.Keys.ToArray()[ind_char],
                    dict_vehicle.Keys.ToArray()[ind_veh]));
            }
        }

        void Row_Add(KmtCharacter character, KmtVehicle vehicle)
        {
            dgv_CPUs.Rows.Add(dict_character[character],
                dict_vehicle[vehicle]);
            CPUs.Add(new KmtCPUEntry(character, vehicle));

            menu_Add.Enabled = (dgv_CPUs.Rows.Count < 11);
        }
        
        public Form_CPUs(
            Dictionary<KmtCharacter, NameImg> dictt_character, 
            Dictionary<KmtVehicle, NameImg> dictt_vehicle,
            KmtCPUEntryList cpuentries)
        {
            InitializeComponent();

            foreach (KeyValuePair<KmtCharacter, NameImg> entry
                in dictt_character)
            {
                dict_character.Add(entry.Key, entry.Value.Name);
                Character.Items.Add(entry.Value.Name);
            }
            foreach (KeyValuePair<KmtVehicle, NameImg> entry
                in dictt_vehicle)
            {
                dict_vehicle.Add(entry.Key, entry.Value.Name);
                Vehicle.Items.Add(entry.Value.Name);
            }

            for (int n = 0; n < cpuentries.Count; n += 1)
            {
                KmtCPUEntry entry = cpuentries[n];
                Row_Add(entry.Character, entry.Vehicle);
            }
        }

        private void menu_Add_Click(object sender, EventArgs e)
        {
            Form_CharVeh dialog = new Form_CharVeh(
                KmtCharacter.Luigi, KmtVehicle.StandardKartM);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dgv_CPUs.Rows.Add(
                    dict_character[dialog.Character],
                    dict_vehicle[dialog.Vehicle]);
            }
            update_cpus();
            update_buttons();
        }
        private void menu_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedrows =
                dgv_CPUs.SelectedRows;
            if (selectedrows.Count > 0)
            {
                int[] indexes = new int[selectedrows.Count];
                for (int n = 0; n < indexes.Length; n += 1)
                {
                    indexes[n] = selectedrows[n].Index;
                }
                Array.Sort(indexes);
                Array.Reverse(indexes);
                for (int n = 0; n < indexes.Length; n += 1)
                {
                    dgv_CPUs.Rows.RemoveAt(indexes[n]);
                }
            }
            update_cpus();
        }
        
        private void dgv_CPUs_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            menu_Delete.Enabled = false;
        }
        
        private void b_OK_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }

        private void Form_CPUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = result;
        }

        private void dgv_CPUs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            update_cpus();
        }
        
        private void dgv_CPUs_SelectionChanged(object sender, EventArgs e)
        {
            update_buttons();
        }

        
    }
}
