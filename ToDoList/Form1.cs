namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ToDoItem> Tasks = new List<ToDoItem>();

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ToDoItem newTask = new ToDoItem()
            {
                ID = Guid.NewGuid(),
                ItemText = this.txtNewTask.Text,
                IsDone = false
            };

            this.Tasks.Add(newTask);
            this.checkBoxListToDo.Items.Add(newTask);
            this.txtNewTask.Text = "";
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // the editted task text refreshes when another item is selected
            if (this.checkBoxListToDo.SelectedItem != null)
            {
                ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
                selectedTask.ItemText = this.txtNewTask.Text;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.checkBoxListToDo.SelectedItem != null)
            {
                ToDoItem selectedTask = (ToDoItem)this.checkBoxListToDo.SelectedItem;
                checkBoxListToDo.Items.Remove(selectedTask);
                Tasks.Remove(selectedTask);
                txtNewTask.Text = "";
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
    }
}
