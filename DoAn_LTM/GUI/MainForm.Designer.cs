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
			this.lbxStations = new System.Windows.Forms.ListBox();
			this.dgvOpenPorts = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbxStatus = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOpenPorts)).BeginInit();
			this.groupBox2.SuspendLayout();
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
			this.rbtnRange.Location = new System.Drawing.Point(6, 42);
			this.rbtnRange.Name = "rbtnRange";
			this.rbtnRange.Size = new System.Drawing.Size(57, 17);
			this.rbtnRange.TabIndex = 1;
			this.rbtnRange.Text = "Range";
			this.rbtnRange.UseVisualStyleBackColor = true;
			// 
			// rbtnFullScan
			// 
			this.rbtnFullScan.AutoSize = true;
			this.rbtnFullScan.Checked = true;
			this.rbtnFullScan.Location = new System.Drawing.Point(6, 19);
			this.rbtnFullScan.Name = "rbtnFullScan";
			this.rbtnFullScan.Size = new System.Drawing.Size(69, 17);
			this.rbtnFullScan.TabIndex = 0;
			this.rbtnFullScan.TabStop = true;
			this.rbtnFullScan.Text = "Full Scan";
			this.rbtnFullScan.UseVisualStyleBackColor = true;
			// 
			// lbxStations
			// 
			this.lbxStations.FormattingEnabled = true;
			this.lbxStations.Location = new System.Drawing.Point(12, 12);
			this.lbxStations.Name = "lbxStations";
			this.lbxStations.Size = new System.Drawing.Size(369, 134);
			this.lbxStations.TabIndex = 4;
			// 
			// dgvOpenPorts
			// 
			this.dgvOpenPorts.AllowUserToAddRows = false;
			this.dgvOpenPorts.AllowUserToDeleteRows = false;
			this.dgvOpenPorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOpenPorts.Location = new System.Drawing.Point(12, 152);
			this.dgvOpenPorts.Name = "dgvOpenPorts";
			this.dgvOpenPorts.ReadOnly = true;
			this.dgvOpenPorts.Size = new System.Drawing.Size(369, 114);
			this.dgvOpenPorts.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbxStatus);
			this.groupBox2.Location = new System.Drawing.Point(387, 196);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(173, 70);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Status";
			// 
			// lbxStatus
			// 
			this.lbxStatus.FormattingEnabled = true;
			this.lbxStatus.Location = new System.Drawing.Point(6, 19);
			this.lbxStatus.Name = "lbxStatus";
			this.lbxStatus.Size = new System.Drawing.Size(157, 43);
			this.lbxStatus.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 278);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dgvOpenPorts);
			this.Controls.Add(this.lbxStations);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnFindStations);
			this.Controls.Add(this.btnScan);
			this.MaximumSize = new System.Drawing.Size(588, 317);
			this.MinimumSize = new System.Drawing.Size(588, 317);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOpenPorts)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.Button btnFindStations;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbtnRange;
		private System.Windows.Forms.RadioButton rbtnFullScan;
		private System.Windows.Forms.ListBox lbxStations;
		private System.Windows.Forms.DataGridView dgvOpenPorts;
		private System.Windows.Forms.NumericUpDown nudFrom;
		private System.Windows.Forms.NumericUpDown nudTo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox lbxStatus;
	}
}