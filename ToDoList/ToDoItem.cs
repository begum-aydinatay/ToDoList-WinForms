using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoItem
    {
        public Guid ID { get; set; }
        public string ItemText { get; set; }
        public DateTime DoneDate { get; set; }
        public bool IsDone { get; set; }

        public override string ToString()
        {
            if (this.IsDone)
            {
                return string.Format("{0} ({1})", this.ItemText, this.DoneDate.ToString());
            }
            else // if it is a task in progress...
            {
                return ItemText;
            }
        }
    }
}
