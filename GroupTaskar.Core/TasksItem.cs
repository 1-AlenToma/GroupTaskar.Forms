using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTaskar.Core
{
    public class TasksItem
    {

        public int Id { get; set; }

        public List<Item> Items { get; set; } = new();

        public string Name { get; set; }

        public string Icon { get; set; }

        public Enums.TaskType Type { get; set; }
    }
}
