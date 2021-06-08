using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class TestEmployee : IEmployee
    {
        public string FirstName => throw new NotImplementedException();

        public string LastName => throw new NotImplementedException();
    }
}
