public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }

    private int age; // private sahə

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new AgeException("Age cannot be zero or negative.");
            }
            age = value;
        }
    }

    public Human(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} {Surname}, Age: {Age}";
    }
}
