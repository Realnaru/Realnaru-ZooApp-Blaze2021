using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class MockConsole : IConsole
    {
        public List<string> Log { get; set; } = new List<string>();
        public void WriteLine(string message)
        {
            Log.Add(message);
            Console.WriteLine(message);
        }

    }
}
