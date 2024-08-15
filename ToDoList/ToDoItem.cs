﻿using System;
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
            return ItemText;
        }
    }
}
