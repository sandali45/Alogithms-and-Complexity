using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_and_Iterative
{
    public class TraverseDirectory
    {
        public void TraverseDirectoryRecursive(DirectoryInfo dir)
        {

            foreach (var child in dir.GetFileSystemInfos())
            {

                if (child is DirectoryInfo directory)
                {
                    TraverseDirectoryRecursive(directory);
                }

                else if (child is FileInfo file)
                {
                    Console.WriteLine(file.FullName);
                }
            }
        }

        public void TraverseDirectoryIterative(DirectoryInfo dir)
        {
            Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();

            stack.Push(dir);

            while (stack.Count > 0)
            {
                DirectoryInfo current = stack.Pop();


                foreach (var file in current.GetFiles())
                {
                    Console.WriteLine(file.FullName);
                }


                foreach (var subDir in current.GetDirectories())
                {
                    stack.Push(subDir);
                }
            }
        }
        }
    }
