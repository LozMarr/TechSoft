namespace TechSoft {
	partial class FormLogin {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtLogin = new TextBox();
			txtPassword = new TextBox();
			button1 = new Button();
			btnClose = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(74, 66);
			label1.Name = "label1";
			label1.Size = new Size(253, 78);
			label1.TabIndex = 0;
			label1.Text = "TechSoft";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(135, 230);
			label2.Name = "label2";
			label2.Size = new Size(131, 23);
			label2.TabIndex = 1;
			label2.Text = "Введите логин:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(129, 297);
			label3.Name = "label3";
			label3.Size = new Size(142, 23);
			label3.TabIndex = 2;
			label3.Text = "Введите пароль:";
			// 
			// txtLogin
			// 
			txtLogin.Location = new Point(116, 256);
			txtLogin.Name = "txtLogin";
			txtLogin.Size = new Size(169, 31);
			txtLogin.TabIndex = 3;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(116, 323);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(169, 31);
			txtPassword.TabIndex = 4;
			// 
			// button1
			// 
			button1.BackColor = Color.Indigo;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.White;
			button1.Location = new Point(150, 386);
			button1.Name = "button1";
			button1.Size = new Size(100, 36);
			button1.TabIndex = 5;
			button1.Text = "Войти";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.Crimson;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.ForeColor = Color.White;
			btnClose.Location = new Point(358, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(30, 30);
			btnClose.TabIndex = 6;
			btnClose.Text = "X";
			btnClose.UseVisualStyleBackColor = false;
			btnClose.Click += btnClose_Click;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(10F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(400, 450);
			Controls.Add(btnClose);
			Controls.Add(button1);
			Controls.Add(txtPassword);
			Controls.Add(txtLogin);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 5, 4, 5);
			Name = "FormLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Авторизация";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtLogin;
		private TextBox txtPassword;
		private Button button1;
		private Button btnClose;
	}
}
