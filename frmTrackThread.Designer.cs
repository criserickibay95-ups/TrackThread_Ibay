namespace ThreadPriorityApp
{
    partial class frmTrackThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblStatus = new Label();
			btnRun = new Button();
			SuspendLayout();
			// 
			// lblStatus
			// 
			lblStatus.BackColor = Color.Transparent;
			lblStatus.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblStatus.ForeColor = Color.Black;
			lblStatus.Location = new Point(23, 35);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(340, 60);
			lblStatus.TabIndex = 0;
			lblStatus.Text = "-----Thread Starts-----";
			lblStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnRun
			// 
			btnRun.BackColor = SystemColors.ActiveBorder;
			btnRun.FlatAppearance.BorderSize = 0;
			btnRun.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 240);
			btnRun.FlatStyle = FlatStyle.Popup;
			btnRun.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRun.ForeColor = Color.Black;
			btnRun.Location = new Point(124, 98);
			btnRun.Name = "btnRun";
			btnRun.Size = new Size(124, 58);
			btnRun.TabIndex = 1;
			btnRun.Text = "Run";
			btnRun.UseVisualStyleBackColor = false;
			btnRun.Click += btnRun_Click;
			// 
			// frmTrackThread
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(384, 186);
			Controls.Add(btnRun);
			Controls.Add(lblStatus);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "frmTrackThread";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "TrackThread";
			ResumeLayout(false);
		}

		#endregion

		private Label lblStatus;
        private Button btnRun;
    }
}
