namespace TechSoft {
	public partial class FormMain : Form {
		public FormMain() {
			InitializeComponent();
			//if () {
			//	var panelButton = new Panel {
			//		Dock = DockStyle.Top,
			//		Height = 50
			//	};
			//	var btnAdd = new Button {
			//		Dock = DockStyle.Fill,
			//		Text = "+",
			//		BackColor = Color.Indigo,
			//		FlatStyle = FlatStyle.Flat
			//	};
			//	btnAdd.FlatAppearance.BorderSize = 0;
			//	FLP.Controls.Add(panelButton);
			//	panelButton.Controls.Add(btnAdd);
			//	btnAdd.Click += btnAdd_Click;
			//}
			Load();
		}

		public void Load() {

		}

		private void btnAdd_Click(object sender, EventArgs e) {
			FormAdd formAdd = new FormAdd();
			formAdd.FormClosed += (s, args) => this.Show();
			formAdd.ShowDialog();
			this.Hide();
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}
	}
}
