using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_chapter10
{
    class CertifiedLetter : Letter
    {
        public int TrackingNumber { get; set; }

        public CertifiedLetter(string recipientName, string dateMailed, int trackingNumber) : base(recipientName, dateMailed)
        {
            this.TrackingNumber = trackingNumber;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Tracking #: {0}\n",
                this.TrackingNumber);
        }
    }
}
