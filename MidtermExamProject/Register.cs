namespace MidtermExam;

public class Register
{
    private static readonly object locks = new object();
    private static Register instance = null;

    static string prefix, firstName, lastName, email, password, correctPassword, studentId;
    static int age;
    static bool isStudent;

    public Register() { }

    public Register Instance
    {
        get
        {
            lock (locks)
            {
                if (instance != null) instance = new Register();
            }
            return instance;
        }
    }

    public static void RegisterUser()
    {
        Console.WriteLine("------------------ Register ------------------");
        Console.WriteLine("(1)General\n(2)Student");
        CheckType();
    }

    static void CheckType()
    {
        switch (UserInput.InputInt())
        {
            case 1:
                Console.Clear();
                isStudent = false;
                General();
                break;
            case 2:
                Console.Clear();
                isStudent = true;
                Student();
                break;
            default: throw new Exception("Out of menu");
        }
    }

    static void General()
    {
        Console.WriteLine("---------------- General Register ----------------");
        Console.WriteLine("Select Your Prefix.");
        Console.WriteLine("(1) Mr\n(2) Ms\n(3) Mrs\n");
        Prefix();
        Console.WriteLine("Input Your FirstName.");
        firstName = UserInput.InputString();
        Console.WriteLine("Input Your LastName.");
        lastName = UserInput.InputString();
        NameCheck();
        Console.WriteLine("Input Your Age.");
        age = UserInput.InputInt();
        Console.WriteLine("Input Your Email.");
        email = UserInput.InputString();
        EmailCheck();
        Console.WriteLine("Input Your Password.");
        password = UserInput.InputString();
        Console.WriteLine("Input Your CurrentPassword.");
        correctPassword = UserInput.InputString();
        PasswordCheck();
    }

    static void Student()
    {
        Console.WriteLine("---------------- Student Register ----------------");
        Console.WriteLine("Select Your Prefix.");
        Console.WriteLine("(1) Mr\n(2) Ms\n(3) Mrs\n");
        Prefix();
        Console.WriteLine("Input Your FirstName.");
        firstName = UserInput.InputString();
        Console.WriteLine("Input Your LastName.");
        lastName = UserInput.InputString();
        NameCheck();
        Console.WriteLine("Input Your Age.");
        age = UserInput.InputInt();
        Console.WriteLine("Input Your StudentId.");
        studentId = UserInput.InputString();
        Console.WriteLine("Input Your Email.");
        email = UserInput.InputString();
        EmailCheck();
        Console.WriteLine("Input Your Password.");
        password = UserInput.InputString();
        Console.WriteLine("Input Your CurrentPassword.");
        correctPassword = UserInput.InputString();
        PasswordCheck();
    }

    static void Prefix()
    {
        switch (UserInput.InputInt())
        {
            case (1):
                prefix = "Mr";
                break;
            case (2):
                prefix = "Ms";
                break;
            case (3):
                prefix = "Mrs";
                break;
            default: throw new Exception("Out of menu");
        }

    }
    
    static void NameCheck()
    {
        if (UserData.UserDataList.ContainsValue(prefix + firstName + lastName))
        {
            Console.Clear();
            Console.WriteLine("User is already registered. Please try again.");
            RegisterUser();
        }
    }

    static void EmailCheck()
    {
        if (UserData.EmailDataList.Contains(email) || email == "exit")
        {
            Console.Clear();
            Console.WriteLine("Invalid email. Please try again.");
            RegisterUser();
        }
    }

    static void PasswordCheck()
    {
        if (password == correctPassword)
        {
            AddUserData();
            Clear();
            Console.Clear();
            Menu.MainMenu();
        }
        else
        {
            Clear();
            Console.Clear();
            Console.WriteLine("Mismatched passwords. Please try again.");
            RegisterUser();
        }
    }

    static void AddUserData()
    {
        UserData.AddUser(prefix + firstName + lastName, email, password, isStudent);
    }

    static void Clear()
    {
        prefix = string.Empty;
        firstName = string.Empty;
        lastName = string.Empty;
        age = 0;
        email = string.Empty;
        password = string.Empty;
        correctPassword = string.Empty;
        studentId = string.Empty;
    }
}