namespace DoAn_LTM.GUI
{
	partial class MainForm
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
			this.btnScan = new System.Windows.Forms.Button();
			this.btnFindStations = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nudTo = new System.Windows.Forms.NumericUpDown();
			this.nudFrom = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rbtnRange = new System.Windows.Forms.RadioButton();
			this.rbtnFullScan = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblSubnet = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNICName = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblBroadcast = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblNetmask = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxIP = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvStations = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lbxOpenports = new System.Windows.Forms.ListBox();
			this.pgbStatus = new System.Windows.Forms.ProgressBar();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
			this.SuspendLayout();
			// 
			// btnScan
			// 
			this.btnScan.Location = new System.Drawing.Point(387, 41);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(173, 23);
			this.btnScan.TabIndex = 1;
			this.btnScan.Text = "Scan";
			this.btnScan.UseVisualStyleBackColor = true;
			this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
			// 
			// btnFindStations
			// 
			this.btnFindStations.Location = new System.Drawing.Point(387, 12);
			this.btnFindStations.Name = "btnFindStations";
			this.btnFindStations.Size = new System.Drawing.Size(173, 23);
			this.btnFindStations.TabIndex = 2;
			this.btnFindStations.Text = "Find Stations";
			this.btnFindStations.UseVisualStyleBackColor = true;
			this.btnFindStations.Click += new System.EventHandler(this.btnFindStations_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudTo);
			this.groupBox1.Controls.Add(this.nudFrom);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.rbtnRange);
			this.groupBox1.Controls.Add(this.rbtnFullScan);
			this.groupBox1.Location = new System.Drawing.Point(387, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(173, 120);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Scan Mode";
			// 
			// nudTo
			// 
			this.nudTo.Location = new System.Drawing.Point(43, 90);
			this.nudTo.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudTo.Name = "nudTo";
			this.nudTo.Size = new System.Drawing.Size(120, 20);
			this.nudTo.TabIndex = 7;
			this.nudTo.ThousandsSeparator = true;
			this.nudTo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// nudFrom
			// 
			this.nudFrom.Location = new System.Drawing.Point(43, 64);
			this.nudFrom.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudFrom.Name = "nudFrom";
			this.nudFrom.Size = new System.Drawing.Size(120, 20);
			this.nudFrom.TabIndex = 6;
			this.nudFrom.ThousandsSeparator = true;
			this.nudFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "To";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "From";
			// 
			// rbtnRange
			// 
			this.rbtnRange.AutoSize = true;
			this.rbtnRange.Checked = true;
			this.rbtnRange.Location = new System.Drawing.Point(6, 42);
			this.rbtnRange.Name = "rbtnRange";
			this.rbtnRange.Size = new System.Drawing.Size(57, 17);
			this.rbtnRange.TabIndex = 1;
			this.rbtnRange.TabStop = true;
			this.rbtnRange.Text = "Range";
			this.rbtnRange.UseVisualStyleBackColor = true;
			// 
			// rbtnFullScan
			// 
			this.rbtnFullScan.AutoSize = true;
			this.rbtnFullScan.Location = new System.Drawing.Point(6, 19);
			this.rbtnFullScan.Name = "rbtnFullScan";
			this.rbtnFullScan.Size = new System.Drawing.Size(69, 17);
			this.rbtnFullScan.TabIndex = 0;
			this.rbtnFullScan.Text = "Full Scan";
			this.rbtnFullScan.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblSubnet);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.lblNICName);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.lblBroadcast);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.lblNetmask);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.cbxIP);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(12, 272);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox2.Size = new System.Drawing.Size(548, 72);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Local Infomation";
			// 
			// lblSubnet
			// 
			this.lblSubnet.AutoSize = true;
			this.lblSubnet.Location = new System.Drawing.Point(372, 54);
			this.lblSubnet.Name = "lblSubnet";
			this.lblSubnet.Size = new System.Drawing.Size(0, 13);
			this.lblSubnet.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(313, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Subnet:";
			// 
			// lblNICName
			// 
			this.lblNICName.AutoSize = true;
			this.lblNICName.Location = new System.Drawing.Point(378, 39);
			this.lblNICName.Name = "lblNICName";
			this.lblNICName.Size = new System.Drawing.Size(0, 13);
			this.lblNICName.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(313, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "NIC Name:";
			// 
			// lblBroadcast
			// 
			this.lblBroadcast.AutoSize = true;
			this.lblBroadcast.Location = new System.Drawing.Point(378, 26);
			this.lblBroadcast.Name = "lblBroadcast";
			this.lblBroadcast.Size = new System.Drawing.Size(0, 13);
			this.lblBroadcast.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(313, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Broadcast: ";
			// 
			// lblNetmask
			// 
			this.lblNetmask.AutoSize = true;
			this.lblNetmask.Location = new System.Drawing.Point(378, 13);
			this.lblNetmask.Name = "lblNetmask";
			this.lblNetmask.Size = new System.Drawing.Size(0, 13);
			this.lblNetmask.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(313, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Netmask:";
			// 
			// cbxIP
			// 
			this.cbxIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxIP.FormattingEnabled = true;
			this.cbxIP.Location = new System.Drawing.Point(6, 29);
			this.cbxIP.Name = "cbxIP";
			this.cbxIP.Size = new System.Drawing.Size(301, 21);
			this.cbxIP.TabIndex = 8;
			this.cbxIP.SelectedIndexChanged += new System.EventHandler(this.cbxIP_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "NICs:";
			// 
			// dgvStations
			// 
			this.dgvStations.AllowUserToAddRows = false;
			this.dgvStations.AllowUserToDeleteRows = false;
			this.dgvStations.Location = new System.Drawing.Point(12, 12);
			this.dgvStations.MultiSelect = false;
			this.dgvStations.Name = "dgvStations";
			this.dgvStations.ReadOnly = true;
			this.dgvStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStations.Size = new System.Drawing.Size(369, 134);
			this.dgvStations.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(388, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Status:";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(427, 210);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(25, 13);
			this.lblStatus.TabIndex = 9;
			this.lblStatus.Text = "___";
			// 
			// lbxOpenports
			// 
			this.lbxOpenports.FormattingEnabled = true;
			this.lbxOpenports.Location = new System.Drawing.Point(12, 152);
			this.lbxOpenports.Name = "lbxOpenports";
			this.lbxOpenports.Size = new System.Drawing.Size(369, 108);
			this.lbxOpenports.TabIndex = 10;
			// 
			// pgbStatus
			// 
			this.pgbStatus.Location = new System.Drawing.Point(387, 237);
			this.pgbStatus.Name = "pgbStatus";
			this.pgbStatus.Size = new System.Drawing.Size(173, 23);
			this.pgbStatus.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 348);
			this.Controls.Add(this.pgbStatus);
			this.Controls.Add(this.lbxOpenports);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dgvStations);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnFindStations);
			this.Controls.Add(this.btnScan);
			this.MaximumSize = new System.Drawing.Size(588, 387);
			this.MinimumSize = new System.Drawing.Size(588, 387);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.Button btnFindStations;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbtnRange;
		private System.Windows.Forms.RadioButton rbtnFullScan;
		private System.Windows.Forms.NumericUpDown nudFrom;
		private System.Windows.Forms.NumericUpDown nudTo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxIP;
		private System.Windows.Forms.Label lblNICName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblBroadcast;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblNetmask;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvStations;
		private System.Windows.Forms.Label lblSubnet;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListBox lbxOpenports;
		private System.Windows.Forms.ProgressBar pgbStatus;
	}
}