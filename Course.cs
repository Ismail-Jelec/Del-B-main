
class Course
{
    public List<Student> student = new List<Student>();

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
            Console.WriteLine($"{newStudent} has joined the course {course}");        
            }

            else
            {
                Console.WriteLine("Student is already there");
            }
        }
    }
        
    public void Remove(Student newStudent)
    {
        if(student.Contains(newStudent))
        {
            student.Remove(newStudent);
            newStudent.courses.Remove(this);
            Console.WriteLine($"{newStudent} was removed from {course}");
        }

        else
        {
            Console.WriteLine($"{newStudent} couldn't be removed");

        }
    }

    public void RollCall()
    {
        if(student.Count == 0)
        {
            Console.WriteLine($"{course} doesn't have any students");
        }

        else
        {
            Console.WriteLine($"\nAll students in {course}:");        
            
            foreach(Student enrolledStudent in student)
            {
                Console.WriteLine($"{enrolledStudent}");
            }    
        }
        
    }

    public override string ToString()
    {
        return $"There is {maxseats - student.Count} out of {maxseats} seats left in the course {course}";
    }
}