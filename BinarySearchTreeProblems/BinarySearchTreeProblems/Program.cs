namespace BinarySearchTreeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(40);
            binarySearchTree.Display();

        }
    }
}