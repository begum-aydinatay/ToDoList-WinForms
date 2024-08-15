namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuToDoList = new ToolStripMenuItem();
            menuNewItem = new ToolStripMenuItem();
            menuEditItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuDeleteItem = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            menuMoreInformation = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuHelp = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAddItem = new ToolStripButton();
            btnEditItem = new ToolStripButton();
            btnDeleteItem = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            btnCut = new ToolStripButton();
            btnCopy = new ToolStripButton();
            btnPaste = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnHelp = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            checkBoxListToDo = new CheckedListBox();
            lblToDoList = new Label();
            panel1 = new Panel();
            grpNewTask = new GroupBox();
            txtNewTask = new TextBox();
            listDone = new ListBox();
            lblDone = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpNewTask.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuToDoList, menuAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(822, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExit });
            menuFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(52, 27);
            menuFile.Text = "File";
            // 
            // menuExit
            // 
            menuExit.Image = Properties.Resources.exit_todo_icon;
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(124, 28);
            menuExit.Text = "Exit";
            // 
            // menuToDoList
            // 
            menuToDoList.DropDownItems.AddRange(new ToolStripItem[] { menuNewItem, menuEditItem, toolStripMenuItem1, menuDeleteItem });
            menuToDoList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuToDoList.Name = "menuToDoList";
            menuToDoList.Size = new Size(103, 27);
            menuToDoList.Text = "To Do List";
            // 
            // menuNewItem
            // 
            menuNewItem.Image = Properties.Resources.add_todo_item;
            menuNewItem.Name = "menuNewItem";
            menuNewItem.ShortcutKeys = Keys.Control | Keys.N;
            menuNewItem.Size = new Size(253, 28);
            menuNewItem.Text = "New Item";
            menuNewItem.Click += btnAddItem_Click;
            // 
            // menuEditItem
            // 
            menuEditItem.Image = Properties.Resources.edit_todo_item;
            menuEditItem.Name = "menuEditItem";
            menuEditItem.ShortcutKeys = Keys.Control | Keys.E;
            menuEditItem.Size = new Size(253, 28);
            menuEditItem.Text = "Edit Item";
            menuEditItem.Click += btnEditItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(250, 6);
            // 
            // menuDeleteItem
            // 
            menuDeleteItem.Image = Properties.Resources.delete_todo_item;
            menuDeleteItem.Name = "menuDeleteItem";
            menuDeleteItem.ShortcutKeys = Keys.Control | Keys.D;
            menuDeleteItem.Size = new Size(253, 28);
            menuDeleteItem.Text = "Delete Item";
            menuDeleteItem.Click += btnDeleteItem_Click;
            // 
            // menuAbout
            // 
            menuAbout.DropDownItems.AddRange(new ToolStripItem[] { menuMoreInformation, toolStripMenuItem2, menuHelp });
            menuAbout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(74, 27);
            menuAbout.Text = "About";
            // 
            // menuMoreInformation
            // 
            menuMoreInformation.Image = Properties.Resources.about_todo_icon;
            menuMoreInformation.Name = "menuMoreInformation";
            menuMoreInformation.Size = new Size(237, 28);
            menuMoreInformation.Text = "More Information";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(234, 6);
            // 
            // menuHelp
            // 
            menuHelp.Image = Properties.Resources.help_todo_item;
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(237, 28);
            menuHelp.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddItem, btnEditItem, btnDeleteItem, toolStripSeparator, btnCut, btnCopy, btnPaste, toolStripSeparator1, btnHelp });
            toolStrip1.Location = new Point(0, 31);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(822, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddItem
            // 
            btnAddItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddItem.Image = Properties.Resources.add_todo_item;
            btnAddItem.ImageTransparentColor = Color.Magenta;
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(29, 24);
            btnAddItem.Text = "Add Task";
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditItem.Image = Properties.Resources.edit_todo_item;
            btnEditItem.ImageTransparentColor = Color.Magenta;
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(29, 24);
            btnEditItem.Text = "Edit Task";
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteItem.Image = Properties.Resources.delete_todo_item;
            btnDeleteItem.ImageTransparentColor = Color.Magenta;
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(29, 24);
            btnDeleteItem.Text = "Delete Task";
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.BackColor = SystemColors.Desktop;
            toolStripSeparator.ForeColor = SystemColors.Desktop;
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // btnCut
            // 
            btnCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCut.Image = Properties.Resources.cut_todo_item;
            btnCut.ImageTransparentColor = Color.Magenta;
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(29, 24);
            btnCut.Text = "Cut";
            btnCut.Click += btnCut_Click;
            // 
            // btnCopy
            // 
            btnCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopy.Image = Properties.Resources.copy_todo_item;
            btnCopy.ImageTransparentColor = Color.Magenta;
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(29, 24);
            btnCopy.Text = "Copy";
            btnCopy.Click += btnCopy_Click;
            // 
            // btnPaste
            // 
            btnPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPaste.Image = Properties.Resources.paste_todo_item;
            btnPaste.ImageTransparentColor = Color.Magenta;
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(29, 24);
            btnPaste.Text = "Paste";
            btnPaste.Click += btnPaste_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnHelp
            // 
            btnHelp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnHelp.Image = Properties.Resources.help_todo_item;
            btnHelp.ImageTransparentColor = Color.Magenta;
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(29, 24);
            btnHelp.Text = "Help";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.Control;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 58);
            splitContainer1.Margin = new Padding(5, 3, 5, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(checkBoxListToDo);
            splitContainer1.Panel1.Controls.Add(lblToDoList);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(grpNewTask);
            splitContainer1.Panel1.Padding = new Padding(8, 7, 8, 7);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(listDone);
            splitContainer1.Panel2.Controls.Add(lblDone);
            splitContainer1.Panel2.Padding = new Padding(8, 7, 8, 7);
            splitContainer1.Size = new Size(822, 460);
            splitContainer1.SplitterDistance = 411;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 2;
            // 
            // checkBoxListToDo
            // 
            checkBoxListToDo.Dock = DockStyle.Fill;
            checkBoxListToDo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxListToDo.FormattingEnabled = true;
            checkBoxListToDo.Location = new Point(8, 226);
            checkBoxListToDo.Name = "checkBoxListToDo";
            checkBoxListToDo.Size = new Size(395, 227);
            checkBoxListToDo.TabIndex = 3;
            checkBoxListToDo.SelectedIndexChanged += checkBoxListToDo_SelectedIndexChanged;
            // 
            // lblToDoList
            // 
            lblToDoList.AutoSize = true;
            lblToDoList.Dock = DockStyle.Top;
            lblToDoList.Location = new Point(8, 189);
            lblToDoList.Margin = new Padding(5, 0, 5, 0);
            lblToDoList.Name = "lblToDoList";
            lblToDoList.Padding = new Padding(8, 7, 8, 7);
            lblToDoList.Size = new Size(105, 37);
            lblToDoList.TabIndex = 2;
            lblToDoList.Text = "To Do List";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(8, 173);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 16);
            panel1.TabIndex = 1;
            // 
            // grpNewTask
            // 
            grpNewTask.BackColor = SystemColors.Control;
            grpNewTask.Controls.Add(txtNewTask);
            grpNewTask.Dock = DockStyle.Top;
            grpNewTask.Location = new Point(8, 7);
            grpNewTask.Margin = new Padding(5, 3, 5, 3);
            grpNewTask.Name = "grpNewTask";
            grpNewTask.Padding = new Padding(15);
            grpNewTask.Size = new Size(395, 166);
            grpNewTask.TabIndex = 0;
            grpNewTask.TabStop = false;
            grpNewTask.Tag = "";
            grpNewTask.Text = "New Task";
            // 
            // txtNewTask
            // 
            txtNewTask.Dock = DockStyle.Fill;
            txtNewTask.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewTask.Location = new Point(15, 38);
            txtNewTask.Multiline = true;
            txtNewTask.Name = "txtNewTask";
            txtNewTask.Size = new Size(365, 113);
            txtNewTask.TabIndex = 0;
            txtNewTask.TextAlign = HorizontalAlignment.Center;
            // 
            // listDone
            // 
            listDone.Dock = DockStyle.Fill;
            listDone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDone.FormattingEnabled = true;
            listDone.Location = new Point(8, 42);
            listDone.Margin = new Padding(4, 3, 4, 3);
            listDone.Name = "listDone";
            listDone.Size = new Size(389, 411);
            listDone.TabIndex = 4;
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.Dock = DockStyle.Top;
            lblDone.Location = new Point(8, 7);
            lblDone.Margin = new Padding(4, 0, 4, 0);
            lblDone.Name = "lblDone";
            lblDone.Padding = new Padding(6);
            lblDone.Size = new Size(64, 35);
            lblDone.TabIndex = 3;
            lblDone.Text = "Done";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 518);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "To Do List";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpNewTask.ResumeLayout(false);
            grpNewTask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddItem;
        private ToolStripButton btnEditItem;
        private ToolStripButton btnDeleteItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton btnCut;
        private ToolStripButton btnCopy;
        private ToolStripButton btnPaste;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnHelp;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuToDoList;
        private ToolStripMenuItem menuAbout;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuNewItem;
        private ToolStripMenuItem menuEditItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuDeleteItem;
        private ToolStripMenuItem menuMoreInformation;
        private ToolStripMenuItem menuHelp;
        private ToolStripSeparator toolStripMenuItem2;
        private SplitContainer splitContainer1;
        private GroupBox grpNewTask;
        private Panel panel1;
        private Label lblToDoList;
        private Label lblDone;
        private ListBox listDone;
        private CheckedListBox checkBoxListToDo;
        private TextBox txtNewTask;
    }
}
