using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class WriteFileCommand : ICommand
    {
        private IFileSystemReceiver fileSystem;
        public WriteFileCommand(IFileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }
        public void execute()
        {
            this.fileSystem.writeFile();
        }
    }
}
