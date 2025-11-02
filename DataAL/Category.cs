using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public string IsActiveStr { get; set; }
    }
}
