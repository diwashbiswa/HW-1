using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    /// <summary>
    /// This is a Node class with data member and left/right nodes
    /// </summary>
    class Node
    {
        public int value;

        public Node left;
        public Node right;
    }

    /// <summary>
    /// This is a BST class that has the following functions:
    ///     * Insert: inserts nodes into the tree
    ///     * Print: prints all the contents from the tree
    ///     * Count Node: counts all the nodes of a tree
    ///     * Count Level: counts the height of a tree
    /// </summary>
    class BST
    {
        //Insert function to insert the number into the tree. Takes in root node and an integer as parameters
        public Node insert(Node root, int num)
        {
            if (root == null) //if root is null, creates new node and assigns the value into that node
            {
                root = new Node();
                root.value = num;
            }
            if (num == root.value) //if there's duplicate, exit out of function; doesn't insert duplicate
            {
                return root;
            }
            if (num < root.value) //if the number is less than the root in the tree, traverse to the left side of the tree and insert
            {
                root.left = insert(root.left, num);
            }
            else if (num > root.value) //if the number is greater than the root, traverse to the right and insert
            {
                root.right = insert(root.right, num);
            }
            return root;
        }

        //Function to print all the contents of the tree in an increasing order; inorder traversal; recursive approach
        public void printBST(Node root)
        {
            if (root == null)
            {
                return;
            }
            printBST(root.left);
            Console.Write(root.value);
            Console.Write(" ");
            printBST(root.right);
        }

        //Function to count the number of nodes of a tree
        public int CountNumberOfNodes(Node root)
        {
            int count = 1;

            if (root.left != null)
            {
                count += CountNumberOfNodes(root.left); //counts the node from the left side of the tree
            }
            if (root.right != null)
            {
                count += CountNumberOfNodes(root.right); //counts the node from the right side of the tree
            }
            return count; //returns the total number of nodes of a tree
        }

        //Function to count the number of levels of a tree
        public int CountLevel(Node root)
        {
            if (root == null) //if tree is null, returns 0
            {
                return 0;
            }
            else
            {
                return Math.Max(CountLevel(root.left), CountLevel(root.right)) + 1; //uses Math.Max method that returns the max level between left or right subtree
            }
        }

    }
}