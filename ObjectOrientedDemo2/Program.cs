using ObjectOrientedDemo2;

public class program
{
     
    public static void Main()
    {
        
        Student Student1 = new Student();
        Student1.GetData();
        Student1.PutData();


        Student Student2 = new Student();
        Student2.GetData();
        Student2.PutData();

        Student Student3 = new Student();
        Student3.GetData();
        Student3.PutData();

        Student Student4 = new Student();
        Student4.GetData();
        Student4.PutData();
        //CreateDemoObject();
    }
    public static void  CreateDemoObject()
    {
        
        Student Student1 = new Student();
        Console.WriteLine("Please enter the student  Id");
        Student1.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the student  Name");
        Student1.Name = Console.ReadLine();

        Console.WriteLine("Please enter the student  Address");
        Student1.Address = Console.ReadLine();


        Student Student2 = new Student();
        Console.WriteLine("Please enter the student  Id");
        Student2.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the student  Name");
        Student2.Name = Console.ReadLine();

        Console.WriteLine("Please enter the student  Address");
        Student2.Address = Console.ReadLine();

        Student Student3 = new Student();
        Console.WriteLine("Please enter the student  Id");
        Student3.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the student  Name");
        Student3.Name = Console.ReadLine();

        Console.WriteLine("Please enter the student  Address");
        Student3.Address = Console.ReadLine();

        Student Student4 = new Student();
        Console.WriteLine("Please enter the student  Id");
        Student4.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the student  Name");
        Student4.Name = Console.ReadLine();

        Console.WriteLine("Please enter the student  Address");
        Student4.Address = Console.ReadLine();


        
        Console.WriteLine("  Id=" + Student1.Id);
        Console.WriteLine(" Name=" + Student1.Name);
        Console.WriteLine(" Address=" + Student1.Address);
    }
}