using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{   
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing object
            Node root = null;
            BST newBST = new BST();

            //Initialize variable to save the collections of number as a string
            string userInput = string.Empty;


            //Prompt the user
            Console.WriteLine("Enter the collection of numbers(0-100) separated by spaces: ");
            userInput = Console.ReadLine(); //Reads the input from the user and saves into the variable 'userInput'


            //Splits the collections of numbers using the delimeter space
            string[] nums = userInput.Split(' ');

            foreach (string number in nums) //iterates thru each number in the collections
            {
                root = newBST.insert(root, Convert.ToInt32(number)); //inserts the number(converted to an integer) into the BST
            }


            //Displays the tree contents(w/o duplicates) in an increasing order
            Console.WriteLine();
            Console.Write("Tree contents: ");
            newBST.printBST(root);
            Console.WriteLine();


            //Gets the number of nodes from the function
            int NumberOfNodes = newBST.CountNumberOfNodes(root);

            //Gets the number of level of the tree
            int level = newBST.CountLevel(root);

            //Gets the minimum height of the tree
            double mimimum_height1 = Math.Log(NumberOfNodes, 2.0);
            double minimum_height_final = Math.Floor(mimimum_height1) + 1;


            //Displays the Tree's Statistics
            Console.WriteLine();
            Console.WriteLine("Tree Statistics: ");
            Console.WriteLine("  Number of Nodes: " + NumberOfNodes);
            Console.WriteLine("  Number of Levels: " + level);
            Console.WriteLine("  Minimum number of levels that a tree with " + NumberOfNodes + " nodes could have: " + minimum_height_final);
            Console.WriteLine("Done");
        }
    }
}
