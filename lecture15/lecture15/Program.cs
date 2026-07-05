using lecture15.Enums;
using lecture15.Helpers;
using lecture15.Models;
using lecture15.Services;

namespace lecture15;

class Program
{
    static void Main(string[] args)
    {

        #region collections

            #region LIST
        
                // // aray - fixed size, same type
                //
                // // List generic type
                // List<int> list = new List<int>();
                //
                //
                // // list.Add("hello"); //error
                //
                //
                // list.Add(1);
                // list.Remove(1);
                //
                //
                //
                // list.AddRange(54, 10, 15);
                //
                // int[] arr = [50, 10, 99, 12];
                // list.AddRange(arr);
                //
                // // foreach (var item in list)
                // // {
                // //     Console.WriteLine(item);
                // // }
                //
                // list.Insert(0, 101);
                // // Console.WriteLine(list[0]);
                //
                // list.RemoveAt(0);
                //
                // Console.WriteLine(list.Max());
                // Console.WriteLine(list.Min());
                // Console.WriteLine(list.Average());
                //
                // // Array - LENGTH |  List - COUNT
                // // for (int i = 0; i < list.Count; i++)
                // // {
                // //     Console.WriteLine(list[i]);
                // // }
                
                
                // List<string> listStr = new List<string>();
                // listStr.Add("hello");
                // listStr.Add("world");
                // listStr.Add("!");
                //
                // listStr[0] = "C#";
                //     
                // // listStr.Insert(0, "C#");
                // listStr.RemoveAt(1);
                //
                // string[] arrStr = ["C#", "World"];
                //
                // arrStr.ToList();
                //
                // listStr = listStr.Concat(arrStr).ToList();
                //
                //
                // string[] strings = listStr.ToArray();
                //
                // foreach (var item in listStr)
                // {
                //     Console.WriteLine(item);
                // }




                // List<int> list = new List<int>();
                //
                // Console.WriteLine(list.Count);
                // Console.WriteLine(list.Capacity);
                //
                // list.Add(100);
                //
                // Console.WriteLine(list.Count);
                // Console.WriteLine(list.Capacity);
                //
                // list.Add(200);
                // list.Add(300);
                // list.Add(400);
                // list.Add(500);
                //
                // Console.WriteLine(list.Count);
                // Console.WriteLine(list.Capacity);
                //
                // list.TrimExcess();
                //
                // Console.WriteLine(list.Count);
                // Console.WriteLine(list.Capacity);
                //
                // // for (int i = 0; i < list.Capacity; i++) //out of range error
                // // {
                // //     Console.WriteLine(list[i]);
                // // }



            #endregion
            
            #region DICTIONARY
            
            //hello - გამარჯობა
            //key value pair
            
            //Manager - 500 123 456
            //Employee - 511 123 456
            
            
            // Dictionary<string, string> dict = new Dictionary<string, string>();
            //
            // dict ["Manager"] = "500 123 456";
            // dict ["Employee"] = "511 123 456";
            //
            // if (dict.ContainsKey("Manager"))
            // {
            //     Console.WriteLine(dict["Manager"]);
            // }
            //
            // foreach (var item in dict)
            // {
            //     // Console.WriteLine(item);
            //     Console.Write(item.Key);
            //     Console.Write(" - ");
            //     Console.WriteLine(item.Value);
            //     // Console.WriteLine(item.Key + " - " + item.Value);
            // }
            //
            #endregion
            
            #region QUEUE and STACK
            
            // Queue<string> queue = new Queue<string>();
            // queue.Enqueue("hello");
            // queue.Enqueue("world");
            // queue.Enqueue("!");
            // queue.Enqueue("C#");
            //
            // Console.WriteLine(queue.Peek()); // გვაწვდის, მაგრამ არ შლის.
            //
            // // queue.Dequeue();  //პირველ ელემენტს გვაძლევს და შლის.
            //
            // foreach (var item in queue)
            // {
            //     Console.WriteLine(item);
            // }
            //
            // Stack<int> stack = new Stack<int>();
            //
            // stack.Push(100);
            // stack.Push(200);
            //
            // Console.WriteLine(stack.Pop());
            // Console.WriteLine(stack.Pop());
            
            #endregion

        #endregion
        
        
        Student student = new Student
            (
            "Will", "Smith", 20, "will@email.com", "512321123", 4, Faculty.Medicine
            );
        
        StudentManagerService stServ = new StudentManagerService();
        
        ArrayHelper.Add(ref stServ.students, student);

        // foreach (var item in stServ.students)
        // {
        //     Console.WriteLine(item);
        // }

        string chooser = "1";
        while (chooser != "8")
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
            chooser = Console.ReadLine();

            switch (chooser)
            {
                case "1":
                    stServ.PrintAllStudents();
                    Console.WriteLine("All students:");
                    break;
                case "2":
                    Console.WriteLine("Best student:");
                    break;
                case "3":
                    Console.WriteLine("Average GPA:");
                    break;
                case "4":
                    Console.WriteLine("Search by last name:");
                    break;
                case "8":
                    Console.WriteLine("App finished");
                    return;
                
                default: Console.WriteLine("Invalid option");
                    break;
            }
        }

    }
}