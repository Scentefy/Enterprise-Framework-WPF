using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Front_End.Models
{
    public class NCRObject
    {
        // Constructor
        public NCRObject(string skew, string dateIssd, string cost, string mnfctYear, string dateMnfct, string dateBB)
        {
            _skew = skew;
            _dateIssd = dateIssd;
            _cost = cost;
            _mnfctYear = mnfctYear;
            _dateMnfct = dateMnfct;
            _dateBB = dateBB;
        }

        // Properties
        public string _skew { get; set; }
        public string _dateIssd { get; set; }
        public string _cost { get; set; }
        public string _mnfctYear { get; set; }
        public string _dateMnfct { get; set; }
        public string _dateBB { get; set; }
    }
}
