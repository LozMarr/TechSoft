namespace TechSoft {
	partial class CardDeveloper {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			lblHeader = new Label();
			picBox = new PictureBox();
			panel1 = new Panel();
			comBoxStatus = new ComboBox();
			lblStatus = new Label();
			lblProject = new Label();
			lblDate = new Label();
			lblDescription = new Label();
			((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.BorderStyle = BorderStyle.FixedSingle;
			lblHeader.Location = new Point(200, 0);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(490, 50);
			lblHeader.TabIndex = 0;
			lblHeader.Text = "label1";
			lblHeader.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// picBox
			// 
			picBox.BorderStyle = BorderStyle.FixedSingle;
			picBox.Location = new Point(0, 0);
			picBox.Name = "picBox";
			picBox.Size = new Size(200, 200);
			picBox.SizeMode = PictureBoxSizeMode.Zoom;
			picBox.TabIndex = 1;
			picBox.TabStop = false;
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(comBoxStatus);
			panel1.Controls.Add(lblStatus);
			panel1.Location = new Point(690, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 200);
			panel1.TabIndex = 2;
			// 
			// comBoxStatus
			// 
			comBoxStatus.FormattingEnabled = true;
			comBoxStatus.Location = new Point(16, 98);
			comBoxStatus.Name = "comBoxStatus";
			comBoxStatus.Size = new Size(169, 31);
			comBoxStatus.TabIndex = 1;
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Location = new Point(16, 72);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(169, 23);
			lblStatus.TabIndex = 0;
			lblStatus.Text = "Статус выполнения:";
			// 
			// lblProject
			// 
			lblProject.BorderStyle = BorderStyle.FixedSingle;
			lblProject.Location = new Point(200, 50);
			lblProject.Name = "lblProject";
			lblProject.Size = new Size(175, 50);
			lblProject.TabIndex = 3;
			lblProject.Text = "label1";
			lblProject.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblDate
			// 
			lblDate.BorderStyle = BorderStyle.FixedSingle;
			lblDate.Location = new Point(375, 50);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(315, 50);
			lblDate.TabIndex = 4;
			lblDate.Text = "label1";
			lblDate.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblDescription
			// 
			lblDescription.BorderStyle = BorderStyle.FixedSingle;
			lblDescription.Location = new Point(200, 99);
			lblDescription.Name = "lblDescription";
			lblDescription.Padding = new Padding(5);
			lblDescription.Size = new Size(490, 101);
			lblDescription.TabIndex = 5;
			lblDescription.Text = "label1";
			// 
			// CardDeveloper
			// 
			AutoScaleDimensions = new SizeF(10F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.BlueViolet;
			Controls.Add(lblDescription);
			Controls.Add(lblDate);
			Controls.Add(lblProject);
			Controls.Add(panel1);
			Controls.Add(picBox);
			Controls.Add(lblHeader);
			Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			Margin = new Padding(5);
			Name = "CardDeveloper";
			Size = new Size(890, 200);
			((System.ComponentModel.ISupportInitialize)picBox).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label lblHeader;
		private PictureBox picBox;
		private Panel panel1;
		private ComboBox comBoxStatus;
		private Label lblStatus;
		private Label lblProject;
		private Label lblDate;
		private Label lblDescription;
	}
}
