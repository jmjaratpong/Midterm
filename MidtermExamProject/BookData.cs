
namespace MidtermExam
{
    public class BookData
    {
        static List<string> bookList = new List<string>();
        static List<string> bookListStore = new List<string>();

        public static List<string> BookList
        {
            get { return bookList; }
            set { bookList = value; }
        }

        public static List<string> BookListStore
        {
            get { return bookListStore; }
            set { bookListStore = value; }
        }

        public static void Clear()
        {
            bookList.Clear();
        }
    }
}
