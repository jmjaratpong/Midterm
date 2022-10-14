
namespace MidtermExam
{
    public class Paymentcs
    {
        static string accountNumber, accountName, creditName, creditNumber, date, cvv;
        static int idMethod; 
        public static void Pay()
        {
            Console.WriteLine("------------------ Pay ------------------");
            ShowSeat();
            PayMethod();
        }

        static void ShowSeat()
        {
            BookData.BookList.Sort();
            Console.WriteLine("General Zone");
            foreach(var i in BookData.BookList)
            {
                if (i.StartsWith("A")) Console.Write(i + " 5,235.25 bath/seat \n");
            }
            Console.WriteLine("Student Zone");
            foreach (var i in BookData.BookList)
            {
                if (i.StartsWith("B")) Console.Write(i + " 1,200.50 bath/seat \n");
            }
        }
        static void PayMethod()
        {
            Console.WriteLine("(1)Banking\n(2)Cradit\n(3)Cancle");
            SelectedMethod();
        }
        static void SelectedMethod()
        {
            switch (UserInput.InputInt())
            {
                case (1):
                    Console.Clear();
                    Banking();
                    break;
                case (2):
                    Console.Clear();
                    Cradit();
                    break;
                case (3):
                    Console.Clear();
                    BookData.Clear();
                    Menu.MainMenu();
                    break;
                default: throw new Exception("Out of menu");
            }
        }

        static void Banking()
        {
            Console.WriteLine("Input account name");
            accountName = UserInput.InputString();
            Console.WriteLine("Input account number");
            accountNumber = UserInput.InputString();
            idMethod = 0;
            EndingPayment();
        }

        static void Cradit()
        {
            Console.WriteLine("Input cradit name");
            creditName = UserInput.InputString();
            Console.WriteLine("Input cradit number");
            creditNumber = UserInput.InputString();
            Console.WriteLine("Input cradit date");
            date = UserInput.InputString();
            Console.WriteLine("Input cradit CVV");
            cvv = UserInput.InputString();
            idMethod = 1;
            EndingPayment();
        }

        static void EndingPayment()
        {
            Console.Clear();
            ShowSeat();
            foreach (var i in BookData.BookList) BookData.BookListStore.Add(i);
            Console.WriteLine("------------- Your order successful -------------");
            Console.WriteLine("------------- Thank you for your order -------------");
            Console.ReadLine();
            BookData.Clear();
            Console.Clear();
            BookResult.Result();
        }

        public static int Method()
        {
            return idMethod;
        }

        public static string BankingName()
        {
            return accountName;
        }

        public static string BankingNumber()
        {
            return accountNumber;
        }

        public static string CraditName()
        {
            return creditName;
        }

        public static string CraditNumber()
        {
            return creditNumber;
        }

        public static string CraditDate()
        {
            return date;
        }

        public static string CraditCVV()
        {
            return cvv;
        }
    }
}
