using System;
namespace DataStructure
{
	public class UnorderedList
	{
        public static void Unordered()
        {
            string text = File.ReadAllText(@"/Users/piyushshaw/Projects/DataStructureProgram/DataStructure/datastructure/WordFile.txt");
            string[] textArray = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            list.Display();
            Console.WriteLine("\nEnter a string which you want to search");
            string searchStr = Console.ReadLine();
            if (list.Search(searchStr))
            {
                list.DeleteElement(searchStr);
            }
            else
            {
                list.InsertFront(searchStr);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"/Users/piyushshaw/Projects/DataStructureProgram/DataStructure/datastructure/WordFile.txt", textFile);
            list.Display();
        }
    }
}

