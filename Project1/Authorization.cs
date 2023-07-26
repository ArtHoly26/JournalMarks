
namespace Project1
{
    public class Authorization
    {
        private string? _login;

        private string? _password;
        public string? getLogin()
        {
            return this._login;
        }
        public void setLogin(string? login)
        {
            this._login = login;
        }
        public string? getPassword()
        {
            return this._password;
        }
        public void setPassword(string? password)
        {
            this._password = password;
        }
        public bool checkEnter(string? login,string? password)
        {
            if ((login == "Пшеницен" || login == "Черваков" || login == "Белобородов" || login == "Пушкин") && password == "1234")
            {
                setLogin(login);
                setPassword(password);
                return true;
            }
            else return false;    
        }
        public void helloEnter(string? login)
        {
            if(login == "Пшеницен")     Console.WriteLine("Добро пожаловать Анатолий Иванович! ");
            if (login == "Черваков")    Console.WriteLine("Добро пожаловать Петр Петрович! ");
            if (login == "Белобородов") Console.WriteLine("Добро пожаловать Дмитрий Викторович! ");
            if (login == "Пушкин")      Console.WriteLine("Добро пожаловать Дмитрий Аркадьевич! ");
        }

    }
}
