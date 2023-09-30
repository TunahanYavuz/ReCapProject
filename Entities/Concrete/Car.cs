using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car
    {
        public string CarName { get; set; }
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public string Description { get; set; }
        public char ModelYear { get; set; }
        public int DailyPrice { get; set; }
    }
}
