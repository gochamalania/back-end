namespace lecture21;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(CountUp);
        Thread thread2 = new Thread(CountDown);
        
        thread1.Start();
        thread2.Start();
        
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Done!");

        static void CountUp()
        {
            for (int i =0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
}
