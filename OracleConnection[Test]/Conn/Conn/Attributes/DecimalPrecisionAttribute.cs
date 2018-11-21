using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Conn.Attributes
{
    public class DecimalPrecisionAttribute : Attribute
    {
        public byte Precision { get; set; }

        public byte Scale { get; set; }

        public DecimalPrecisionAttribute(byte precision = 18, byte scale = 2)
        {
            Precision = precision;
            Scale = scale;
        }

        public class DecimalPrecisionAttributeConvention : PrimitivePropertyAttributeConfigurationConvention<DecimalPrecisionAttribute>
        {
            public override void Apply(ConventionPrimitivePropertyConfiguration configuration, DecimalPrecisionAttribute attribute)
            {
                if (attribute.Precision < 1 || attribute.Precision > 38)
                {
                    throw new InvalidOperationException("Precision must be between 1 and 38.");
                }
                if (attribute.Scale > attribute.Precision)
                {
                    throw new InvalidOperationException("Scale must be between 0 and the Precision value.");
                }
                configuration.HasPrecision(attribute.Precision, attribute.Scale);
            }
        }
    }
}