using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplication.Domain.Models
{
    public class AgentChat
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public string ConnectionId { get; set; }
        public virtual Agent Agent { get; set; }
    }
}
