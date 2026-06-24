namespace homeWork13_project;

class Program
{
    static void Main(string[] args)
    {
        
        using Logger logger = new Logger();
        logger.Log("Program started");
        
        Student[] students = new Student[20];
        int count = 0;
        
        // Starting 10 students
        students[count++] = new Student("Giorgi", "Beridze", 25, "g@gmail.com", "599123456", 3.5, Faculty.IT);
        students[count++] = new Student("Nino", "Kapanadze", 31, "nino@gmail.com", "555987654", 2, Faculty.Business);
        students[count++] = new Student("Luka", "Makharadze", 19, "luka@gmail.com", "577321654", 1, Faculty.IT);
        students[count++] = new Student("Ani", "Dolidze", 28, "ani@gmail.com", "591456789", 3.9, Faculty.Design);
        students[count++] = new Student("Davit", "Japaridze", 42, "davit@gmail.com", "551112233", 4, Faculty.Medicine);
        students[count++] = new Student("Mariam", "Chkheidze", 22, "mariam@gmail.com", "598778899", 3, Faculty.IT);
        students[count++] = new Student("Irakli", "Gelashvili", 35, "irakli@gmail.com", "595334455", 2, Faculty.Business);
        students[count++] = new Student("Elene", "Kvaratskhelia", 27, "elene@gmail.com", "574665544", 2.75, Faculty.Design);
        students[count++] = new Student("Alex", "Meskhi", 30, "alex@gmail.com", "593221100", 1.6, Faculty.Medicine);
        students[count++] = new Student("Sopo", "Tsiklauri", 24, "sopo@gmail.com", "568445566", 1.2, Faculty.IT);

        StudentService service = new StudentService(students, count);

        while (true)
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Show all students");
            Console.WriteLine("2. Best student");
            Console.WriteLine("3. Average GPA");
            Console.WriteLine("4. Search by last name");
            Console.WriteLine("5. Sort by GPA");
            Console.WriteLine("6. Add student");
            Console.WriteLine("7. Delete student");
            Console.WriteLine("8. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    service.ShowAllStudents();
                    break;
                case "2":
                    service.GetBestStudent().Print();
                    break;
                case "3":
                    Console.WriteLine("Average GPA: " + service.GetAverageGPA());
                    break;
                case "4":
                    Console.WriteLine("Enter last name to search: ");
                    string lastName = Console.ReadLine();
                    service.SearchByLastName(lastName);
                    break;
                case "5":
                    service.SortByGPA();
                    Console.WriteLine("Students sorted by GPA:");
                    service.ShowAllStudents();
                    break;
                case "6":
                    try
                    {
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();
                        
                        Console.WriteLine("Last name: ");
                        string surname = Console.ReadLine();
                        
                        Console.WriteLine("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Email: ");
                        string email = Console.ReadLine();
                        
                        if(!email.Contains("@"))
                            throw new Exception("Email is not valid");

                        Console.WriteLine("Phone: ");
                        string phone = Console.ReadLine();

                        Console.WriteLine("GPA: ");
                        double gpa = double.Parse(Console.ReadLine());
                        
                        if (gpa < 0 || gpa > 4)
                            throw new Exception("GPA cannot be less than 0 or greater than 4");

                        Console.WriteLine("Faculty (0-IT, 1-Business, 2-Design, 3-Medicine): ");
                        Faculty faculty = (Faculty)int.Parse(Console.ReadLine());
                        
                        Student newStudent = new Student(name, surname, age, email, phone, gpa, faculty);
                        service.AddStudent(newStudent);
                        count++;
                    }
                    
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    
                    break;
                
                case "7":
                    Console.Write("Enter email to delete: ");
                    string emailToDelete = Console.ReadLine();
                    service.DeleteStudent(emailToDelete);
                    break;
                
                case "8":
                    Console.WriteLine("Exiting...");
                    return;
                
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        
    }
}