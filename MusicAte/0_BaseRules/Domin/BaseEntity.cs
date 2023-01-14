using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_BaseRules.Domin
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public string CreationDate { get; set; }

        public BaseEntity()
        {
            CreationDate = DateTime.Now.ToString();
        }
    }
}
