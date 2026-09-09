using System.Data;
using Microsoft.Data.SqlClient;
using _1ADONet.Models;

namespace _1ADONet.Data;

public class InstructorRepository
{
    private readonly string _connectionString;

    public InstructorRepository(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException( "connection string cannot be null or empty.", nameof(connectionString));
        }
        _connectionString = connectionString;
    }

    public bool TestConnection()
    {
        try
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return true;
            }
        }
        catch (SqlException)
        {
            return false;
        }
    }


    public List<Instructor> GetAll()
    {
        var instructors = new List<Instructor>();

        const string query = @"
        SELECT InstructorID, FirstName, LastName, Email
        FROM INSTRUCTORS
        ORDER BY InstructorID;";

        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            connection.Open();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var instructor = new Instructor
                    {
                        InstructorID = reader.GetInt32(reader.GetOrdinal("InstructorID")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        Email = reader.GetString(reader.GetOrdinal("Email"))
                    };

                    instructors.Add(instructor);
                }
            }
        }

        return instructors;
    }


    public Instructor? GetById(int id)
    {
        if (id <= 0)
        {
            return null;
        }
        
        const string query = @"
            SELECT InstructorID, FirstName, LastName, Email
            FROM INSTRUCTORS
            WHERE InstructorID = @InstructorID;";
        
        
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.Add("@InstructorID", SqlDbType.Int).Value = id;
            
            connection.Open();

            using (var reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }

                return new Instructor
                {
                    InstructorID = reader.GetInt32(
                        reader.GetOrdinal("InstructorID")),

                    FirstName = reader.GetString(
                        reader.GetOrdinal("FirstName")),

                    LastName = reader.GetString(
                        reader.GetOrdinal("LastName")),

                    Email = reader.GetString(
                        reader.GetOrdinal("Email"))
                };
            }
        }
    }
    
    
    public int Create(Instructor instructor)
    {
        if (instructor is null)
        {
            throw new ArgumentNullException(nameof(instructor));
        }

        if (string.IsNullOrWhiteSpace(instructor.FirstName))
        {
            throw new ArgumentException("First name is required.");
        }

        if (string.IsNullOrWhiteSpace(instructor.LastName))
        {
            throw new ArgumentException("Last name is required.");
        }

        if (string.IsNullOrWhiteSpace(instructor.Email))
        {
            throw new ArgumentException("Email is required.");
        }

        const string query = @"
        INSERT INTO INSTRUCTORS (FirstName, LastName, Email)
        VALUES (@FirstName, @LastName, @Email);

        SELECT CAST(SCOPE_IDENTITY() AS INT);";

        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50)
                .Value = instructor.FirstName.Trim();

            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50)
                .Value = instructor.LastName.Trim();

            command.Parameters.Add("@Email", SqlDbType.VarChar, 255)
                .Value = instructor.Email.Trim();

            connection.Open();

            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
    
    
    public bool Update(Instructor instructor)
    {
        if (instructor is null)
        {
            throw new ArgumentNullException(nameof(instructor));
        }

        if (instructor.InstructorID <= 0)
        {
            throw new ArgumentException("Invalid instructor ID.");
        }

        if (string.IsNullOrWhiteSpace(instructor.FirstName))
        {
            throw new ArgumentException("First name is required.");
        }

        if (string.IsNullOrWhiteSpace(instructor.LastName))
        {
            throw new ArgumentException("Last name is required.");
        }

        if (string.IsNullOrWhiteSpace(instructor.Email))
        {
            throw new ArgumentException("Email is required.");
        }

        const string query = @"
        UPDATE INSTRUCTORS
        SET FirstName = @FirstName,
            LastName = @LastName,
            Email = @Email
        WHERE InstructorID = @InstructorID;";

        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.Add("@InstructorID", SqlDbType.Int)
                .Value = instructor.InstructorID;

            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50)
                .Value = instructor.FirstName.Trim();

            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50)
                .Value = instructor.LastName.Trim();

            command.Parameters.Add("@Email", SqlDbType.VarChar, 255)
                .Value = instructor.Email.Trim();

            connection.Open();

            int affectedRows = command.ExecuteNonQuery();

            return affectedRows > 0;
        }
    }
    
    public bool Delete(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Invalid instructor ID.");
        }

        const string query = @"
        DELETE FROM INSTRUCTORS
        WHERE InstructorID = @InstructorID;";

        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.Add("@InstructorID", SqlDbType.Int)
                .Value = id;

            connection.Open();

            int affectedRows = command.ExecuteNonQuery();

            return affectedRows > 0;
        }
    }
    
}