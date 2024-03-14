
using C_hash_Ass1_Dhanya_Mathew;

public class Program
{

    // Method to create a Student object
    static Student CreateStudent(string id, StudentType type, string firstName, string lastName)
    {

        id ??= "0";
        var student = new Student();
        student.id = Int32.Parse(id);
        student.type = type;
        student.firstName = firstName ?? "Unknown";
        student.lastName = lastName ?? "";
       // return Student object
        return student;
    }

    // Method to output Student information
    static void OutputStudent(Student student)
    {
        Console.WriteLine($"Student: {student.id:D3} {student.firstName} {student.lastName} ({student.type}) ");
    }

    static void Main(string[] args)
    {
        // Define and assign three variables using CreateStudent method

        var student1 = CreateStudent("1", StudentType.FullTime, "John", "Anderson");
        var student2 = CreateStudent("2", StudentType.FullTime, "Karen", "Smith");
        var student3 = CreateStudent("3", StudentType.PartTime, "Kevin", "Peters");
        Console.WriteLine("Assignment One");
        // Output each student
        OutputStudent(student1);
        OutputStudent(student2);
        OutputStudent(student3);

    }
}
