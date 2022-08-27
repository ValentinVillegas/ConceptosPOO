using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class ProductoPrecioVariable : Producto
    {
        public string UnidadDeMedida { get; set; }

        public float Cantidad { get; set; }

        public override decimal GetValueToPay()
        {
            return Precio * (decimal)Cantidad + (Precio * (decimal)IVA * (decimal)Cantidad);
        }

        public override string ToString()
        {
            return $"{Id} — {Descripcion}" +
                $"\n\tPrecio {UnidadDeMedida}..........: {$"{Precio:C2}",18}" +
                $"\n\tCantidad...........: {$"{Cantidad:N2}", 18} {UnidadDeMedida}" +
                $"\n\tImporte............: {$"{Precio * (decimal)Cantidad:C2}", 18}" +
                $"\n\tIVA................: {$"{Precio * (decimal)IVA * (decimal)Cantidad:C2}",18}" +
                $"\n\tTotal..............: {$"{GetValueToPay():C2}", 18}" +
                $"\n";
        }


    }
}
