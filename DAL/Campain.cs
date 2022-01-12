using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Campain
    {
        public int CampainId { get; set; }
        public float Pricedrop { get; set; }

        public ICollection<Product> ProductInCampain { get; set; }
    }
}
