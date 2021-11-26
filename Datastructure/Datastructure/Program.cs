using System;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1. Unordred list \n2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Unorderedlist unordered = new Unorderedlist();
                        unordered.Operation();
                        break;        
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
