/* 
 * Binary Search Tree
 * 
 * DO NOT CHANGE ANYTHING IN THIS FILE
 */
using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinSearchTree tree = new BinSearchTree();
            string line;
            int inputNumber, number;

            do
            {
                Console.Write(
                    "1 - Build Hard coded tree\n" +
                    "2 - Load a tree from a file\n" +
                    "3 - Print out the tree\n" +
                    "4 - Save the tree to a file\n" +
                    "5 - Add a new number to the tree\n" +
                    "6 - Count the how many numbers are in the tree\n" +
                    "7 - Exit\n" +
                    "Enter the number (1-7) for what you would like to do? ");

                line = Console.ReadLine();

                if(int.TryParse(line, out inputNumber))
                {
                    switch(inputNumber)
                    {
                        case 1:
                            tree.HardCode();
                            Console.WriteLine("Tree built");
                            break;
                        case 2:
                            Console.Write("What file would you like to load? ");
                            tree.LoadFromFile(Console.ReadLine());
                            Console.WriteLine("Tree built");
                            break;
                        case 3:
                            tree.Print();
                            break;
                        case 4:
                            Console.Write("What file you would like to save the tree to? ");
                            tree.SaveToFile(Console.ReadLine());
                            Console.WriteLine("Tree saved");
                            break;
                        case 5:
                            Console.Write("What whole number would you like to add? ");
                            line = Console.ReadLine();

                            if(int.TryParse(line, out number))
                            {
                                tree.Add(number);
                                Console.WriteLine("Number added to tree");
                            }
                            else
                            {
                                Console.WriteLine("{} is not a valid whole number", line);
                            }
                            break;
                        case 6:
                            Console.WriteLine("There are {0} numbers in the tree", tree.Count());
                            break;
                        case 7:
                            Console.WriteLine("Good bye");
                            break;
                        default:
                            Console.WriteLine("Please enter a number between 1-7");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1-7");
                }

                Console.WriteLine("\n\n\n\n");
            } while (inputNumber != 7);
        }
    }
}
