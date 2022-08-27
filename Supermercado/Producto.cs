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

        public decimal IVA { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"Id............: {$"{Id}", 15}" +
                $"\n\tDescripción..: {Descripcion}" +
                $"\n\tPrecio:......: {$"{Precio:C2}"}" +
                $"\n\tIVA..........: {$"{IVA:C2}", 15}";
        }
    }
}
