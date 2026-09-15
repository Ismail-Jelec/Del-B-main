class Student(string FirstName, string LastName)
{
    public List<Course> courses = new List<Course>();

    public string firstname = FirstName;
    public string lastname = LastName;



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
        return firstname + "" + lastname;
    }

}

