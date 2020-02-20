using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        public DateTime AddedOn { get; set; }
        public Boolean isNew
        {
            get
            {
                return AddedOn.Date >= DateTime.Now.Date.AddMonths(-3); // from Scott's example
            }
        }

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }

    }
}
