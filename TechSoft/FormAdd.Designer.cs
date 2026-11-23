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
			panel2 = new Panel();
			dateTimePicker1 = new DateTimePicker();
			label8 = new Label();
			panelPicture = new Panel();
			comBoxPicture = new ComboBox();
			label2 = new Label();
			panelDescription = new Panel();
			txtDescription = new TextBox();
			label7 = new Label();
			panelHeader = new Panel();
			comBoxPriority = new ComboBox();
			label4 = new Label();
			txtName = new TextBox();
			label3 = new Label();
			panelProject = new Panel();
			comBoxProject = new ComboBox();
			label5 = new Label();
			panelDeveloper = new Panel();
			comboBox1 = new ComboBox();
			label6 = new Label();
			comBoxDeveloper = new ComboBox();
			lblStatus = new Label();
			btnClose = new Button();
			label1 = new Label();
			button1 = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panelPicture.SuspendLayout();
			panelDescription.SuspendLayout();
			panelHeader.SuspendLayout();
			panelProject.SuspendLayout();
			panelDeveloper.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(panelPicture);
			panel1.Controls.Add(panelDescription);
			panel1.Controls.Add(panelHeader);
			panel1.Controls.Add(panelProject);
			panel1.Controls.Add(panelDeveloper);
			panel1.Location = new Point(2, 50);
			panel1.Name = "panel1";
			panel1.Size = new Size(926, 210);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(dateTimePicker1);
			panel2.Controls.Add(label8);
			panel2.Location = new Point(477, 55);
			panel2.Name = "panel2";
			panel2.Size = new Size(250, 50);
			panel2.TabIndex = 22;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.CustomFormat = "dd.MM.yyyy";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.Location = new Point(109, 9);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(136, 31);
			dateTimePicker1.TabIndex = 25;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(3, 13);
			label8.Name = "label8";
			label8.Size = new Size(86, 23);
			label8.TabIndex = 24;
			label8.Text = "Дедлайн:";
			// 
			// panelPicture
			// 
			panelPicture.BorderStyle = BorderStyle.FixedSingle;
			panelPicture.Controls.Add(comBoxPicture);
			panelPicture.Controls.Add(label2);
			panelPicture.Location = new Point(5, 5);
			panelPicture.Name = "panelPicture";
			panelPicture.Size = new Size(200, 200);
			panelPicture.TabIndex = 21;
			// 
			// comBoxPicture
			// 
			comBoxPicture.FormattingEnabled = true;
			comBoxPicture.Location = new Point(15, 97);
			comBoxPicture.Name = "comBoxPicture";
			comBoxPicture.Size = new Size(169, 31);
			comBoxPicture.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(55, 71);
			label2.Name = "label2";
			label2.Size = new Size(89, 23);
			label2.TabIndex = 4;
			label2.Text = "Картинка:";
			// 
			// panelDescription
			// 
			panelDescription.BorderStyle = BorderStyle.FixedSingle;
			panelDescription.Controls.Add(txtDescription);
			panelDescription.Controls.Add(label7);
			panelDescription.Location = new Point(205, 104);
			panelDescription.Name = "panelDescription";
			panelDescription.Size = new Size(522, 100);
			panelDescription.TabIndex = 20;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(100, 3);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(417, 92);
			txtDescription.TabIndex = 1;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(5, 3);
			label7.Name = "label7";
			label7.Size = new Size(94, 23);
			label7.TabIndex = 0;
			label7.Text = "Описание:";
			// 
			// panelHeader
			// 
			panelHeader.BorderStyle = BorderStyle.FixedSingle;
			panelHeader.Controls.Add(comBoxPriority);
			panelHeader.Controls.Add(label4);
			panelHeader.Controls.Add(txtName);
			panelHeader.Controls.Add(label3);
			panelHeader.Location = new Point(205, 5);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(522, 50);
			panelHeader.TabIndex = 19;
			// 
			// comBoxPriority
			// 
			comBoxPriority.FormattingEnabled = true;
			comBoxPriority.Location = new Point(381, 11);
			comBoxPriority.Name = "comBoxPriority";
			comBoxPriority.Size = new Size(136, 31);
			comBoxPriority.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(275, 15);
			label4.Name = "label4";
			label4.Size = new Size(100, 23);
			label4.TabIndex = 2;
			label4.Text = "Приоритет:";
			// 
			// txtName
			// 
			txtName.Location = new Point(100, 11);
			txtName.Name = "txtName";
			txtName.Size = new Size(169, 31);
			txtName.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 15);
			label3.Name = "label3";
			label3.Size = new Size(91, 23);
			label3.TabIndex = 0;
			label3.Text = "Название:";
			// 
			// panelProject
			// 
			panelProject.BorderStyle = BorderStyle.FixedSingle;
			panelProject.Controls.Add(comBoxProject);
			panelProject.Controls.Add(label5);
			panelProject.Location = new Point(205, 55);
			panelProject.Name = "panelProject";
			panelProject.Size = new Size(284, 50);
			panelProject.TabIndex = 18;
			// 
			// comBoxProject
			// 
			comBoxProject.FormattingEnabled = true;
			comBoxProject.Location = new Point(100, 9);
			comBoxProject.Name = "comBoxProject";
			comBoxProject.Size = new Size(169, 31);
			comBoxProject.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 13);
			label5.Name = "label5";
			label5.Size = new Size(72, 23);
			label5.TabIndex = 0;
			label5.Text = "Проект:";
			// 
			// panelDeveloper
			// 
			panelDeveloper.BorderStyle = BorderStyle.FixedSingle;
			panelDeveloper.Controls.Add(comboBox1);
			panelDeveloper.Controls.Add(label6);
			panelDeveloper.Controls.Add(comBoxDeveloper);
			panelDeveloper.Controls.Add(lblStatus);
			panelDeveloper.Location = new Point(724, 5);
			panelDeveloper.Name = "panelDeveloper";
			panelDeveloper.Size = new Size(196, 200);
			panelDeveloper.TabIndex = 17;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(15, 97);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(169, 31);
			comboBox1.TabIndex = 3;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(39, 71);
			label6.Name = "label6";
			label6.Size = new Size(120, 23);
			label6.TabIndex = 2;
			label6.Text = "Исполнитель:";
			// 
			// comBoxDeveloper
			// 
			comBoxDeveloper.FormattingEnabled = true;
			comBoxDeveloper.Location = new Point(15, 98);
			comBoxDeveloper.Name = "comBoxDeveloper";
			comBoxDeveloper.Size = new Size(169, 31);
			comBoxDeveloper.TabIndex = 1;
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Location = new Point(39, 72);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(120, 23);
			lblStatus.TabIndex = 0;
			lblStatus.Text = "Исполнитель:";
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.Crimson;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.ForeColor = Color.White;
			btnClose.Location = new Point(896, 8);
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
			label1.Location = new Point(323, 8);
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
			button1.Location = new Point(389, 281);
			button1.Name = "button1";
			button1.Size = new Size(153, 32);
			button1.TabIndex = 9;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = false;
			button1.Click += Button1_Click;
			// 
			// FormAdd
			// 
			AutoScaleDimensions = new SizeF(10F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(930, 350);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(btnClose);
			Controls.Add(panel1);
			Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 5, 4, 5);
			Name = "FormAdd";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormAdd";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panelPicture.ResumeLayout(false);
			panelPicture.PerformLayout();
			panelDescription.ResumeLayout(false);
			panelDescription.PerformLayout();
			panelHeader.ResumeLayout(false);
			panelHeader.PerformLayout();
			panelProject.ResumeLayout(false);
			panelProject.PerformLayout();
			panelDeveloper.ResumeLayout(false);
			panelDeveloper.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button btnClose;
		private Label label1;
		private Button button1;
		private Panel panelPicture;
		private ComboBox comBoxPicture;
		private Label label2;
		private Panel panelDescription;
		private TextBox txtDescription;
		private Label label7;
		private Panel panelHeader;
		private ComboBox comBoxPriority;
		private Label label4;
		private TextBox txtName;
		private Label label3;
		private Panel panelProject;
		private ComboBox comBoxProject;
		private Label label5;
		private Panel panelDeveloper;
		private ComboBox comboBox1;
		private Label label6;
		private ComboBox comBoxDeveloper;
		private Label lblStatus;
		private Panel panel2;
		private DateTimePicker dateTimePicker1;
		private Label label8;
	}
}