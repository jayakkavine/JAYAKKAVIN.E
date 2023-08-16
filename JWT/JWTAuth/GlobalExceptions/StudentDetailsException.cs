namespace StudentDetails.GlobalExceptions
{
    public class StudentDetailsException
    {
        public static List<string> ExceptionMessage { get; } = new List<string> { 
        
        "Student Not Found",
        "User Not Found"
        
        };
    }
}
