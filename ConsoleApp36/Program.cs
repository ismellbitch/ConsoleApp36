using ConsoleApp36;

internal class Program
{
    private static void Main(string[] args)
    {
        Meeting meeting = new GroupsMeeting(5, 5, 5);
        Console.WriteLine(meeting.ToString());
    }
}