using Project1;

var student = new List<Student>
{
    new Student(1,"Иванов", "Иван", "Иванович"),
    new Student(2,"Петров", "Петр", "Петрович"),
    new Student(3,"Леонтьев", "Леонид", "Викторович"),
    new Student(4,"Стрелков", "Вадим", "Анатольевич"),
};
var teacher = new List<Teacher>
{
    new Teacher(1,"Пшеницен","Анатолий","Иванович"),
    new Teacher(2,"Черваков", "Петр", "Петрович"),
    new Teacher(3,"Белобородов", "Дмитрий", "Викторович"),
    new Teacher(4,"Пушкин", "Вадим", "Аркадьевич")
};
var subject = new Dictionary<int, string>()
{
     {1, "Математика" },
     {2, "Программирование" },
     {3, "История" },
     {4, "Физика" }
};
bool flag = false;
var user = new Authorization();
ConsoleKeyInfo choise;
int marks1;

do
{
    do
    {
        Console.WriteLine(DateTime.Now);
        Console.Write("Программа по учету оценок студентов:\n" +
                           "1 - Войти в программу.\n" +
                           "2 - Выйти из программы.\n");
        choise = Console.ReadKey();
        Console.Clear();
        switch (choise.Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("Введите логин:");
                user.setLogin(Console.ReadLine());
                Console.WriteLine("Введите пароль:");
                user.setPassword(Console.ReadLine());
                if (flag != user.checkEnter(user.getLogin(), user.getPassword()))
                {
                    flag = true;
                    user.helloEnter(user.getLogin());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль");
                    Console.ReadLine();
                }
                Console.Clear();
                break;

            case ConsoleKey.D2:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Данного поля не существует!!!");
                break;

        }
    } while (!flag);

    flag = false;

    do
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Пользователь:{0} ", user.getLogin());
        Console.WriteLine("1 - Информация по оценкам.\n" +
                          "2 - Добавить оценки.\n" +
                          "3 - Просмотреть все оценки по студентам.\n" +
                          "4 - Выход");
        choise = Console.ReadKey();
        Console.Clear();
        switch (choise.Key)
        {
            case ConsoleKey.D1:
                foreach (var item in student)
                {
                    item.infoStudent();
                    item.getInfoMarks();
                }
                Console.ReadLine();
                Console.Clear();
                break;

            case ConsoleKey.D2:
                Console.WriteLine("Выберите студента для добавления оценки ");
                foreach (var item in student)
                {
                    item.infoStudent();
                }
                choise = Console.ReadKey();
                Console.Clear();
                switch (choise.Key)
                {
                    case ConsoleKey.D1:
                        do
                        {
                            Console.WriteLine("Выберите предмет: ");
                            foreach (var item in subject) Console.WriteLine($"{item.Key} {item.Value} ");
                            choise = Console.ReadKey();
                            Console.Clear();
                            switch (choise.Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(0).setMathematics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(0).setInfoMarks(user.getLogin(), subject[1], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(0).setProgramming(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(0).setInfoMarks(user.getLogin(), subject[2], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1}", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(0).setHistory(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(0).setInfoMarks(user.getLogin(), subject[3], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D4:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(0).setPhysics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(0).setInfoMarks(user.getLogin(), subject[4], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.Escape:
                                    flag = true;
                                    break;
                                default:
                                    break;
                            }
                        } while (!flag);
                        flag = false;
                        break;

                    case ConsoleKey.D2:
                        do
                        {
                            Console.WriteLine("Выберите предмет: ");
                            foreach (var item in subject) Console.WriteLine($"{item.Key} {item.Value} ");
                            choise = Console.ReadKey();
                            Console.Clear();
                            switch (choise.Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(1).setMathematics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(1).setInfoMarks(user.getLogin(), subject[1], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(1).setProgramming(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(1).setInfoMarks(user.getLogin(), subject[2], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(1).setHistory(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(1).setInfoMarks(user.getLogin(), subject[3], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D4:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(1).setPhysics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(1).setInfoMarks(user.getLogin(), subject[4], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.Escape:
                                    flag = true;
                                    break;
                            }
                        } while (!flag);
                        flag = false;
                        break;

                    case ConsoleKey.D3:
                        do
                        {
                            Console.WriteLine("Выберите предмет: ");
                            foreach (var item in subject) Console.WriteLine($"{item.Key} {item.Value} ");
                            choise = Console.ReadKey();
                            Console.Clear();
                            switch (choise.Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(2).setMathematics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(2).setInfoMarks(user.getLogin(), subject[1], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(2).setProgramming(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(2).setInfoMarks(user.getLogin(), subject[2], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(2).setHistory(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(2).setInfoMarks(user.getLogin(), subject[3], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D4:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(2).setPhysics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(2).setInfoMarks(user.getLogin(), subject[4], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.Escape:
                                    flag = true;
                                    break;
                            }
                        } while (!flag);
                        flag = false;
                        break;

                    case ConsoleKey.D4:
                        do
                        {
                            Console.WriteLine("Выберите предмет: ");
                            foreach (var item in subject) Console.WriteLine($"{item.Key} {item.Value} ");
                            choise = Console.ReadKey();
                            Console.Clear();
                            switch (choise.Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(3).setMathematics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(3).setInfoMarks(user.getLogin(), subject[1], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(3).setProgramming(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(3).setInfoMarks(user.getLogin(), subject[2], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(3).setHistory(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(3).setInfoMarks(user.getLogin(), subject[3], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D4:
                                    Console.WriteLine("Введите оценку:");
                                    student.ElementAt(3).setPhysics(marks1 = Convert.ToInt32(Console.ReadLine()));
                                    student.ElementAt(3).setInfoMarks(user.getLogin(), subject[4], marks1);
                                    Console.WriteLine("Оценка успешно выставлена за: {0}, кем: {1} ", DateTime.Now, user.getLogin());
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case ConsoleKey.Escape:
                                    flag = true;
                                    break;
                            }
                        } while (!flag);
                        flag = false;
                        break;
                }
                Console.Clear();
                break;

            case ConsoleKey.D3:
                foreach (var item in student)
                {
                    item.infoStudent();
                    item.getMathematics();
                    item.getProgramming();
                    item.getHistory();
                    item.getPhysics();
                }
                Console.ReadLine();
                Console.Clear();
                break;

            case ConsoleKey.D4:
                flag = true;
                break;

            default:
                Console.WriteLine("Данного поля не существует!!!");
                break;
        }
    } while (!flag);
    flag=false;
} while (!flag);


