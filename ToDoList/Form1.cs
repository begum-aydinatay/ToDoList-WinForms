namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ToDoItem> Tasks = new List<ToDoItem>();
        private string Path = Application.StartupPath + @"\data.xml";
        private XMLSerializer serializer = new XMLSerializer();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Path))
            {
                this.ReadToDoList();
            }
            this.FillLists();

            this.notifyIcon1.BalloonTipText = "Tasks loaded.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveToDoList();

            this.notifyIcon1.BalloonTipText = "Application exited.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ToDoItem newTask = new ToDoItem()
            {
                ID = Guid.NewGuid(),
                ItemText = this.txtNewTask.Text,
                IsDone = false
            };

            this.Tasks.Add(newTask);
            this.FillLists();
            this.txtNewTask.Text = string.Empty;

            this.notifyIcon1.BalloonTipText = "New task added.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // the editted task text refreshes when another item is selected
            if (this.checkBoxListToDo.SelectedItem != null || this.checkBoxListToDo.SelectedIndex != -1)
            {
                ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
                selectedTask.ItemText = this.txtNewTask.Text;
                this.FillLists();
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.notifyIcon1.BalloonTipText = "Task edited.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.checkBoxListToDo.SelectedItem != null || this.checkBoxListToDo.SelectedIndex != -1)
            {
                ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
                this.Tasks.Remove(selectedTask);
                this.FillLists();
                this.txtNewTask.Text = string.Empty;
            }
            else if (this.listDone.SelectedItem != null || this.listDone.SelectedIndex != -1)
            {
                ToDoItem selectedTask = (ToDoItem)this.listDone.SelectedItem;
                this.Tasks.Remove(selectedTask);
                this.FillLists();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            this.notifyIcon1.BalloonTipText = "Task deleted.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void checkBoxListToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // exit the method if no index is selected (a.k.a SelectedIndex == -1)
            if (this.checkBoxListToDo.SelectedIndex == -1)
            {
                return;
            }

            ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
            this.txtNewTask.Text = selectedTask.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            this.txtNewTask.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.txtNewTask.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            this.txtNewTask.Paste();
        }

        private void FillLists()
        {
            this.checkBoxListToDo.Items.Clear();
            this.listDone.Items.Clear();

            foreach (ToDoItem task in Tasks)
            {
                if (task.IsDone)
                {
                    this.listDone.Items.Add(task);
                }
                else
                {
                    this.checkBoxListToDo.Items.Add(task);
                }
            }
        }

        private void SaveToDoList()
        {
            serializer.Serialize<List<ToDoItem>>(Path, this.Tasks);
        }

        private void ReadToDoList()
        {
            this.Tasks = serializer.Deserialize<List<ToDoItem>>(Path);
        }

        private void checkBoxListToDo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
                selectedTask.IsDone = true;
                selectedTask.DoneDate = DateTime.Now;

                this.notifyIcon1.BalloonTipText = "Task marked as done.";
                this.notifyIcon1.ShowBalloonTip(2000);
            }
        }

        private void checkBoxListToDo_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.checkBoxListToDo.CheckedItems.Count > 0)
            {
                this.FillLists();
                this.txtNewTask.Text = string.Empty;
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.SaveToDoList();
            Application.Exit();

            this.notifyIcon1.BalloonTipText = "Application exited.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        private void menuMoreInformation_Click(object sender, EventArgs e)
        {
            ProgramInformationBox infoBox = new ProgramInformationBox();
            infoBox.ShowDialog();
        }
    }
}
