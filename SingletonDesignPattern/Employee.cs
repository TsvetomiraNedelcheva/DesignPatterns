namespace SingletonDesignPattern
{
    public class Employee
    {
        public Employee(string name, Boss boss)
        {
            this.Name = name;
            this.Boss = boss;
        }

        public string Name { get; set; }
        public Boss Boss { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("I am {0} and my boss is {1}", Name, Boss.Name);
        }
    }
}
