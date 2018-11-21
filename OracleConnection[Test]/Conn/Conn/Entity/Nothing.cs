using Conn.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conn.Entity
{
    public class Nothing
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DecimalPrecision(20, 6)]
        public decimal Salary { get; set; }
    }
}