using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class FileWriterCaretaker
    {
        object obj;

        public void save(FileWriterUtil fr)
        {
            this.obj = fr.save();
        }
        public void undo(FileWriterUtil fw)
        {
            fw.undoToLastSave(this.obj);
        }
    }
}
