
namespace MidtermExam
{
    public class Login
    {
        static string email, password;
        public static void LoginUser()
        {
            Console.WriteLine("---------------- Login ----------------");
            Console.WriteLine("Input Email.");
            email = UserInput.InputString();
            CheckExit();
            Console.WriteLine("Input Password.");
            password = UserInput.InputString();
            CheckUser();
        }

        static void CheckExit()
        {
            if (email == "exit")
            {
                Console.Clear();
                Menu.MainMenu();
            }
        }

        static void CheckUser()
        {
            if (!UserData.EmailDataList.Contains(email) || password != UserData.LoginDataList[email])
            {
                Console.Clear();
                Console.WriteLine("Incorrect password. Please try again.");
                LoginUser();
            }
            else
            {
                Console.Clear();
                LoginMenu();
            }
        }

        static void LoginMenu()
        {
            Console.WriteLine("------------------ Menu ------------------");
            Console.WriteLine("Please Enter Menu");
            Console.WriteLine("(1)Book\n(2)Book Result\n(3)Logout");
            SelectedLoginMenu();
        }

        static void SelectedLoginMenu()
        {
            switch (UserInput.InputInt())
            {
                case (1):
                    Console.Clear();
                    Book.BookSeat();
                    break;
                case (2):
                    Console.Clear();
                    BookResult.Result();
                    break;
                case (3):
                    Console.Clear();
                    Menu.MainMenu();
                    break;
                default: throw new Exception("Out of menu");
            }
        }

        public static string GetEmailID()
        {
            return email;
        }
    }
}
