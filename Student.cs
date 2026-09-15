class Student(string Name)
{
    public List<Course> courses = new List<Course>();

    public string name = Name;



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


        if(courses.Count >= 1)
        foreach(Course courselista in courses)
        {
            Console.WriteLine($"-{courselista}");
        }

        else
        {
            Console.WriteLine("The student does not have any courses");
        }
    }

    public override string ToString()
    {
        return name;
    }

}

