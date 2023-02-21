using DataStructure;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure Program ");
        while (true)
        {
            Console.WriteLine("\n1.Unordered List \n2.Ordered List");
            Console.WriteLine("Enter a choice from above");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    UnorderedList.Unordered();
                    break;
                case 2:
                    OrderedList.Ordered();
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice ");
                    break;
            }
        }
    }
}