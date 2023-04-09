class student
{
    public string name;
    public string surname;
    public string group;
    public int point;
    public bool isGraduated;

    public student(string name, string surname, string group, int point, bool isGraduated)
    {
        this.name = name;
        this.surname = surname;
        this.group = group;
        this.point = point;
        this.isGraduated = isGraduated;
    }
    public void GetFullInfo() 
    {
        Console.WriteLine($"{this.name},{this.surname},{this.group},{this.point}");
        if (point>50)
        {
            Console.WriteLine("mezun oldunuz");
        }
        else
        {
            Console.WriteLine("mezun olmayib");
        }
        if(isGraduated=true &&  point > 80)
        {
            Console.WriteLine("ikinci imtahana gire biler");
        }
        else if (isGraduated=true && point < 80)
        {
            Console.WriteLine("ikinci imtahana gire bilmez");
        }
    }
}