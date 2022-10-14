namespace MidtermExam;

public class Menu
{
    private static readonly object locks = new object();
    private static Menu instance = null;
    public Menu() { }

    public Menu Instance
    {
        get
        {
            lock (locks)
            {
                if (instance != null) instance = new Menu();
            }
            return instance;
        }
    }

    public static void MainMenu()
    {
        Console.WriteLine("------------------ Menu ------------------");
        Console.WriteLine("Please Enter Menu");
        Console.WriteLine("(1)Register\n(2)Login");
        SelectedMainMenu();
    }

    private static void SelectedMainMenu()
    {
        switch (UserInput.InputInt())
        {
            case (1):
                Console.Clear();
                Register.RegisterUser();
                break;
            case (2):
                Console.Clear();
                Login.LoginUser();
                break;
            default: throw new Exception("Out of menu");
        }
    }
}