using System.Text;
using _1ADONet.Data;
using _1ADONet.Models;
using Microsoft.Data.SqlClient;
namespace _1ADONet;

class Program
{
    // Data Source=DESKTOP-TKA0BPM;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name="SQL Server Management Studio";Command Timeout=0

    private static readonly string _connectionString =
        "Data Source=DESKTOP-TKA0BPM; Database=UNIVERSITY; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
    
    static void Main(string[] args)
    {
        
        var repository = new InstructorRepository(_connectionString);

        while (true)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("     INSTRUCTOR MANAGEMENT");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Get all instructors");
            Console.WriteLine("2. Get instructor by ID");
            Console.WriteLine("3. Create instructor");
            Console.WriteLine("4. Update instructor");
            Console.WriteLine("5. Delete instructor");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=================================");

            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            Console.Clear();

            try
            {
                switch (choice)
                {
                    case "1":
                        GetAllInstructors(repository);
                        break;

                    case "2":
                        GetInstructorById(repository);
                        break;

                    case "3":
                        CreateInstructor(repository);
                        break;

                    case "4":
                        UpdateInstructor(repository);
                        break;

                    case "5":
                        DeleteInstructor(repository);
                        break;

                    case "0":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("\nDatabase error:");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\nValidation error:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nUnexpected error:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    private static void GetAllInstructors(InstructorRepository repository)
    {
        var instructors = repository.GetAll();

        if (instructors.Count == 0)
        {
            Console.WriteLine("No instructors found.");
            return;
        }

        Console.WriteLine("========== ALL INSTRUCTORS ==========\n");

        foreach (var instructor in instructors)
        {
            Console.WriteLine($"ID: {instructor.InstructorID}");
            Console.WriteLine($"Name: {instructor.FirstName} {instructor.LastName}");
            Console.WriteLine($"Email: {instructor.Email}");
            Console.WriteLine("-------------------------------------");
        }
    }

    private static void GetInstructorById(InstructorRepository repository)
    {
        Console.Write("Enter Instructor ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Invalid Instructor ID.");
            return;
        }

        var instructor = repository.GetById(id);

        if (instructor is null)
        {
            Console.WriteLine("Instructor not found.");
            return;
        }

        Console.WriteLine("\n========== INSTRUCTOR ==========");
        Console.WriteLine($"ID: {instructor.InstructorID}");
        Console.WriteLine($"First Name: {instructor.FirstName}");
        Console.WriteLine($"Last Name: {instructor.LastName}");
        Console.WriteLine($"Email: {instructor.Email}");
    }

    private static void CreateInstructor(InstructorRepository repository)
    {
        Console.WriteLine("========== CREATE INSTRUCTOR ==========\n");

        Console.Write("First Name: ");
        string? firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string? lastName = Console.ReadLine();

        Console.Write("Email: ");
        string? email = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("First name is required.");
            return;
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Last name is required.");
            return;
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Email is required.");
            return;
        }

        var instructor = new Instructor
        {
            FirstName = firstName.Trim(),
            LastName = lastName.Trim(),
            Email = email.Trim()
        };

        int newId = repository.Create(instructor);

        Console.WriteLine("\nInstructor created successfully!");
        Console.WriteLine($"New Instructor ID: {newId}");
    }

    private static void UpdateInstructor(InstructorRepository repository)
    {
        Console.WriteLine("========== UPDATE INSTRUCTOR ==========\n");

        Console.Write("Enter Instructor ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Invalid Instructor ID.");
            return;
        }

        var existingInstructor = repository.GetById(id);

        if (existingInstructor is null)
        {
            Console.WriteLine("Instructor not found.");
            return;
        }

        Console.WriteLine("\nCurrent information:");
        Console.WriteLine(
            $"Name: {existingInstructor.FirstName} {existingInstructor.LastName}");

        Console.WriteLine($"Email: {existingInstructor.Email}");

        Console.WriteLine("\nEnter new information:");

        Console.Write("First Name: ");
        string? firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string? lastName = Console.ReadLine();

        Console.Write("Email: ");
        string? email = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("First name is required.");
            return;
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Last name is required.");
            return;
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Email is required.");
            return;
        }

        var updatedInstructor = new Instructor
        {
            InstructorID = id,
            FirstName = firstName.Trim(),
            LastName = lastName.Trim(),
            Email = email.Trim()
        };

        bool updated = repository.Update(updatedInstructor);

        if (updated)
        {
            Console.WriteLine("\nInstructor updated successfully!");
        }
        else
        {
            Console.WriteLine("\nInstructor was not found.");
        }
    }

    private static void DeleteInstructor(InstructorRepository repository)
    {
        Console.WriteLine("========== DELETE INSTRUCTOR ==========\n");

        Console.Write("Enter Instructor ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Invalid Instructor ID.");
            return;
        }

        var instructor = repository.GetById(id);

        if (instructor is null)
        {
            Console.WriteLine("Instructor not found.");
            return;
        }

        Console.WriteLine("\nInstructor to delete:");
        Console.WriteLine($"ID: {instructor.InstructorID}");
        Console.WriteLine($"Name: {instructor.FirstName} {instructor.LastName}");
        Console.WriteLine($"Email: {instructor.Email}");

        Console.Write("\nAre you sure you want to delete this instructor? (y/n): ");

        string? confirmation = Console.ReadLine();

        if (confirmation?.Trim().ToLower() != "y")
        {
            Console.WriteLine("Delete operation cancelled.");
            return;
        }

        bool deleted = repository.Delete(id);

        if (deleted)
        {
            Console.WriteLine("\nInstructor deleted successfully!");
        }
        else
        {
            Console.WriteLine("\nInstructor was not found.");
        }
    }
        
}
    