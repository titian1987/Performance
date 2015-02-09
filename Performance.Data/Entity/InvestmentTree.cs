using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Performance.Data.Entity
{
    public class InvestmentTree
    {
        public int Id { get; set; }

        public int TreeId { get; set; }

        public string TreeName { get; set; }

        public int ParentId { get; set; }

        public string SplitType { get; set; }
    }
}
