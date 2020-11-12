using System;
using System.Collections.Generic;

namespace LLDB.Models
{
    public class Practice
    {
        public int PracticeId { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }

        public DateTime Time { get; set; }

        public List<Child> Participants { get; set; }
        
    }
}