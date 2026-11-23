using TechSoft.Models;

namespace TechSoft {
	public partial class CardDeveloper : UserControl {
		private string _nameTask;

		public CardDeveloper(bool flag) {
			InitializeComponent();
			if (flag) {
				comBoxStatus.Enabled = false;
			}
			comBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			comBoxStatus.SelectionChangeCommitted += ComBoxStatus_SelectionChangeCommitted;
		}

		public void FillDeveloper(string photo, string nameTask, string description, string priority,
				string project, DateOnly dateCreate, DateOnly deadline, string statusFromDB) {
			_nameTask = nameTask;

			lblDate.Text = $"С {dateCreate} до {deadline}";
			lblDescription.Text = $"Описание: {description}";
			lblProject.Text = $"Проект: {project}";
			lblHeader.Text = $"{nameTask} (Приоритет: {priority})";

			using (var db = new MyDbContext()) {
				comBoxStatus.DisplayMember = "StatusTaskName";
				comBoxStatus.ValueMember = "Id";
				comBoxStatus.DataSource = db.StatusTasks.ToList();
			}

			comBoxStatus.SelectedIndex = comBoxStatus.FindStringExact(statusFromDB);

			var path = Path.Combine(Application.StartupPath, "Images", $"{photo}");
			if (!string.IsNullOrEmpty(photo) && File.Exists(path)) {
				picBox.Image = Image.FromFile(path);
			} else {
				path = Path.Combine(Application.StartupPath, "Images", "photo.png");
				if (File.Exists(path)) {
					picBox.Image = Image.FromFile(path);
				}
			}
		}

		private void ComBoxStatus_SelectionChangeCommitted(object sender, EventArgs e) {
			int newStatusId = (int)comBoxStatus.SelectedValue;

			using (var db = new MyDbContext()) {
				var currentTask = db.Tasks.FirstOrDefault(t => t.TaskName == _nameTask);
				if (currentTask != null) {
					currentTask.IdStatussTask = newStatusId;
					db.SaveChanges();
				}
			}
		}
	}
}
