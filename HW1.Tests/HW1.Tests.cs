using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        class Node
        {
            public int value;
            public Node right;
            public Node left;
        }
        class BST
        {
            public Node insert(Node root, int num)
            {
                if (root == null)
                {
                    root = new Node();
                    root.value = num;
                }
                if (num == root.value)
                {
                    return root;
                }
                if (num < root.value)
                {
                    root.left = insert(root.left, num);
                }
                else if (num > root.value)
                {
                    root.right = insert(root.right, num);
                }
                return root;
            }
            public int CountNumberOfNodes(Node root)
            {
                int count = 1;

                if (root.left != null)
                {
                    count += CountNumberOfNodes(root.left);
                }
                if (root.right != null)
                {
                    count += CountNumberOfNodes(root.right);
                }
                return count; 
            }

            public int CountLevel(Node root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    return System.Math.Max(CountLevel(root.left), CountLevel(root.right)) + 1; 
                }
            }
        }

        [Test]
        public void TestInsert()
        {
            Node root = null;
            BST BinaryTree = new BST();

            root = BinaryTree.insert(root, 43);
            root = BinaryTree.insert(root, 12);
            root = BinaryTree.insert(root, 50);

            int NumberOfNodes = BinaryTree.CountNumberOfNodes(root);
            int Level = BinaryTree.CountLevel(root);

            Assert.AreEqual(root.value, 43);
            Assert.AreEqual(root.left.value, 12);
            Assert.AreEqual(root.right.value, 50);

            Assert.AreEqual(NumberOfNodes, 3);

            Assert.AreEqual(Level, 2);
        }
    }
}