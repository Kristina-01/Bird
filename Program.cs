using Bird.Parsing;
using Bird.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                return;
            }

            Runer(args, new Prs().Start);

            #region MyRegion
            /*
                Func<string[], string> CreatedString = (arr)=>
                {
                    string res = "";
                    for(int i = 0; i < arr.Length; ++i)
                    {
                        res += arr[i];
                    }
                    return res;
                };

               var str = CreatedString(args);*/
            #endregion

            var bt = new BinaryTree<string>();

            bt.Add("4");
            bt.Add("*");
            bt.Add("5");
            bt.Add("-");
            bt.Add("+");
            bt.Add("/");
            bt.Add("*");
            bt.Add("-");
            bt.Add("+");
            bt.Add("/");
            bt.PrintTree();

            /*
            var binaryTree = new BinaryTree<int>();
            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(1);
            binaryTree.Add(6);
            binaryTree.Add(4);
            binaryTree.Add(7);
            binaryTree.Add(14);
            binaryTree.Add(16);

            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(3);
            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(8);
            binaryTree.PrintTree();
            */

            Console.Read();
        }

        private static void Runer(string[] args, Action<string> act)
        {
            for(int i = 0; i < args.Length; ++i)
            {
                act(args[i]);
            }
        }
    }
}
