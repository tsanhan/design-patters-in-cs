using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class WindowsFileSystemReceiver : IFileSystemReceiver
    {
        public void closeFile()
        {
            Console.WriteLine("Closing  file in Windows OS");
        }
        
        public void openFile()
        {
            Console.WriteLine("Opening  file in Windows OS");
        }

        public void writeFile()
        {
            Console.WriteLine("Writing  file in Windows OS");
        }
    }
}
