using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Unorderedlist
    {
        public void Operation()
        {
           // string filepath = @"E:\RFP\DataStructure\Datastructure\Datastructure\Utility\DataFile.txt";
            string data = File.ReadAllText(@"E:\RFP\DataStructure\Datastructure\Datastructure\Utility\DataFile.txt");
            Console.WriteLine("-----------------------Data from the file..---------------------------");
            Console.WriteLine(data);
           // data = Regex.Replace(data, @"[^a-zA-Z0-9 ]+", "");
           // Console.WriteLine();
           // Console.WriteLine(data);
            string[] words = data.Split(' ');
           // Console.WriteLine();
            LinkedList<string> linkedlist = new LinkedList<string>();
            foreach (string item in words)
            {
                linkedlist.AddLast(item);
            }
            Console.WriteLine("data into array...");
            Display(linkedlist);
            Console.WriteLine("Enter the string you want to search");
            string input = Console.ReadLine();
            if (linkedlist.Contains(input))
            {
                linkedlist.Remove(input);
                Console.WriteLine($"{input} removed from the list");
            }
            else
            {
                linkedlist.AddLast(input);
                Console.WriteLine($"{input} added to the list");
            }
            Console.WriteLine("-----------Data from the file after changes-----------------");
            Display(linkedlist);

        }

        private void Display(LinkedList<string> linkedlist)
        {
            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}

