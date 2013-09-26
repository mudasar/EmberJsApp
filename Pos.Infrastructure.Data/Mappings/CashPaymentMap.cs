using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pos.Core.Domain;

namespace Pos.Infrastructure.Data.Mappings
{
    public class CashPaymentMap : EntityTypeConfiguration<CashPayment>
    {
        public CashPaymentMap()
        {
            
        }
    }
}
