using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class ProductoPrecioFijo : Producto
    {
        public override decimal GetValueToPay()
        {
            return Precio + (Precio * (decimal)IVA);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
