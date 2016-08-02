using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class FileInvoker
    {
        ICommand cmd;
        public FileInvoker(ICommand c)
        {
            this.cmd = c;
        }

        public void execute()
        {
            this.cmd.execute();
        }
    }
}
