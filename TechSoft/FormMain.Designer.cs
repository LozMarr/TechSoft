namespace TechSoft {
	partial class FormMain {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			FLP = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// FLP
			// 
			FLP.AutoScroll = true;
			FLP.Dock = DockStyle.Fill;
			FLP.ForeColor = Color.White;
			FLP.Location = new Point(0, 0);
			FLP.Name = "FLP";
			FLP.Size = new Size(917, 561);
			FLP.TabIndex = 0;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(10F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(917, 561);
			Controls.Add(FLP);
			Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4, 5, 4, 5);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Задачи";
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel FLP;
	}
}