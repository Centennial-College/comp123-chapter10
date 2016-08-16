using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_chapter10
{
    class Letter
    {
        public string RecipientName { get; set; }
        public string DateMailed { get; set; }

        public Letter(string recipientName, string dateMailed)
        {
            this.RecipientName = recipientName;
            this.DateMailed = dateMailed;
        }

        public override string ToString()
        {
            return string.Format("{0}\nRecipient Name: {1}\nDate Mailed: {2}\n",
                this.GetType(), this.RecipientName, this.DateMailed);
        }
    }
}
