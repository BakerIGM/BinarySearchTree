/* 
 * Node class
 * Pretty standard class for a Node used to build a Binary Tree
 */

namespace BinarySearchTree
{
    class Node
    {
        //  Fields
        private int data;
        private Node left;
        private Node right;

        //  Properties
        public int Data
        {
            get
            {
                return data;
            }
        }

        public Node Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }

        public Node Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }

        //  Parameterised constructor to initialize Node with a data value
        public Node(int data)
        {
            this.data = data;
        }
    }
}
