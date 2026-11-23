namespace TechSoft {
	partial class FormAdd {
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
			panel1 = new Panel();
			btnClose = new Button();
			label1 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Location = new Point(0, 50);
			panel1.Name = "panel1";
			panel1.Size = new Size(900, 210);
			panel1.TabIndex = 0;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.Crimson;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.ForeColor = Color.White;
			btnClose.Location = new Point(858, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(30, 30);
			btnClose.TabIndex = 7;
			btnClose.Text = "X";
			btnClose.UseVisualStyleBackColor = false;
			btnClose.Click += btnClose_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.ForeColor = Color.White;
			label1.Location = new Point(308, 8);
			label1.Name = "label1";
			label1.Size = new Size(285, 33);
			label1.TabIndex = 8;
			label1.Text = "Добавить новую задачу";
			// 
			// button1
			// 
			button1.BackColor = Color.Indigo;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.White;
			button1.Location = new Point(374, 281);
			button1.Name = "button1";
			button1.Size = new Size(153, 32);
			button1.TabIndex = 9;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = false;
			// 
			// FormAdd
			// 
			AutoScaleDimensions = new SizeF(10F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(900, 325);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(btnClose);
			Controls.Add(panel1);
			Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 5, 4, 5);
			Name = "FormAdd";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormAdd";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button btnClose;
		private Label label1;
		private Button button1;
	}
}