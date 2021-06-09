using System;
using System.Collections.Generic;

namespace ZooLab.BusinessLogic
{
    public class ZooApp
    {
        private List<Zoo> _zoo = new List<Zoo>();

        public void AddZoo(Zoo zoo)
        {
            _zoo.Add(zoo);
        }
    }
}
