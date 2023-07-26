
using System.Drawing;
using System.Security.Authentication;

namespace Project1
{
    public class Student
    {
        private string? _firstName;
        private string? _lastName;
        private string? _patronymic;
        private int _id;
        private List<int> _mathematics;
        private List<int> _programming;
        private List<int> _history;
        private List<int> _physics;
        private List<string> _infoMarks;

        public Student(int id,string lastname,string firstname,string patronymic)
        {
            setId(id);
            setLastname(lastname);
            setFirstname(firstname);
            setPatronymic(patronymic);
            _mathematics = new List<int>(100);
            _programming = new List<int>(100);
            _history = new List<int>(100);
            _physics = new List<int>(100);
            _infoMarks = new List<string>(100);
        }
        public string? getFirstname()
        {
            return this._firstName;
        }
        public void setFirstname(string firstname)
        {
           this._firstName = firstname;
        }
        public string? getLastname()
        {
            return this._lastName;
        }
        public void setLastname(string lastname)
        {
           this._lastName=lastname;
        }
        public string? getPatronymic()
        {
            return this._patronymic;
        }
        public void setPatronymic(string patronymic)
        {
           this._patronymic=patronymic;
        }
        public int getId()
        {
           return this._id;
        }
        public  void setId(int id)
        {
            this._id = id;
        }
        public void infoStudent()
        {
            Console.WriteLine("{0} {1} {2} {3} ",getId(), getLastname(), getFirstname(), getPatronymic());
        }
        public void getMathematics()
        {
            Console.Write("Математика:       ");
            for (int i = 0; i < _mathematics.Count; i++)
            {
                Console.Write("\t{0}", _mathematics[i]);
            }
            Console.WriteLine();
        }
        public void setMathematics(int marks)
        {
            _mathematics.Add(marks);
        }
        public void getProgramming()
        {
            Console.Write("Программирование: ");
            for (int i = 0; i < _programming.Count; i++)
            {
                Console.Write("\t{0}", _programming[i]);
            }
            Console.WriteLine();
        }
        public void setProgramming(int marks)
        {
            _programming.Add(marks);
        }
        public void getHistory()
        {
            Console.Write("История:          ");
            for (int i = 0; i < _history.Count; i++)
            {
                Console.Write("\t{0}", _history[i]);
            }
            Console.WriteLine();
        }
        public void setHistory(int marks)
        {
            _history.Add(marks);
        }
        public void getPhysics()
        {
            Console.Write("Физика:           ");
            for (int i = 0; i < _physics.Count; i++)
            {
                Console.Write("\t{0}", _physics[i]);
            }
            Console.WriteLine();
        }
        public void setPhysics(int marks)
        {
            _physics.Add(marks);
        }
        public void setInfoMarks( string user, string subject, int marks)
        {
            _infoMarks.Add(DateTime.Now.ToString());
            _infoMarks.Add(user);
            _infoMarks.Add(subject);
            _infoMarks.Add(marks.ToString());
        }
        public void getInfoMarks()
        {
           foreach(var el in _infoMarks)
            {
                Console.WriteLine(el);
            }
        }

    }
}
