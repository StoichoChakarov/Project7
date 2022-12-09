using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace Project7.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }

        public int UserId { get; set; }
        public string TaskTitle { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DeadLine { get;set;}
        public string TaskDescr { get; set; }
        public int TaskListId { get; set; }
    }
}
