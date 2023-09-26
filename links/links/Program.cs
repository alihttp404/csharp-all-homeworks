using System;

public class MyClass
{
    public string MyString {  get; set; }

    public MyClass(string str) => MyString = str;

    public void Space(string str)
    {
        string result = string.Join("_", str.ToCharArray());
        Console.WriteLine(result);
    }

    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string result = new string(charArray);
        Console.WriteLine(result);
    }
}

public class Run
{
    public void runFunc(Func func, string str)
    {
        func(str);
    }
}

public delegate void Func(string str);

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string");
        string str = Console.ReadLine();
        MyClass cls = new MyClass(str);

        Func spaceFunc = new Func(cls.Space);
        Func reverseFunc = new Func(cls.Reverse);

        Run run = new Run();

        Console.WriteLine("Space():");
        run.runFunc(spaceFunc, str);

        Console.WriteLine("Reverse():");
        run.runFunc(reverseFunc, str);
    }
}
