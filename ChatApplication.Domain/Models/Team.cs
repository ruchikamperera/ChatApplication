using System.Collections.Generic;

namespace ChatApplication.Domain.Models
{
    public class Team
    {
        public Team()
        {
            Agents = new HashSet<Agent>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
    }
}
