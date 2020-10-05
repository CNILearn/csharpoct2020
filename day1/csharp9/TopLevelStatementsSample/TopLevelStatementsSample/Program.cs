System.Console.WriteLine("Hello World!");

ShowArgs(args);

void ShowArgs(string[] args)
{
    foreach (var item in args)
    {
        System.Console.WriteLine(item);
    }
}
