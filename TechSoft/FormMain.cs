using TechSoft.Models;

namespace TechSoft {
	public partial class FormMain : Form {
		public User CurrentUser { get; private set; }
		public FormMain(User user) {
			InitializeComponent();
			if (user.IdRole == 3) {
				var panelButton = new Panel {
					Width = FLP.Width - 26,
					Height = 50
				};
				var btnAdd = new Button {
					Dock = DockStyle.Fill,
					Text = "+",
					BackColor = Color.Indigo,
					FlatStyle = FlatStyle.Flat
				};
				btnAdd.FlatAppearance.BorderSize = 0;
				FLP.Controls.Add(panelButton);
				panelButton.Controls.Add(btnAdd);
				btnAdd.Click += btnAdd_Click;
			}
			CurrentUser = user;
			Load(CurrentUser);
			this.FormClosed += FormMain_FormClosed;
		}

		public void Load(User user) {
			using(var db = new MyDbContext()) {
				var view = db.ViewDbs;
				if (user.IdRole == 3) {
					bool flag = true;
					foreach (var item in view) {
						CardDeveloper card = new CardDeveloper(flag);
						card.FillDeveloper(
							photo: item.PhotoUrl,
							nameTask: item.TaskName,
							description: item.Description,
							priority: item.PriorityName,
							project: item.ProjectName,
							dateCreate: (DateOnly)item.DateCreate,
							deadline: (DateOnly)item.Deadline,
							statusFromDB: item.StatusTaskName
						);
						FLP.Controls.Add(card);
					}
				} else {
					bool flag = false;
					foreach (var item in view) {
						if(item.FullName == user.FullName) {
							CardDeveloper card = new CardDeveloper(flag);
							card.FillDeveloper(
								photo: item.PhotoUrl,
								nameTask: item.TaskName,
								description: item.Description,
								priority: item.PriorityName,
								project: item.ProjectName,
								dateCreate: (DateOnly)item.DateCreate,
								deadline: (DateOnly)item.Deadline,
								statusFromDB: item.StatusTaskName
							);
							FLP.Controls.Add(card);
						}
					}
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			FormAdd formAdd = new FormAdd();
			formAdd.FormClosed += (s, args) => this.Show();
			formAdd.Show();
			this.Hide();
			Load(CurrentUser);
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}
	}
}
