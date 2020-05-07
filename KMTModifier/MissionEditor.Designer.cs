namespace KMTModifier
{
    partial class MissionEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Class = new System.Windows.Forms.GroupBox();
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.gb_Course = new System.Windows.Forms.GroupBox();
            this.b_Course = new System.Windows.Forms.Button();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.gb_CharVeh = new System.Windows.Forms.GroupBox();
            this.b_CharVeh = new System.Windows.Forms.Button();
            this.cb_CharVeh_Veh = new System.Windows.Forms.ComboBox();
            this.cb_CharVeh_Char = new System.Windows.Forms.ComboBox();
            this.gb_GameMode = new System.Windows.Forms.GroupBox();
            this.tb_GameMode = new System.Windows.Forms.TextBox();
            this.cb_GameMode = new System.Windows.Forms.ComboBox();
            this.gb_Cannon = new System.Windows.Forms.GroupBox();
            this.tb_Cannon = new System.Windows.Forms.TextBox();
            this.gb_CPUs = new System.Windows.Forms.GroupBox();
            this.b_CPUs = new System.Windows.Forms.Button();
            this.tpl_CPUs = new System.Windows.Forms.TableLayoutPanel();
            this.tb_CPUs_Characters = new System.Windows.Forms.TextBox();
            this.tb_CPUs_Vehicles = new System.Windows.Forms.TextBox();
            this.gb_Minimap = new System.Windows.Forms.GroupBox();
            this.tb_Minimap = new System.Windows.Forms.TextBox();
            this.gb_Controller = new System.Windows.Forms.GroupBox();
            this.tb_Controller = new System.Windows.Forms.TextBox();
            this.gb_Score = new System.Windows.Forms.GroupBox();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.gb_Time = new System.Windows.Forms.GroupBox();
            this.tb_ro_Time = new System.Windows.Forms.TextBox();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.gb_mrf = new System.Windows.Forms.GroupBox();
            this.tb_ro_mrf = new System.Windows.Forms.TextBox();
            this.tb_mrf = new System.Windows.Forms.TextBox();
            this.gb_Camera = new System.Windows.Forms.GroupBox();
            this.cb_Camera = new System.Windows.Forms.ComboBox();
            this.gb_Class.SuspendLayout();
            this.gb_Course.SuspendLayout();
            this.gb_CharVeh.SuspendLayout();
            this.gb_GameMode.SuspendLayout();
            this.gb_Cannon.SuspendLayout();
            this.gb_CPUs.SuspendLayout();
            this.tpl_CPUs.SuspendLayout();
            this.gb_Minimap.SuspendLayout();
            this.gb_Controller.SuspendLayout();
            this.gb_Score.SuspendLayout();
            this.gb_Time.SuspendLayout();
            this.gb_mrf.SuspendLayout();
            this.gb_Camera.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Class
            // 
            this.gb_Class.Controls.Add(this.cb_Class);
            this.gb_Class.Location = new System.Drawing.Point(3, 175);
            this.gb_Class.Name = "gb_Class";
            this.gb_Class.Size = new System.Drawing.Size(83, 45);
            this.gb_Class.TabIndex = 16;
            this.gb_Class.TabStop = false;
            this.gb_Class.Text = "Engine Class";
            // 
            // cb_Class
            // 
            this.cb_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(6, 14);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(64, 21);
            this.cb_Class.TabIndex = 8;
            this.cb_Class.SelectedIndexChanged += new System.EventHandler(this.cb_Class_SelectedIndexChanged);
            // 
            // gb_Course
            // 
            this.gb_Course.AutoSize = true;
            this.gb_Course.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_Course.Controls.Add(this.b_Course);
            this.gb_Course.Controls.Add(this.cb_Course);
            this.gb_Course.Location = new System.Drawing.Point(9, 264);
            this.gb_Course.Name = "gb_Course";
            this.gb_Course.Size = new System.Drawing.Size(287, 59);
            this.gb_Course.TabIndex = 15;
            this.gb_Course.TabStop = false;
            this.gb_Course.Text = "Course";
            // 
            // b_Course
            // 
            this.b_Course.Location = new System.Drawing.Point(194, 17);
            this.b_Course.Name = "b_Course";
            this.b_Course.Size = new System.Drawing.Size(87, 23);
            this.b_Course.TabIndex = 2;
            this.b_Course.Text = "Select Course";
            this.b_Course.UseVisualStyleBackColor = true;
            this.b_Course.Click += new System.EventHandler(this.b_Course_Click);
            // 
            // cb_Course
            // 
            this.cb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Location = new System.Drawing.Point(6, 19);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(182, 21);
            this.cb_Course.TabIndex = 1;
            this.cb_Course.SelectedIndexChanged += new System.EventHandler(this.cb_Course_SelectedIndexChanged);
            // 
            // gb_CharVeh
            // 
            this.gb_CharVeh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_CharVeh.Controls.Add(this.b_CharVeh);
            this.gb_CharVeh.Controls.Add(this.cb_CharVeh_Veh);
            this.gb_CharVeh.Controls.Add(this.cb_CharVeh_Char);
            this.gb_CharVeh.Location = new System.Drawing.Point(92, 175);
            this.gb_CharVeh.Name = "gb_CharVeh";
            this.gb_CharVeh.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gb_CharVeh.Size = new System.Drawing.Size(232, 83);
            this.gb_CharVeh.TabIndex = 14;
            this.gb_CharVeh.TabStop = false;
            this.gb_CharVeh.Text = "Character/Vehicle";
            // 
            // b_CharVeh
            // 
            this.b_CharVeh.Location = new System.Drawing.Point(6, 46);
            this.b_CharVeh.Name = "b_CharVeh";
            this.b_CharVeh.Size = new System.Drawing.Size(214, 23);
            this.b_CharVeh.TabIndex = 17;
            this.b_CharVeh.Text = "Select Character/Vehicle";
            this.b_CharVeh.UseVisualStyleBackColor = true;
            this.b_CharVeh.Click += new System.EventHandler(this.b_CharVeh_Click);
            // 
            // cb_CharVeh_Veh
            // 
            this.cb_CharVeh_Veh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CharVeh_Veh.FormattingEnabled = true;
            this.cb_CharVeh_Veh.Location = new System.Drawing.Point(99, 19);
            this.cb_CharVeh_Veh.Name = "cb_CharVeh_Veh";
            this.cb_CharVeh_Veh.Size = new System.Drawing.Size(121, 21);
            this.cb_CharVeh_Veh.TabIndex = 16;
            this.cb_CharVeh_Veh.SelectedIndexChanged += new System.EventHandler(this.cb_CharVeh_Veh_SelectedIndexChanged);
            // 
            // cb_CharVeh_Char
            // 
            this.cb_CharVeh_Char.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CharVeh_Char.FormattingEnabled = true;
            this.cb_CharVeh_Char.Location = new System.Drawing.Point(6, 19);
            this.cb_CharVeh_Char.Name = "cb_CharVeh_Char";
            this.cb_CharVeh_Char.Size = new System.Drawing.Size(87, 21);
            this.cb_CharVeh_Char.TabIndex = 15;
            this.cb_CharVeh_Char.SelectedIndexChanged += new System.EventHandler(this.cb_CharVeh_Char_SelectedIndexChanged);
            // 
            // gb_GameMode
            // 
            this.gb_GameMode.Controls.Add(this.tb_GameMode);
            this.gb_GameMode.Controls.Add(this.cb_GameMode);
            this.gb_GameMode.Location = new System.Drawing.Point(3, 3);
            this.gb_GameMode.Name = "gb_GameMode";
            this.gb_GameMode.Size = new System.Drawing.Size(370, 84);
            this.gb_GameMode.TabIndex = 3;
            this.gb_GameMode.TabStop = false;
            this.gb_GameMode.Text = "Game Mode";
            // 
            // tb_GameMode
            // 
            this.tb_GameMode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_GameMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_GameMode.Location = new System.Drawing.Point(133, 10);
            this.tb_GameMode.Multiline = true;
            this.tb_GameMode.Name = "tb_GameMode";
            this.tb_GameMode.ReadOnly = true;
            this.tb_GameMode.Size = new System.Drawing.Size(231, 67);
            this.tb_GameMode.TabIndex = 1;
            // 
            // cb_GameMode
            // 
            this.cb_GameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GameMode.FormattingEnabled = true;
            this.cb_GameMode.Location = new System.Drawing.Point(6, 19);
            this.cb_GameMode.Name = "cb_GameMode";
            this.cb_GameMode.Size = new System.Drawing.Size(121, 21);
            this.cb_GameMode.TabIndex = 0;
            this.cb_GameMode.SelectedIndexChanged += new System.EventHandler(this.cb_GameMode_SelectedIndexChanged);
            // 
            // gb_Cannon
            // 
            this.gb_Cannon.Controls.Add(this.tb_Cannon);
            this.gb_Cannon.Location = new System.Drawing.Point(379, 3);
            this.gb_Cannon.Name = "gb_Cannon";
            this.gb_Cannon.Size = new System.Drawing.Size(113, 53);
            this.gb_Cannon.TabIndex = 12;
            this.gb_Cannon.TabStop = false;
            this.gb_Cannon.Text = "Cannon Flag";
            // 
            // tb_Cannon
            // 
            this.tb_Cannon.Location = new System.Drawing.Point(7, 23);
            this.tb_Cannon.Name = "tb_Cannon";
            this.tb_Cannon.Size = new System.Drawing.Size(100, 20);
            this.tb_Cannon.TabIndex = 0;
            this.tb_Cannon.TextChanged += new System.EventHandler(this.tb_Cannon_TextChanged);
            this.tb_Cannon.Leave += new System.EventHandler(this.tb_Cannon_Leave);
            // 
            // gb_CPUs
            // 
            this.gb_CPUs.Controls.Add(this.b_CPUs);
            this.gb_CPUs.Controls.Add(this.tpl_CPUs);
            this.gb_CPUs.Location = new System.Drawing.Point(379, 120);
            this.gb_CPUs.Name = "gb_CPUs";
            this.gb_CPUs.Size = new System.Drawing.Size(232, 200);
            this.gb_CPUs.TabIndex = 13;
            this.gb_CPUs.TabStop = false;
            this.gb_CPUs.Text = "CPUs";
            // 
            // b_CPUs
            // 
            this.b_CPUs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_CPUs.Location = new System.Drawing.Point(3, 174);
            this.b_CPUs.Name = "b_CPUs";
            this.b_CPUs.Size = new System.Drawing.Size(226, 23);
            this.b_CPUs.TabIndex = 1;
            this.b_CPUs.Text = "Edit CPUs";
            this.b_CPUs.UseVisualStyleBackColor = true;
            this.b_CPUs.Click += new System.EventHandler(this.b_CPUs_Click);
            // 
            // tpl_CPUs
            // 
            this.tpl_CPUs.ColumnCount = 2;
            this.tpl_CPUs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl_CPUs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl_CPUs.Controls.Add(this.tb_CPUs_Characters, 0, 0);
            this.tpl_CPUs.Controls.Add(this.tb_CPUs_Vehicles, 1, 0);
            this.tpl_CPUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpl_CPUs.Location = new System.Drawing.Point(3, 16);
            this.tpl_CPUs.Name = "tpl_CPUs";
            this.tpl_CPUs.RowCount = 1;
            this.tpl_CPUs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl_CPUs.Size = new System.Drawing.Size(226, 152);
            this.tpl_CPUs.TabIndex = 0;
            // 
            // tb_CPUs_Characters
            // 
            this.tb_CPUs_Characters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_CPUs_Characters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CPUs_Characters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CPUs_Characters.Location = new System.Drawing.Point(3, 3);
            this.tb_CPUs_Characters.Multiline = true;
            this.tb_CPUs_Characters.Name = "tb_CPUs_Characters";
            this.tb_CPUs_Characters.ReadOnly = true;
            this.tb_CPUs_Characters.Size = new System.Drawing.Size(107, 146);
            this.tb_CPUs_Characters.TabIndex = 0;
            // 
            // tb_CPUs_Vehicles
            // 
            this.tb_CPUs_Vehicles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_CPUs_Vehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CPUs_Vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CPUs_Vehicles.Location = new System.Drawing.Point(116, 3);
            this.tb_CPUs_Vehicles.Multiline = true;
            this.tb_CPUs_Vehicles.Name = "tb_CPUs_Vehicles";
            this.tb_CPUs_Vehicles.ReadOnly = true;
            this.tb_CPUs_Vehicles.Size = new System.Drawing.Size(107, 146);
            this.tb_CPUs_Vehicles.TabIndex = 1;
            this.tb_CPUs_Vehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_Minimap
            // 
            this.gb_Minimap.Controls.Add(this.tb_Minimap);
            this.gb_Minimap.Location = new System.Drawing.Point(498, 3);
            this.gb_Minimap.Name = "gb_Minimap";
            this.gb_Minimap.Size = new System.Drawing.Size(113, 50);
            this.gb_Minimap.TabIndex = 11;
            this.gb_Minimap.TabStop = false;
            this.gb_Minimap.Text = "Minimap Object";
            // 
            // tb_Minimap
            // 
            this.tb_Minimap.Location = new System.Drawing.Point(6, 19);
            this.tb_Minimap.Name = "tb_Minimap";
            this.tb_Minimap.Size = new System.Drawing.Size(100, 20);
            this.tb_Minimap.TabIndex = 0;
            this.tb_Minimap.TextChanged += new System.EventHandler(this.tb_Minimap_TextChanged);
            this.tb_Minimap.Leave += new System.EventHandler(this.tb_Minimap_Leave);
            // 
            // gb_Controller
            // 
            this.gb_Controller.Controls.Add(this.tb_Controller);
            this.gb_Controller.Location = new System.Drawing.Point(498, 62);
            this.gb_Controller.Name = "gb_Controller";
            this.gb_Controller.Size = new System.Drawing.Size(113, 61);
            this.gb_Controller.TabIndex = 10;
            this.gb_Controller.TabStop = false;
            this.gb_Controller.Text = "Controller Restriction";
            // 
            // tb_Controller
            // 
            this.tb_Controller.Location = new System.Drawing.Point(6, 30);
            this.tb_Controller.Name = "tb_Controller";
            this.tb_Controller.Size = new System.Drawing.Size(101, 20);
            this.tb_Controller.TabIndex = 0;
            this.tb_Controller.TextChanged += new System.EventHandler(this.tb_Controller_TextChanged);
            this.tb_Controller.Leave += new System.EventHandler(this.tb_Controller_Leave);
            // 
            // gb_Score
            // 
            this.gb_Score.Controls.Add(this.tb_Score);
            this.gb_Score.Location = new System.Drawing.Point(241, 101);
            this.gb_Score.Name = "gb_Score";
            this.gb_Score.Size = new System.Drawing.Size(112, 55);
            this.gb_Score.TabIndex = 4;
            this.gb_Score.TabStop = false;
            this.gb_Score.Text = "Score Required";
            // 
            // tb_Score
            // 
            this.tb_Score.Location = new System.Drawing.Point(6, 19);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(100, 20);
            this.tb_Score.TabIndex = 0;
            this.tb_Score.TextChanged += new System.EventHandler(this.tb_Score_TextChanged);
            this.tb_Score.Leave += new System.EventHandler(this.tb_Score_Leave);
            // 
            // gb_Time
            // 
            this.gb_Time.Controls.Add(this.tb_ro_Time);
            this.gb_Time.Controls.Add(this.tb_Time);
            this.gb_Time.Location = new System.Drawing.Point(122, 98);
            this.gb_Time.Name = "gb_Time";
            this.gb_Time.Size = new System.Drawing.Size(113, 71);
            this.gb_Time.TabIndex = 5;
            this.gb_Time.TabStop = false;
            this.gb_Time.Text = "Time Limit";
            // 
            // tb_ro_Time
            // 
            this.tb_ro_Time.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_ro_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ro_Time.Location = new System.Drawing.Point(6, 45);
            this.tb_ro_Time.Name = "tb_ro_Time";
            this.tb_ro_Time.ReadOnly = true;
            this.tb_ro_Time.Size = new System.Drawing.Size(100, 13);
            this.tb_ro_Time.TabIndex = 2;
            // 
            // tb_Time
            // 
            this.tb_Time.Location = new System.Drawing.Point(6, 19);
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(100, 20);
            this.tb_Time.TabIndex = 1;
            this.tb_Time.TextChanged += new System.EventHandler(this.tb_Time_TextChanged);
            this.tb_Time.Leave += new System.EventHandler(this.tb_Time_Leave);
            // 
            // gb_mrf
            // 
            this.gb_mrf.Controls.Add(this.tb_ro_mrf);
            this.gb_mrf.Controls.Add(this.tb_mrf);
            this.gb_mrf.Location = new System.Drawing.Point(3, 93);
            this.gb_mrf.Name = "gb_mrf";
            this.gb_mrf.Size = new System.Drawing.Size(113, 76);
            this.gb_mrf.TabIndex = 6;
            this.gb_mrf.TabStop = false;
            this.gb_mrf.Text = "Mission Run File";
            // 
            // tb_ro_mrf
            // 
            this.tb_ro_mrf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_ro_mrf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ro_mrf.Location = new System.Drawing.Point(6, 47);
            this.tb_ro_mrf.Name = "tb_ro_mrf";
            this.tb_ro_mrf.ReadOnly = true;
            this.tb_ro_mrf.Size = new System.Drawing.Size(100, 13);
            this.tb_ro_mrf.TabIndex = 1;
            // 
            // tb_mrf
            // 
            this.tb_mrf.Location = new System.Drawing.Point(6, 24);
            this.tb_mrf.Name = "tb_mrf";
            this.tb_mrf.Size = new System.Drawing.Size(100, 20);
            this.tb_mrf.TabIndex = 0;
            this.tb_mrf.TextChanged += new System.EventHandler(this.tb_mrf_TextChanged);
            this.tb_mrf.Leave += new System.EventHandler(this.tb_mrf_Leave);
            // 
            // gb_Camera
            // 
            this.gb_Camera.Controls.Add(this.cb_Camera);
            this.gb_Camera.Location = new System.Drawing.Point(379, 62);
            this.gb_Camera.Name = "gb_Camera";
            this.gb_Camera.Size = new System.Drawing.Size(112, 48);
            this.gb_Camera.TabIndex = 9;
            this.gb_Camera.TabStop = false;
            this.gb_Camera.Text = "Camera";
            // 
            // cb_Camera
            // 
            this.cb_Camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Camera.FormattingEnabled = true;
            this.cb_Camera.Location = new System.Drawing.Point(6, 19);
            this.cb_Camera.Name = "cb_Camera";
            this.cb_Camera.Size = new System.Drawing.Size(100, 21);
            this.cb_Camera.TabIndex = 0;
            this.cb_Camera.SelectedIndexChanged += new System.EventHandler(this.cb_Camera_SelectedIndexChanged);
            // 
            // MissionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.gb_CPUs);
            this.Controls.Add(this.gb_Course);
            this.Controls.Add(this.gb_Class);
            this.Controls.Add(this.gb_CharVeh);
            this.Controls.Add(this.gb_GameMode);
            this.Controls.Add(this.gb_Cannon);
            this.Controls.Add(this.gb_Minimap);
            this.Controls.Add(this.gb_Score);
            this.Controls.Add(this.gb_Controller);
            this.Controls.Add(this.gb_Time);
            this.Controls.Add(this.gb_Camera);
            this.Controls.Add(this.gb_mrf);
            this.Name = "MissionEditor";
            this.Size = new System.Drawing.Size(614, 326);
            this.gb_Class.ResumeLayout(false);
            this.gb_Course.ResumeLayout(false);
            this.gb_CharVeh.ResumeLayout(false);
            this.gb_GameMode.ResumeLayout(false);
            this.gb_GameMode.PerformLayout();
            this.gb_Cannon.ResumeLayout(false);
            this.gb_Cannon.PerformLayout();
            this.gb_CPUs.ResumeLayout(false);
            this.tpl_CPUs.ResumeLayout(false);
            this.tpl_CPUs.PerformLayout();
            this.gb_Minimap.ResumeLayout(false);
            this.gb_Minimap.PerformLayout();
            this.gb_Controller.ResumeLayout(false);
            this.gb_Controller.PerformLayout();
            this.gb_Score.ResumeLayout(false);
            this.gb_Score.PerformLayout();
            this.gb_Time.ResumeLayout(false);
            this.gb_Time.PerformLayout();
            this.gb_mrf.ResumeLayout(false);
            this.gb_mrf.PerformLayout();
            this.gb_Camera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Class;
        private System.Windows.Forms.ComboBox cb_Class;
        private System.Windows.Forms.GroupBox gb_Course;
        private System.Windows.Forms.Button b_Course;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.GroupBox gb_CharVeh;
        private System.Windows.Forms.Button b_CharVeh;
        private System.Windows.Forms.ComboBox cb_CharVeh_Veh;
        private System.Windows.Forms.ComboBox cb_CharVeh_Char;
        private System.Windows.Forms.GroupBox gb_CPUs;
        private System.Windows.Forms.Button b_CPUs;
        private System.Windows.Forms.TableLayoutPanel tpl_CPUs;
        private System.Windows.Forms.TextBox tb_CPUs_Characters;
        private System.Windows.Forms.TextBox tb_CPUs_Vehicles;
        private System.Windows.Forms.GroupBox gb_Minimap;
        private System.Windows.Forms.TextBox tb_Minimap;
        private System.Windows.Forms.GroupBox gb_Controller;
        private System.Windows.Forms.TextBox tb_Controller;
        private System.Windows.Forms.GroupBox gb_Score;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.GroupBox gb_Time;
        private System.Windows.Forms.TextBox tb_ro_Time;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.GroupBox gb_mrf;
        private System.Windows.Forms.TextBox tb_ro_mrf;
        private System.Windows.Forms.TextBox tb_mrf;
        private System.Windows.Forms.GroupBox gb_Camera;
        private System.Windows.Forms.ComboBox cb_Camera;
        private System.Windows.Forms.GroupBox gb_GameMode;
        private System.Windows.Forms.TextBox tb_GameMode;
        private System.Windows.Forms.ComboBox cb_GameMode;
        private System.Windows.Forms.GroupBox gb_Cannon;
        private System.Windows.Forms.TextBox tb_Cannon;
    }
}
