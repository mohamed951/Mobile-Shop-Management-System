namespace SkypeDemo
{
    partial class DetailsRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsRevenue));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.firstDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.endDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proftext = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 319);
            this.dataGridView1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Search by date";
            // 
            // firstDate
            // 
            this.firstDate.BackColor = System.Drawing.Color.SeaGreen;
            this.firstDate.BorderRadius = 0;
            this.firstDate.ForeColor = System.Drawing.Color.White;
            this.firstDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.firstDate.FormatCustom = null;
            this.firstDate.Location = new System.Drawing.Point(269, 16);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(246, 36);
            this.firstDate.TabIndex = 25;
            this.firstDate.Value = new System.DateTime(2018, 4, 1, 15, 56, 31, 902);
            this.firstDate.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // endDate
            // 
            this.endDate.BackColor = System.Drawing.Color.SeaGreen;
            this.endDate.BorderRadius = 0;
            this.endDate.ForeColor = System.Drawing.Color.White;
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDate.FormatCustom = null;
            this.endDate.Location = new System.Drawing.Point(553, 16);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(255, 36);
            this.endDate.TabIndex = 26;
            this.endDate.Value = new System.DateTime(2018, 4, 1, 15, 56, 31, 902);
            this.endDate.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(518, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "To";
            // 
            // proftext
            // 
            this.proftext.AutoSize = true;
            this.proftext.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.proftext.ForeColor = System.Drawing.Color.White;
            this.proftext.Location = new System.Drawing.Point(282, 465);
            this.proftext.Margin = new System.Windows.Forms.Padding(0);
            this.proftext.Name = "proftext";
            this.proftext.Size = new System.Drawing.Size(138, 24);
            this.proftext.TabIndex = 30;
            this.proftext.Text = "//Value in LE";
            this.proftext.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 464);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total Profit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // loginB
            // 
            this.loginB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginB.BackColor = System.Drawing.Color.Green;
            this.loginB.FlatAppearance.BorderSize = 0;
            this.loginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginB.ForeColor = System.Drawing.Color.White;
            this.loginB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginB.Location = new System.Drawing.Point(599, 465);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(163, 45);
            this.loginB.TabIndex = 37;
            this.loginB.Text = "   View";
            this.loginB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginB.UseVisualStyleBackColor = false;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(599, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 38;
            this.button1.Text = "   View";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailsRevenue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.proftext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DetailsRevenue";
            this.Size = new System.Drawing.Size(996, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker firstDate;
        private Bunifu.Framework.UI.BunifuDatepicker endDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label proftext;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button loginB;
        public System.Windows.Forms.Button button1;
    }
}
