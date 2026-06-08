namespace homeWork9;

class Program
{
    static void Main(string[] args)
    {
        Employ[] employs = new Employ[8];

        employs[0] = new Employ("Jon", "Doe", new DateTime(1994, 8, 12), Country.Georgia, Gender.Male, Contacts.Phone);
        employs[1] = new Employ("Jon", "Jolly", new DateTime(1998, 2, 25), Country.UK, Gender.Male, Contacts.Email);
        employs[2] = new Employ("John", "Smith", new DateTime(1995, 10, 5), Country.Netherlands, Gender.Male, Contacts.Phone);
        employs[3] = new Employ("Emma", "Johnson", new DateTime(1997, 7, 11), Country.Spain, Gender.Female, Contacts.Email);
        employs[4] = new Employ("Hans", "Muller", new DateTime(1993, 1, 18), Country.Georgia, Gender.Male, Contacts.Phone);
        employs[5] = new Employ("Anna", "Schmidt", new DateTime(1999, 9, 9), Country.Spain, Gender.Female, Contacts.Email);
        employs[6] = new Employ("Pierre", "Dubois", new DateTime(1996, 4, 2), Country.UK, Gender.Male,Contacts.Phone);
        employs[7] = new Employ("Marie", "Laurent", new DateTime(2001, 12, 30), Country.UK, Gender.Female, Contacts.Email);

        Console.WriteLine("All Employees By Country:");
        
        Helpers.PrintByCountry(employs, Country.UK);

        Console.WriteLine();
        
        Helpers.PrintByCountry(employs, Country.Spain);
        
    }
}