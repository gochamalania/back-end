using System.Text.RegularExpressions;

namespace lecture10;

enum Country
{
    Georgia,
    Germany,
    Netherlands,
    Belgium,
}
    
enum Gender
{
    Male,
    Female,
}

enum Contacts
{
    Phone,
    Email,
    Fax
}


public struct Address //value
{
    public string Street { get; set; }
    public string City { get; set; }
    
    public int x { get; set; }
    public int y { get; set; }
}




public record Person(string Name);

// init


internal class Employee //reference
{
    private sealed class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x is null) return false;
            if (y is null) return false;
            if (x.GetType() != y.GetType()) return false;
            return x._name == y._name && x._lastName == y._lastName && x._birthDate.Equals(y._birthDate) && x.Name == y.Name && x.LastName == y.LastName && x.BirthDate.Equals(y.BirthDate) && x.Cuntry == y.Cuntry && x.Gender == y.Gender && x.Contacts == y.Contacts && x.ContactValue == y.ContactValue;
        }

        public int GetHashCode(Employee obj)
        {
            var hashCode = new HashCode();
            hashCode.Add(obj._name);
            hashCode.Add(obj._lastName);
            hashCode.Add(obj._birthDate);
            hashCode.Add(obj.Name);
            hashCode.Add(obj.LastName);
            hashCode.Add(obj.BirthDate);
            hashCode.Add((int)obj.Cuntry);
            hashCode.Add((int)obj.Gender);
            hashCode.Add((int)obj.Contacts);
            hashCode.Add(obj.ContactValue);
            return hashCode.ToHashCode();
        }
    }

    public static IEqualityComparer<Employee> EmployeeComparer { get; } = new EmployeeEqualityComparer();

    protected bool Equals(Employee other)
    {
        return _name == other._name && 
               _lastName == other._lastName && 
               _birthDate.Equals(other._birthDate) && 
               Name == other.Name && 
               LastName == other.LastName && 
               BirthDate.Equals(other.BirthDate) && 
               Cuntry == other.Cuntry && 
               Gender == other.Gender && 
               Contacts == other.Contacts && 
               ContactValue == other.ContactValue;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Employee)obj);
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(_name);
        hashCode.Add(_lastName);
        hashCode.Add(_birthDate);
        hashCode.Add(Name);
        hashCode.Add(LastName);
        hashCode.Add(BirthDate);
        hashCode.Add((int)Cuntry);
        hashCode.Add((int)Gender);
        hashCode.Add((int)Contacts);
        hashCode.Add(ContactValue);
        return hashCode.ToHashCode();
    }

    public override string ToString()
    {
        return $"Name:{Name}, LastName:{LastName}, Age:{GetAge()}, Country:{Cuntry}";
    }

    private string _name;
    private string _lastName;
    private DateTime _birthDate;
    private string _contactValue;


    public Employee(string name, string lastName, DateTime birthDate, Country cuntry, Gender gender, Contacts contacts, string contactValue)
    {
        Name = name;
        LastName = lastName;
        BirthDate = birthDate;
        Cuntry = cuntry;
        Gender = gender;
        Contacts = contacts;
        ContactValue = contactValue;
    }

    public string Name
    {
        get { return _name;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("name is empty");
                return;
            }
            _name = value;
        }
    }

    public string LastName
    {
        get{ return _lastName;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("last name is empty");
                return;
            }
            _lastName = value;
        }
        
    }

    public DateTime BirthDate
    {
        get{ return _birthDate;}
        set
        {
            if (BirthDate > DateTime.Now)
            {
                Console.WriteLine("BirthDate is in the future, correct it");
                return;
            }
            _birthDate = value;
        }
    }
    
    public Country Cuntry { get; set; }
    public Gender Gender { get; set; }
    public Contacts Contacts { get; set; }

    public string ContactValue
    {
        get
        {
            return _contactValue;
        }
        set
        {
            if (Contacts == Contacts.Phone && value.Length < 10)
            {
                Console.WriteLine("Phone number should be at least 10 digits");
                return;
            }

            if (Contacts == Contacts.Email && !value.Contains("@"))
            {
                Console.WriteLine("Email must contain @ symbol");
                return;
            }

            if (Contacts == Contacts.Email &&
                !Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine("invalid email format");
                return;
            }
            
            _contactValue = value;
        }
    }


    public int GetAge()
    {
        int age = DateTime.Now.Year - BirthDate.Year;

        if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            age--;
        
        return age;
    }


    
}