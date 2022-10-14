
namespace MidtermExam
{
    public class BookResult
    {
        public static void Result()
        {
            Console.WriteLine("------------------ Book Result ------------------");
            if (!CheckStoreBook())
            {
                Console.WriteLine("Please book your seat first.");
                Console.ReadLine();
                Console.Clear();
                Menu.MainMenu();
            }
            else ShowInformation();
            CheckMethod();
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu();
        }

        static bool CheckStoreBook()
        {
            if (BookData.BookListStore.Count > 0) return true;
            else return false;
        }

        static void ShowInformation()
        {
            if(UserData.TypeDataList[Login.GetEmailID()]) Console.WriteLine("General");
            else Console.WriteLine("Student");
            BookData.BookListStore.Sort();
            Console.WriteLine("General Zone");
            foreach (var i in BookData.BookListStore)
            {
                if (i.StartsWith("A")) Console.Write(i + " 5,235.25 bath/seat \n");
            }
            Console.WriteLine("Student Zone");
            foreach (var i in BookData.BookListStore)
            {
                if (i.StartsWith("B")) Console.Write(i + " 1,200.50 bath/seat \n");
            }
        }

        static void CheckMethod()
        {
            if(Paymentcs.Method() == 0)
            {
                Console.WriteLine("Payment Method : Baking");
                Console.WriteLine("Banking Name : " + Paymentcs.BankingName());
                Console.WriteLine("Banking Number : " + Paymentcs.BankingNumber());
            }
            if (Paymentcs.Method() == 1)
            {
                Console.WriteLine("Payment Method : Cradit");
                Console.WriteLine("Cradit Name : " + Paymentcs.CraditName());
                Console.WriteLine("Cradit Number : " + Paymentcs.CraditNumber());
                Console.WriteLine("Cradit Date : " + Paymentcs.CraditDate());
                Console.WriteLine("Cradit CVV : " + Paymentcs.CraditCVV());
            }
        }
    }
}
