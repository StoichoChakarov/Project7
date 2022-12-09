namespace Project7.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhnoneNumber { get; set; }

        public List<TaskListModel> TaskList { get; set; }
    }
}
