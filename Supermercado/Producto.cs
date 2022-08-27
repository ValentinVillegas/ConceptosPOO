using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public abstract class Producto
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public float IVA { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} — {Descripcion}" +
                $"\n\tPrecio:......: {$"{Precio:C2}", 18}" +
                $"\n\tIVA..........: {$"{Precio * (decimal)IVA:C2}", 18}";
        }
    }
}
