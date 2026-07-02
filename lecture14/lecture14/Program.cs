using lecture14.Helpers;

namespace lecture14;

class Program
{
    static void Main(string[] args)
    {
        #region Generic
        
        // Box<int> box = new();
        // box.Value = 10;
        // box.Display();
        //
        //
        // var box2 = new Box<string>();
        // box2.Value = "Hello";
        // box2.Display();
        
        
        // Pair<int, string> pair = new() {First = 10, Second = "KG"};


        // Pair<int, string> pair = new();
        // pair.First = 10;
        // pair.Second = "KG";
        // pair.Display();
        
        
        // Test test = new Test();
        
        // Test.Print<string>("Hello");
        // Test.Print<int>(10);
        // Test.Print<bool>(true);
        // Test.Print("Hello");
        // Test.Print(10);
        // Test.Print(true);


        // Test<int> test = new();
        // test.Value = 50;
        // test.DisplayInfo<string>("Passed");
        // Test<int>.Print<string>("Hello");
        
        #endregion

        // Student student = new Student();
        // student.Grade = new Grade() {Value = 95};
        // student.Comment = new Comment() {Value = "Good"};
        // student.PassedExam = new PassedExam() {Value = true};
        //
        // // student.Grade.Print();
        // // student.Comment.Print();
        // // student.PassedExam.Print();
        //
        // student.Print(student.Grade);
        // student.Print(student.Comment);
        // student.Print(student.PassedExam);


        Student student = new Student();

        student.Grade = new Remark<int> { Type = RemarkType.Grade, Value = 95 };
        student.Comment = new Remark<string> { Type = RemarkType.Comment, Value = "Good" };
        student.Passed = new Remark<bool> { Type = RemarkType.Passed, Value = true };
        
        student.Grade.Print();
        student.Comment.Print();
        student.Passed.Print();

        
        Player player = new Player();
        
        Inventory inventory = new Inventory();
        inventory.Name = "Sword";
        inventory.Description = "A sword for fighting";
        
        Inventory inventory2 = new Inventory();
        inventory2.Name = "Shield";
        inventory2.Description = "A shield for defending";
        
        player.Inventory = [inventory, inventory2];


        Enemy enemy = new Enemy();

        Weapon weapon = new();
        weapon.Name = "kar98";
        weapon.Damage = 105;

        Weapon weapon2 = new();
        weapon2.Name = "AS50";
        weapon2.Damage = 120;
        
        Weapon weapon3 = new();
        weapon3.Name = "HDR";
        weapon3.Damage = 150;

        enemy.Weapon = [weapon, weapon2];



        ArrayHelper.Add<Weapon>(ref enemy.Weapon, weapon3);
        
        foreach (var item in enemy.Weapon)
        {
            Console.WriteLine(item.Name);
        }


    }
    
    
    
    
    
    
    
    
    #region Generic
    
    // public class Test<T>
    // {
    //     public T Value;
    //
    //     public void DisplayInfo<T1>(T1 param)
    //     {
    //         Console.WriteLine($"Name: {Value} {param}");
    //     }
    //     
    //
    //     public static void Print<T>(T param)
    //     {
    //         Console.WriteLine(param);
    //     }
    // }
    
    // name age
    // name passed
    // public class Pair<T1, T2>
    // {
    //     public T1 First;
    //     public T2 Second;
    //
    //     public void Display()
    //     {
    //         Console.WriteLine($"{First} {Second}");
    //     }
    
    // }
    
    
    // class Box <T>
    // {
    //     public T Value;
    //
    //     public void Display()
    //     {
    //         Console.WriteLine(Value);
    //     }
    //         
    // }
    
    #endregion
    
    
    
    
}