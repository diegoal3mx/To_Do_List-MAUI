using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_3P_PR02
{
    public class task
    {
        public int id { get; set; }
        public string description { get; set; }
        public bool status { get; set; }

        public task(int id, string description, bool status)
        {
            this.id = id;
            this.description= description;
            this.status = status;
        }

    }


}
