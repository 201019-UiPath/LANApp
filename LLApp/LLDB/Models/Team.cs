using System.Collections.Generic;

namespace LLDB.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public List<Child> Roster { get; set; }

        public List<Game> Games { get; set; }

        public List<Practice> Practices { get; set; }
    }
}