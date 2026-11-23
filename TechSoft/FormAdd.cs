using TechSoft.Models;

namespace TechSoft {
	public partial class FormAdd : Form {
		public User CurrentUser { get; private set; }
		public FormAdd() {
			InitializeComponent();
			FormLoad();
		}
		private void FormLoad() {
			using (var db = new MyDbContext()) {
				comBoxProject.DisplayMember = "ProjectName";
				comBoxProject.ValueMember = "Id";
				comBoxProject.DataSource = db.Projects.ToList();

				comBoxPriority.DisplayMember = "PriorityName";
				comBoxPriority.ValueMember = "Id";
				comBoxPriority.DataSource = db.Priorities.ToList();

				comboBox1.DisplayMember = "FullName";
				comboBox1.ValueMember = "Id";
				comboBox1.DataSource = db.Users.ToList();

				comBoxPicture.DisplayMember = "PhotoUrl";
				comBoxPicture.ValueMember = "Id";
				comBoxPicture.DataSource = db.Projects
					.Where(p => p.PhotoUrl != null && p.PhotoUrl != "")
					.ToList()
					.GroupBy(p => p.PhotoUrl)
					.Select(g => g.First())
					.ToList();

				comBoxProject.SelectedIndex = -1;
				comBoxPriority.SelectedIndex = -1;
				comboBox1.SelectedIndex = -1;
				comBoxPicture.SelectedIndex = -1;
			}
		}
		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void Button1_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(txtName.Text)) {
				MessageBox.Show("Введите название!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (comBoxProject.SelectedIndex == -1) {
				MessageBox.Show("Выберите проект!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (comBoxPriority.SelectedIndex == -1) {
				MessageBox.Show("Выберите приоритет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (comboBox1.SelectedIndex == -1) {
				MessageBox.Show("Выберите пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (comBoxPicture.SelectedIndex == -1) {
				MessageBox.Show("Выберите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (var db = new MyDbContext()) {
				var newTask = new Models.Task {
					TaskName = txtName.Text.Trim(),
					IdUser = (int)comboBox1.SelectedValue,
					IdPriority = (int)comBoxPriority.SelectedValue,
					IdProject = (int)comBoxProject.SelectedValue,
					Description = txtDescription.Text.Trim(),
					IdStatussTask = 4,

					DateCreate = DateOnly.FromDateTime(DateTime.Now),
					Deadline = DateOnly.FromDateTime(dateTimePicker1.Value)
				};

				db.Tasks.Add(newTask);
				db.SaveChanges();

				MessageBox.Show("Задача успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.DialogResult = DialogResult.OK;
				this.Close();
			}

		}

	}
}