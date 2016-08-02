using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class FileWriterUtil
    {
        string fileName;
        StringBuilder content;

        public FileWriterUtil( string file)
        {
            this.fileName = file;
            this.content = new StringBuilder();
        }

        public override string ToString()
        {
            return this.content.ToString();
        }

        public void write(string str)
        {
            this.content.Append(str);
        }
        public object save()
        {
            return new Memento(this.fileName, this.content);
        }

        public void undoToLastSave(object obj)
        {
            Memento memento = (Memento) obj;
            this.fileName = memento.Filename;
            this.content = memento.Content;
        }
        private class Memento
        {
            string filename;
            StringBuilder content;

            public Memento(string filename, StringBuilder content)
            {
                this.filename = filename;
                this.content = new StringBuilder(content.ToString());      
            }
            public string Filename
            { get { return filename; } }

            public StringBuilder Content
            { get { return content; } }
        }
    }
}
