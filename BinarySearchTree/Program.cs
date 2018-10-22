/* 
 * Binary Search Tree
 */
using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinSearchTree tree = new BinSearchTree();

            //  Comment out for BST part 3
            tree.HardCode();

            do
            {
                Console.Write("What would you like to do? (add, display, quit) ");

                string line = Console.ReadLine();
                line = line.ToLower();

                if (line.Equals("add"))
                {
                    /*      BST part 3
                    Console.Write("Number to add: ");

                    string input = Console.ReadLine();

                    tree.Add(int.Parse(input));
                    */
                }
                else if (line.Equals("display"))
                {
                    /*      BST part 2
                    Console.Write("Which traversal method? (in, pre, post)");

                    switch(Console.ReadLine().ToLower())
                    {
                        case "in":
                            tree.InOrderTraversal();
                            break;
                        case "pre":
                            tree.PreOrderTraversal();
                            break;
                        case "post":
                            tree.PosstOrderTraversal();
                            break;
                        default:
                            Console.WriteLine("Invaild Input");
                            break;
                    }
                    */
                }
                else if (line.Equals("quit"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invaild Input");
                }
            } while (true);

            Console.WriteLine("Good bye");
        }
    }
}
