namespace LLDB.Models
{
    public class Child
    {
        public int ChildId { get; set; }

        public string Name { get; set; }

        public int TeamId { get; set; }

        public List<Game> Games { get; set; }

        public List<Team> Teams { get; set; }
    }
}