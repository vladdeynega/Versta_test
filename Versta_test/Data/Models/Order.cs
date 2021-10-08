using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Versta_test.Data.Models
{
    public class Order
    {
        public int id { get; set; }

        public string townFrom { get; set; }

        public string townTo { get; set; }

        public string addrFrom { get; set; }

        public string addrTo { get; set; }

        public float weight { get; set; }

        public string date { get; set; }

    }
}
