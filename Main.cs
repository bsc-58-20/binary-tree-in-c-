using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree<int> tree = new BinaryTree<int>();
		
        int choice;
	do{
		Console.WriteLine();
		Console.WriteLine("BINARY TREE");
		Console.WriteLine("1.Insert a number");
		Console.WriteLine("2.Search a number");
		Console.WriteLine("3.Remove a number");
		Console.WriteLine("4.Inorder Traversal");
		Console.WriteLine("5.Postorder Traversal");
		Console.WriteLine("6.Press 6 to exit");
		Console.WriteLine();
		Console.WriteLine("Enter your choice");
		choice = Convert.ToInt32(Console.ReadLine());

		if(choice==1)
		{
            Console.WriteLine("Enter number");
		    int userInput = Convert.ToInt32(Console.ReadLine());
            tree.Insert(userInput);
		}
		else if(choice==2)
		{
             Console.WriteLine("Enter number");
		     int userInput1 = Convert.ToInt32(Console.ReadLine());
		    tree.Search(userInput1);
		}
		else if(choice==3)
		{
            Console.WriteLine("Enter number");
		    int userInput2 = Convert.ToInt32(Console.ReadLine());
	    	tree.Remove(userInput2);
		}
		else if(choice==4)
		{
				Console.Write("Inorder traversal\n");
				foreach (int value in tree.InOrderTraversal())
				{
					Console.WriteLine(value);
				}  
          }
		
		else if(choice==5)
		{
				Console.WriteLine("Post-Order Traversal:");
				foreach (int value in tree.PostOrderTraversal())
				{
					Console.WriteLine(value);
				}
		}

     	}while(choice!=6);		
    }
}

