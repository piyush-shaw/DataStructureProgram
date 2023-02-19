using DataStructure;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure Program ");
        while (true)
        {
            Console.WriteLine("1.Unordered List ");
            Console.WriteLine("Enter a choice from above");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    UnorderedList.Unordered();
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice ");
                    break;
            }
        }
    }
}