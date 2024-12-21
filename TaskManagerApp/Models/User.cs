namespace TaskManagerApp.Models
{
    public class User
    {
        public int Id { get; set; } // Unique identifier
        public string Name { get; set; } // User's name
        public string Email { get; set; } // User's email
        public string Role { get; set; } // Role: Admin or RegularUser

        // Constructor
        public User(int id, string name, string email, string role)
        {
            Id = id;
            Name = name;
            Email = email;
            Role = role;
        }

        // Display user information
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Email: {Email}, Role: {Role}";
        }
    }
}
