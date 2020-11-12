using System.Collections.Generic;

namespace LLDB.Models
{
    public class Parent
    {
        public int ParentId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public List<Child> Children { get; set; }
    }
}