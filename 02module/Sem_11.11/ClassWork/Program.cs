using System;
/*
 Реализовать класс, представляющий сведения о человеке Person.
Реализовать свойства: Ф.И.О.(string FullName), дата рождения (DateTime BirthDate), пол (bool IsMale).
Реализовать метод для вывода информации о человеке void ShowInfo().
Реализовать класс, представляющий сведения о студенте Student (наследуется от Person).
Реализовать свойства: название ВУЗа (string Institute), специальность (string Speciality).
Реализовать класс, представляющий сведения о сотруднике фирмы Employee (наследуется от Person).
Реализовать свойства: название компании (string CompanyName), должность (string Post), график (string Schedule),
оклад (decimal Salary).
 
В основной программе решить задачи:
- Создать  объекты всех трех типов и вызвать ShowInfo(), чтобы показать всю доступную информацию.
- Создать массив Person[] arr и присвоить его членам объекты всех трех типов. Продемонстрировать работу метода ShowInfo() на массиве. 
 */

class Person
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }

    public Person(string f, DateTime d, bool m)
    {
        FullName = f;
        BirthDate = d;
        IsMale = m;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale}");
    }
}

class Student : Person
{
    public string Institute { get; set; }
    public string Speciality { get; set; }

    public Student(string f, DateTime d, bool m, string inst, string spec) : base(f, d, m)
    {
        Institute = inst;
        Speciality = spec;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {Institute} {Speciality}");
    }
}
class Employee : Person
{
    string CompanyName { get; set; }
    string Post { get; set; }
    string Schedule { get; set; }
    decimal Salary { get; set; }

    public Employee(string f, DateTime d, bool m, string compName, string p, string sch, decimal sal) : base(f, d, m)
    {
        CompanyName = compName;
        Post = p;
        Schedule = sch;
        Salary = sal;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {CompanyName} {Post} {Schedule} {Salary}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("ewfewfef", new DateTime(2000, 10, 10), true);
        Student student = new Student("oieweqvb", new DateTime(2010, 5, 5), false, "3grh4", "r4tgrv");
        Employee employee = new Employee("Name", new DateTime(2000, 12, 3), true, "App", "mail", "full", 10000);
        person.ShowInfo();
        student.ShowInfo();
        employee.ShowInfo();
        Person[] arr = { person, student, employee };
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i].ShowInfo();
        }
    }
}
