namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ToDoItem> Tasks = new List<ToDoItem>();

        private void FillToDoList()
        {
            this.checkBoxListToDo.Items.Clear();
            
            foreach (ToDoItem task in Tasks)
            {
                this.checkBoxListToDo.Items.Add(task);
            }
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
            this.FillToDoList();
            this.txtNewTask.Text = "";
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // the editted task text refreshes when another item is selected
            if (this.checkBoxListToDo.SelectedItem != null || this.checkBoxListToDo.SelectedIndex != -1)
            {
                ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
                selectedTask.ItemText = this.txtNewTask.Text;
                this.FillToDoList();
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.checkBoxListToDo.SelectedItem != null || this.checkBoxListToDo.SelectedIndex != -1)
            {
                ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
                this.Tasks.Remove(selectedTask);
                this.FillToDoList();
                this.txtNewTask.Text = "";
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
