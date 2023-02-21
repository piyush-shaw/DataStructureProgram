using System;
namespace DataStructure
{
	public class OrderedList
	{
        public static void Ordered()
        {
            string text = File.ReadAllText(@"/Users/piyushshaw/Projects/DataStructureProgram/DataStructure/datastructure/NumberList1.txt");
            string[] textArray = text.Split(" ");
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            int[] arr = new int[textArray.Length];
            for (int i = 0; i < textArray.Length; i++)
            {
                int a = Convert.ToInt32(textArray[i]);
                arr[i] = a;
            }
            for (int i = 0; i < textArray.Length; i++)
            {
                Console.Write(arr[i] + " ");
                //Console.WriteLine("\n");
            }
            for (int i = 0; i < textArray.Length; i++)
            {
                list.Sort(arr[i]);
            }
            list.Display();
            Console.WriteLine("\nEnter a number to search");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            if (list.Search(searchNum))
            {
                list.DeleteElement(searchNum);

            }
            else
            {
                list.Sort(searchNum);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"/Users/piyushshaw/Projects/DataStructureProgram/DataStructure/datastructure/NumberList.txt", textFile);
            list.Display();

        }
    }
}

