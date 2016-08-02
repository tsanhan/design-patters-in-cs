using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Employees : ICloneable
    {

        private List<string> empList;

        public Employees()
        {
            empList = new List<string>();
        }

        public Employees(List<string> empList)
        {
            this.empList = empList;
        }
        
        public void loadData()
        {
            empList = new List<string>() { "Pankaj", "Raj", "David", "Lisa" };
        }

        public List<string> getList()
        {
            return empList;
        }
        public object Clone()
        {
            List<string> tempEmpList = new List<string>();
            foreach(string s in this.empList)
            {
                tempEmpList.Add(s);
            }
            return new Employees(tempEmpList);
        }
        
        
    }
}
