using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Factura : IPago
    {
        private List<Producto> _productos;

        public Factura()
        {
            _productos = new List<Producto>();
        }

        public void AgregarProducto(Producto prod)
        {
            _productos.Add(prod);
        }

        public decimal GetValueToPay()
        {
            decimal importe = 0;

            _productos.ForEach(p => importe += p.GetValueToPay());

            return importe;
        }

        public override string ToString()
        {
            
            foreach(Producto prod in _productos)
            {
                Console.WriteLine(prod);
            }

            return $"Total............: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
