using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class UnixFileSystemReceiver : IFileSystemReceiver
    {
        public void closeFile()
        {
            Console.WriteLine("Closing file in unix OS");
        }

        public void openFile()
        {
            Console.WriteLine("Opening file in unix OS");
        }

        public void writeFile()
        {
            Console.WriteLine("Writing file in unix OS");
        }
    }
}
