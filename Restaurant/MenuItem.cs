using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        private DateTime itemAddDate = new DateTime(2020, 1, 1);
        private Boolean isNew = false;
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }

    }
}
