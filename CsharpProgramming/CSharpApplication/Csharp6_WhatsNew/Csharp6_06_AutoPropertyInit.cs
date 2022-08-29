using System;

class ToDo
{
    public DateTime Due { get; set; } = DateTime.Now.AddDays(1);
    public DateTime Created { get; } = DateTime.Now;
    public string Description { get; }

    public ToDo(string description)
    {
        this.Description = description; //Can assign (only in constructor!)
    }
}

class Program
{
    static void Main()
    {
        ToDo t = new ToDo("Hello");
    }
}
