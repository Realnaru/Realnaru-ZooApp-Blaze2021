using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests.Validation.Tests
{
    class TestEmployee : IEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }

    }
}
