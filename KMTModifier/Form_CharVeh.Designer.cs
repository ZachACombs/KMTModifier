namespace KMTModifier
{
    partial class Form_CharVeh
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
            this.flp_CharVeh = new System.Windows.Forms.FlowLayoutPanel();
            this.p_CharVeh = new System.Windows.Forms.Panel();
            this.b_PrevNext = new System.Windows.Forms.Button();
            this.b_Finish = new System.Windows.Forms.Button();
            this.flp_CharVeh.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_CharVeh
            // 
            this.flp_CharVeh.AutoSize = true;
            this.flp_CharVeh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_CharVeh.Controls.Add(this.p_CharVeh);
            this.flp_CharVeh.Controls.Add(this.b_PrevNext);
            this.flp_CharVeh.Controls.Add(this.b_Finish);
            this.flp_CharVeh.Location = new System.Drawing.Point(0, 0);
            this.flp_CharVeh.Margin = new System.Windows.Forms.Padding(0);
            this.flp_CharVeh.Name = "flp_CharVeh";
            this.flp_CharVeh.Size = new System.Drawing.Size(562, 60);
            this.flp_CharVeh.TabIndex = 0;
            // 
            // p_CharVeh
            // 
            this.p_CharVeh.Location = new System.Drawing.Point(0, 0);
            this.p_CharVeh.Margin = new System.Windows.Forms.Padding(0);
            this.p_CharVeh.Name = "p_CharVeh";
            this.p_CharVeh.Size = new System.Drawing.Size(400, 60);
            this.p_CharVeh.TabIndex = 0;
            // 
            // b_PrevNext
            // 
            this.b_PrevNext.Location = new System.Drawing.Point(403, 3);
            this.b_PrevNext.Name = "b_PrevNext";
            this.b_PrevNext.Size = new System.Drawing.Size(75, 23);
            this.b_PrevNext.TabIndex = 1;
            this.b_PrevNext.Text = "Next";
            this.b_PrevNext.UseVisualStyleBackColor = true;
            this.b_PrevNext.Click += new System.EventHandler(this.b_PrevNext_Click);
            // 
            // b_Finish
            // 
            this.b_Finish.Location = new System.Drawing.Point(484, 3);
            this.b_Finish.Name = "b_Finish";
            this.b_Finish.Size = new System.Drawing.Size(75, 23);
            this.b_Finish.TabIndex = 2;
            this.b_Finish.Text = "Finish";
            this.b_Finish.UseVisualStyleBackColor = true;
            this.b_Finish.Click += new System.EventHandler(this.b_Finish_Click);
            // 
            // Form_CharVeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flp_CharVeh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CharVeh";
            this.Text = "Form_CharVeh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CharVeh_FormClosing);
            this.flp_CharVeh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_CharVeh;
        private System.Windows.Forms.Panel p_CharVeh;
        private System.Windows.Forms.Button b_PrevNext;
        private System.Windows.Forms.Button b_Finish;
    }
}