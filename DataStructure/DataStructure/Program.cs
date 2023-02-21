using DataStructure;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure Program ");
        while (true)
        {
            Console.WriteLine("\n1.Unordered List \n2.Ordered List \n3.Balancing Parantheses");
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
                case 3:
                    char[] expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)".ToCharArray();
                    BalancingParentheses.StackOperations stackOperations = new BalancingParentheses.StackOperations();
                    bool result = stackOperations.Isbalanced(expression);
                    if (result)
                    {
                        Console.WriteLine("Parantheses Balanced");
                    }
                    else
                    {
                        Console.WriteLine("Parantheses not Balanced");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice ");
                    break;
            }
        }
    }
}