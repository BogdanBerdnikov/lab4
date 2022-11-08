namespace Task1
{
    class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class Company : Printer
    {
        public Company()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }

    class Position : Company
    {
        public Position()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }

    class NamePerson : Position
    {
        public NamePerson()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            NamePerson name = new NamePerson();
            name.Print("Elon");
            Position company = (Position)name;
            company.Print("Tesla, SpaceX");
            Company position = (Company)company;
            position.Print("Head");
        }
    }
}