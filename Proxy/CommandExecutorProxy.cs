using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CommandExecutorProxy : ICommandExecuter
    {
        private bool IsAdmin;
        private ICommandExecuter executer;

        public CommandExecutorProxy(string user, string pwd)
        {
            if ("Sandip".Equals(user) && "a$d$in".Equals(pwd)) IsAdmin = true;
            executer = new CommandExecuterImpl();
        }
        public void runCommand(string cmd)
        {
            if (IsAdmin)
            {
                executer.runCommand(cmd);
            }
            else
            {

                if (cmd.Trim().StartsWith("rm"))
                {
                    throw new Exception("rm command is not allowed for non admin users");
                }
                else
                {
                    executer.runCommand(cmd);
                }
            }
        }
    }
}
