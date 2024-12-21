using System;
using System.Collections.Generic;
using TaskManagerApp.Models;

namespace TaskManagerApp
{
    class Program
    {
        private static List<User> users = new List<User>();
        private static List<TaskManagerApp.Models.Task> tasks = new List<TaskManagerApp.Models.Task>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Task Management System!");
            Console.WriteLine("=====================================");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. List Users");
                Console.WriteLine("3. Add Task");
                Console.WriteLine("4. List Tasks");
                Console.WriteLine("5. Assign Task");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        ListUsers();
                        break;
                    case "3":
                        AddTask();
                        break;
                    case "4":
                        ListTasks();
                        break;
                    case "5":
                        AssignTask();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the Task Management System. Goodbye!");
        }

        private static void AddUser()
        {
            Console.WriteLine("\nEnter user details:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Role (Admin/RegularUser): ");
            string role = Console.ReadLine();

            User user = new User(id, name, email, role);
            users.Add(user);

            Console.WriteLine("User added successfully!");
        }

        private static void ListUsers()
        {
            Console.WriteLine("\nRegistered Users:");

            if (users.Count == 0)
            {
                Console.WriteLine("No users found.");
                return;
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("\nEnter task details:");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Status (Pending/Completed): ");
            string status = Console.ReadLine();

            TaskManagerApp.Models.Task task = new TaskManagerApp.Models.Task(id, title, description, status);
            tasks.Add(task);

            Console.WriteLine("Task added successfully!");
        }

        private static void ListTasks()
        {
            Console.WriteLine("\nTasks:");

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        private static void AssignTask()
        {
            Console.Write("\nEnter Task ID to assign: ");
            int taskId = int.Parse(Console.ReadLine());

            TaskManagerApp.Models.Task task = tasks.Find(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine("Task not found.");
                return;
            }

            Console.Write("Enter User ID to assign the task to: ");
            int userId = int.Parse(Console.ReadLine());

            User user = users.Find(u => u.Id == userId);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            task.AssignedUser = user;
            Console.WriteLine($"Task '{task.Title}' has been assigned to {user.Name}.");
        }
    }
}
