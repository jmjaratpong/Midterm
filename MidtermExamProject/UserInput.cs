namespace MidtermExam;

public class UserInput
{
    public static string InputString()
    {
        return Console.ReadLine();
    }

    public static int InputInt()
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }

        throw new Exception("Not integer");
    }
}