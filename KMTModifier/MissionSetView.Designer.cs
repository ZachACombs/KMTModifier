namespace KMTModifier
{
    partial class MissionSetView
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
            this.components = new System.ComponentModel.Container();
            this.b_m_Remove = new System.Windows.Forms.Button();
            this.b_m_Add = new System.Windows.Forms.Button();
            this.b_m_Down = new System.Windows.Forms.Button();
            this.b_m_Up = new System.Windows.Forms.Button();
            this.tv_Missions = new System.Windows.Forms.TreeView();
            this.t_NodeText = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // b_m_Remove
            // 
            this.b_m_Remove.Enabled = false;
            this.b_m_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_m_Remove.Image = global::KMTModifier.Properties.Resources.remove;
            this.b_m_Remove.Location = new System.Drawing.Point(143, 117);
            this.b_m_Remove.Name = "b_m_Remove";
            this.b_m_Remove.Size = new System.Drawing.Size(32, 32);
            this.b_m_Remove.TabIndex = 5;
            this.b_m_Remove.UseVisualStyleBackColor = true;
            this.b_m_Remove.Click += new System.EventHandler(this.b_m_Remove_Click);
            // 
            // b_m_Add
            // 
            this.b_m_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_m_Add.Image = global::KMTModifier.Properties.Resources.add;
            this.b_m_Add.Location = new System.Drawing.Point(143, 79);
            this.b_m_Add.Name = "b_m_Add";
            this.b_m_Add.Size = new System.Drawing.Size(32, 32);
            this.b_m_Add.TabIndex = 4;
            this.b_m_Add.UseVisualStyleBackColor = true;
            this.b_m_Add.Click += new System.EventHandler(this.b_m_Add_Click);
            // 
            // b_m_Down
            // 
            this.b_m_Down.Enabled = false;
            this.b_m_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_m_Down.Image = global::KMTModifier.Properties.Resources.arrow_down;
            this.b_m_Down.Location = new System.Drawing.Point(143, 41);
            this.b_m_Down.Name = "b_m_Down";
            this.b_m_Down.Size = new System.Drawing.Size(32, 32);
            this.b_m_Down.TabIndex = 3;
            this.b_m_Down.UseVisualStyleBackColor = true;
            this.b_m_Down.Click += new System.EventHandler(this.b_m_Down_Click);
            // 
            // b_m_Up
            // 
            this.b_m_Up.Enabled = false;
            this.b_m_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_m_Up.Image = global::KMTModifier.Properties.Resources.arrow_up;
            this.b_m_Up.Location = new System.Drawing.Point(143, 3);
            this.b_m_Up.Name = "b_m_Up";
            this.b_m_Up.Size = new System.Drawing.Size(32, 32);
            this.b_m_Up.TabIndex = 2;
            this.b_m_Up.UseVisualStyleBackColor = true;
            this.b_m_Up.Click += new System.EventHandler(this.b_m_Up_Click);
            // 
            // tv_Missions
            // 
            this.tv_Missions.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv_Missions.HideSelection = false;
            this.tv_Missions.Location = new System.Drawing.Point(0, 0);
            this.tv_Missions.Name = "tv_Missions";
            this.tv_Missions.Size = new System.Drawing.Size(134, 346);
            this.tv_Missions.TabIndex = 0;
            this.tv_Missions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Missions_AfterSelect);
            // 
            // t_NodeText
            // 
            this.t_NodeText.Interval = 1000;
            this.t_NodeText.Tick += new System.EventHandler(this.t_NodeText_Tick);
            // 
            // MissionSetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv_Missions);
            this.Controls.Add(this.b_m_Up);
            this.Controls.Add(this.b_m_Down);
            this.Controls.Add(this.b_m_Add);
            this.Controls.Add(this.b_m_Remove);
            this.Name = "MissionSetView";
            this.Size = new System.Drawing.Size(179, 346);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_m_Remove;
        private System.Windows.Forms.Button b_m_Add;
        private System.Windows.Forms.Button b_m_Down;
        private System.Windows.Forms.Button b_m_Up;
        private System.Windows.Forms.TreeView tv_Missions;
        private System.Windows.Forms.Timer t_NodeText;
    }
}
