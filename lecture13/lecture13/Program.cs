namespace lecture13;

class Program
{
    static void Main(string[] args)
    {

        try
        {


            string path = @"../../../data.txt";
            
            // StreamReader reader = new StreamReader(path); //using-ის გარეშე გვჭირდება reader.Close(); reader.Dispose();

            using StreamReader reader = new StreamReader(path);
            
            Student[] students = new Student[0];

            int index = 0;
            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                
                string[] data = line.Split(',');
                
                Student student = new Student();
                
                student.FirstName = data[0];
                student.LastName = data[1];
                student.Age = int.Parse(data[2]);
                student.Email = data[3];
                student.Phone = data[4];
                student.Point = int.Parse(data[5]);
                
                Array.Resize(ref students, index + 1);
                students [index] = student;
                index++;

                // Console.WriteLine(line);
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
            
            // reader.Close();
            // reader.Dispose();
            
            

            // string[] lines = File.ReadAllLines(path);
            //
            // Student[] students = new Student[lines.Length];
            //
            //
            // for (int i = 0; i < students.Length; i++)
            // {
            //     string[] data = lines[i].Split(',');
            //     students[i] = new Student();
            //
            //     students[i].FirstName = data[0];
            //     students[i].LastName = data[1];
            //     students[i].Age = int.Parse(data[2]);
            //     students[i].Email = data[3];
            //     students[i].Phone = data[4];
            //     students[i].Point = int.Parse(data[5]);
            // }



        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("File was not loaded.");
        }

        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Age or point is not a number.");
        }

        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("One of the fields is empty.");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Unknown error:");

        }

        finally
        {
            Console.WriteLine("File reading is finished.");
        }

        Console.WriteLine("Hello World!");

        
        
        
        
        
        // Array.Sort(students);
        //
        // foreach (var student in students)
        // {
        //     Console.WriteLine(student);
        // }
        //
        // Console.WriteLine($"Minimal point: {students[0].Point}");
        //
        //
        // Student oldest = students[0];
        // foreach (var student in students)
        // {
        //     if (student > oldest) oldest = student;
        // }
        //
        // Console.WriteLine($"Oldest student: {oldest}");
        //
        //
        // // int sum = 0;
        // // foreach (var item in students)
        // // {
        // //     sum += item;
        // // }
        //
        //
        // int sum = 0;
        // foreach (var student in students)
        // {
        //     sum += student;
        // }
        //
        // int point = 90;
        // Student std = new Student();
        // std = (Student)point;
        //
        // Console.WriteLine($"Avarage point: {(double)sum / students.Length}");

    }
}