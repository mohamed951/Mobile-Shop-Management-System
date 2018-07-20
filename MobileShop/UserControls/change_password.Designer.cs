namespace SkypeDemo.UserControls
{
    partial class change_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_password));
            this.label5 = new System.Windows.Forms.Label();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.RNewPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OldPass = new System.Windows.Forms.TextBox();
            this.AddEmpB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(139, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "New Password";
            // 
            // NewPass
            // 
            this.NewPass.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.NewPass.Location = new System.Drawing.Point(357, 197);
            this.NewPass.Margin = new System.Windows.Forms.Padding(0);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(248, 33);
            this.NewPass.TabIndex = 52;
            this.NewPass.UseSystemPasswordChar = true;
            // 
            // RNewPass
            // 
            this.RNewPass.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.RNewPass.Location = new System.Drawing.Point(357, 264);
            this.RNewPass.Margin = new System.Windows.Forms.Padding(0);
            this.RNewPass.Name = "RNewPass";
            this.RNewPass.Size = new System.Drawing.Size(248, 33);
            this.RNewPass.TabIndex = 53;
            this.RNewPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Re-Enter New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Enter Old Password";
            // 
            // OldPass
            // 
            this.OldPass.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.OldPass.Location = new System.Drawing.Point(357, 91);
            this.OldPass.Margin = new System.Windows.Forms.Padding(0);
            this.OldPass.Name = "OldPass";
            this.OldPass.Size = new System.Drawing.Size(248, 33);
            this.OldPass.TabIndex = 59;
            this.OldPass.UseSystemPasswordChar = true;
            // 
            // AddEmpB
            // 
            this.AddEmpB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddEmpB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEmpB.BackColor = System.Drawing.Color.Green;
            this.AddEmpB.FlatAppearance.BorderSize = 0;
            this.AddEmpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmpB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpB.ForeColor = System.Drawing.Color.White;
            this.AddEmpB.Image = ((System.Drawing.Image)(resources.GetObject("AddEmpB.Image")));
            this.AddEmpB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEmpB.Location = new System.Drawing.Point(558, 379);
            this.AddEmpB.Name = "AddEmpB";
            this.AddEmpB.Size = new System.Drawing.Size(163, 54);
            this.AddEmpB.TabIndex = 60;
            this.AddEmpB.Text = "  Save";
            this.AddEmpB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmpB.UseVisualStyleBackColor = false;
            this.AddEmpB.Click += new System.EventHandler(this.AddEmpB_Click);
            // 
            // change_password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.AddEmpB);
            this.Controls.Add(this.OldPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RNewPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.label5);
            this.Name = "change_password";
            this.Size = new System.Drawing.Size(996, 623);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox RNewPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldPass;
        private System.Windows.Forms.Button AddEmpB;
    }
}
