
class Course
{
    List<Student> student = new List<Student>();

    public string course;
    public int maxseats;

    public Course(string CourseName, int MaxSeats)
    {
        course = CourseName;
        maxseats = MaxSeats;
    }

    public void Enroll(Student newStudent)
    {
        if(student.Count >= maxseats)
        {
            Console.WriteLine("There are no more spaces left");
        }

        else
        {
            if (!student.Contains(newStudent))
            {
            student.Add(newStudent);
            newStudent.courses.Add(this);            
            }

            else
            {
                Console.WriteLine("Student couldn't be added");
            }
        }
    }
        

    public void Remove(Student newStudent)
    {
        if(student.Contains(newStudent))
        {
            student.Remove(newStudent);
            newStudent.courses.Remove(this);
        }

        else
        {
            Console.WriteLine("Student couldn't be removed");

        }
    }

    public void RollCall()
    {
        if(student.Count == 0)
        {
            Console.WriteLine("The course doesn't have any students");
        }
        
        foreach(Student enrolledStudent in student)
        {
            Console.WriteLine($"-{enrolledStudent}");
        }
    }

    public override string ToString()
    {
        return $"There is {student.Count}/{maxseats} remaining";


    }
}