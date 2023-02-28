using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Problems
{
    public class ParallelismProblems
    {

        public void Main() 
        {
            

        }


    }

    public class ExecutableGraph 
    {
        public ExecutableCustom Root { get; set; }
        public List<(ExecutableCustom, List<ExecutableCustom>)> Graph { get; set; }

    }

    public class ExecutableCustom 
    {
        public List<ExecutableCustom> Predesessors { get; set; }

        public void Execute() 
        {

        }
    }
}
