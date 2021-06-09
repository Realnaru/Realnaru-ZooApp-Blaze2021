using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    class ConsoleWrapper : IConsoleWrapper
    {
        List<string> Logs { get; set; } = new List<string>();
        public void WriteLine(string anyText)
        {
            Logs.Add(anyText);

        }
    }
}
