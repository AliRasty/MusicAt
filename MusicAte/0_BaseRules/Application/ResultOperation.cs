using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_BaseRules.Application
{
    public class ResultOperation
    {
        public string Massage { get; set; }

        public bool IsSuccedded { get; set; }

        public ResultOperation()
        {
            IsSuccedded = false;
        }


        public ResultOperation Succedded(string message = "عملیات با موفقیت انجام شد.")
        {
            IsSuccedded = true;
            Massage = message;
            return this;
        }

        public ResultOperation Failed(string message)
        {
            IsSuccedded = false;
            Massage = message;
            return this;
        }


    }
}
