namespace homeWork9;

public class Employ
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    public Country Country { get; set; }
    public Gender Gender { get; set; }
    public Contacts Contacts { get; set; }
    
    public Employ 
    (
        string name, 
        string lastName, 
        DateTime dateOfBirth, 
        Country country, 
        Gender gender, 
        Contacts contactType
    )
    {
        Name = name;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Country = country;
        Gender = gender;
        Contacts = contactType;
    }

    public int GetAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        
        if (DateTime.Now.Month < DateOfBirth.Month || (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day))
        {
            age--;
        }
        
        return age;
    }
    
}