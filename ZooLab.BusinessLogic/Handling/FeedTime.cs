using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class FeedTime
    {
        public DateTime TimeToFeed { get; set; }
        public ZooKeeper FedByZookeeper { get; set; }
    }

    
}
