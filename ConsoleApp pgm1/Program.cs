// See https://aka.ms/new-console-template for more information
class MyClass
{
    enum Grade { pass = 60, Distinction = 85 };
    public  static string GetGrade(int marks)
    {
        if (marks >= (int)Grade.Distinction)
            return "Distinction";
        else if (marks >= (int)Grade.pass)
            return "Pass";
        else
            return "Fail";
        
    }
    public static void Main()
    {

        int empid;
        int Marks;
        Console.WriteLine("Whats your empid?");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Thanks for entering empid {empid}");

        Console.WriteLine("Enter your TSQL Marks?");
        Marks = Convert.ToInt32(Console.ReadLine());

        string Grade = GetGrade(Marks);
        Console.WriteLine($"you are in {Grade}grade,TRY AGAIN");
    }
}
 