
class Course
{
    public List<Student> Students = new List<Student>();

    public string Name;
    public int MaxSeats;

    public Course(string CourseName, int Maxseats)
    {
        Name = CourseName;
        MaxSeats = Maxseats;
    }

    public void Enroll(Student newStudent)
    {
        if(Students.Count >= MaxSeats)
        {
            Console.WriteLine("There are no more spaces left");
        }

        else
        {
            if (!Students.Contains(newStudent))
            {
            Students.Add(newStudent);
            newStudent.Courses.Add(this);    
            Console.WriteLine($"{newStudent} has joined the course {Name}");        
            }

            else
            {
                Console.WriteLine("Student is already there");
            }
        }
    }
        
    public void Remove(Student newStudent)
    {
        if(Students.Contains(newStudent))
        {
            Students.Remove(newStudent);
            newStudent.Courses.Remove(this);
            Console.WriteLine($"{newStudent} was removed from {Name}");
        }

        else
        {
            Console.WriteLine($"{newStudent} couldn't be removed");

        }
    }

    public void RollCall()
    {
        if(Students.Count == 0)
        {
            Console.WriteLine($"{Name} doesn't have any students");
        }

        else
        {
            Console.WriteLine($"\nAll students in {Name}:");        
            
            foreach(Student enrolledStudent in Students)
            {
                Console.WriteLine($"{enrolledStudent}");
            }    
        }
        
    }

    public override string ToString()
    {
        return $"There is {MaxSeats - Students.Count} out of {MaxSeats} seats left in the course {Name}";
    }
}