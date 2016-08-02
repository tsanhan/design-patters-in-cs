using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OpenFileCommand : ICommand
    {
        private IFileSystemReceiver fileSystem;
        public OpenFileCommand(IFileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }
        public void execute()
        {
            this.fileSystem.openFile();
        }
    }
}
