using Conn.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static Conn.Attributes.DecimalPrecisionAttribute;

namespace Conn.DataAccessLayer
{
    public class ConnContext : DbContext
    {
        public ConnContext() : base("Conn")
        {

        }

        public IDbSet<Nothing> Nothings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SCOTT");
            modelBuilder.Conventions.Add(new DecimalPrecisionAttributeConvention());
            base.OnModelCreating(modelBuilder);
        }
    }
}