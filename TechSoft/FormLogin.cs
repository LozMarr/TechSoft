using TechSoft.Models;

namespace TechSoft {
	public partial class FormLogin : Form {
		public User CurrentUser { get; private set; }
		public FormLogin() {
			InitializeComponent();
			txtLogin.Text = "LozHad";
			txtPassword.Text = "123";
		}

		private void button1_Click(object sender, EventArgs e) {
			if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtPassword.Text)) {
				MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			using (var db = new MyDbContext()) {
				var user = db.Users.Where(w => w.Login == txtLogin.Text && w.Password == txtPassword.Text).FirstOrDefault();

				if (user != null) {
					CurrentUser = user;
					this.DialogResult = DialogResult.OK;
					FormMain formMain = new FormMain(user);
					formMain.Show();
					this.Hide();
				} else {
					MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
