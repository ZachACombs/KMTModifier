namespace KMTModifier
{
    partial class Form_CPUs
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
            this.dgv_CPUs = new System.Windows.Forms.DataGridView();
            this.Character = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.b_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CPUs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CPUs
            // 
            this.dgv_CPUs.AllowUserToAddRows = false;
            this.dgv_CPUs.AllowUserToDeleteRows = false;
            this.dgv_CPUs.AllowUserToResizeColumns = false;
            this.dgv_CPUs.AllowUserToResizeRows = false;
            this.dgv_CPUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CPUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Character,
            this.Vehicle});
            this.dgv_CPUs.Location = new System.Drawing.Point(0, 27);
            this.dgv_CPUs.Name = "dgv_CPUs";
            this.dgv_CPUs.Size = new System.Drawing.Size(300, 279);
            this.dgv_CPUs.TabIndex = 0;
            this.dgv_CPUs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CPUs_CellEndEdit);
            this.dgv_CPUs.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CPUs_RowLeave);
            this.dgv_CPUs.SelectionChanged += new System.EventHandler(this.dgv_CPUs_SelectionChanged);
            // 
            // Character
            // 
            this.Character.HeaderText = "Character";
            this.Character.Name = "Character";
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Vehicle";
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Width = 140;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Add,
            this.menu_Delete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Add
            // 
            this.menu_Add.Name = "menu_Add";
            this.menu_Add.Size = new System.Drawing.Size(41, 20);
            this.menu_Add.Text = "Add";
            this.menu_Add.Click += new System.EventHandler(this.menu_Add_Click);
            // 
            // menu_Delete
            // 
            this.menu_Delete.Enabled = false;
            this.menu_Delete.Name = "menu_Delete";
            this.menu_Delete.Size = new System.Drawing.Size(52, 20);
            this.menu_Delete.Text = "Delete";
            this.menu_Delete.Click += new System.EventHandler(this.menu_Delete_Click);
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(213, 312);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 3;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // Form_CPUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 347);
            this.Controls.Add(this.dgv_CPUs);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CPUs";
            this.Text = "Form_CPUs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CPUs_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CPUs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CPUs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Add;
        private System.Windows.Forms.ToolStripMenuItem menu_Delete;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.DataGridViewComboBoxColumn Character;
        private System.Windows.Forms.DataGridViewComboBoxColumn Vehicle;
    }
}