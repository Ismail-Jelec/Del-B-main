
class Course
{
    List<Student> student = new List<Student>();

    public string course;
    public int maxseats;

    public Course(string Course, int MaxSeats)
    {
        course = Course;
        maxseats = MaxSeats;
    }

    public string Enroll()
    {
        if(!course.Contains(student))
        {
            
        }
    }

    public string Remove()
    {
        
    }

    public string RollCall()
    {
        
    }

    public string ToString()
    {
        
    }
}