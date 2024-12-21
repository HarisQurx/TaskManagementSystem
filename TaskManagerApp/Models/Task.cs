namespace TaskManagerApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // E.g., Pending, Completed
        public User? AssignedUser { get; set; } // Nullable to handle unassigned tasks

        public Task(int id, string title, string description, string status, User? assignedUser = null)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
            AssignedUser = assignedUser;
        }

        public override string ToString()
        {
            string assignedTo = AssignedUser != null ? AssignedUser.Name : "Unassigned";
            return $"ID: {Id}, Title: {Title}, Status: {Status}, Assigned To: {assignedTo}";
        }
    }
}
