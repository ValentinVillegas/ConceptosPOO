using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class ProductoCompuesto:Producto
    {
        public float Descuento { get; set; }

        public List<Producto> Productos { get; set; }

        public override decimal GetValueToPay()
        {
            decimal importe = 0;

            foreach (Producto p in Productos)
            {
                importe += p.GetValueToPay();
            }

            return importe - (importe * (decimal)Descuento);
        }

        public override string ToString()
        {
            string prods = "";

            foreach (Producto p in Productos)
            {
                prods += p.Descripcion + ", ";
            }

            return $"{Id} — {Descripcion}" +
                $"\n\tProductos...........: {prods}" +
                $"\n\tDescuento............: {$"{Descuento:P2}",18}" +
                $"\n\tTotal..............: {$"{GetValueToPay():C2}",18}" +
                $"\n";
        }
    }
}