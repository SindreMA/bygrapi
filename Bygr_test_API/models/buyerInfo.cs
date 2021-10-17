using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bygr_test_API.models
{
    public class Buyer_Info
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int residentialUnitGroupId { get; set; }
        public int floor { get; set; }
        public string layoutType { get; set; }
        public Deadline[] deadlines { get; set; }
        public Buyer[] buyers { get; set; }
    }

    public class Deadline
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
    }

    public class Buyer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string displayName { get; set; }
        public string phoneNumber { get; set; }
        public DateTime lastVisitDate { get; set; }
    }
}
