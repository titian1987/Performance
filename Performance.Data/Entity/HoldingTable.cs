using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Performance.Data.Entity
{
    public class HoldingTable
    {
        public int Id { get; set; }

        public int SecurityId { get; set; }

        public string SecurityName { get; set; }

        public int PortfolioId { get; set; }

        public string PortfolioName { get; set; }

        public int ModelPortfolioId { get; set; }

        public string ModelPortfolioName { get; set; }

        public double Price { get; set; }

        public double Nominal { get; set; }

        public double MarketValue { get; set; }

        public double CashFlow { get; set; }
    }
}
