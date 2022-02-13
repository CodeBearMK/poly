namespace poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Person person = new Person();
            animal.display();
            person.display();
            Console.WriteLine("------------------------");
            animal = person;
            animal.display();
            Console.Read();
        }
    }
}