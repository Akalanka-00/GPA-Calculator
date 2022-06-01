namespace GPA_Calculator
{
    partial class GPA_CAL
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gpaLab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sgpaLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lvlCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rsDataView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 782);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rsDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(83, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 659);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::GPA_Calculator.Properties.Resources.back;
            this.panel6.Controls.Add(this.gpaLab);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.sgpaLab);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(83, 721);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1118, 61);
            this.panel6.TabIndex = 3;
            // 
            // gpaLab
            // 
            this.gpaLab.AutoSize = true;
            this.gpaLab.ForeColor = System.Drawing.Color.White;
            this.gpaLab.Location = new System.Drawing.Point(276, 31);
            this.gpaLab.Name = "gpaLab";
            this.gpaLab.Size = new System.Drawing.Size(33, 21);
            this.gpaLab.TabIndex = 4;
            this.gpaLab.Text = "2.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(176, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total GPA";
            // 
            // sgpaLab
            // 
            this.sgpaLab.AutoSize = true;
            this.sgpaLab.ForeColor = System.Drawing.Color.White;
            this.sgpaLab.Location = new System.Drawing.Point(68, 31);
            this.sgpaLab.Name = "sgpaLab";
            this.sgpaLab.Size = new System.Drawing.Size(33, 21);
            this.sgpaLab.TabIndex = 2;
            this.sgpaLab.Text = "2.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SGPA";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::GPA_Calculator.Properties.Resources.back;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1201, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(83, 720);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::GPA_Calculator.Properties.Resources.back;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 720);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::GPA_Calculator.Properties.Resources.back;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lvlCombo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 62);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(368, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvlCombo
            // 
            this.lvlCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lvlCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lvlCombo.FormattingEnabled = true;
            this.lvlCombo.Items.AddRange(new object[] {
            "All",
            "L1S1",
            "L1S2",
            "L2S1",
            "L2S2",
            "L3S1",
            "L3S2",
            "L4S1",
            "L4S2"});
            this.lvlCombo.Location = new System.Drawing.Point(161, 22);
            this.lvlCombo.Name = "lvlCombo";
            this.lvlCombo.Size = new System.Drawing.Size(172, 29);
            this.lvlCombo.TabIndex = 1;
            this.lvlCombo.SelectedIndexChanged += new System.EventHandler(this.lvlCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select the Level";
            // 
            // rsDataView
            // 
            this.rsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rsDataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.rsDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rsDataView.Location = new System.Drawing.Point(0, 0);
            this.rsDataView.MultiSelect = false;
            this.rsDataView.Name = "rsDataView";
            this.rsDataView.ReadOnly = true;
            this.rsDataView.RowHeadersWidth = 51;
            this.rsDataView.RowTemplate.Height = 24;
            this.rsDataView.Size = new System.Drawing.Size(1118, 659);
            this.rsDataView.TabIndex = 0;
            // 
            // GPA_CAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GPA_CAL";
            this.Text = "GPA CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox lvlCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label gpaLab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sgpaLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView rsDataView;
    }
}

