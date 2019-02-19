/* 
 * BinSearchTree class
 * Implements a binary search.
 */
using System;
using System.IO;

namespace BinarySearchTree
{
    class BinSearchTree
    {
        Node root;

        StreamReader reader;
        StreamWriter writer;

        //  Constructor creates an empty tree (no nodes)
        public BinSearchTree()
        {
            root = null;
        }

        //  Used to set up a tree before we've built a general Add() method
        public void HardCode()
        {
            root = new Node(23);
            root.Left = new Node(13);
            root.Left.Left = new Node(7);
            root.Left.Right = new Node(18);
            root.Right = new Node(33);
            root.Right.Right = new Node(47);
        }

        #region Add
        public void Add(int number)
        {
            //  Check if the tree is empty
            if(root == null)
            {
                root = new Node(number);
            }
            //  Move to the root
            else
            {
                Add(number, root);
            }
        }

        void Add(int number, Node n)
        {
            //  Check if it should go to the left
            if (n.Data >= number)
            {
                //  Check if there is a left
                if (n.Left == null)
                {
                    n.Left = new Node(number);
                }
                //  Move to the left node
                else
                {
                    Add(number, n.Left);
                }
            }
            //  Add it to the right
            else
            {
                //  Check if there is a right
                if (n.Right == null)
                {
                    n.Right = new Node(number);
                }
                //  Move to the right
                else
                {
                    Add(number, n.Right);
                }
            }
        }
        #endregion

        #region Print
        public void Print()
        {
            if (root == null)
            {
                Console.WriteLine("EMPTY TREE");
            }
            else
            {
                Print(root);
            }
        }

        void Print(Node n)
        {
            if(n.Left != null)
            {
                Print(n.Left);
            }

            Console.WriteLine(n.Data);

            if(n.Right != null)
            {
                Print(n.Right);
            }
        }
        #endregion

        public void LoadFromFile(string file)
        {
            try
            {
                reader = new StreamReader(file);

                do
                {
                    string line = reader.ReadLine();

                    if(string.IsNullOrEmpty(line))
                    {
                        break;
                    }

                    int number;

                    if (int.TryParse(line, out number))
                    {
                        Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Couldn't parse data: {0}", line);
                    }
                } while (true);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Could not find the file {0}", file);
            }
            catch(IOException e)
            {
                Console.WriteLine("Error loading data from {0}\n{1}", file, e.Message);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
        }

        #region Save to file
        public void SaveToFile(string file)
        {
            if(root != null)
            {
                try
                {
                    writer = new StreamWriter(file);

                    SaveNodeToFile(root);
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error saving data to {0}\n{1}", file, e.Message);
                }
                finally
                {
                    if(writer != null)
                    {
                        writer.Close();
                    }
                }
            }
        }

        void SaveNodeToFile(Node n)
        {
            writer.WriteLine(n.Data);

            if(n.Left != null)
            {
                SaveNodeToFile(n.Left);
            }

            if(n.Right != null)
            {
                SaveNodeToFile(n.Right);
            }
        }
        #endregion

        #region Count
        public int Count()
        {
            return 0;
        }

        int Count(Node n)
        {
            if(n == null)
            {
                return 0;
            }
            else
            {
                return 1 + Count(n.Left) + Count(n.Right);
            }
        }
        #endregion
    }
}
