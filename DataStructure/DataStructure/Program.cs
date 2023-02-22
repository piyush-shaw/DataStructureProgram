using DataStructure;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure Program ");
        while (true)
        {
            Console.WriteLine("\n1.Unordered List \n2.Ordered List \n3.Balancing Parantheses \n4.Banking Cash Counter \n5.Palindrome Checker \n6.Print Calendar");
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
                case 4:
                    BankingCashCounter banking = new BankingCashCounter();
                    banking.MaintainQueue();
                    break;
                case 5:
                    PalindromeChecker<char> checker = new PalindromeChecker<char>();
                    checker.IsPalindrome();
                    break;
                case 6:
                    Calendar.PrintCalender();
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice ");
                    break;
            }
        }
    }
}