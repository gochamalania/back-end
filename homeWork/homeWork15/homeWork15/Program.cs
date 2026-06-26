using homeWork15.Models;
using homeWork15.Services;

namespace homeWork15;

class Program
{
    static void Main(string[] args)
    {
        StudentManager manager = new StudentManager();
        StudentService service = new StudentService(manager);


        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===== STUDENT SCORE SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Find Student");
            Console.WriteLine("3. Update Score");
            Console.WriteLine("4. Show All Students");
            Console.WriteLine("5. Exit");

            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    service.AddStudent();
                    break;

                case "2":
                    service.FindStudent();
                    break;

                case "3":
                    service.UpdateScore();
                    break;

                case "4":
                    service.ShowAllStudents();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
