using System;
using System.Collections.Generic;
using TaskManagerApp.Models;

namespace TaskManagerApp
{
    class Program
    {
        // In-memory list to store users
        private static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Task Management System!");
            Console.WriteLine("=====================================");

            // Main menu
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. List Users");
                Console.WriteLine("3. Exit");
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
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the Task Management System. Goodbye!");
        }

        // Add a new user
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

        // List all users
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
    }
}
