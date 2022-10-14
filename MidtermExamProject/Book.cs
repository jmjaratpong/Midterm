
namespace MidtermExam
{
    public class Book
    {
        static string seat;
        static string[] charArray;

        public static void BookSeat()
        {
            Console.WriteLine("------------------ Book ------------------");
            Console.WriteLine("Input your book seat.\n[Input MUST start with type seat then number and line between number... example B-1-2-3 or A-5-7-9]");
            seat = UserInput.InputString();
            CheckInput();
        }

        static void CheckInput()
        {
            if (seat == "checkout" && BookData.BookList.Count > 0)
            {
                Console.Clear();
                Paymentcs.Pay();
                ClearSeat();
                return;
            }

            if (seat == "exit" ) 
            {
                Console.Clear();
                Menu.MainMenu();
                BookData.Clear();
                return;
            }

            if(seat == "checkout" && BookData.BookList.Count == 0)
            {
                Console.Clear();
                Menu.MainMenu();
                BookData.Clear();
                return;
            }

            if(SeatInput[0] == "A" && UserData.TypeDataList[Login.GetEmailID()])
            {
                Console.Clear();
                Console.WriteLine("Cannot book. Please try again.");
                ClearSeat();
                BookSeat();
                return;
            }

            CheckSeat();
        }

        static void CheckSeat()
        {
            Console.Clear();
            for (int i = 1; i < SeatInput.Length; i++)
            {
                if (!BookData.BookListStore.Contains(SeatInput[0].ToString() + "-" + SeatInput[i]) && !BookData.BookList.Contains(SeatInput[0].ToString() + "-" + SeatInput[i]))
                {
                    BookData.BookList.Add(SeatInput[0].ToString() + "-" + SeatInput[i]);
                }
                else AlreadyBook();
            }
            BookSeat();
            ClearSeat();
        }

        static void AlreadyBook()
        {
            Console.Clear();
            Console.WriteLine("Already booked. Please try again.");
        }

        public static string[] SeatInput
        {
            get
            {
                seat = seat.ToUpper();
                charArray = seat.Split("-");
                return charArray;
            }
        }

        public static void ClearSeat()
        {
            for(int i = 0; i < SeatInput.Length; i++)
            {
                SeatInput[i] = string.Empty;
            }
            seat = string.Empty;
        }
    }
}
