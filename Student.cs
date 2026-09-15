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


    public void Schedule(Course newCourse)
    {
        
    }

    public override string ToString()
    {
        
    }

}

