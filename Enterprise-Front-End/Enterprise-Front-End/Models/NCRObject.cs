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
            Skew = skew;
            DateIssd = dateIssd;
            Cost = cost;
            MnfctYear = mnfctYear;
            DateMnfct = dateMnfct;
            DateBB = dateBB;
            // TODO: Add all the NCR Attributes
        }

        // Default
        public NCRObject()
        {
            Skew = "";
            DateIssd = "";
            Cost = "";
            MnfctYear = "";
            DateMnfct = "";
            DateBB = "";
            IssDescr = "";
        }

        // Properties
        public string Skew { get; set; }
        public string DateIssd { get; set; }
        public string Cost { get; set; }
        public string MnfctYear { get; set; }
        public string DateMnfct { get; set; }
        public string DateBB { get; set; }
        public string IssDescr { get; set; }
    }
}
