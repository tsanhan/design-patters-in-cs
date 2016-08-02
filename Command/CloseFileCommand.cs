using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CloseFileCommand : ICommand
    {
        private IFileSystemReceiver fileSystem;
        public CloseFileCommand(IFileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }
        public void execute()
        {
            this.fileSystem.closeFile();
        }
    }
}
