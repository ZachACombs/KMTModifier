namespace KMTModifier
{
    partial class Form_Course
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
            this.p_Courses = new System.Windows.Forms.Panel();
            this.flp_Courses = new System.Windows.Forms.FlowLayoutPanel();
            this.b_OK = new System.Windows.Forms.Button();
            this.flp_Courses.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Courses
            // 
            this.p_Courses.Location = new System.Drawing.Point(0, 0);
            this.p_Courses.Margin = new System.Windows.Forms.Padding(0);
            this.p_Courses.Name = "p_Courses";
            this.p_Courses.Size = new System.Drawing.Size(200, 100);
            this.p_Courses.TabIndex = 0;
            // 
            // flp_Courses
            // 
            this.flp_Courses.AutoSize = true;
            this.flp_Courses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Courses.Controls.Add(this.p_Courses);
            this.flp_Courses.Controls.Add(this.b_OK);
            this.flp_Courses.Location = new System.Drawing.Point(0, 0);
            this.flp_Courses.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Courses.Name = "flp_Courses";
            this.flp_Courses.Size = new System.Drawing.Size(281, 100);
            this.flp_Courses.TabIndex = 1;
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(203, 3);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 1;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // Form_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(417, 259);
            this.Controls.Add(this.flp_Courses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Course";
            this.Text = "Select Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Course_FormClosing);
            this.flp_Courses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Courses;
        private System.Windows.Forms.FlowLayoutPanel flp_Courses;
        private System.Windows.Forms.Button b_OK;
    }
}