using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mentorship
    {

        public int MentoredById { get; set; }
        public virtual Employee EMentoredBy { get; set; }

        public int MentoredForId { get; set; }
        public virtual Employee EMentoredFor { get; set; }
    }
}
