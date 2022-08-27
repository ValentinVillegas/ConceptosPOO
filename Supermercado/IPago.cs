using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public interface IPago
    {
        public decimal GetValueToPay();
    }
}
