
namespace MidtermExam
{
    public class UserData
    {
        private static Dictionary<string, string> userData = new Dictionary<string, string>();
        private static List<string> emailData = new List<string>();
        private static Dictionary<string, bool> typeData = new Dictionary<string, bool>();
        private static Dictionary<string,string> loginData = new Dictionary<string, string>();

        public static void AddUser(string user, string email, string password, bool isStudent)
        {
            userData.Add(email, user);
            emailData.Add(email);
            typeData.Add(email, isStudent);
            loginData.Add(email, password);
        }

        public static void Clear()
        {
            userData.Clear();
            emailData.Clear();
            typeData.Clear();
            loginData.Clear();
        }

        public static Dictionary<string, string> UserDataList
        {
            get { return userData; }
            set { userData = value; }
        }

        public static List<string> EmailDataList
        {
            get { return emailData; }
            set { emailData = value; }
        }
        public static Dictionary<string, bool> TypeDataList
        {
            get { return typeData; }
            set { typeData = value; }
        }

        public static Dictionary<string, string> LoginDataList
        {
            get { return loginData; }
            set { loginData = value; }
        }
    }
}
