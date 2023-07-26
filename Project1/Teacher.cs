
namespace Project1
{
    public class Teacher : Student
    {
        public Teacher(int id,string lastname,string firstname,string patronymic) :base(id,lastname,firstname, patronymic)
        {
            setId(id);
            setLastname(lastname);
            setFirstname(firstname);
            setPatronymic(patronymic);
        }
    }
}
