//Създайте програма, която да се предоставя информация за служителите в една фирма.
//Всички служители трябва да имат един и същ шеф. Използвайте Singleton, за да постигнете това.

using SingletonDesignPattern;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        Boss boss = Boss.GetInstance;
        boss.Name = "Josh";

        Employee emp1 = new Employee("John", boss);
        Employee emp2 = new Employee("Emma", boss);

        emp1.ShowInfo();
        emp2.ShowInfo();
    }
}
