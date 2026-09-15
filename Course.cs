
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
        if(!student.Contains(newStudent))
        {
            student.Add(newStudent);
        }

        newStudent.courses.Add(this);
    }

    public void Remove(Student newStudent)
    {
        if(student.Contains(newStudent))
        {
            
        }
    }

    public void RollCall()
    {
        
    }

    public void ToString()
    {
        
    }
}