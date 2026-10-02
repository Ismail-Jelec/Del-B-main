class Student(string Name)
{
    public List<Course> Courses = new List<Course>();

    public void Join(Course newCourse)
    {
        newCourse.Enroll(this);
    }

    public void Leave(Course newCourse)
    {
        newCourse.Remove(this);
    }

    public void Schedule()
    {


        if(Courses.Count >= 1)
        {
            Console.WriteLine($"This is {Name}'s courses: ");

            foreach(Course courselista in Courses)
            {
                Console.WriteLine($"{courselista.Name}");
            }
        }
            else
            {
                Console.WriteLine("The student does not have any courses");
            }
    }

    public override string ToString()
    {
        return Name;
    }

}

