using System.Collections.Generic;
using System.Linq;

namespace Factory.Models
{
    public class Machine
    {
        public Machine()
        {
            this.JoinEntities = new HashSet<EngineerMachine>();
        }

        public int MachineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<EngineerMachine> JoinEntities { get; }

    }
}